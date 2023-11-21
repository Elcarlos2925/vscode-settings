create database the_drop_coffee;
use the_drop_coffee;

create table usuarios(
id_usuario int not null,
nombre_usuario varchar (30) not null,
apellido_usuario varchar (50) not null,
contraseña varchar (40) not null,
correo_electronico varchar (90) not null
);

create table producto(
id_producto int not null,
nombre_producto int not null,
precio float not null,
descripcion longtext not null,
envio float not null, /*envio se veria raro solo una en español jajaja*/
estrellas int not null
);

create table comentario(
id_comentario int not null,
estrellas int not null,
id_usuario int not null,
id_producto int not null,
comentario longtext not null
);

create table pedido(
    id_pedido int not null,
    id_producto int not null,
    id_direccion int not null,
    fecha_compra date not null,
    fecha_entrega date not null
);

create table direccion(
    codigo_postal int (5) not null,/*codigo postal*/
    ciudad varchar (50) not null,
    estado varchar (50) not null,
    calle varchar (50) not null,
    entre_calle varchar (100) not null,
    especificaciones longtext not null,
    num_int int not null,
    num_ext int not null,
    id_direccion int not null,
    nombre_receptor varchar (90) not null,
    tel int (10) not null,
    id_usuario int not null
);
                                                
create table comentario_usuario(
    id_comentario int not null,
    id_usuario int not null
);

create table pedido_usuario(
    id_pedido int not null,
    id_usuario int not null
);

create table wish_list(
id_producto int not null,
id_usuario int not null
);

create table carrito(
id_producto int not null,
id_usuario int not null
);

create table direccion_usuario(
    id_direccion int not null,
    id_usuario int not null
);

alter table comentario_usuario add constraint comentario_usuario_id_comentario_fk foreign key (id_comentario) references comentario(id_comentario);

alter table INGREDIENTES_PRODUCTOS add constraint INGREDIENTES_PRODUCTOS_ID_PRODUCTOS_FK foreign key (Id_Producto)references PRODUCTOS(ID_PRODUCTO);
