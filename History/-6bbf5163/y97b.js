function nombre(valor) {
    // Verificar si hay números en la cadena
    if (/[\d]/.test(valor)) {
        alert("Por favor, ingresa solo letras y espacios.");
        return; // No se establece el valor del input si hay números
    }

    // Filtrar caracteres que no son letras ni espacios
    var titularFormateado = valor.replace(/[^a-zA-Z\s]/g, '');

    // Establecer el valor formateado en el input
    document.getElementById('nombre').value = titularFormateado;
}