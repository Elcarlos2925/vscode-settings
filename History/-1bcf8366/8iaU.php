<?php
//declarar las variables de conexión
$servidor="Localhost";
$usuario="root";
$password="ds";
$db ="the_drop_coffee";

$conexion= mysqli_connect($servidor, $usuario, $password, $db);
if($conexion->connect_error){
    die("Error al conectar la base de datos".$conexion->connect_error);
}
?>