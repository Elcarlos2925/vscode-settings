const productosEnCarrito = JSON.parse(localStorage.getItem("productos-en-carrito"));

const contenedorCarritoVacio = document.querySelector("#carrito-vacio");
const contenedorProductos = document.querySelector("#contenedor-productos");
const contenedorCarritoComprado = document.querySelector("#carrito-comprado");




if(productosEnCarrito){
    contenedorCarritoVacio.classList.add("disabled");
    contenedorProductos.classList.remove("disabled");
    contenedorCarritoComprado.classList.add("disabled");
}else{

}