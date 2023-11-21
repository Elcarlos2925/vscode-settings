-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost
-- Tiempo de generación: 21-11-2023 a las 00:46:56
-- Versión del servidor: 10.4.28-MariaDB
-- Versión de PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `the_drop_coffee`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `direccion`
--

CREATE TABLE `direccion` (
  `codigo_postal` int(11) NOT NULL,
  `ciudad` varchar(50) NOT NULL,
  `estado` varchar(50) NOT NULL,
  `calle` varchar(50) NOT NULL,
  `entre_calle` varchar(100) NOT NULL,
  `especificaciones` longtext DEFAULT NULL,
  `num_int` int(11) NOT NULL,
  `num_ext` varchar(11) DEFAULT NULL,
  `id_direccion` int(11) NOT NULL,
  `nombre_receptor` varchar(90) NOT NULL,
  `tel` varchar(11) NOT NULL,
  `id_usuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `direccion`
--

INSERT INTO `direccion` (`codigo_postal`, `ciudad`, `estado`, `calle`, `entre_calle`, `especificaciones`, `num_int`, `num_ext`, `id_direccion`, `nombre_receptor`, `tel`, `id_usuario`) VALUES
(22550, 'Tijuana]', 'Baja California', 'Av tomas aquino', 'Entre La postal y otay', 'Casa Color verde Justo enfrente de paleteria LA REYNA', 12, '2', 1, 'Carlos Abraham Lozoya Avalos', '6641234567', 2),
(22456, 'Tijuana]', 'Baja California', 'Av tomas aquino', 'Entre La postal y otay', '', 11, '', 2, 'test', '6647654321', 2),
(22551, 'Tijuana]', 'Baja California', 'Av tomas aquino', 'Entre La postal y otay', '', 15, '', 3, 'Carlos Abraham Lozoya Avalos', '6641234567', 2),
(22550, 'Tijuana]', 'Baja California', 'Av tomas aquino', 'Entre La postal y otay', 'Casa Color verde Justo enfrente de paleteria LA REYNA', 12, '2', 4, 'Carlos Abraham Lozoya Avalos', '6641234567', 2),
(22550, 'Tijuana]', 'Baja California', 'Av tomas aquino', 'Entre La postal y otay', '', 12, '2', 5, 'Carlos Abraham Lozoya Avalos', '6641234567', 2),
(22550, 'Tijuana]', 'Baja California', 'Av tomas aquino', 'Entre La postal y otay', '', 12, '2', 6, 'Carlos Abraham Lozoya Avalos', '6641234567', 2),
(22550, 'Tijuana]', 'Baja California', 'Av tomas aquino', 'Entre La postal y otay', '', 12, '2', 7, 'Carlos Abraham Lozoya Avalos', '6641234567', 2),
(22550, 'Tijuana]', 'Baja California', 'Av tomas aquino', 'Entre La postal y otay', '', 12, '', 8, 'Carlos Abraham Lozoya Avalos', '6641234567', 2);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `direccion`
--
ALTER TABLE `direccion`
  ADD PRIMARY KEY (`id_direccion`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
