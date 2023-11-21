const productos=[
    {
        "id": "12",
        "titulo": "Llavero vaso de café helado The Drop Coffee",
        "imagen": "./img/C1.png",
        "precio": 150.00,
        "imagen1": "./img/12-1.png",
        "imagen2": "./img/12-2.png",
        "imagen3": "./img/12-3.png",
        "Descripción": `<h2>Descripción</h2>
        <br>Lleva contigo tu pasión por el café a todas partes con nuestro encantador Llavero vaso de café helado The Drop Coffee. Este llavero es mucho más que una simple pieza, es una declaración de tu amor por el café y tu afinidad con The Drop Coffee.
        <br>
        <br>El llavero está hecho de metal y plástico resistente y tiene una forma única: un vaso de café estilizado, que mide 10x8 cm (centímetros). Además, viene acompañado de un grano de café por separado, un símbolo del ingrediente esencial que da vida a tus bebidas favoritas.
        <br>
        <br>Este llavero es una representación perfecta de tu pasión por el café y tu conexión con The Drop Coffee. Ya sea que lo lleves en tus llaves, en tu mochila o en tu bolso, mostrarás tu amor por el café de calidad en cada paso que des.
        `,
        "Características": `<h2>Características<h2>
        <br>Cantidad: 1 pieza
        <br>Acabado: Liso
        <br>Color: ocre y amarillo
        <br>Es industrial: No
        <br>Es portátil: Si
        <br>Género: Unisex
        <br>Material: metal y plástico
        <br>Medida de altura: 10 cm
        <br>Medida de ancho: 8 cm
        <br>Medida de peso: 0.83 kg
        <br>Requiere ensamblaje: No
        <br>Uso recomendado: Llaves, mochila o bolso
        `,
        "Instrucciones_de_uso": `<h2>Instrucciones de uso</h2>
        <br><h2>Manejo con cuidado<h2>
        <br>Tu llavero es un accesorio elegante y funcional. Trátalo con cariño y evita someterlo a un uso rudo o fuerza excesiva.
  
        <br><h2>Limpieza regular<h2>
        <br>Para mantener su brillo y apariencia impecable, límpialo con un paño suave y seco de vez en cuando. Esto ayudará a eliminar la suciedad y el polvo acumulados.
    
        <br><h2>Evita la exposición a la humedad<h2>
        <br>Aunque es resistente, evita sumergir tu llavero en agua o exponerlo a la humedad prolongada, el contacto constante con la humedad podría afectar su durabilidad.
  
        <br><h2>Cuidado con elementos decorativos<h2>
        <br>Si tu llavero cuenta con elementos decorativos como piedras o detalles metálicos, ten en cuenta que podrían desprenderse si se someten a un uso áspero, trátalos con delicadeza.
  
        <br><h2>Prevención contra raspaduras<h2>
        <br>Evita que tu llavero entre en contacto con objetos afilados o superficies ásperas que puedan causar raspaduras en su acabado.
  
        <br>Siguiendo estas sencillas instrucciones, podrás disfrutar de tu llavero The Drop Coffee con estilo y mantenerlo en excelentes condiciones durante mucho tiempo. ¡Llévalo contigo con orgullo!
        `,
        "Comentarios": `<h2>Comentarios</h2>`
    }
]

const contenedorProductos = document.querySelector("#contenedor-producto-vista");
const numerito = document.querySelector("#numerito");
let botonesAgregar = document.querySelectorAll(".añadir-al-carrito");

