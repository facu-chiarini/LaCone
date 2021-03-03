DROP DATABASE Vivero

CREATE DATABASE Vivero

USE Vivero

CREATE TABLE TipoDoc (ID INT,
						Descripcion VARCHAR(20),
						CONSTRAINT id_tipoDoc_pk PRIMARY KEY(ID))

CREATE TABLE Estado (ID INT,
					 Descripcion VARCHAR(10),
					 CONSTRAINT id_Estado_pk PRIMARY KEY (ID))

CREATE TABLE TipoPlanta (ID INT,
						Nombre VARCHAR(30),
						Descripcion VARCHAR(30),
						Estado INT
						CONSTRAINT Estado NOT NULL,
						CONSTRAINT id_tipoPlanta_pk PRIMARY KEY (ID),
						CONSTRAINT estado_tipo_planta_fk FOREIGN KEY (Estado) REFERENCES Estado(ID))

CREATE TABLE TipoProducto (ID INT,
							Nombre VARCHAR(30),
							Descripcion VARCHAR(50),
							Estado INT
							CONSTRAINT Estado NOT NULL,
							CONSTRAINT id_tipoProducto_pk PRIMARY KEY (ID),
							CONSTRAINT estado_tipo_producto_fk FOREIGN KEY (Estado) REFERENCES Estado(ID))

CREATE TABLE Plantas(Codigo INT, 
					NombreCientifico VARCHAR(50), 
					NombreComun VARCHAR(20), 
					Tipo VARCHAR(20), 
					Precio DECIMAL
					CONSTRAINT Precio NOT NULL, 
					Stock INT,
					Estado INT
					CONSTRAINT Estado NOT NULL,
					CONSTRAINT id_planta_pk PRIMARY KEY (Codigo),
					CONSTRAINT estado_planta_fk FOREIGN KEY (Estado) REFERENCES Estado(ID))

CREATE TABLE Producto(Codigo INT, 
					Nombre VARCHAR(50), 
					Tipo VARCHAR(20), 
					Stock INT, 
					Costo DECIMAL
					CONSTRAINT Costo NOT NULL, 
					Precio DECIMAL
					CONSTRAINT Precio NOT NULL,
					Composicion INT,
					Estado INT
					CONSTRAINT Estado NOT NULL,
					CONSTRAINT id_Producto_pk PRIMARY KEY (Codigo),
					CONSTRAINT estado_producto_fk FOREIGN KEY (Estado) REFERENCES Estado(ID))

CREATE TABLE Barrio (ID INT,
					Nombre VARCHAR(30),
					CONSTRAINT id_barrio_pc PRIMARY KEY (ID))

CREATE TABLE Localidad (ID INT,
						Nombre varchar(30),
						CONSTRAINT id_Localidad_pc PRIMARY KEY (ID))

CREATE TABLE Proveedor (ID INT,
						Nombre VARCHAR (20),
						Calle VARCHAR(20),
						Nro_Calle INT,
						Barrio INT,
						Localidad INT,
						Telefono VARCHAR(30),
						Razon_Social VARCHAR(50),
						Estado INT
						CONSTRAINT Estado NOT NULL,
						CONSTRAINT id_proveedor_pk PRIMARY KEY(ID),
						CONSTRAINT barrio_fk FOREIGN KEY (Barrio) REFERENCES Barrio(ID),
						CONSTRAINT estado_proveedor_fk FOREIGN KEY (Estado) REFERENCES Estado(ID))

CREATE TABLE Cliente	(TipoDoc INT,
						NroDoc VARCHAR(30),
						Nombre VARCHAR(30)
						CONSTRAINT Nombre NOT NULL,
						Apellido VARCHAR(30)
						CONSTRAINT Apellido NOT NULL,
						Calle VARCHAR(30),
						NroCalle INT,
						Barrio INT,
						Localidad INT,
						Telefono VARCHAR(30),
						Email VARCHAR(30),
						Estado INT
						CONSTRAINT Estado NOT NULL,
						CONSTRAINT id_cliente_pk PRIMARY KEY (TipoDoc, NroDoc),
						CONSTRAINT id_barrio_fk FOREIGN KEY (Barrio) REFERENCES Barrio(ID),
						CONSTRAINT id_localidad_fk FOREIGN KEY (Localidad) REFERENCES Localidad(ID),
						CONSTRAINT estado_cliente_fk FOREIGN KEY (Estado) REFERENCES Estado(ID))

