<?php

ini_set('display_errors', 1);
ini_set('display_startup_errors', 1);
error_reporting(E_ALL);
$mensaje='';
//llamar conexión base de datos
include ('../ConexionDB/conexion.php');
if(isset($_POST['finalizar_compra']))
{
    if(strlen($_POST['numeroTarjeta']) >= 19
    && strlen($_POST['fecha']) >= 5
    && strlen($_POST['nombreTitular']) >= 5
    && strlen($_POST['cvv']) >= 3)
    {
        $numeroTarjeta = trim($_POST['numeroTarjeta']);
        $fecha = trim($_POST['fecha']);
        $nombreTitular = trim($_POST['nombreTitular']);
        $cvv = trim($_POST['cvv']);

        $numeroTarjeta_encriptada = md5($numeroTarjeta);
        $fecha_encriptada = md5($fecha);
        $cvv_encriptada = md5($cvv);
        //auto incremento
        $id_pago_result = mysqli_query($conexion, "SELECT MAX(id_pago) + 1 AS next_id FROM pago;");
        $row = mysqli_fetch_assoc($id_pago_result);
        $id_pago = $row['next_id'];

        $consulta="INSERT INTO `pago` (`id_pago`, `id_usuario`, `numero`, `fecha_vencimiento`, `titular`, `cvv`) VALUES ('$id_pago', '2', '$numeroTarjeta_encriptada', '$fecha_encriptada', '$nombreTitular', '$cvv_encriptada');";
        $resultado=mysqli_query($conexion, $consulta);
        $mensaje="<div class='contenedor-mensaje-succes'>
                <strong>Compra Exitosa Muchas Gracias Por Confiar En Nosotros.</strong>
                </div><style>.fondo-contenedor{display:none;}</style>";
    } 
    elseif (strlen($_POST['numeroTarjeta']) >= 19
    && strlen($_POST['fecha']) >= 5
    && strlen($_POST['nombreTitular']) >= 5
    && strlen($_POST['cvv']) >= 0){
        $mensaje="<div class='contenedor-mensaje'>
                    <strong>hubo un error en el registro</strong> por favor, llena todos los campos.
                    </div>";
    }
    else{
        $mensaje="<div class='contenedor-mensaje'>
                    <strong>hubo un error en el registro</strong> por favor, llena todos los campos.
                    </div>";
    }
}
?>