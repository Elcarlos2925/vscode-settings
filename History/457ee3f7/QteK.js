document.addEventListener("DOMContentLoaded", function () {
    let index = 0;
    const imagenes = document.querySelectorAll('.imagen-productos-completo img');

    function mostrarImagen(index) {
        imagenes.forEach(imagen => {
            imagen.style.display = 'none';
        });
        imagenes[index].style.display = 'block';
    }

    function mostrarSiguiente() {
        index++;
        if (index >= imagenes.length) {
            index = 0;
        }
        mostrarImagen(index);
    }

    function mostrarAnterior() {
        index--;
        if (index < 0) {
            index = imagenes.length - 1;
        }
        mostrarImagen(index);
    }

    function cambiarAutomaticamente() {
        mostrarSiguiente();
    }

    document.querySelector('.siguiente-producto').addEventListener('click', () => {
        mostrarSiguiente();
    });

    document.querySelector('.anterior-producto').addEventListener('click', () => {
        mostrarAnterior();
    });

    let intervalo = setInterval(cambiarAutomaticamente, 10000); // Cambiar automáticamente cada 10 segundos
    mostrarImagen(index);
});
