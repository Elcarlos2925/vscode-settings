const productosEnCarrito = JSON.parse(localStorage.getItem("productos-en-carrito"));

const contenedorcarritoVacio = document.querySelector("#carrito-vacio");
const contenedorProductos = document.querySelector("#contenedor-productos");
const contenedorCarritoComprado = document.querySelector("#carrito-comprado");




if(productosEnCarrito){
    contenedorcarritoVacio.classList.add.("disabled");
}else{

}