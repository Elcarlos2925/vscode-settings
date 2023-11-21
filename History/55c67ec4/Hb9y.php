<?php
//declarar las variables de conexión
$servidor="Localhost";
$usuario="root";
$password="1122334455";
$db ="the_drop_coffee";

$conexion= mysqli_connect($servidor, $usuario, $password, $db);
if($conexion)
?>