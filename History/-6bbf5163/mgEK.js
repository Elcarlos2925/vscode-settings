function nombre(valor) {
    // Filtrar caracteres que no son letras ni espacios
    var titularFormateado = valor.replace(/[^a-zA-Z\s]/g, '');

    // Convertir todas las letras a mayúsculas
    titularFormateado = titularFormateado.toUpperCase();

    // Establecer el valor formateado en el input
    document.getElementById('nombre').value = titularFormateado;
}
function nombre(valor) {
    // Filtrar caracteres que no son letras ni espacios
    var titularFormateado = valor.replace(/[^a-zA-Z\s]/g, '');

    // Establecer el valor formateado en el input
    document.getElementById('nombre').value = titularFormateado;
}
