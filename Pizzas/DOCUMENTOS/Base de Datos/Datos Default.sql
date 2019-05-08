TRUNCATE `pizzas`.`orden_detalle`;
DELETE FROM `orden` ;
ALTER TABLE `orden` AUTO_INCREMENT = 0;
DELETE from mesa;

INSERT INTO `pizzas`.`usuario` (`id`, `nombre`, `usuario`, `password`, `perfil`, `status`) VALUES
(1, 'SERGIO', 'sergio', '12345', 1, 1);


INSERT INTO `pizzas`.`producto` (`id`, `categoria`, `descripcion`, `precio`, `status`) VALUES
(1, 1, 'Pizza Chica', 80, 1),
(2, 1, 'Pizza Mediana', 125, 1),
(3, 1, 'Pizza Grande', 170, 1),
(4, 1, 'Pizza Jumbo', 280, 1),
(5, 2, 'Refresco de 1/2 lt', 15, 1),
(6, 2, 'Refresco de 2  lt', 35, 1),
(7, 2, 'Refresco de 3 lt', 45, 1),
(8, 2, 'Ingrediente Extra #1', 10, 1),
(9, 2, 'Ingrediente Extra #2', 15, 1),
(10, 2, 'Aderezo Extra', 10, 1),
(11, 3, 'Alitas adobadas o picantes 1/2 kg', 90, 1),
(12, 3, 'Alitas adobadas o picantes 1 kg', 155, 1),
(13, 3, 'Spaguetti a la Bolognesa', 125, 1),
(14, 3, 'Fussili 4 quesos c/champiñon', 145, 1),
(15, 3, 'Calzone', 60, 1),
(16, 3, 'Burgueroni', 70, 1);


INSERT INTO `pizzas`.`producto_especialidad` (`id`, `descripcion`, `status`) VALUES
(1, 'Carnes Frias', 1),
(2, 'Mexicana', 1),
(3, 'Cuatro Quesos', 1),
(4, 'Margarita', 1),
(5, 'Supreme', 1),
(6, 'Hawaiana', 1),
(7, 'Di Carlo', 1),
(8, 'Alambre', 1),
(9, 'Veggie', 1);



