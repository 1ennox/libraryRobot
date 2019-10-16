-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- 主机： 127.0.0.1
-- 生成日期： 2019-10-16 04:47:16
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
  `title` varchar(128) NOT NULL,
  `callNo` varchar(128) NOT NULL
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

--
-- 转存表中的数据 `comparebarcode`
--

INSERT INTO `comparebarcode` (`barCode`, `title`) VALUES
('A000032305', '思想家莎士比亚 :a very short introduction'),
('A000032640', '权力、政治与WTO :a very short introduction'),
('A000032651', '文艺复兴简史 :a very short introduction'),
('A000032745', '古代战争与西方战争文化 :a very short introduction'),
('a000052227', '政治哲学与幸福根基 :a very short introduction'),
('A000094359', '英美畅销小说简史 :a very short intriduction'),
('A000096617', '欧盟概览 :a very short introduction'),
('A000141773', '美国总统制'),
('A000143692', '全球化面面观 :a very short introduction'),
('A000143696', '后殖民主义与世界格局 :a very short introduction'),
('A000143698', '政治的历史与边界'),
('A000143699', '选择理论'),
('A000152366', '资本主义'),
('A000152368', '文学理论入门'),
('A000152371', '古代战争简史'),
('A000152372', '解码畅销小说'),
('A000152380', '女权主义简史'),
('A000152382', '缤纷的语言学 :a very short introduction'),
('A000152383', '社会学的意识'),
('A000152384', '卡夫卡是谁'),
('A000152385', '政治哲学与幸福根基 :a very short introduction'),
('A000152390', '文艺复兴简史'),
('A000152391', '世界贸易组织概览'),
('A000152393', '埃及神话'),
('A000152397', '神话密钥'),
('A000152400', '欧盟概览 :a very short introduction'),
('A000152411', '法哲学 :价值与事实'),
('a000187541', '性存在 :牛津通识读本 :a very short introduction'),
('a000188125', '国际移民 :a very short introduction'),
('A000198162', '国际移民 :a very short introduction'),
('a000212112', '法律 :a very short introduction'),
('A000221746', '科幻作品 :a very short introduction'),
('A000221748', '托克维尔 :A very short introduction'),
('a000237563', '美国国会 :a very short introduction'),
('A000241085', '大萧条与罗斯福新政 :a very short introduction'),
('A000241102', '领导力 :a very short introduction'),
('a000254076', '美国最高法院');

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
(19, 2, 2, 18, 4, 2, '01020201800402'),
(19, 2, 2, 26, 1, 2, '01020202600102');

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
