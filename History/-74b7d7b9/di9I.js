function mostrarCondiciones() {
    var mensaje = "La contraseña debe cumplir con los siguientes requisitos:\n" +
                  "- Al menos 8 caracteres de longitud\n" +
                  "- Al menos una letra mayúscula\n" +
                  "- Al menos una letra minúscula\n" +
                  "- Al menos un número\n" +
                  "- Al menos un carácter especial (por ejemplo, !@#$%^&*)";
  
    var mensajeCondiciones = document.getElementById("mensaje-condiciones");
    mensajeCondiciones.innerText = mensaje;
  }

  function mostrarCondicionesNombre() {
    var mensaje = "Solo puede contener letras y espacios.";
  
    var mensajeCondiciones = document.getElementById("mensaje-condiciones-nombre");
    mensajeCondiciones.innerText = mensaje;
  }

  function mostrarCondicionesApellido() {
    var mensaje = "Solo puede contener letras y espacios.";
  
    var mensajeCondiciones = document.getElementById("mensaje-condiciones-apellido");
    mensajeCondiciones.innerText = mensaje;
  }

  function mostrarCondicionesCorreo() {
    var mensaje = "";
  
    var mensajeCondiciones = document.getElementById("mensaje-condiciones");
    mensajeCondiciones.innerText = mensaje;
  }