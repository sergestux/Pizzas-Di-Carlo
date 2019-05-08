-- MySQL Workbench Synchronization
-- Generated: 2015-10-12 02:44
-- Model: New Model
-- Version: 1.0
-- Project: Name of the project
-- Author: Sergio

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE TABLE IF NOT EXISTS `pizzas`.`orden` (
  `id` INT(255) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '',
  `cliente_id` INT(255) NOT NULL COMMENT '',
  `subtotal` FLOAT(11) NOT NULL COMMENT '',
  `descuento` FLOAT(11) NOT NULL COMMENT '',
  `total` FLOAT(11) NOT NULL COMMENT '',
  `fecha_hora` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT '',
  `usuario_id` INT(11) NULL DEFAULT NULL COMMENT '',
  `status` TINYINT(1) NOT NULL DEFAULT 2 COMMENT '0 Cancelada\r\n1 Cobrada\r\n2 Sin cobrar',
  PRIMARY KEY (`id`)  COMMENT '',
  INDEX `fk_orden_cliente1_idx` (`cliente_id` ASC)  COMMENT '',
  INDEX `fk_orden_usuario1_idx` (`usuario_id` ASC)  COMMENT '',
  CONSTRAINT `fk_orden_mesa_orden1`
    FOREIGN KEY (`id`)
    REFERENCES `pizzas`.`mesa_orden` (`orden_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_orden_cliente1`
    FOREIGN KEY (`cliente_id`)
    REFERENCES `pizzas`.`cliente` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_orden_usuario1`
    FOREIGN KEY (`usuario_id`)
    REFERENCES `pizzas`.`usuario` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_spanish_ci;

CREATE TABLE IF NOT EXISTS `pizzas`.`orden_detalle` (
  `id` BIGINT(255) UNSIGNED NOT NULL COMMENT '',
  `orden_id` INT(255) UNSIGNED NOT NULL COMMENT '',
  `producto_id` INT(255) NOT NULL COMMENT '',
  `especialidad_id` INT(255) NOT NULL DEFAULT 0 COMMENT '',
  `cantidad` SMALLINT(255) UNSIGNED NOT NULL COMMENT '',
  `descripcion` VARCHAR(50) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `importe_unitario` VARCHAR(255) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `total` VARCHAR(255) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `status` TINYINT(1) NOT NULL DEFAULT 1 COMMENT '',
  PRIMARY KEY (`id`)  COMMENT '',
  INDEX `fk_orden_detalle_producto1_idx` (`producto_id` ASC)  COMMENT '',
  INDEX `fk_orden_detalle_producto_especialidad1_idx` (`especialidad_id` ASC)  COMMENT '',
  INDEX `fk_orden_detalle_orden1_idx` (`orden_id` ASC)  COMMENT '',
  CONSTRAINT `fk_orden_detalle_producto1`
    FOREIGN KEY (`producto_id`)
    REFERENCES `pizzas`.`producto` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_orden_detalle_producto_especialidad1`
    FOREIGN KEY (`especialidad_id`)
    REFERENCES `pizzas`.`producto_especialidad` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_orden_detalle_orden1`
    FOREIGN KEY (`orden_id`)
    REFERENCES `pizzas`.`orden` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_spanish_ci;

CREATE TABLE IF NOT EXISTS `pizzas`.`producto_especialidad` (
  `id` INT(255) NOT NULL AUTO_INCREMENT COMMENT '',
  `descripcion` VARCHAR(30) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `status` TINYINT(1) NOT NULL DEFAULT 1 COMMENT '',
  PRIMARY KEY (`id`)  COMMENT '')
ENGINE = InnoDB
AUTO_INCREMENT = 10
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_spanish_ci;

CREATE TABLE IF NOT EXISTS `pizzas`.`producto` (
  `id` INT(255) NOT NULL AUTO_INCREMENT COMMENT '',
  `categoria` INT(255) NOT NULL COMMENT '',
  `descripcion` VARCHAR(50) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `precio` FLOAT(11) NOT NULL DEFAULT 0 COMMENT '',
  `status` TINYINT(1) NOT NULL DEFAULT 1 COMMENT '1 Significa que este producto está disponible para su venta\r\n0 Significa que este producto NO está disponible para su venta',
  PRIMARY KEY (`id`)  COMMENT '')
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_spanish_ci;


DELIMITER $$

USE `pizzas`$$
CREATE
DEFINER=`dicarlodb`@`localhost`
TRIGGER `pizzas`.`actualizar_mesa_cliente`
AFTER INSERT ON `pizzas`.`mesa`
FOR EACH ROW
INSERT INTO mesa_cliente SET mesa_id = NEW.id$$


DELIMITER ;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
