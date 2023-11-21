<?php
//declarar las variables de conexión

use function PHPSTORM_META\type;

$servidor="Localhost";
$usuario="root";
$password="1122334455";
$db ="the_drop_coffee";

$conexion= mysqli_connect($servidor, $usuario, $password, $db);
if($conexion->connect_error){
    die("Error al conectar la base de datos".$conexion->connect_error);
}
?>