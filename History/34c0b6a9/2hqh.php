<?php
$para      = 'aquí va el correo de a quien envías';
$asunto    = 'El asunto del correo';
$descripcion   = 'Este es el cuerpo del correo';
$de = 'From: tu correo configurado';

if (mail($para, $asunto, $descripcion, $de))
   {
echo "Correo enviado satisfactoriamente";
}
?>