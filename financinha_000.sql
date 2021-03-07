-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 07, 2021 at 04:53 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `financinha_000`
--

-- --------------------------------------------------------

--
-- Table structure for table `cause`
--

CREATE TABLE `cause` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `created_at` datetime NOT NULL DEFAULT current_timestamp(),
  `name` varchar(65) NOT NULL,
  `description` varchar(200) NOT NULL,
  `value` decimal(10,0) NOT NULL,
  `image` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cause`
--

INSERT INTO `cause` (`id`, `user_id`, `created_at`, `name`, `description`, `value`, `image`) VALUES
(4, 6, '2021-02-16 15:37:37', 'Ong Cão de Rua', 'Doar ração', '40', '');

-- --------------------------------------------------------

--
-- Table structure for table `event`
--

CREATE TABLE `event` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `type` varchar(15) NOT NULL,
  `created_at` datetime NOT NULL DEFAULT current_timestamp(),
  `value` double NOT NULL,
  `reason` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `event`
--

INSERT INTO `event` (`id`, `user_id`, `type`, `created_at`, `value`, `reason`) VALUES
(20, 6, 'w_deposit', '2021-02-16 15:22:59', 20, 'Semanada'),
(21, 6, 'w2s', '2021-02-27 23:04:40', 123, '123'),
(22, 6, 's2w', '2021-02-27 23:04:45', 123, '123'),
(23, 6, 'w_deposit', '2021-02-28 01:48:24', 120, '120'),
(24, 6, 'w_takeout', '2021-02-28 02:11:29', 100, 'teste ganho'),
(25, 6, 'w_takeout', '2021-02-28 02:11:40', 200, 'teste gasto'),
(26, 6, 'w_takeout', '2021-02-28 02:47:07', 1, 'gagagagaga'),
(27, 6, 'w_takeout', '2021-02-28 02:47:16', 2, 'gagagaga'),
(28, 6, 'w_takeout', '2021-03-01 04:48:26', 9, 'daniel teste haha');

-- --------------------------------------------------------

--
-- Table structure for table `notification`
--

CREATE TABLE `notification` (
  `id` int(11) NOT NULL,
  `from_user` int(11) NOT NULL,
  `to_user` int(11) NOT NULL,
  `relation_type` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `objective`
--

CREATE TABLE `objective` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `created_at` datetime NOT NULL DEFAULT current_timestamp(),
  `gift_name` varchar(100) NOT NULL,
  `cause_name` varchar(100) NOT NULL,
  `gift_value` double NOT NULL,
  `cause_value` double NOT NULL,
  `weekly_value` double NOT NULL,
  `buying_date` date NOT NULL,
  `image` varchar(65) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `objective`
--

INSERT INTO `objective` (`id`, `user_id`, `created_at`, `gift_name`, `cause_name`, `gift_value`, `cause_value`, `weekly_value`, `buying_date`, `image`) VALUES
(6, 6, '0000-00-00 00:00:00', 'teste', 'teste', 500, 50, 0, '0000-00-00', '');

-- --------------------------------------------------------

--
-- Table structure for table `question`
--

CREATE TABLE `question` (
  `id` int(11) NOT NULL,
  `level` int(11) NOT NULL,
  `question` varchar(300) COLLATE utf8mb4_unicode_ci NOT NULL,
  `option_1` varchar(300) COLLATE utf8mb4_unicode_ci NOT NULL,
  `option_2` varchar(300) COLLATE utf8mb4_unicode_ci NOT NULL,
  `option_3` varchar(300) COLLATE utf8mb4_unicode_ci NOT NULL,
  `option_4` varchar(300) COLLATE utf8mb4_unicode_ci NOT NULL,
  `option_5` varchar(300) COLLATE utf8mb4_unicode_ci NOT NULL,
  `right_answer` int(11) NOT NULL,
  `created_at` datetime NOT NULL DEFAULT current_timestamp(),
  `is_active` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `question`
--

INSERT INTO `question` (`id`, `level`, `question`, `option_1`, `option_2`, `option_3`, `option_4`, `option_5`, `right_answer`, `created_at`, `is_active`) VALUES
(1, 1, 'aaaaaa', 'Teste', 'Teste', 'teste', 'teste', 'teste', 5, '2021-03-06 20:05:28', 1),
(2, 1, '2', '2', '2', '2', '2', '2', 2, '2021-03-06 20:07:26', 1),
(3, 1, '1', '1', '1', '1', '1', '1', 1, '2021-03-06 21:48:16', 1),
(4, 1, 'aaa', 'aaa', 'aaa', 'aaa', 'aaa', 'aaa', 3, '2021-03-06 21:48:43', 1),
(5, 1, 'AAA', 'CCC', 'CCC', 'CCC', 'CCC', 'CCC', 4, '2021-03-06 21:49:09', 1);

-- --------------------------------------------------------

--
-- Table structure for table `quiz_open_answer`
--

CREATE TABLE `quiz_open_answer` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `created_at` datetime NOT NULL DEFAULT current_timestamp(),
  `level` int(11) NOT NULL,
  `answer` varchar(300) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `quiz_open_answer`
--

INSERT INTO `quiz_open_answer` (`id`, `user_id`, `created_at`, `level`, `answer`) VALUES
(12, 6, '2021-03-06 22:15:27', 1, ''),
(13, 6, '2021-03-06 22:22:41', 1, '');

-- --------------------------------------------------------

--
-- Table structure for table `relation`
--

CREATE TABLE `relation` (
  `id` int(11) NOT NULL,
  `resp` int(11) NOT NULL,
  `apr` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `relation`
--

INSERT INTO `relation` (`id`, `resp`, `apr`) VALUES
(5, 10, 6),
(6, 6, 14),
(7, 6, 15);

-- --------------------------------------------------------

--
-- Table structure for table `relation_type`
--

CREATE TABLE `relation_type` (
  `id` int(11) NOT NULL,
  `relation` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `relation_type`
--

INSERT INTO `relation_type` (`id`, `relation`) VALUES
(1, 'Filho'),
(2, 'Filha'),
(3, 'Pai'),
(4, 'Mãe'),
(5, 'Avó'),
(6, 'Avô'),
(7, 'Tio'),
(8, 'Tia'),
(9, 'Neto'),
(10, 'Neta'),
(11, 'Sobrinho'),
(12, 'Sobrinha');

-- --------------------------------------------------------

--
-- Table structure for table `rule`
--

CREATE TABLE `rule` (
  `id` int(11) NOT NULL,
  `created_by` int(11) NOT NULL,
  `name` varchar(60) NOT NULL,
  `description` varchar(200) NOT NULL,
  `value` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `rule`
--

INSERT INTO `rule` (`id`, `created_by`, `name`, `description`, `value`) VALUES
(1, 6, 'Cortar Grama', 'Cortar a grama todos os sábados de manhã', 20),
(2, 6, 'Teste PHP', 'Testando', 50),
(3, 11, 'te-te-te-te-teste', 'te-te-te-te-teste', 20),
(4, 6, 'Teste 16/02', 'Teste 16/02', 20),
(5, 6, 'Teste', 'Teste Unity', 50),
(6, 6, 'Tentou burlar o jogo', 'Mentiu para o pai', 20),
(7, 6, 'lalala', 'descrição', 111),
(8, 6, 'teste', 'descrição', 15);

-- --------------------------------------------------------

--
-- Table structure for table `saving`
--

CREATE TABLE `saving` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `amount` double NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `saving`
--

INSERT INTO `saving` (`id`, `user_id`, `amount`) VALUES
(1, 4, 0),
(2, 5, 0),
(3, 6, 5299),
(4, 7, 0),
(5, 8, 0),
(6, 9, 100),
(7, 10, 0),
(8, 10, 0),
(9, 11, -50),
(10, 12, 0),
(11, 12, 0),
(12, 13, 0),
(13, 13, 0),
(14, 13, 0);

-- --------------------------------------------------------

--
-- Table structure for table `token`
--

CREATE TABLE `token` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `created_at` datetime NOT NULL DEFAULT current_timestamp(),
  `token` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `token`
--

INSERT INTO `token` (`id`, `user_id`, `created_at`, `token`) VALUES
(2, 6, '2021-03-07 00:39:18', '@Jl%J7P9Orwq9Jp01RHFgMeID33ytv&zojSAyqA3rjx0w4cVujiQQuTV9Dl!C9k!MB6B8g$MSW#m7UroWNQF5%8F!29FATTjSFZS!g1ZVnPgA8YPSbZq2BIr!kZRFca'),
(3, 7, '2021-02-13 09:50:35', '7sb56G0LSgg6T@F5c8GXT7AMB0%bUbpd!bNW#7i6eYPxSvWOmHX9zAsQYnPeNgxTwc#46u71hb3NYc22hSbdl0e%3h@l89Z%lMRz8sy8TBWdk0f5$KeFU!yIVCzYYsR'),
(4, 8, '2021-02-13 10:05:04', '8zLjfJ6Q75%EERnr2o7bjY4FX0QUocHPTjQ6ybT&EQRU#UVq$r8YL2&aSK9!2DUb2XAYuwINEiaUR4r3iOxpyLsL6ijc@wAQniycZ2168%GkUTaF5zg6rojiC1Q9bye'),
(5, 9, '2021-02-15 21:17:20', '5%Aq!PN!1HtKxW@K7KaD3MqyIKXn%M5SCcik9du0YzallwzlgcPbFfjEH#N5f0M@GpDGQtA#H7wcR2#kZj7hPv&DvWcz6ZBBBRPJNlSoMrZgdDK@W&2wb8WsUl9&6c7'),
(6, 10, '2021-02-13 19:02:14', 'Eeh8j3AOKqoVR$6GUcU5QO4J2BwoM4ABneU5Rm9d!NkNi4QWp#Ik9MM1r481L0zfy5P2cPpB&v3h@89dn87QN5x&VxYxa8tAoa2atbWzJ8yK!tpInla9a9clAGLMIPY'),
(7, 10, '2021-02-15 23:20:46', 'init'),
(8, 11, '2021-02-15 23:21:35', 'pDShTeo6athmgG6af$YMtEOx%&jL46zcZDiaosAnYRf6NtWsi74xvtYN1TLOTbPSm3Rl8nRUYRgjsggrGeSTq7It%VU4cEeh!NbUEbXbQXd!hFoxJ1%yps30HhQ@WEB'),
(9, 12, '2021-03-06 23:11:01', 'init'),
(10, 12, '2021-03-06 23:50:52', 'init'),
(11, 13, '2021-03-06 23:52:10', 'init'),
(12, 13, '2021-03-06 23:57:26', 'init'),
(13, 13, '2021-03-06 23:57:47', 'init');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `name` varchar(65) NOT NULL,
  `email` varchar(100) NOT NULL,
  `level` int(11) NOT NULL DEFAULT 0,
  `permission` varchar(5) NOT NULL DEFAULT 'resp',
  `id_responsible` int(11) NOT NULL DEFAULT 0,
  `created_at` datetime NOT NULL DEFAULT current_timestamp(),
  `username` varchar(30) NOT NULL,
  `password` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `name`, `email`, `level`, `permission`, `id_responsible`, `created_at`, `username`, `password`) VALUES
(6, 'Luis', 'luisaslan@gmail.com', 10, 'resp', 0, '2021-01-30 22:32:27', 'luis', '8cb2237d0679ca88db6464eac60da96345513964'),
(9, 'Marcio', '', 3, '0', 0, '2021-02-13 10:18:52', 'marcio', '8cb2237d0679ca88db6464eac60da96345513964'),
(10, 'teste', '', 0, 'apr', 0, '2021-02-13 16:18:52', 'teste', '2e6f9b0d5885b6010f9167787445617f553a735f'),
(11, 'Luis', '', 0, '0', 0, '2021-02-15 23:21:03', 'luis2', '8cb2237d0679ca88db6464eac60da96345513964'),
(12, 'teste3', '', 0, 'resp', 0, '2021-03-06 23:11:01', 'teste3', '5458cb00631fc6748f9d3a52cf6c22ae9b232e91'),
(13, 'testeemail', 'testeemail@email.com', 0, 'resp', 0, '2021-03-06 23:52:10', 'testeemail', '7cf68461b03bb19f1d98a8e7df901d5cd0e1d29c'),
(14, 'Amanda', '', 0, 'apr', 6, '2021-03-07 00:10:45', 'a', '86f7e437faa5a7fce15d1ddcb9eaeaea377667b8'),
(15, 'Daniel', '', 0, 'apr', 6, '2021-03-07 00:12:26', 'lalala', 'df2efa060e335f97628ca39c9fef5469ab3cb837');

-- --------------------------------------------------------

--
-- Table structure for table `user_answer`
--

CREATE TABLE `user_answer` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `question_id` int(11) NOT NULL,
  `selected_option` int(11) NOT NULL,
  `created_at` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `user_answer`
--

INSERT INTO `user_answer` (`id`, `user_id`, `question_id`, `selected_option`, `created_at`) VALUES
(5, 1, 3, 4, '2021-03-06 22:15:27'),
(6, 1, 1, 1, '2021-03-06 22:15:27'),
(7, 1, 2, 2, '2021-03-06 22:15:27'),
(8, 1, 5, 3, '2021-03-06 22:15:27'),
(9, 1, 4, 2, '2021-03-06 22:15:27'),
(10, 1, 2, 4, '2021-03-06 22:22:42'),
(11, 1, 1, 1, '2021-03-06 22:22:42'),
(12, 1, 4, 2, '2021-03-06 22:22:42'),
(13, 1, 3, 5, '2021-03-06 22:22:42'),
(14, 1, 5, 1, '2021-03-06 22:22:42');

-- --------------------------------------------------------

--
-- Table structure for table `wallet`
--

CREATE TABLE `wallet` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `amount` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `wallet`
--

INSERT INTO `wallet` (`id`, `user_id`, `amount`) VALUES
(5, 6, 9765),
(8, 9, 4255),
(9, 10, 0),
(10, 10, 0),
(11, 11, 250),
(12, 12, 0),
(13, 12, 0),
(14, 13, 0),
(15, 13, 0),
(16, 13, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cause`
--
ALTER TABLE `cause`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `event`
--
ALTER TABLE `event`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `notification`
--
ALTER TABLE `notification`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `objective`
--
ALTER TABLE `objective`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `question`
--
ALTER TABLE `question`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `quiz_open_answer`
--
ALTER TABLE `quiz_open_answer`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `relation`
--
ALTER TABLE `relation`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `relation_type`
--
ALTER TABLE `relation_type`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `rule`
--
ALTER TABLE `rule`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `saving`
--
ALTER TABLE `saving`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `token`
--
ALTER TABLE `token`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user_answer`
--
ALTER TABLE `user_answer`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `wallet`
--
ALTER TABLE `wallet`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cause`
--
ALTER TABLE `cause`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `event`
--
ALTER TABLE `event`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT for table `notification`
--
ALTER TABLE `notification`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `objective`
--
ALTER TABLE `objective`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `question`
--
ALTER TABLE `question`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `quiz_open_answer`
--
ALTER TABLE `quiz_open_answer`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `relation`
--
ALTER TABLE `relation`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `relation_type`
--
ALTER TABLE `relation_type`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `rule`
--
ALTER TABLE `rule`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `saving`
--
ALTER TABLE `saving`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `token`
--
ALTER TABLE `token`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `user_answer`
--
ALTER TABLE `user_answer`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `wallet`
--
ALTER TABLE `wallet`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
