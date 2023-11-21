let productosEnCarrito = localStorage.getItem("productos-en-carrito");
productosEnCarrito = JSON.parse(productosEnCarrito);

const contenedorCarritoVacio = document.querySelector("#carrito-vacio");
const contenedorCarritoProductos = document.querySelector("#contenedor-productos");
const contenedorCarritoComprado = document.querySelector("#carrito-comprado");
let botonesEliminar = document.querySelector(".eliminar");
const contenedorTotal = document.querySelector("#total");
let menos = document.querySelectorAll(".menos");
let mas = document.querySelectorAll(".mas");

function actualizarNumerito(){
    let nuevoNumerito = productosEnCarrito.reduce((acc, producto) => acc + producto.cantidad, 0);
    numerito.innerText = nuevoNumerito;
}
function cargarProductosCarrito(){
    
    if(productosEnCarrito && productosEnCarrito.length > 0){
        contenedorCarritoVacio.classList.add("disabled");
        contenedorCarritoProductos.classList.remove("disabled");
        contenedorCarritoComprado.classList.add("disabled");
        
        contenedorCarritoProductos. innerHTML = "";
    
        productosEnCarrito.forEach(producto => {
            const div = document.createElement("div");
            
            div.classList.add("contenedor-carrito");
            div.innerHTML = `
                <div class="producto-contenedor">                           
                    <img src="../${producto.imagen}" id="imagen-producto">
                    <div class="centrar">
                        <div class="contenedor-superior">
                            <p id="nombre-producto">${producto.titulo}</p>
                            <div class="precio-mxn">
                                <p id="precio-producto">$ ${producto.precio}</p>
                                <p class="mxn">MXN</p>
                            </div>
                        </div>
                        <div class="contenedor-inferior">
                            <button class="eliminar" id="${producto.id}"><img src="../img/trash-kaki-relleno.png" width="auto" height="100%"></button>
                            <div class="cantidad-contenedor">
                                <div class="left">
                                    <button id="menos" class="menos">-</button>
                                </div>
                                <div class="cantidad-contenedor">
                                    <label for="cantidad" id="cantidad">${producto.cantidad}</label>
                                </div>
                                <div class="right">
                                    <button id="mas" class="mas">+</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>                                                                                                      
            `;
            contenedorCarritoProductos.append(div);
        })
        const div1 = document.createElement("div");
            
        div1.classList.add("contenedor-carrito");
        div1.innerHTML = `
            <div class="datos-carrito">
                    <div class="subtotal-contenedor">                          
                        <h4>Subtotal: </h4>
                        <p id="subtotal">$ 750.00</p>
                        <p class="mxn">MXN</p>
                    </div>                                                      
                    <div class="envio-contenedor">                              
                        <h4>Envío: </h4>
                        <p id="envio">$ 0.00</p>
                        <p id="mxnenvio" class="mxn">MXN</p>
                    </div>                                                      
                    <p id="promocionenvio">Promoción envío gratis aplicada</p>
                    <div class="total-contenedor">                              
                        <h3>Total: </h3>
                        <p id="total">$ 750.00</p>
                        <p class="mxn">MXN</p>
                    </div>                                                      
                    <button class="Finalizar-compra">ir al pago</button>
                </div>
        `;
        contenedorCarritoProductos.append(div1);
    } else{
        contenedorCarritoVacio.classList.remove("disabled");
        contenedorCarritoProductos.classList.add("disabled");
        contenedorCarritoComprado.classList.add("disabled");
    }
    actualizarNumerito();
    actualizarTotal();
    actualizarBotonesEliminar();
}

function actualizarBotonesEliminar(){
    botonesEliminar = document.querySelectorAll(".eliminar");

    botonesEliminar.forEach(boton => {
        boton.addEventListener("click", eliminarDelCarrito);
    });
}


function eliminarDelCarrito(e){
    const idBoton = e.currentTarget.id;
    const index = productosEnCarrito.findIndex(producto => producto.id === idBoton);

    productosEnCarrito.splice(index, 1);
    cargarProductosCarrito();
    localStorage.setItem("productos-en-carrito", JSON.stringify(productosEnCarrito));
}

function actualizarTotal(){
    const subtotalCalculado = productosEnCarrito.reduce((acc, producto) => acc + (producto.precio * producto.cantidad), 0);
    if(subtotalCalculado >= 500){
        const totalCalculado = productosEnCarrito.reduce((acc, producto) => acc +(producto.precio * producto.cantidad), 0);
        total.innerText = `$${totalCalculado}.00`;
        subtotal.innerText = `$${subtotalCalculado}.00`;
        envio.innerText = `GRATIS`;
        mxnenvio.innerText = ``;
    }else{
        const totalCalculado = productosEnCarrito.reduce((acc, producto) => acc + 180 +(producto.precio * producto.cantidad), 0);
        total.innerText = `$${totalCalculado}.00`;
        subtotal.innerText = `$${subtotalCalculado}.00`;
        envio.innerText = `$ 180.00`;
        promocionenvio.innerText = ``;
    }
}
                                                       
function actualizarBotonesSumar(){
    mas = document.querySelectorAll(".mas");

    mas.forEach(botonMas => {
       botonMas.addEventListener("click", sumarAlCarrito);
    })
}


function sumarAlCarrito(e){
    const idBoton = e.currentTarget.id;

    console.log(idBoton);
    const index = productosEnCarrito.findIndex(producto => producto.id === idBoton);

    productosEnCarrito[index].cantidad++;
    actualizarNumerito();
    localStorage.setItem("productos-en-carrito", JSON.stringify(productosEnCarrito));
}

cargarProductosCarrito();
actualizarBotonesSumar();
