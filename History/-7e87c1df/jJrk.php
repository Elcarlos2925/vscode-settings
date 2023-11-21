<?php
$mensaje='';
include("../ConexionDB/controlador-registro.php");

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $nombre = $_POST["nombre"];
    $apellido = $_POST["apellido"];
    $email = $_POST["email"];
    $contrasena = $_POST["contrasena"];
    $verificarContrasena = $_POST["verificar-contrasena"];

    // Verificar si el nombre contiene solo letras y espacios
    if (!preg_match("/^[A-Za-z\s]+$/", $nombre)) {
        $mensaje="<div class='contenedor-mensaje'>
            <strong>Error de formato.</strong> El espacio Nombre solo permite ingresar letras y números, intentelo nuevamente.
            </div>";
    }
    if (!preg_match("/^[A-Za-z\s]+$/", $apellido)) {
        $mensaje="<div class='contenedor-mensaje'>
            <strong>Error de formato.</strong> Introduzca un correo electronico valido, intentelo nuevamente.
            </div>";
    if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
        $mensaje="<div class='contenedor-mensaje'>
        <strong>Correo electrónico no es válido.</strong> El espacio Apellidos solo permite ingresar letras y números, intentelo nuevamente.
        </div>";
    }
}}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Registrar</title>
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
    <div class="Forms-Login">
        <a href="../index.php"><img src="img/Logo-White.png" id="Logo"></a>
        <h2>Crear Cuenta</h2>
        <form method="post">
            <label for="nombre">Nombre: <span style="color: rgb(170, 56, 56);">*</span></label>
            <div class="contraseña-contenedor">
                <input type="text" name="nombre" id="nombre" placeholder="Ingrese su Nombre" required>
            </div>
            <br>
            <label for="apellido">Apellidos: <span style="color: rgb(170, 56, 56);">*</span></label>
            <div class="contraseña-contenedor">
                <input type="text" name="apellido" id="apellido" placeholder="Ingrese sus Apellidos" required>
            </div>
            <br>
            <label for="email">Correo Electronico: <span style="color: rgb(170, 56, 56);">*</span></label>
            <div class="contraseña-contenedor">
                <input type="email" name="email" id="email" placeholder="Ingrese su Correo Electronico" required>
                <button type="button" onclick="mostrarCondicionesCorreo()" class="fas fa-info-circle" id="info-btn1"></button>
            </div>
            <div id="mensaje-condiciones-email"></div>
            <br>
            <label for="contraseña">Contraseña: <span style="color: rgb(170, 56, 56);">*</span></label>
            <div class="contraseña-contenedor">
                <input type="password" name="contraseña" id="contraseña" placeholder="Ingrese su Contraseña" pattern="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+{}\[\]:;<>,.?~\\/-]).{8,}$" required>
                <span toggle="#contraseña" class="eye"></span>
                <button type="button" onclick="mostrarCondiciones()" class="fas fa-info-circle" id="info-btn1"></button>
            </div>
            <div id="mensaje-condiciones"></div>
            <br>
            <label for="verificar-contraseña">Verificar Contraseña: <span style="color: rgb(170, 56, 56);">*</span></label>
            <div class="contraseña-contenedor">
                <input type="password" name="verificar-contraseña" id="verificar-contraseña" placeholder="Ingrese su Contraseña"  pattern="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+{}\[\]:;<>,.?~\\/-]).{8,}$" required>
                <span toggle="#verificar-contraseña" class="eye1"></span>
                <!--<button type="button" onclick="mostrarCondicionesVerificar()" class="fas fa-info-circle" id="info-btn1"></button>-->
            </div>
            <div id="mensaje-condiciones-verificar"></div>
            <br>
            <input class="btn-is" type="submit" name="Registrar" value="Registrarse">

            <a href="sign-in.php" class="cambio-form">¿Ya tienes una cuenta?</a>
        </form>
    </div>

</body>
<script type="text/javascript" src="scripts/mostrar-ocultar.js"></script>
<script type="text/javascript" src="scripts/mensajes-contraseña.js"></script>
</html>