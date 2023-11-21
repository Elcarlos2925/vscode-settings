function mostrarCondiciones() {
    var mensaje = "La contraseña debe cumplir con los siguientes requisitos:\n" +
                  "- Al menos 8 caracteres de longitud\n" +
                  "- Al menos una letra mayúscula\n" +
                  "- Al menos una letra minúscula\n" +
                  "- Al menos un número\n" +
                  "- Al menos un carácter especial (por ejemplo, !@#$%^&*)";
  
    var mensajeCondiciones = document.getElementById("mensaje-condiciones");
    mensajeCondiciones.innerText = mensaje;
  
    // Alternar la clase 'visible' para mostrar u ocultar el mensaje
    mensajeCondiciones.classList.toggle("visible");
  }

  document.addEventListener("click", function(event) {
    var mensajeCondiciones = document.getElementById("mensaje-condiciones");
    
    // Si el clic ocurrió fuera del mensaje y el mensaje está visible, ocúltalo
    if (event.target !== mensajeCondiciones && !mensajeCondiciones.contains(event.target)) {
      mensajeCondiciones.classList.remove("visible");
    }
  });
  