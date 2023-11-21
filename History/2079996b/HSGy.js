const carrusel = document.querySelector('.carrusel-slides');
const anteriorBtn = document.querySelector('.anterior-btn');
const siguienteBtn = document.querySelector('.siguiente-btn');
const carruselSlides = document.querySelectorAll('.carrusel-slides img');

let contador = 0;

siguienteBtn.addEventListener('click', () => {
  if (contador >= carruselSlides.length - 1) return;
  contador++;
  actualizarCarrusel();
});

anteriorBtn.addEventListener('click', () => {
  if (contador <= 0) return;
  contador--;
  actualizarCarrusel();
});

function actualizarCarrusel() {
  carrusel.style.transform = `translateX(${-contador * 100}%)`;
}
