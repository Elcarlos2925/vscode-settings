<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Carrito</title>
    <link rel="stylesheet" href="style.css">
    <link rel="stylesheet" href="../css/style.css">
    <link rel="Website Icon" type="png" href="../img/Logosinfondo.png">

</head>
<body>
    <header class="header">
        <div class="nav-logo">
            <a href="../index.php"><img src="../img/Logo-White.png" alt="logo"></a>
        </div>
        <div class="nav-nombre">
            <a href="../index.php"><h2>The Drop Coffee</h2></a>
        </div>
        <nav>
            <ul class="nav-links">
                <li>
                    <a href="../index.php">Inicio</a>
                </li>
                <li>
                    <a href="../Coffee.php">Café</a>
                </li>
                <li>
                    <a href="../Productos.php">Productos</a>
                </li>
                <li>
                    <a href="../Recetas.php">Recetas</a>
                </li>
            </ul>
        </nav>
        
        <div class="botones-izq">
            <div class="btn-btn">
                <a href="../Registro/index.php" class="btn"><button>Registrar</button></a>        
            </div>
            <div class="btn-car-shop">
                <a href="index.php" class="car-shop"><button><img src="../img/carrito.png" width="auto" height="50%" alt="carrito nav-bar"></button></a>
            </div>
        </div>

        <a onclick="openNav()" class="menu" href="#"><button><img src="../img/menu.png" width="auto" height="50%" alt="3 barras horizontales"></button></a>
        <div class="overlay" id="mobile-menu">
            <a onclick="closeNav()"  href="" class="close">&times;</a>
            <div class="overlay-content">
                    <a href="../index.php">Inicio</a>
                    <a href="../Coffee.php">Café</a>
                    <a href="../Productos.php">Productos</a>
                    <a href="../Recetas.php">Recetas</a>
                    <a href="../Registro/index.php">Registrar</a>
                    <a href="index.php">Carrito</a>
            </div>
        </div>

    </header>
<!-------------------------------------header--------------------------------------->
   <div class="centrar-contenedor">
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

        <div class="producto-contenedor">                           
            <img src="../img/6.png" id="imagen-producto">
            <div class="centrar">
                <div class="contenedor-superior">
                    <p id="nombre-producto">Café Colombiano</p>
                    <div class="precio-mxn">
                        <p id="precio-producto">$ 500.00</p>
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
                            <label for="cantidad" id="cantidad">2</label>
                        </div>
                        <div class="right">
                            <button class="mas">+</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>                                                     

        <hr style="color: rgb(236, 236, 236);" >

        <div class="datos-carrito">
            <div class="subtotal-contenedor">                          
                <h4>Subtotal: </h4>
                <p id="subtotal">$ 750.00</p>
                <p class="mxn">MXN</p>
            </div>                                                      
            <div class="envio-contenedor">                              
                <h4>Envío: </h4>
                <p id="envio">$ 0.00</p>
                <p class="mxn">MXN</p>
            </div>                                                      
            <p id="promocion-envio">Promoción envío gratis aplicada</p>
            <div class="total-contenedor">                              
                <h3>Total: </h3>
                <p id="total">$ 750.00</p>
                <p class="mxn">MXN</p>
            </div>                                                      
            <button class="Finalizar-compra">ir al pago</button>
        </div>
    </div>
</div>

<footer>
    <hr>
    &copy; 2023 - The Drop Coffee - <a href="">Privacy</a>
</footer>


</body>
<script type="text/javascript" src="../js/Nav-Menu.js"></script>
</html>