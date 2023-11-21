// Desactivar el botón cuando se carga la página
document.getElementById("btn-descripcion").disabled = true;

// Activar el botón cuando se hace clic en otro elemento (por ejemplo, un botón de "Activar")
function activarBoton() {
    document.getElementById("btn-descripcion").disabled = false;
}