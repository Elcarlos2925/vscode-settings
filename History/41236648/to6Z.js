const productos=[
    {
        "id": "1",
        "titulo": "Café de Veracruz 300g",
        "imagen": "./img/C1.png",
        "precio": 250.00
    },

    {
        "id": "2",
        "titulo": "Café de Puebla 300g",
        "imagen": "./img/C3.png",
        "precio": 250.00
    },

    {
        "id": "3",
        "titulo": "Café de Chiapas 300g",
        "imagen": "./img/C5.png",
        "precio": 250.00
    },

    {
        "id": "4",
        "titulo": "Café de Oaxaca 300g",
        "imagen": "./img/C7.png",
        "precio": 250.00
    },

    {
        "id": "5",
        "titulo": "Café especial 300g",
        "imagen": "./img/C11.png",
        "precio": 250.00
    },

    {
        "id": "6",
        "titulo": "Café mezclas <br> mexicanas 300g",
        "imagen": "./img/C9.png",
        "precio": 250.00
    },

    {
        "id": "7",
        "titulo": "Café de Veracruz Descafeinado 300g",
        "imagen": "./img/C2.png",
        "precio": 250.00
    },

    {
        "id": "8",
        "titulo": "Café de Puebla Descafeinado 300g",
        "imagen": "./img/C4.png",
        "precio": 250.00
    },

    {
        "id": "9",
        "titulo": "Café de Chiapas Descafeinado 300g",
        "imagen": "./img/C6.png",
        "precio": 250.00
    },

    {
        "id": "10",
        "titulo": "Café de Oaxaca Descafeinado 300g",
        "imagen": "./img/C8.png",
        "precio": 250.00
    },

    {
        "id": "11",
        "titulo": "Café mezclas mexicanas Descafeinado 300g",
        "imagen": "./img/C10.png",
        "precio": 250.00
    },

    {
        "id": "12",
        "titulo": "Café especial <br> Descafeinado 300g",
        "imagen": "./img/C12.png",
        "precio": 250.00
    }
]

const contenedorProductos = document.querySelector("#contenedor-productos");
let botonesAgregar = document.querySelectorAll(".añadir-al-carrito");


function CargarProductos(){

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

     
}


CargarProductos();




/*const contenedorproductos = document.querySelector("#contenedorproductos");
let botonesAgregar = document.querySelectorAll(".añadir-al-carrito");
const numerito = document.querySelector("#numerito");


function CargarProductos(){
    productos.forEach(producto => {
        let div = document.createElement("div")
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
        `
        contenedorproductos.append(div);
    })
}

CargarProductos();

actualizarBotonesAgregar();


function actualizarBotonesAgregar(){
    botonesAgregar = document.querySelectorAll(".añadir-al-carrito");

    botonesAgregar.forEach(boton => {
        boton.addEventListener("click", agregarAlCarrito);
    })
}

const productos_en_carrito = []

function agregarAlCarrito(e){
    const idBoton = e.currentTarget.id;
    const ProductoAgregado = productos.flat().find(producto => producto.id === idBoton);
    const ProductoAgregado = productos.find(productos => productos.id === idBoton)
    
    if(productos_en_carrito.some(productos => productos.id === idBoton)){
        const index = productos_en_carrito.findIndex(productos => productos.id === idBoton);
        productos_en_carrito[index].cantidad++;
    }
    else{
        ProductoAgregado.cantidad = 1;
        productos_en_carrito.push(ProductoAgregado)
    }
    actualizarNumerito()
    localStorage.setItem("productos-en-carrito", JSON.stringify(productos_en_carrito))
}

function actualizarNumerito(){
    let newnumerito = productos_en_carrito.reduce((acc, productos) => acc + productos.cantidad, 0);
    numerito.innerText = newnumerito;
}*/