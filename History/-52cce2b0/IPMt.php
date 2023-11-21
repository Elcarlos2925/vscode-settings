<?php
//declarar las variables de conexión

use function PHPSTORM_META\type;

$servidor="Localhost";
$usuario="root";
$password="112233ewfc4455";
$db ="the_drop_coffee";

$conexion= mysqli_connect($servidor, $usuario, $password, $db);
if($conexion->connect_error){
    die("Error al conectar la base de datos".$conexion->connect_error);
}
?>