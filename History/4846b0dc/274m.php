<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Productos</title>
    <link rel="stylesheet" href="style-Productos.css">
    <link rel="stylesheet" href="style.css">
    <link rel="Website Icon" type="png" href="img/Logosinfondo.png">

</head>
<body>
    
    <header class="header">
        <div class="nav-logo">
            <a href="index.php"><img src="img/Logo-White.png" alt="logo"></a>
        </div>
        <div class="nav-nombre">
            <a href="index.php"><h2>The Drop Coffee</h2></a>
        </div>
        <nav>
            <ul class="nav-links">
                <li>
                    <a href="index.php">Inicio</a>
                </li>
                <li>
                    <a href="Coffee.html">Café</a>
                </li>
                <li>
                    <a href="Productos.html">Productos</a>
                </li>
                <li>
                    <a href="Recetas.html">Recetas</a>
                </li>
            </ul>
        </nav>
        
        <div class="botones-izq">
            <div class="btn-btn">
                <a href="Registro/index.html" class="btn"><button>Registrar</button></a>        
            </div>
            <div class="btn-car-shop">
                <a href="Carrito/index.html" class="car-shop"><button><img src="img/carrito.png" width="auto" height="50%" alt="carrito nav-bar"></button></a>
            </div>
        </div>

        <a onclick="openNav()" class="menu" href="#"><button><img src="img/menu.png" width="auto" height="50%" alt="3 barras horizontales"></button></a>
        <div class="overlay" id="mobile-menu">
            <a onclick="closeNav()"  href="" class="close">&times;</a>
            <div class="overlay-content">
                    <a href="index.php">Inicio</a>
                    <a href="Coffee.html">Café</a>
                    <a href="Productos.html">Productos</a>
                    <a href="Recetas.html">Recetas</a>
                    <a href="Registro/index.html">Registrar</a>
                    <a href="Carrito/index.html">Carrito</a>
            </div>
        </div>

    </header>

    <div class="carrusel">
        <div class="imagen">
            <a href="Recetas.html" ><img src="img/BannerTemporada.png" alt="Imagen 1"></a>
        </div>
        <div class="imagen">
            <a href="Coffee.html"><img src="img/3.png" alt="Imagen 2"></a>
        </div>
        <div class="imagen">
            <a href="Productos.html"><img src="img/4.png" alt="Imagen 3"></a>
        </div>
        <div class="imagen">
            <a href="index.php"><img src="img/5.1.png" alt="Imagen 4"></a>
        </div>
        <button class="anterior">&#10094; </button>
        <button class="siguiente"> &#10095;</button>
    </div>
    <script src="script.js"></script>
    
    <div class="productos">
        <div class="fondo-contenedor">
            <div class="contenedor_producto">
    
                <div class="imagen">
                    <img src="img/Taza.png">
                </div>
    
                <div class="descripcion-producto">
                    <p style="color:#EBE6DF">Taza de porcelana</p>
                    <div class="precio-boton">
                        <p id="precio">$199.90</p>
                        <button class="añadir-al-carrito"><img src="img/carrito+.png" id="carritoplus" /></button>
                    </div>
                </div>
            </div>
        </div>
    
        <div class="fondo-contenedor">
            <div class="contenedor_producto">
    
                <div class="imagen">
                    <img src="img/Taza.png">
                </div>
    
                <div class="descripcion-producto">
                    <p style="color:#EBE6DF">Taza de porcelana</p>
                    <div class="precio-boton">
                        <p id="precio">$199.90</p>
                        <button class="añadir-al-carrito"><img src="img/carrito+.png" id="carritoplus" /></button>
                    </div>
                </div>
            </div>
        </div>
    
        <div class="fondo-contenedor">
            <div class="contenedor_producto">
    
                <div class="imagen">
                    <img src="img/Taza.png">
                </div>
    
                <div class="descripcion-producto">
                    <p style="color:#EBE6DF">Taza de porcelana</p>
                    <div class="precio-boton">
                        <p id="precio">$199.90</p>
                        <button class="añadir-al-carrito"><img src="img/carrito+.png" id="carritoplus" /></button>
                    </div>
                </div>
            </div>
        </div>
    
        <div class="fondo-contenedor">
            <div class="contenedor_producto">
    
                <div class="imagen">
                    <img src="img/Taza.png">
                </div>
    
                <div class="descripcion-producto">
                    <p style="color:#EBE6DF">Taza de porcelana</p>
                    <div class="precio-boton">
                        <p id="precio">$199.90</p>
                        <button class="añadir-al-carrito"><img src="img/carrito+.png" id="carritoplus" /></button>
                    </div>
                </div>
            </div>
        </div>
    
        <div class="fondo-contenedor">
            <div class="contenedor_producto">
    
                <div class="imagen">
                    <img src="img/Taza.png">
                </div>
    
                <div class="descripcion-producto">
                    <p style="color:#EBE6DF">Taza de porcelana</p>
                    <div class="precio-boton">
                        <p id="precio">$199.90</p>
                        <button class="añadir-al-carrito"><img src="img/carrito+.png" id="carritoplus" /></button>
                    </div>
                </div>
            </div>
        </div>
    
        <div class="fondo-contenedor">
            <div class="contenedor_producto">
    
                <div class="imagen">
                    <img src="img/Taza.png">
                </div>
    
                <div class="descripcion-producto">
                    <p style="color:#EBE6DF">Taza de porcelana</p>
                    <div class="precio-boton">
                        <p id="precio">$199.90</p>
                        <button class="añadir-al-carrito"><img src="img/carrito+.png" id="carritoplus" /></button>
                    </div>
                </div>
            </div>
        </div>
    
        <div class="fondo-contenedor">
            <div class="contenedor_producto">
    
                <div class="imagen">
                    <img src="img/Taza.png">
                </div>
    
                <div class="descripcion-producto">
                    <p style="color:#EBE6DF">Taza de porcelana</p>
                    <div class="precio-boton">
                        <p id="precio">$199.90</p>
                        <button class="añadir-al-carrito"><img src="img/carrito+.png" id="carritoplus" /></button>
                    </div>
                </div>
            </div>
        </div>
    
        <div class="fondo-contenedor">
            <div class="contenedor_producto">
    
                <div class="imagen">
                    <img src="img/Taza.png">
                </div>
    
                <div class="descripcion-producto">
                    <p style="color:#EBE6DF">Taza de porcelana</p>
                    <div class="precio-boton">
                        <p id="precio">$199.90</p>
                        <button class="añadir-al-carrito"><img src="img/carrito+.png" id="carritoplus" /></button>
                    </div>
                </div>
            </div>
        </div>
    
        <div class="fondo-contenedor">
            <div class="contenedor_producto">
    
                <div class="imagen">
                    <img src="img/Taza.png">
                </div>
    
                <div class="descripcion-producto">
                    <p style="color:#EBE6DF">Taza de porcelana</p>
                    <div class="precio-boton">
                        <p id="precio">$199.90 </p>
                        <button class="añadir-al-carrito"><img src="img/carrito+.png" id="carritoplus" /></button>
                    </div>
                </div>
            </div>
        </div>
    
        <div class="fondo-contenedor">
            <div class="contenedor_producto">
    
                <div class="imagen">
                    <img src="img/Taza.png">
                </div>
    
                <div class="descripcion-producto">
                    <p style="color:#EBE6DF">Taza de porcelana</p>
                    <div class="precio-boton">
                        <p id="precio">$199.90</p>
                        <button class="añadir-al-carrito"><img src="img/carrito+.png" id="carritoplus" /></button>
                    </div>
                </div>
            </div>
        </div>
    
        <div class="fondo-contenedor">
            <div class="contenedor_producto">
    
                <div class="imagen">
                    <img src="img/Taza.png">
                </div>
    
                <div class="descripcion-producto">
                    <p style="color:#EBE6DF">Taza de porcelana</p>
                    <div class="precio-boton">
                        <p id="precio">$199.90</p>
                        <button class="añadir-al-carrito"><img src="img/carrito+.png" id="carritoplus" /></button>
                    </div>
                </div>
            </div>
        </div>
    
        <div class="fondo-contenedor">
            <div class="contenedor_producto">
    
                <div class="imagen">
                    <img src="img/Taza.png">
                </div>
    
                <div class="descripcion-producto">
                    <p style="color:#EBE6DF">Taza de porcelana</p>
                    <div class="precio-boton">
                        <p id="precio">$199.90</p>
                        <button class="añadir-al-carrito"><img src="img/carrito+.png" id="carritoplus" /></button>
                    </div>
                </div>
            </div>
        </div>
    
        <div class="fondo-contenedor">
            <div class="contenedor_producto">
    
                <div class="imagen">
                    <img src="img/Taza.png">
                </div>
    
                <div class="descripcion-producto">
                    <p style="color:#EBE6DF">Taza de porcelana</p>
                    <div class="precio-boton">
                        <p id="precio">$199.90</p>
                        <button class="añadir-al-carrito"><img src="img/carrito+.png" id="carritoplus" /></button>
                    </div>
                </div>
            </div>
        </div>
    
        <div class="fondo-contenedor">
            <div class="contenedor_producto">
    
                <div class="imagen">
                    <img src="img/Taza.png">
                </div>
    
                <div class="descripcion-producto">
                    <p style="color:#EBE6DF">Taza de porcelana</p>
                    <div class="precio-boton">
                        <p id="precio">$199.90</p>
                        <button class="añadir-al-carrito"><img src="img/carrito+.png" id="carritoplus" /></button>
                    </div>
                </div>
            </div>
        </div>
    
        <div class="fondo-contenedor">
            <div class="contenedor_producto">
    
                <div class="imagen">
                    <img src="img/Taza.png">
                </div>
    
                <div class="descripcion-producto">
                    <p style="color:#EBE6DF">Taza de porcelana</p>
                    <div class="precio-boton">
                        <p id="precio">$199.90</p>
                        <button class="añadir-al-carrito"><img src="img/carrito+.png" id="carritoplus" /></button>
                    </div>
                </div>
            </div>
        </div>
    
        <div class="fondo-contenedor">
            <div class="contenedor_producto">
    
                <div class="imagen">
                    <img src="img/Taza.png">
                </div>
    
                <div class="descripcion-producto">
                    <p style="color:#EBE6DF">Taza de porcelana</p>
                    <div class="precio-boton">
                        <p id="precio">$199.90</p>
                        <button class="añadir-al-carrito"><img src="img/carrito+.png" id="carritoplus" /></button>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <footer>
        <hr>
        &copy; 2023 - The Drop Coffee - <a href="">Privacy</a>
    </footer>

    <script type="text/javascript" src="Nav-Menu.js"></script>
</body>
</html>