CREATE TABLE Empleado (ID INT,
					   Nombre VARCHAR(30),
					   Apellido VARCHAR(30),
					   Telefono VARCHAR(30),
					   Calle VARCHAR(30),
					   Nro_Calle INT,
					   Barrio INT,
					   Localidad INT,
					   Contraseña VARCHAR(30),
					   Estado INT
					   CONSTRAINT Estado NOT NULL,
					   CONSTRAINT id_empleado_pk PRIMARY KEY (ID),
					   CONSTRAINT barrio_empleado_fk FOREIGN KEY (Barrio) REFERENCES Barrio(ID),
					   CONSTRAINT localidad_empleado_fk FOREIGN KEY (Localidad) REFERENCES Localidad(ID),
					   CONSTRAINT estado_empleado_fk FOREIGN KEY (Estado) REFERENCES Estado(ID))

CREATE TABLE TipoFactura (ID INT,
						  Nombre VARCHAR(30)
						  CONSTRAINT tipofactura_pk PRIMARY KEY (ID))

CREATE TABLE Factura (Tipo_Factura INT,
					  Nro_Factura INT,
					  TipoDoc INT
					  CONSTRAINT TipoDoc NOT NULL,
					  NroDoc VARCHAR(30)
					  CONSTRAINT NroDoc NOT NULL,
					  Fecha DATE,
					  Id_Empleado INT,
					  Monto INT,
					  CONSTRAINT id_factura_pk PRIMARY KEY (Tipo_Factura, Nro_Factura),
					  CONSTRAINT doc_factura_fk FOREIGN KEY (TipoDoc, NroDoc) REFERENCES Cliente(TipoDoc, NroDoc),
					  CONSTRAINT TipoFactura_fk FOREIGN KEY (Tipo_Factura) REFERENCES TipoFactura (ID))

CREATE TABLE Puntos (TipoDoc INT,
					NroDoc VARCHAR(30),
					Tipo_Factura INT,
					Nro_Factura INT,
					Cantidad INT
					CONSTRAINT CANTIDAD NOT NULL,
					Fecha DATETIME,
					CONSTRAINT id_puntos_pk PRIMARY KEY (TipoDoc, NroDoc, Nro_Factura,Tipo_Factura, Fecha),
					CONSTRAINT doc_puntos_fk FOREIGN KEY (TipoDoc, NroDoc) REFERENCES Cliente(TipoDoc, NroDoc),
					CONSTRAINT puntos_factura_fk FOREIGN KEY (Tipo_Factura, Nro_Factura) REFERENCES Factura(Tipo_Factura, Nro_Factura))

CREATE TABLE Composicion (ID INT,
						  Cod_Prod_Compuesto INT,
						  Cod_Prod_Componente INT,
						  Cant_Compuesto INT,
						  Cant_Componente INT,
						  CONSTRAINT composicion_id_pk PRIMARY KEY (ID),
						  CONSTRAINT cod_prod_comp_fk FOREIGN KEY (Cod_Prod_Compuesto) REFERENCES Producto (Codigo),
						  CONSTRAINT cod_prod_Componente_fk FOREIGN KEY (Cod_Prod_Componente) REFERENCES Producto (Codigo))

CREATE TABLE Catalogo (ID INT,
						Id_Planta INT,
						Puntos_Necesarios INT,
						Estado INT
						CONSTRAINT Estado NOT NULL,
						CONSTRAINT id_Catalogo_pk PRIMARY KEY (ID, Id_Planta),
						CONSTRAINT id_planta_catalogo_fk FOREIGN KEY (Id_Planta) REFERENCES Plantas(Codigo),
						CONSTRAINT estado_catalogo_fk FOREIGN KEY (Estado) REFERENCES Estado(ID))

CREATE TABLE DetalleFactura (Tipo_Factura INT,
							 Nro_Factura INT,
							 Id_Planta INT,
							 Id_Producto INT,
							 Cantidad INT,
							 Precio DECIMAL,
							 CONSTRAINT detalle_Factura_pk PRIMARY KEY (Tipo_Factura, Nro_Factura,Id_Planta, Id_Producto),
							 CONSTRAINT detalle_Factira_fk FOREIGN KEY (Tipo_Factura, Nro_Factura) REFERENCES Factura(Tipo_Factura, Nro_Factura),
							 CONSTRAINT Id_Planta_fk FOREIGN KEY (ID_Planta) REFERENCES Plantas (Codigo),
							 CONSTRAINT Id_Producto_fk FOREIGN KEY (Id_Producto) REFERENCES Producto (Codigo))

CREATE TABLE Canje (ID INT,
					TipoDoc INT,
					NroDoc VARCHAR(30),
					Id_Catalogo INT,
					Id_Planta INT,
					Fecha DATETIME,
					Puntos_a_Restar INT,
					CONSTRAINT canje_pk PRIMARY KEY (ID, TipoDoc, NroDoc, Id_Catalogo, Id_Planta,Fecha),
					CONSTRAINT canje_cliente_fk FOREIGN KEY (TipoDoc, NroDoc) REFERENCES Cliente(TipoDoc, NroDoc),
					CONSTRAINT canje_productos_fk FOREIGN KEY (Id_Catalogo, Id_Planta) REFERENCES Catalogo(ID, Id_Planta)) 



