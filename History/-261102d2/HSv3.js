function numeroTarjeta1(valor) {
    // Filtrar caracteres no numéricos
    var numeros = valor.replace(/\D/g, '');

    // Limitar a solo números y dividir en grupos de cuatro dígitos
    var grupos = numeros.match(/(\d{1,4})/g);

    // Unir los grupos con espacio
    var resultado = grupos ? grupos.join(' ') : '';

    // Establecer el valor formateado en el input
    document.getElementById('numeroTarjeta').value = resultado;
}