create database the_drop_coffee;
use the_drop_coffee;

create table usuarios(
id_user int not null,
name_user varchar (30) not null,
last_name_user varchar (50) not null,
password varchar (40) not null,
email varchar (90) not null
);

create table producto(
id_product int not null,
name_product int not null,
price float not null,
description longtext not null,
shipping float not null, /*envio se veria raro solo una en español jajaja*/
stars int not null
);

create table comentario(
id_coment int not null,
stars int not null,
id_user int not null,
id_product int not null,
coment longtext not null
);

create table pedido(
    id_order int not null,
    id_product int not null,
    id_direction int not null,
    date_buy date not null,
    date_delivery date not null
);

create table direccion(
    cp int (5) not null,/*codigo postal*/
    city varchar (50) not null,
    estado varchar (50) not null,
    calle varchar (50) not null,
    entre_calle varchar (100) not null,
    especificaciones longtext not null,
    num_int int not null,
    num_ext int not null,
    id_direccion int not null,
    nombre_receptor varchar (90) not null,
    tel int (10) not null,
    id_user int not null
);
                                                
create table comentario_usuario(
    id_coment int not null,
    id_user int not null
);

create table pedido_usuario(
    id_pedido int not null,
    id_user int not null
);

create table wish_list(
id_product int not null,
id_user int not null
);

create table carrito(
id_product int not null,
id_user int not null
);

create table direccion_usuario(
    id_direccion int not null,
    id_user int not null
);

alter table comentario_usuario add constraint _ID_PRODUCTOS_FK foreign key (Id_Producto)references PRODUCTOS(ID_PRODUCTO);