ALTER TABLE Producto ADD CONSTRAINT id_composicion_producto_fk FOREIGN KEY (Composicion) REFERENCES Composicion(ID)


INSERT INTO Estado VALUES (1, 'Activo'), (2, 'Inactivo')

INSERT INTO TipoProducto VALUES (4,'Compuesto','Producto formado por 2 productos',1)

INSERT INTO TipoFactura VALUES (1, 'Electronica'), (2, 'Simplificada')

INSERT INTO Estado (ID) VALUES (0)

INSERT INTO Producto (Codigo,Costo,Precio,Estado) VALUES (0,0,0,0)

INSERT INTO Plantas (Codigo,Precio,Estado) VALUES (0,0,0)

INSERT INTO Composicion (ID, Cod_Prod_Componente, Cod_Prod_Compuesto) VALUES (0,0,0)

INSERT INTO TipoFactura (ID) VALUES (0)

INSERT INTO TipoDoc (ID) VALUES (0)

INSERT INTO Cliente (NroDoc, Estado, TipoDoc,Nombre,Apellido) VALUES (0,0,0,'','')

INSERT INTO Factura (Nro_Factura,Tipo_Factura,TipoDoc,NroDoc) VALUES (0,0,0,0)				    

INSERT INTO Barrio VALUES (1, 'General Paz'),(2,'Nueva Cordoba'), (3, 'Crisol'), (4, 'Centro'), (5,'Cerro')

INSERT INTO TipoDoc VALUES (1, 'DNI Tarjeta'), (2,'DNI Libreta verde'), (3, 'Libreta Civica')

INSERT INTO Localidad VALUES (1,'Cordoba'), (2,'Carlos Paz'), (3,'Rio Segundo'), (4, 'Calamuchita'), (5, 'General Roca')

INSERT INTO TipoPlanta VALUES (1, 'Helecho','Planta de interior',1), (2, 'Herbacea','Culinaria',1), (3,'Angiospermas','Planta con flores',1)

INSERT INTO Plantas VALUES (1, 'ADIANTUM CAPILLUS-VENERIS', 'Culantrillo',1, 55, 100,1), 
							(2, 'Ocimum basilicum', 'Albahaca',2,40,200,1),
							(3,'Bellis perennis','Margarita',3,120,50,1),
							(4, 'Asplenium nidus', 'Nido de ave',1,65.50,20,1),
							(5, 'Saccharum officinarum', 'Caña de azucar',3,80,70,1)

INSERT INTO TipoProducto VALUES (1,'Accesorio','Piezas parar adornar las plantas',1),
								(2, 'Tierra', 'Distintos tipos de tierras',1),
								(3, 'Fertilizante','Distintos tipos de fertilizantes',1)


INSERT INTO Producto VALUES (1,'Maceta',1,200,40,80,0,1),
							(2,'Tierra negra',2,100,20,30,0,1),
							(3,'Tierra profesional',2,100,40,60,0,1),
							(4, 'Abono universal',3,70,65,100,0,1)

INSERT INTO Composicion VALUES (1,1,2,1,1)

INSERT INTO Empleado VALUES (1,'Agustin','Hadad','3512495352','Vigo',2190,3,1,'123',1),
							(2,'Facundo','Chiarini','3515467890','Maipu',194,4,3,'321',1),
							(3,'Gio','Marandino','3515352351','Nuñez',2190,2,2,'456',1)

INSERT INTO Cliente VALUES (1,'42543887','Juan','Paraje', 'La coruña',203, 3,5,'3514698752','juan@gmail.com',1),
						   (3,'42543883','Milagros','Barnasthpol', 'Agustin Garzon',86, 4,1,'3514624752','milagros@gmail.com',1),
						   (2,'42543821','Maria','Kuttel', 'Buenos Aires',600, 2,1,'3514694752','Maria@gmail.com',1)

INSERT INTO Proveedor VALUES (1,'TerraFertil','Olmos',194,4,1,'4271421','Venta al x mayor de tierra',1),
							 (2,'AgroFy','Revolucion de mayo',300,3,2,'4277821','Venta al x mayor de fertilizantes',1),
							 (3,'Emporio de la maceta','Av Rafael Nuñez',500,5,3,'4271746','Venta al x mayor de macetas',1)

INSERT INTO Catalogo VALUES (1,1,200,1),
							(1,2,200,1),
							(1,3,200,1),
							(2,4,250,1),
							(2,5,250,1)

