DROP VIEW pizzas.`mesa_orden_detalle`;
CREATE VIEW pizzas.`mesa_orden_detalle` AS 
SELECT O.id AS 'OrdenId', M.id AS 'MesaId', M.descripcion As 'Mesa', 
	C.id AS 'ClienteId', C.nombre AS 'Cliente', 
    O.total AS 'Total'
FROM pizzas.mesa_orden MO
	INNER JOIN pizzas.mesa AS M ON MO.mesa_id=M.id
	INNER JOIN pizzas.orden O ON MO.orden_id=O.id
    INNER JOIN pizzas.cliente C ON O.cliente_id=C.id;
    
DROP VIEW pizzas.`mesa_desocupada`;    
CREATE VIEW pizzas.`mesa_desocupada` AS
SELECT M.id AS 'mesa_id', M.descripcion AS 'mesa_descripcion'
FROM pizzas.mesa M
WHERE M.id NOT IN (SELECT MO.mesa_id FROM  pizzas.mesa_orden MO);


DROP VIEW pizzas.`orden_detallada`;

CREATE VIEW pizzas.`orden_detallada` AS
SELECT O.id, O.tipo_venta,
	CASE O.tipo_venta 
		WHEN 1 THEN 'PARA COMER AQUI'
		WHEN 2 THEN 'PARA LLEVAR'
		WHEN 3 THEN 'A DOMICILIO'
		ELSE 'NO ESPECIFICADA'
	END AS 'Tipo Venta',
    O.cliente_id,	
    M.id AS 'mesa_id', M.descripcion AS 'Mesa',
    O.subtotal, O.descuento, O.total, 
    O.fecha_hora, 
    U.id AS 'usuario_id', U.nombre AS 'Usuario', 
    O.status,
    CASE O.status 
		WHEN 1 THEN 'ABIERTA'
		WHEN 2 THEN 'COBRADA'
		WHEN 3 THEN 'CANCELADA'
		ELSE 'NO ESPECIFICADA'
	END AS 'Orden Status'
FROM pizzas.orden O
	LEFT JOIN pizzas.usuario U
		ON O.usuario_id=U.id
	LEFT JOIN pizzas.mesa_orden MO
		ON O.id=MO.orden_id
	LEFT JOIN pizzas.mesa M
		ON MO.mesa_id=M.id
ORDER BY fecha_hora DESC;