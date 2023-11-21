const productos=[
    {
        "id": "13",
        "titulo": "Taza Porcelana",
        "imagen": "./img/",
        "precio": 250.00,
        "categoria":"producto"
    },

    {
        "id": "14",
        "titulo": "Café de Puebla 300g",
        "imagen": "./img/C3.png",
        "precio": 250.00,
        "categoria":"producto"
    },

    {
        "id": "15",
        "titulo": "Café de Chiapas 300g",
        "imagen": "./img/C5.png",
        "precio": 250.00,
        "categoria":"producto"
    },

    {
        "id": "16",
        "titulo": "Café de Oaxaca 300g",
        "imagen": "./img/C7.png",
        "precio": 250.00,
        "categoria":"producto"
    },

    {
        "id": "17",
        "titulo": "Café especial 300g",
        "imagen": "./img/C11.png",
        "precio": 250.00,
        "categoria":"producto"
    },

    {
        "id": "18",
        "titulo": "Café mezclas <br> mexicanas 300g",
        "imagen": "./img/C9.png",
        "precio": 250.00,
        "categoria":"producto"
    },

    {
        "id": "19",
        "titulo": "Café de Veracruz Descafeinado 300g",
        "imagen": "./img/C2.png",
        "precio": 250.00,
        "categoria":"producto"
    },

    {
        "id": "20",
        "titulo": "Café de Puebla Descafeinado 300g",
        "imagen": "./img/C4.png",
        "precio": 250.00,
        "categoria":"producto"
    },

    {
        "id": "21",
        "titulo": "Café de Chiapas Descafeinado 300g",
        "imagen": "./img/C6.png",
        "precio": 250.00,
        "categoria":"producto"
    },

    {
        "id": "22",
        "titulo": "Café de Oaxaca Descafeinado 300g",
        "imagen": "./img/C8.png",
        "precio": 250.00,
        "categoria":"producto"
    },

    {
        "id": "23",
        "titulo": "Café mezclas mexicanas Descafeinado 300g",
        "imagen": "./img/C10.png",
        "precio": 250.00,
        "categoria":"producto"
    },

    {
        "id": "24",
        "titulo": "Café especial <br> Descafeinado 300g",
        "imagen": "./img/C12.png",
        "precio": 250.00,
        "categoria":"producto"
    }
]

const contenedorProductos = document.querySelector("#contenedor-productos");
const numerito = document.querySelector("#numerito");
let botonesAgregar = document.querySelectorAll(".añadir-al-carrito");


function CargarProductos(){

    contenedorProductos. innerHTML = "";

    productos.forEach(producto => {

        const div = document.createElement("div");
        div.classList.add("fondo-contenedor");
        div.innerHTML = `
        <div class="contenedor_producto">
            <div class="imagen-cafe">
                <a href="Productos/index.php"><img src="${producto.imagen}"></a>
            </div>

            <div class="descripcion-producto">
                <div style="color:#EBE6DF" id="nombre-cafe">${producto.titulo}</div>
                <div class="precio-boton">
                    <div id="precio">$${producto.precio}</div>
                    <div class="btn-add-carrito"><button class="añadir-al-carrito" id="${producto.id}"><img src="img/carrito+.png" class="carritoplus" /></button>
                </div>
            </div>
        </div>
        `;
        contenedorProductos.append(div);
    })

}

function actualizarBotonesAgregar(){
     botonesAgregar = document.querySelectorAll(".añadir-al-carrito");
     console.log(botonesAgregar);

     botonesAgregar.forEach(boton => {
        boton.addEventListener("click", agregarAlCarrito);
     })
}

let nuevoNumerito;
let productosEnCarritoLS = localStorage.getItem("productos-en-carrito");
if(productosEnCarritoLS){
    productosEnCarrito = JSON.parse(productosEnCarritoLS);
    actualizarNumerito();
}else{
    productosEnCarrito = [];
}

function agregarAlCarrito(e){
    const idBoton = e.currentTarget.id;
    const productoAgregado = productos.find(producto => producto.id === idBoton);

    if(productosEnCarrito.some(producto => producto.id === idBoton)){
        const index = productosEnCarrito.findIndex(producto => producto.id === idBoton);
        productosEnCarrito[index].cantidad++;
    }else{
        productoAgregado.cantidad = 1 ;
        productosEnCarrito.push(productoAgregado);
    }
    actualizarNumerito();

    localStorage.setItem("productos-en-carrito", JSON.stringify(productosEnCarrito));
}

function actualizarNumerito(){
    let nuevoNumerito = productosEnCarrito.reduce((acc, producto) => acc + producto.cantidad, 0);
    numerito.innerText = nuevoNumerito;
}

CargarProductos();
actualizarBotonesAgregar();