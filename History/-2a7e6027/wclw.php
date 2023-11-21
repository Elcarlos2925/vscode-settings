<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Carrito</title>
    <link rel="stylesheet" href="style.css">
    <link rel="stylesheet" href="../css/style.css">
    <link rel="Website Icon" type="png" href="../img/Logosinfondo.png">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css">

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
                <li>
                    <a href="index.php">Favoritos</a>
                </li>
            </ul>
        </nav>
        
        <div class="botones-izq">
            <div class="btn-btn">
                <a href="../Registro/index.php" class="btn"><button>Registrar</button></a>        
            </div>
            <div class="btn-car-shop">
            <a href="index.php" class="car-shop"><button><img src="../img/carrito.png" width="auto" height="50%" alt="carrito nav-bar"><span id="numerito" class="numerito">0</span></button></a>
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
                    <a href="index.php">Favoritos</a>

            </div>
        </div>

    </header>
<!-------------------------------------header--------------------------------------->
<div id="carrito-vacio" class="disabled">
    <h1>
        Carrito Vacio
        <span style="margin-left: 10px;">
            <i class="far fa-frown"></i>
        </span>
    </h1>
</div>


<div class="centrar-contenedor">
    <div id="contenedor-productos" class="contenedor-carrito disabled">
        <!--? aqui se autocompleta el codigo del codigo-->
    </div>
</div>
<div id="carrito-comprado" class="disabled">
    <h1 id="carrito-comprado">
        Muchas Gracias Por Tu Compra
        <span style="margin-left: 10px;" >
            <i class="far fa-smile"></i>
        </span>
    </h1>
</div>

<footer>
    <hr>
    &copy; 2023 - The Drop Coffee - <a href="">Privacy</a>
</footer>


</body>
</html>
<script src="../js/cafes.js"></script>
<script type="text/javascript" src="../js/Nav-Menu.js"></script>