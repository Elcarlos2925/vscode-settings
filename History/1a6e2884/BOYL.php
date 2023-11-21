<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);

//llamar conexión base de datos
include ('../ConexionDB/conexion.php');
if(isset($_POST['Registrar'])){
    if(strlen($_POST['nombre']) >= 1 && strlen($_POST['apellido']) >= 1 && strlen($_POST['email']) >= 1 && strlen($_POST['contraseña']) >= 1 && strlen($_POST['verificar-contraseña']) >= 1)
    {
        $nombre = trim($_POST['nombre']);
        $apellido = trim($_POST['apellido']);
        $email = trim($_POST['email']);
        $contraseña = trim($_POST['contraseña']);
        $validar_contraseña = trim($_POST['verificar-contraseña']);
        if ($contraseña == $validar_contraseña)
        {
            $contraseña_encriptada = md5($contraseña);
            //auto incremento
            $id_usuario=$conexion->query("SELECT MAX(id_usuario) + 1  FROM usuarios;");
            $consulta="INSERT INTO `usuarios`(`id_usuario`, `nombre_usuario`, `apellido_usuario`, `contraseña`, `correo_electronico`) VALUES ('2','$nombre','$apellido','$email','$contraseña_encriptada');";
            $resultado=mysqli_query($conexion, $consulta);
            if($resultado){
                $mensaje="<div class='contenedor-mensaje'>
                        <strong>si registra pa</strong>
                        </div>";
            }
            else
            {
                $mensaje="<div class='contenedor-mensaje'>
                <strong>Contraseña no valida</strong> Las contraseñas ingresadas no coinciden, intentelo nuevamente.
                </div>";
            }
        }
        else{
            $mensaje="<div class='contenedor-mensaje'>
                    <strong>hubo un error en el registro</strong> pero mimnimo llegaste aqui, hechale ganas.
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




<!--if (!empty($_POST['Registrar']))
{
    if (empty($_POST['nombre']) or empty($_POST['apellido']) or empty($_POST['email']) or empty($_POST['contraseña']) or empty($_POST['verificar-contraseña'])){
        echo "<div class='contenedor-mensaje'>
        <strong>empty</strong>
        </div>";
    }
    else{
        $nombre=$_POST['nombre'];
        $apellido=$_POST['apellido'];
        $email=$_POST['email'];
        $contraseña=$_POST['contraseña'];
        $validar_contraseña=$_POST['verificar-contraseña'];
            if ($contraseña == $validar_contraseña)
            {
                $contraseña_encriptada = md5($contraseña);
                //auto incremento
                $id_usuario=$conexion->query("SELECT MAX(id_usuario) + 1  FROM usuarios;");
                $sql=$conexion->query("INSERT INTO `usuarios`(`id_usuario`, `nombre_usuario`, `apellido_usuario`, `contraseña`, `correo_electronico`) VALUES ('$id_usuario','$nombre','$apellido','$email','$contraseña_encriptada');");
                if($sql == 1)
                {
                    $mensaje="<div class='contenedor-mensaje'>
                    <strong>usuario registrado correctamente</strong>
                    </div>";
                }
                else
                {
                    $mensaje="<div class='contenedor-mensaje'>
                    <strong>hubo un error en el registro</strong>
                    </div>";
                }
        }
        else
        {
            $mensaje="<div class='contenedor-mensaje'>
            <strong>Contraseña no valida</strong> Las contraseñas ingresadas no coinciden, intentelo nuevamente.
            </div>";
        }
    }
    $mensaje="<div class='contenedor-mensaje'>
        <strong>aca tambien</strong>
        </div>";
}-->