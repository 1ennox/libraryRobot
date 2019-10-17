-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- 主机： 127.0.0.1
-- 生成日期： 2019-10-17 09:19:29
-- 服务器版本： 10.1.39-MariaDB
-- PHP 版本： 7.1.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 数据库： `library`
--

-- --------------------------------------------------------

--
-- 表的结构 `layer`
--

CREATE TABLE `layer` (
  `LibraryCode` int(36) NOT NULL,
  `Level` int(36) NOT NULL,
  `RoomNumber` int(36) NOT NULL,
  `shelf` int(36) NOT NULL,
  `ColumnNumber` int(36) NOT NULL,
  `Tier` int(36) NOT NULL,
  `LayerCode` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 转存表中的数据 `layer`
--

INSERT INTO `layer` (`LibraryCode`, `Level`, `RoomNumber`, `shelf`, `ColumnNumber`, `Tier`, `LayerCode`) VALUES
(19, 2, 2, 22, 8, 1, '01020202200801');

--
-- 转储表的索引
--

--
-- 表的索引 `layer`
--
ALTER TABLE `layer`
  ADD PRIMARY KEY (`LayerCode`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
