-- phpMyAdmin SQL Dump
-- version 4.4.14
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 03-11-2015 a las 23:41:53
-- Versión del servidor: 5.6.26
-- Versión de PHP: 5.6.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `pizzas`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`dicarlodb`@`localhost` PROCEDURE `InsertarOrdenDetalle`(IN `_producto_id` INT, IN `_cantidad` INT, IN `_descripcion` VARCHAR(80), 
		IN `_importe_unitario` DECIMAL, IN `_total` DECIMAL, IN `_especialidad_id` INT, 
        IN `_orden_id` INT, OUT `Retorno` INT)
    NO SQL
    COMMENT 'Agrega un detalle a la orden y regresa el ultimo insertado'
BEGIN
	INSERT orden_detalle(producto_id, cantidad, descripcion, importe_unitario, total, especialidad_id, orden_id) 
	VALUES (_producto_id, _cantidad, _descripcion, _importe_unitario, _total, _especialidad_id, _orden_id); 
	SET Retorno = 0; 
	SELECT LAST_INSERT_ID() INTO Retorno;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE IF NOT EXISTS `cliente` (
  `id` int(255) NOT NULL,
  `nombre` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `telefono` varchar(10) COLLATE utf8_spanish_ci NOT NULL,
  `domicilio` text COLLATE utf8_spanish_ci NOT NULL,
  `status` tinyint(1) DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `configuraciones`
--

CREATE TABLE IF NOT EXISTS `configuraciones` (
  `id` int(11) NOT NULL,
  `descripcion` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `valor` text COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `corte_caja`
--
CREATE TABLE IF NOT EXISTS `corte_caja` (
`id` int(255) unsigned
,`tipo_venta` int(11)
,`Tipo Venta` varchar(15)
,`descuento` float
,`total` float
,`fecha_hora` datetime
,`status` int(11)
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mesa`
--

CREATE TABLE IF NOT EXISTS `mesa` (
  `id` int(255) NOT NULL,
  `descripcion` varchar(30) COLLATE utf8_spanish_ci NOT NULL,
  `status` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Disparadores `mesa`
--
DELIMITER $$
CREATE TRIGGER `actualizar_mesa_cliente` AFTER INSERT ON `mesa`
 FOR EACH ROW INSERT INTO mesa_orden SET mesa_id = NEW.id
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `mesa_desocupada`
--
CREATE TABLE IF NOT EXISTS `mesa_desocupada` (
`mesa_id` int(255)
,`mesa_descripcion` varchar(30)
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mesa_orden`
--

CREATE TABLE IF NOT EXISTS `mesa_orden` (
  `mesa_id` int(255) NOT NULL,
  `orden_id` int(255) unsigned DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `mesa_orden_detalle`
--
CREATE TABLE IF NOT EXISTS `mesa_orden_detalle` (
`OrdenId` int(255) unsigned
,`MesaId` int(255)
,`Mesa` varchar(30)
,`ClienteId` int(255)
,`Cliente` varchar(50)
,`Total` float
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `orden`
--

CREATE TABLE IF NOT EXISTS `orden` (
  `id` int(255) unsigned NOT NULL,
  `tipo_venta` int(11) NOT NULL DEFAULT '1' COMMENT '1. Para comer aqui 2. Para llevar 3. A domicilio',
  `cliente_id` int(255) NOT NULL,
  `subtotal` float NOT NULL,
  `descuento` float NOT NULL,
  `total` float NOT NULL,
  `fecha_hora` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `usuario_id` int(11) DEFAULT NULL,
  `status` int(11) NOT NULL DEFAULT '1' COMMENT '1 ABIERTA 2 COBRADA 3 CANCELADA'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Disparadores `orden`
--
DELIMITER $$
CREATE TRIGGER `desocupar_mesa` AFTER UPDATE ON `orden`
 FOR EACH ROW IF (NEW.tipo_venta=1)
THEN
    IF(NEW.status=2 OR NEW.status=3) 
        THEN
		UPDATE mesa_orden SET orden_id=0 WHERE orden_id = OLD.id;
    END IF;
END IF
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `orden_detallada`
--
CREATE TABLE IF NOT EXISTS `orden_detallada` (
`id` int(255) unsigned
,`tipo_venta` int(11)
,`Tipo Venta` varchar(15)
,`cliente_id` int(255)
,`mesa_id` int(255)
,`Mesa` varchar(30)
,`subtotal` float
,`descuento` float
,`total` float
,`fecha_hora` datetime
,`usuario_id` int(255)
,`Usuario` varchar(50)
,`status` int(11)
,`Orden Status` varchar(15)
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `orden_detalle`
--

CREATE TABLE IF NOT EXISTS `orden_detalle` (
  `id` bigint(255) unsigned NOT NULL,
  `orden_id` int(255) unsigned NOT NULL,
  `producto_id` int(255) NOT NULL,
  `especialidad_id` int(255) NOT NULL DEFAULT '0',
  `cantidad` smallint(255) unsigned NOT NULL,
  `descripcion` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `importe_unitario` varchar(255) COLLATE utf8_spanish_ci NOT NULL,
  `total` varchar(255) COLLATE utf8_spanish_ci NOT NULL,
  `status` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE IF NOT EXISTS `producto` (
  `id` int(255) NOT NULL,
  `categoria` int(255) NOT NULL,
  `descripcion` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `precio` float NOT NULL DEFAULT '0',
  `status` tinyint(1) NOT NULL DEFAULT '1' COMMENT '1 Significa que este producto está disponible para su venta\r\n0 Significa que este producto NO está disponible para su venta'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto_especialidad`
--

CREATE TABLE IF NOT EXISTS `producto_especialidad` (
  `id` int(255) NOT NULL,
  `descripcion` varchar(30) COLLATE utf8_spanish_ci NOT NULL,
  `status` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE IF NOT EXISTS `usuario` (
  `id` int(255) NOT NULL,
  `nombre` varchar(50) COLLATE utf8_spanish_ci DEFAULT NULL,
  `usuario` varchar(20) COLLATE utf8_spanish_ci DEFAULT NULL,
  `password` varchar(50) COLLATE utf8_spanish_ci DEFAULT NULL,
  `perfil` int(11) NOT NULL DEFAULT '2' COMMENT '1. Administrador 2. Cajero (Default)',
  `status` tinyint(1) DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura para la vista `corte_caja`
--
DROP TABLE IF EXISTS `corte_caja`;

CREATE ALGORITHM=UNDEFINED DEFINER=`dicarlodb`@`localhost` SQL SECURITY DEFINER VIEW `corte_caja` AS select `o`.`id` AS `id`,`o`.`tipo_venta` AS `tipo_venta`,(case `o`.`tipo_venta` when 1 then 'PARA COMER AQUI' when 2 then 'PARA LLEVAR' when 3 then 'A DOMICILIO' else 'NO ESPECIFICADA' end) AS `Tipo Venta`,`o`.`descuento` AS `descuento`,`o`.`total` AS `total`,`o`.`fecha_hora` AS `fecha_hora`,`o`.`status` AS `status` from `orden` `o` where (cast(`o`.`fecha_hora` as date) = curdate());

-- --------------------------------------------------------

--
-- Estructura para la vista `mesa_desocupada`
--
DROP TABLE IF EXISTS `mesa_desocupada`;

CREATE ALGORITHM=UNDEFINED DEFINER=`dicarlodb`@`localhost` SQL SECURITY DEFINER VIEW `mesa_desocupada` AS select `m`.`id` AS `mesa_id`,`m`.`descripcion` AS `mesa_descripcion` from (`mesa` `m` join `mesa_orden` `mo` on((`m`.`id` = `mo`.`mesa_id`))) where ((`mo`.`orden_id` = 0) and (`m`.`status` = 1));

-- --------------------------------------------------------

--
-- Estructura para la vista `mesa_orden_detalle`
--
DROP TABLE IF EXISTS `mesa_orden_detalle`;

CREATE ALGORITHM=UNDEFINED DEFINER=`dicarlodb`@`localhost` SQL SECURITY DEFINER VIEW `mesa_orden_detalle` AS select `o`.`id` AS `OrdenId`,`m`.`id` AS `MesaId`,`m`.`descripcion` AS `Mesa`,`c`.`id` AS `ClienteId`,`c`.`nombre` AS `Cliente`,`o`.`total` AS `Total` from (((`mesa_orden` `mo` join `mesa` `m` on((`mo`.`mesa_id` = `m`.`id`))) join `orden` `o` on((`mo`.`orden_id` = `o`.`id`))) join `cliente` `c` on((`o`.`cliente_id` = `c`.`id`)));

-- --------------------------------------------------------

--
-- Estructura para la vista `orden_detallada`
--
DROP TABLE IF EXISTS `orden_detallada`;

CREATE ALGORITHM=UNDEFINED DEFINER=`dicarlodb`@`localhost` SQL SECURITY DEFINER VIEW `orden_detallada` AS select `o`.`id` AS `id`,`o`.`tipo_venta` AS `tipo_venta`,(case `o`.`tipo_venta` when 1 then 'PARA COMER AQUI' when 2 then 'PARA LLEVAR' when 3 then 'A DOMICILIO' else 'NO ESPECIFICADA' end) AS `Tipo Venta`,`o`.`cliente_id` AS `cliente_id`,`m`.`id` AS `mesa_id`,`m`.`descripcion` AS `Mesa`,`o`.`subtotal` AS `subtotal`,`o`.`descuento` AS `descuento`,`o`.`total` AS `total`,`o`.`fecha_hora` AS `fecha_hora`,`u`.`id` AS `usuario_id`,`u`.`nombre` AS `Usuario`,`o`.`status` AS `status`,(case `o`.`status` when 1 then 'ABIERTA' when 2 then 'COBRADA' when 3 then 'CANCELADA' else 'NO ESPECIFICADA' end) AS `Orden Status` from (((`orden` `o` left join `usuario` `u` on((`o`.`usuario_id` = `u`.`id`))) left join `mesa_orden` `mo` on((`o`.`id` = `mo`.`orden_id`))) left join `mesa` `m` on((`mo`.`mesa_id` = `m`.`id`))) order by `o`.`fecha_hora` desc;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `configuraciones`
--
ALTER TABLE `configuraciones`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `mesa`
--
ALTER TABLE `mesa`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `mesa_orden`
--
ALTER TABLE `mesa_orden`
  ADD PRIMARY KEY (`mesa_id`);

--
-- Indices de la tabla `orden`
--
ALTER TABLE `orden`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_orden_cliente1_idx` (`cliente_id`),
  ADD KEY `fk_orden_usuario1_idx` (`usuario_id`) USING BTREE;

--
-- Indices de la tabla `orden_detalle`
--
ALTER TABLE `orden_detalle`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_orden_detalle_producto1_idx` (`producto_id`),
  ADD KEY `fk_orden_detalle_producto_especialidad1_idx` (`especialidad_id`),
  ADD KEY `fk_orden_detalle_orden1_idx` (`orden_id`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `producto_especialidad`
--
ALTER TABLE `producto_especialidad`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `configuraciones`
--
ALTER TABLE `configuraciones`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `mesa`
--
ALTER TABLE `mesa`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `orden`
--
ALTER TABLE `orden`
  MODIFY `id` int(255) unsigned NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `orden_detalle`
--
ALTER TABLE `orden_detalle`
  MODIFY `id` bigint(255) unsigned NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `producto`
--
ALTER TABLE `producto`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `producto_especialidad`
--
ALTER TABLE `producto_especialidad`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `mesa_orden`
--
ALTER TABLE `mesa_orden`
  ADD CONSTRAINT `fk_mesa_cliente_mesa1` FOREIGN KEY (`mesa_id`) REFERENCES `mesa` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `orden`
--
ALTER TABLE `orden`
  ADD CONSTRAINT `fk_orden_cliente1` FOREIGN KEY (`cliente_id`) REFERENCES `cliente` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_orden_usuario1` FOREIGN KEY (`usuario_id`) REFERENCES `usuario` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `orden_detalle`
--
ALTER TABLE `orden_detalle`
  ADD CONSTRAINT `fk_orden_detalle_orden1` FOREIGN KEY (`orden_id`) REFERENCES `orden` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_orden_detalle_producto1` FOREIGN KEY (`producto_id`) REFERENCES `producto` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
