function nombre(valor) {
    // Filtrar caracteres que no son letras ni espacios
    var titularFormateado = valor.replace(/[^\sa-zA-Z]/g, '');

    // Establecer el valor formateado en el input
    document.getElementById('nombre').value = titularFormateado;
}
