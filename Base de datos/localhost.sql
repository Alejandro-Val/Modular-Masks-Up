-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost:3306
-- Tiempo de generación: 16-03-2023 a las 23:40:25
-- Versión del servidor: 10.5.16-MariaDB
-- Versión de PHP: 7.3.32

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `id20458499_masksupdb`
--
CREATE DATABASE IF NOT EXISTS `id20458499_masksupdb` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE `id20458499_masksupdb`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `achievements`
--

CREATE TABLE `achievements` (
  `id_user` int(11) NOT NULL,
  `achievement1` tinyint(1) NOT NULL DEFAULT 0,
  `achievement2` tinyint(1) NOT NULL DEFAULT 0,
  `achievement3` tinyint(1) NOT NULL DEFAULT 0,
  `achievement4` tinyint(1) NOT NULL DEFAULT 0,
  `achievement5` tinyint(1) NOT NULL DEFAULT 0,
  `achievement6` tinyint(1) NOT NULL DEFAULT 0,
  `achievement7` tinyint(1) NOT NULL DEFAULT 0,
  `achievement8` tinyint(1) NOT NULL DEFAULT 0,
  `achievement9` tinyint(1) NOT NULL DEFAULT 0,
  `achievement10` tinyint(1) NOT NULL DEFAULT 0,
  `achievement11` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `achievements`
--

INSERT INTO `achievements` (`id_user`, `achievement1`, `achievement2`, `achievement3`, `achievement4`, `achievement5`, `achievement6`, `achievement7`, `achievement8`, `achievement9`, `achievement10`, `achievement11`) VALUES
(1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `username` varchar(13) NOT NULL,
  `password` varchar(20) NOT NULL,
  `age` int(11) NOT NULL,
  `diagnostico` varchar(64) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `user`
--

INSERT INTO `user` (`id`, `username`, `password`, `age`, `diagnostico`) VALUES
(1, 'Test1', '12345', 23, 'Depresión'),
(2, 'Cesar', '123456', 21, 'cancer');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `achievements`
--
ALTER TABLE `achievements`
  ADD UNIQUE KEY `id_user` (`id_user`);

--
-- Indices de la tabla `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `achievements`
--
ALTER TABLE `achievements`
  ADD CONSTRAINT `achievments_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `user` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
