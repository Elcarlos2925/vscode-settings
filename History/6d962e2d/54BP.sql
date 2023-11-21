create database the_drop_coffee;
use the_drop_coffee;

create table usuarios(
id_usuario int not null,
nombre_usuario varchar (30) not null,
apellido_usuario varchar (50) not null,
contraseña varchar (40) not null,
correo_electronico varchar (90) not null,
primary key (id_usuario)
);

create table producto(
id_producto int not null,
nombre_producto int not null,
precio double not null,
descripcion longtext not null,
envio double not null, /*envio se veria raro solo una en español jajaja*/
estrellas int not null,
primary key (id_producto)
);

create table comentario(
id_comentario int not null,
estrellas int not null,
id_usuario int not null,
id_producto int not null,
comentario longtext not null,
primary key (id_comentario)
);

create table pedido(
    id_pedido int not null,
    id_producto int not null,
    id_direccion int not null,
    fecha_compra date not null,
    fecha_entrega date not null,
    total double not null,
    IVA double not null,
    envio double not null,
    primary key (id_pedido)
);

create table direccion(
    codigo_postal int not null,
    ciudad varchar (50) not null,
    estado varchar (50) not null,
    calle varchar (50) not null,
    entre_calle varchar (100) not null,
    especificaciones longtext,
    num_int int not null,
    num_ext int,
    id_direccion int not null,
    nombre_receptor varchar (90) not null,
    tel int not null,
    id_usuario int not null,
    primary key (id_direccion)
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

CREATE TABLE pago_usuario (
    id_pago INT NOT NULL ,
    id_usuario INT NOT NULL,
    numero int(19) not null,
    fecha_vencimiento date not null,
    titular varchar 
    );

CREATE TABLE pago_usuario (
    id_pago INT NOT NULL ,
    id_usuario INT NOT NULL );



alter table comentario_usuario add constraint comentario_usuario_id_comentario_fk foreign key (id_comentario) references comentario(id_comentario);
alter table comentario_usuario add constraint comentario_usuario_id_usuario_fk foreign key (id_usuario) references usuarios(id_usuario);

alter table pedido_usuario add constraint pedido_usuario_id_pedido_fk foreign key (id_pedido) references pedido(id_pedido);
alter table pedido_usuario add constraint pedido_usuario_id_usuario_fk foreign key (id_usuario) references usuarios(id_usuario);


alter table wish_list add constraint wish_list_id_producto_fk foreign key (id_producto) references producto(id_producto);
alter table wish_list add constraint wish_list_id_usuario_fk foreign key (id_usuario) references usuarios(id_usuario);

alter table carrito add constraint carrito_id_producto_fk foreign key (id_producto) references producto(id_producto);
alter table carrito add constraint carrito_id_usuario_fk foreign key (id_usuario) references usuarios(id_usuario);

alter table direccion_usuario add constraint direccion_usuario_id_direccion_fk foreign key (id_direccion) references direccion (id_direccion);
alter table direccion_usuario add constraint direccion_usuario_id_usuario_fk foreign key (id_usuario) references usuarios(id_usuario);
