<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);
//llamar conexión base de datos
include '../ConexionDB/conexion.php';
$mensaje = '';
if(isset($_POST['iniciar-sesion'])){

    //ruser r=recuperar user=usuario por que luego llora el niño omar psdt:carita enojada
    $ruser = $conexion->real_escape_string($_POST['email']);
    //pass de password
    $rpass = $conexion->real_escape_string(md5($_POST['contraseña']));
    $consulta = "SELECT * FROM usuarios WHERE correo_electronico='$ruser' and contraseña='$rpass'";
    if($resultado = $conexion->query($consulta)){
        while($row = $resultado->fetch_array()){
            $uservalid = $row["correo_electronico"];
            $passwordvalid = $row["contraseña"];
        }
        $resultado->close();
    }
    $conexion->close();
    if(isset($ruser) && isset($rpass)){
        if($ruser == $uservalid && $rpass == $passwordvalid){
            $_SESSION['login'] = true;
            $_SESSION['usuario'] = $usuario;
            header("location:../index.php");
        }
        else{
/*            header("location:login.php");*/
              $mensaje.="<div class='contenedor-mensaje'>
                        <button type='button' class='close'>
                        <strong>Usuario no valido: </strong> El usuario no se encuatra registrado, registre un usuario valido para iniciar sesión.    
                        <button type='button' class='close'>
                        <span aria-hidden='true'>&times;</span>
                        </button>
                        </div>";
        }
    }
    else{
        /*            header("location:login.php");*/
                      $mensaje.="<div class='contenedor-mensaje'>
                                <strong>Usuario no valido</strong> El usuario no se encuatra registrado en el sistema consulta a soporte.
                                <button type='button' class='close' data-dismiss='alert' aria-label='Close'>
                                <span aria-hidden='true'>&times;</span>
                                </button>
                                </div>";
                }
        
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Iniciar Sesión</title>
    <link rel="stylesheet" href="style.css">
    <link rel="Website Icon" type="png" href="../img/Logosinfondo.png">

    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css">

</head>
<body>
<div class="mensaje-error">
        <?php
            echo "$mensaje";
        ?>
   </div>
    <div class="Forms-Login" >
        <a href="../index.php"><img src="img/Logo-White.png" id="Logo"></a>
        <h2>Iniciar Sesión</h2>
        <form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post">
            <label for="email">Correo Electronico: <span style="color: rgb(170, 56, 56);">*</span></label>
            <div class="contraseña-contenedor">
                <input type="email" name="email" id="email" placeholder="Ingrese su Correo Electronico" required>
                <button type="button" onclick="mostrarCondicionesCorreo()" class="fas fa-info-circle" id="info-btn1"></button>
            </div>
            <div id="mensaje-condiciones-email"></div>
            <br>

            <label for="contraseña">Contraseña: <span style="color: rgb(170, 56, 56);">*</span></label>
            <div class="contraseña-contenedor">
                <input type="password" name="contraseña" id="contraseña" placeholder="Ingrese su Contraseña"  pattern="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+{}\[\]:;<>,.?~\\/-]).{8,}$" required >
                <span toggle="#contraseña" class="eye"></span>
                <button type="button" onclick="mostrarCondiciones()" class="fas fa-info-circle" id="info-btn"></button>
            </div>
            <div id="mensaje-condiciones"></div>
            <br>
            <input class="btn-is" name="iniciar-sesion" type="submit" value="iniciar sesión">
            <a href="index.php" class="cambio-form">Registrarse</a>

        </form>
</div>
</body>
<script type="text/javascript" src="scripts/mostrar-ocultar.js"></script>
<script type="text/javascript" src="scripts/mensajes-contraseña.js"></script>
</html>