let index = 0;
const imagenes = document.querySelectorAll('.imagen');

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

document.querySelector('.siguiente').addEventListener('click', mostrarSiguiente);
document.querySelector('.anterior').addEventListener('click', mostrarAnterior);

mostrarImagen(index);