function CargarInformacion(){

    productos.forEach(producto => {

        const div = document.createElement("div");
        div.classList.add("contenedor-producto-vista");
        div.innerHTML = `
        <div class="fondo-contenedor-producto" id="fondo-contenedor-producto">
            <div class="carrusel-datos">
            
                <div class="carrusel-btn">
                    <button class="anterior-producto">&#10094; </button>
                    <div class="carrusel-producto-completo">
                        <div class="imagen-productos-completo">
                            <img src="${producto.imagen1}">
                        </div>
                        <div class="imagen-productos-completo">
                            <img src="${producto.imagen2}">
                        </div>
                        <div class="imagen-productos-completo">
                            <img src="${producto.imagen3}">
                        </div>
                    </div>
                    <button class="siguiente-producto"> &#10095;</button>
                </div>
                
                <div class="contenedor-datos-producto">
                    
                    <div class="titulo">
                        ${producto.titulo}
                    </div>
                    <div class="calific-like-share">
                        <div class="calificacion-contenedor">
                            <div id="descripción-calificacion">
                                Calificación:
                            </div>
                            <div id="cal-5btn">
                                <div id="calificacion">
                                    <h5>
                                        4.0
                                    </h5>
                                </div>
                                <div class="btn-calificacion">
                                    <button id="estrellas">
                                        <i class="fas fa-coffee"></i>
                                    </button>
                                    <button id="estrellas">
                                        <i class="fas fa-coffee"></i>
                                    </button>
                                    <button id="estrellas">
                                        <i class="fas fa-coffee"></i>
                                    </button>
                                    <button id="estrellas">
                                        <i class="fas fa-coffee"></i>
                                    </button>
                                    <button id="estrellas-deshabilitada">
                                        <i class="fas fa-coffee"></i>
                                    </button>
                                </div>
                            </div>
                        </div>
                        <div class="like-share">
                            <input type="checkbox" id="like">
                            <label for="like" class="lbl-like"><i class="fas fa-heart"></i></label>
                            
                            <input type="checkbox" id="share">
                            <label for="share" class="lbl-share"><i class="fas fa-link"></i></label>
                        </div>
                    </div>
                    <div class="precio-mxn-completo">
                        <div class="precio-completo">
                            <h5 class="signo-dollar">
                                $
                            </h5>
                            <h5>
                                ${producto.precio}
                            </h5>
                        </div>
                        <div class="mxn-completo">
                            <h5>
                                MXN
                            </h5>
                        </div>
                    </div>
                    <div class="contenedor-cant-comp-addcar">
                        <div class="cantidad-completo">
                            <div class="centrar-cantidad-contenedor">
                                <div class="cantidad-contenedor">
            
                                    <div id="left">
                                        <button id="menos-completo">-</button>
                                    </div>
                                    
                                    <div id="label-cantidad">
                                        <label for="cantidad" id="cantidad-completo">1</label>
                                    </div>
                                    
                                    <div id="right">
                                        <button id="mas-completo">+</button>
                                    </div>
                                </div>
                            </div>
            
                        </div>
                        <div class="comprar-ahora">
                            <button id="btn-comprar-ahora">
                                <h5>Comprar Ahora</h5>
                            </button>
                        </div>
                        <div class="add-to-car-completo">
                            <button class="añadir-al-carrito">
                                <img src="../../img/carrito+.png" id="carritoplus" />
                            </button>
                        </div>
                    </div>
                </div>
            </div>

            <div class="barra-opciones">
                <button  id="btn-descripcion" onclick="mostrarDescripcion()">
                    Descripción
                </button>
                <button id="btn-ingredientes" onclick="mostrarCaracteristicas()">
                    Características
                </button>
                <button id="btn-instrucciones" onclick="mostrarInstrucciones()">
                    Instrucciones de uso
                </button>
                <button id="btn-comentarios" onclick="mostrarComentarios()">
                    Comentarios
                </button>
            </div>
            <div class="contenido" id="contenido">
                <p>${producto.Descripción}</p>
            </div>
    </div>
        `;
        contenedorProductos.append(div);
    })
    actualizarNumerito();
}
let productosEnCarrito = localStorage.getItem("productos-en-carrito");
productosEnCarrito = JSON.parse(productosEnCarrito);
function actualizarNumerito(){
    let nuevoNumerito = productosEnCarrito.reduce((acc, producto) => acc + producto.cantidad, 0);
    numerito.innerText = nuevoNumerito;
}
actualizarNumerito();
CargarInformacion();

function mostrarDescripcion() {

    document.querySelector("#contenido"). innerHTML = "";
    productos.forEach(producto => {

        const div = document.createElement("div");
        div.innerHTML = `
            ${producto.Descripción}
            <style>
                #btn-descripcion{
                    color: #342009;
                    background-color: #fff;
                }
                
                #btn-ingredientes,
                #btn-instrucciones,
                #btn-comentarios,
                {
                    color: #fff;
                    background-color: #342009;
                }
            </style>
        `;
        document.querySelector("#contenido").append(div);
    })
  }


function mostrarCaracteristicas() {
    document.querySelector("#contenido"). innerHTML = "";
    productos.forEach(producto => {

        const div = document.createElement("div");
        div.innerHTML = `
            ${producto.Características}
            <style>
                #btn-ingredientes{
                    color: #342009;
                    background-color: #fff;
                }
                
                #btn-instrucciones,
                #btn-comentarios,
                #btn-descripcion
                {
                    color: #fff;
                    background-color: #342009;
                }
            </style>
        `;
        document.querySelector("#contenido").append(div);
    })
  }

  function mostrarInstrucciones() {
    document.querySelector("#contenido"). innerHTML = "";
    productos.forEach(producto => {

        const div = document.createElement("div");
        div.innerHTML = `
            ${producto.Instrucciones_de_uso}
            <style>
                #btn-instrucciones{
                    color: #342009;
                    background-color: #fff;
                }
                
                #btn-ingredientes,
                #btn-comentarios,
                #btn-descripcion
                {
                    color: #fff;
                    background-color: #342009;
                }
            </style>
        `;
        document.querySelector("#contenido").append(div);
    })
  }

  function mostrarComentarios() {
    document.querySelector("#contenido"). innerHTML = "";
    productos.forEach(producto => {

        const div = document.createElement("div");
        div.innerHTML = `
            ${producto.Comentarios}
            <style>
                #btn-comentarios{
                    color: #342009;
                    background-color: #fff;
                }
                
                #btn-ingredientes,
                #btn-instrucciones,
                #btn-descripcion
                {
                    color: #fff;
                    background-color: #342009;
                }
            </style>
        `;
        document.querySelector("#contenido").append(div);
    })
  }