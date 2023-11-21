function mostrarCondiciones() {
    var mensaje = "La contraseña debe cumplir con los siguientes requisitos:\n" +
                  "- Al menos 8 caracteres de longitud\n" +
                  "- Al menos una letra mayúscula\n" +
                  "- Al menos una letra minúscula\n" +
                  "- Al menos un número\n" +
                  "- Al menos un carácter especial (por ejemplo, !@#$%^&*)";
  
    document.getElementById("mensaje-condiciones").innerText = mensaje;
  }  