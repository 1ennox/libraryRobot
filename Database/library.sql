-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- 主机： 127.0.0.1
-- 生成日期： 2019-10-18 14:40:20
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

--
-- 转存表中的数据 `book`
--

INSERT INTO `book` (`barCode`, `title`, `callNo`, `isbn`) VALUES
('A000050461', ' Suetonius /', 'LOEB/S84', '0674995651'),
('A000050502', ' Suetonius /', 'LOEB/S84', '0674995708'),
('A000050733', ' The elder : declamations /', 'LOEB/S46O', '9780674995116'),
('A000050734', ' The elder : declamations /', 'LOEB/S46O', '0674995104'),
('A000050831', ' Punica /', 'LOEB/S55', '0674993063'),
('A000050832', ' Punica /', 'LOEB/S55', '0674993055'),
('A000050860', ' Sidonius /', 'LOEB/S53', '0674994620'),
('A000050861', ' Sidonius /', 'LOEB/S53', '0674993276'),
('A000050936', ' Statius /', 'LOEB/S73', '0674012097'),
('A000050937', ' Statius /', 'LOEB/S73', '0674012097'),
('A000050938', ' Statius /', 'LOEB/S73', '0674012089');

-- --------------------------------------------------------

--
-- 表的结构 `bookread`
--

CREATE TABLE `bookread` (
  `barCode` varchar(128) NOT NULL,
  `layerCode` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 转存表中的数据 `bookread`
--

INSERT INTO `bookread` (`barCode`, `layerCode`) VALUES
('A000050733', '01020202100701'),
('A000050734', '01020202100701'),
('A000050831', '01020202100701'),
('A000050832', '01020202100701'),
('A000050842', '01020202100601'),
('A000050860', '01020202100701'),
('A000050861', '01020202100701'),
('A000050936', '01020202100701'),
('A000050937', '01020202100701'),
('A000050938', '01020202100701');

-- --------------------------------------------------------

--
-- 表的结构 `comparebarcode`
--

CREATE TABLE `comparebarcode` (
  `barCode` varchar(128) NOT NULL,
  `title` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 转存表中的数据 `comparebarcode`
--

INSERT INTO `comparebarcode` (`barCode`, `title`) VALUES
('A000050461', ' Suetonius /'),
('A000050502', ' Suetonius /');

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
(19, 2, 2, 21, 7, 1, '01020202100701');

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
-- 表的索引 `layer`
--
ALTER TABLE `layer`
  ADD PRIMARY KEY (`LayerCode`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
