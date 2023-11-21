const productosEnCarrito = JSON.parse(localStorage.getItem("productos-en-carrito"));

const contenedorCarritoVacio = document.querySelector("#carrito-vacio");
const contenedorProductos = document.querySelector("#contenedor-productos");
const contenedorCarritoComprado = document.querySelector("#carrito-comprado");




if(productosEnCarrito){
    contenedorCarritoVacio.classList.add("disabled");
    contenedorProductos.classList.remove("disabled");
    contenedorCarritoComprado.classList.add("disabled");

    productosEnCarrito.forEach(producto => {
        const div = document.createElement("div");
        div.classList.add("contenedor-carrito");
    })




}else{
    contenedorCarritoVacio.classList.remove("disabled");
    contenedorProductos.classList.add("disabled");
    contenedorCarritoComprado.classList.remove("disabled");
}



<div class="contenedor-carrito">

<div class="producto-contenedor">                           
    <img src="../img/6.png" id="imagen-producto">
    <div class="centrar">
        <div class="contenedor-superior">
            <p id="nombre-producto">Café Colombiano</p>
            <div class="precio-mxn">
                <p id="precio-producto">$ 250.00</p>
                <p class="mxn">MXN</p>
            </div>
        </div>
        <div class="contenedor-inferior">
            <button class="eliminar"><img src="../img/trash-kaki-relleno.png" width="auto" height="100%"></button>
            <div class="cantidad-contenedor">
                <div class="left">
                    <button class="menos">-</button>
                </div>
                <div class="cantidad-contenedor">
                    <label for="cantidad" id="cantidad">1</label>
                </div>
                <div class="right">
                    <button class="mas">+</button>
                </div>
            </div>
        </div>
    </div>
</div>                                                     
                                                                                    
<hr style="color: rgb(236, 236, 236);">