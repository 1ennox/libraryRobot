-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- 主机： 127.0.0.1
-- 生成日期： 2019-10-18 14:59:40
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
-- 表的结构 `book`
--

CREATE TABLE `book` (
  `barCode` varchar(128) NOT NULL,
  `title` varchar(256) NOT NULL,
  `callNo` varchar(128) NOT NULL,
  `isbn` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- 表的结构 `bookread`
--

CREATE TABLE `bookread` (
  `barCode` varchar(128) NOT NULL,
  `layerCode` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- 表的结构 `comparebarcode`
--

CREATE TABLE `comparebarcode` (
  `barCode` varchar(128) NOT NULL,
  `title` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- 表的结构 `comparelayercode`
--

CREATE TABLE `comparelayercode` (
  `barCode` varchar(36) NOT NULL,
  `title` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

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
-- 转储表的索引
--

--
-- 表的索引 `book`
--
ALTER TABLE `book`
  ADD PRIMARY KEY (`barCode`);

--
-- 表的索引 `bookread`
--
ALTER TABLE `bookread`
  ADD PRIMARY KEY (`barCode`);

--
-- 表的索引 `comparebarcode`
--
ALTER TABLE `comparebarcode`
  ADD PRIMARY KEY (`barCode`);

--
-- 表的索引 `comparelayercode`
--
ALTER TABLE `comparelayercode`
  ADD PRIMARY KEY (`barCode`);

--
-- 表的索引 `layer`
--
ALTER TABLE `layer`
  ADD PRIMARY KEY (`LayerCode`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
