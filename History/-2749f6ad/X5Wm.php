<?php

ini_set('display_errors', 1);
ini_set('display_startup_errors', 1);
error_reporting(E_ALL);
//llamar conexión base de datos
include ('../ConexionDB/conexion.php');
if(isset($_POST['guardar-direccion']))
{
    if(strlen($_POST['Nombre-apellido'])              
    >= 1 && strlen($_POST['Codigo-postal'])          
    >= 1 && strlen($_POST['Telefono-contacto'])      
    >= 1 && strlen($_POST['Estado'])                  
    >= 1 && strlen($_POST['Municipio'])                
    >= 1 && strlen($_POST['Calle-colonia'])            
    >= 1 && strlen($_POST['Num-interior'])              
    >= 1 && strlen($_POST['Entre-calles'])              
    >= 1)
    {
        $nombre= trim($_POST['Nombre-apellido'])  
        $CP= trim($_POST['Codigo-postal'])    
        $telefono= trim($_POST['Telefono-contacto'])
        $estado = trim($_POST['Estado'])           
        $municipio = trim($_POST['Municipio'])        
        $calle = trim($_POST['Calle-colonia'])    
        $num_int = trim($_POST['Num-interior'])     
        $num_ext = trim($_POST['Num-exterior'])     
        $entre_calles = trim($_POST['Entre-calles'])     
        $especificaciones = trim($_POST['Especificaciones']);
        if ($contraseña == $validar_contraseña)
        {
            $contraseña_encriptada = md5($contraseña);
            //auto incremento
            $id_usuario_result = mysqli_query($conexion, "SELECT MAX(id_usuario) + 1 AS next_id FROM usuarios;");
            $row = mysqli_fetch_assoc($id_usuario_result);
            $id_usuario = $row['next_id'];

            $consulta="INSERT INTO `usuarios`(`id_usuario`, `nombre_usuario`, `apellido_usuario`, `contraseña`, `correo_electronico`) VALUES ('$id_usuario','$nombre','$apellido','$contraseña_encriptada','$email');";
            $resultado=mysqli_query($conexion, $consulta);
            $mensaje="<div class='contenedor-mensaje-succes'>
                    <strong>Usuario creado exitosamente.</strong>
                    </div>";
        }
        else{
            $mensaje="<div class='contenedor-mensaje'>
            <strong>Contraseña no valida</strong> Las contraseñas ingresadas no coinciden, intentelo nuevamente.
            </div>";
        }
    }
    else{
        $mensaje="<div class='contenedor-mensaje'>
                    <strong>hubo un error en el registro</strong> por favor, llena todos los campos.
                    </div>";
    }
}
?>