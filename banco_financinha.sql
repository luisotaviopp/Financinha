-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 19-Set-2020 às 00:57
-- Versão do servidor: 10.4.14-MariaDB
-- versão do PHP: 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `banco_financinha`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `carteira`
--

CREATE TABLE `carteira` (
  `id_carteira` int(11) NOT NULL,
  `id_pessoa` int(11) NOT NULL,
  `valor` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `carteira`
--

INSERT INTO `carteira` (`id_carteira`, `id_pessoa`, `valor`) VALUES
(1, 2, 400),
(2, 2, 250);

-- --------------------------------------------------------

--
-- Estrutura da tabela `causa`
--

CREATE TABLE `causa` (
  `id_causa` int(11) NOT NULL,
  `id_pessoa` int(11) NOT NULL,
  `criada_em` date NOT NULL,
  `nome` varchar(128) NOT NULL,
  `comentario` varchar(128) NOT NULL,
  `valor` double NOT NULL,
  `caminho_imagem` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `cofrinho`
--

CREATE TABLE `cofrinho` (
  `id_cofrinho` int(11) NOT NULL,
  `id_pessoa` int(11) NOT NULL,
  `valor` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `grau_parentesco`
--

CREATE TABLE `grau_parentesco` (
  `id_grau_parentesco` int(11) NOT NULL,
  `grau` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `grau_parentesco`
--

INSERT INTO `grau_parentesco` (`id_grau_parentesco`, `grau`) VALUES
(1, 'pai'),
(2, 'filho');

-- --------------------------------------------------------

--
-- Estrutura da tabela `parentesco`
--

CREATE TABLE `parentesco` (
  `id_parentesco` int(11) NOT NULL,
  `grau` int(11) NOT NULL,
  `pessoa_1` int(11) NOT NULL,
  `pessoa_2` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `parentesco`
--

INSERT INTO `parentesco` (`id_parentesco`, `grau`, `pessoa_1`, `pessoa_2`) VALUES
(1, 1, 1, 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `pessoa`
--

CREATE TABLE `pessoa` (
  `id_pessoa` int(11) NOT NULL,
  `nome` varchar(128) NOT NULL,
  `lvl` int(11) NOT NULL,
  `permissoes` int(11) NOT NULL,
  `registrado_em` datetime NOT NULL DEFAULT current_timestamp(),
  `usuario` varchar(64) NOT NULL,
  `senha` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `pessoa`
--

INSERT INTO `pessoa` (`id_pessoa`, `nome`, `lvl`, `permissoes`, `registrado_em`, `usuario`, `senha`) VALUES
(1, 'PAI', 12, 0, '0000-00-00 00:00:00', 'pai', 'pai'),
(2, 'Israel', 100, 1, '0000-00-00 00:00:00', '', ''),
(3, 'Luiz', 124, 1, '2020-08-31 00:02:53', '', ''),
(4, 'testando', 1, 1, '2020-08-31 12:36:35', 'testando', '1234'),
(5, 'ttttttttt', 1, 1, '2020-09-02 21:54:39', 'testando123', '1234'),
(6, 'ttttttttt', 1, 1, '2020-09-02 21:54:39', 'testando123', '1234'),
(7, 'aaaaaaaaa', 1, 1, '2020-09-02 21:55:30', 'testando123', '1234'),
(8, 'aaaaaaaaa', 1, 1, '2020-09-02 21:55:30', 'testando123', '1234'),
(9, 'aaaaaaaaa', 1, 1, '2020-09-02 21:56:27', 'testando123', '1234');

-- --------------------------------------------------------

--
-- Estrutura da tabela `presente`
--

CREATE TABLE `presente` (
  `id_presente` int(11) NOT NULL,
  `id_pessoa` int(11) NOT NULL,
  `criado_em` date NOT NULL DEFAULT current_timestamp(),
  `nome` varchar(64) NOT NULL,
  `comentario` varchar(128) NOT NULL,
  `valor` double NOT NULL,
  `valor_semana` double NOT NULL,
  `data_compra` date NOT NULL,
  `caminho_imagem` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `regras`
--

CREATE TABLE `regras` (
  `id_regra` int(11) NOT NULL,
  `criada_por` int(11) NOT NULL,
  `criado_em` date NOT NULL DEFAULT current_timestamp(),
  `nome` varchar(128) NOT NULL,
  `descricao` varchar(128) NOT NULL,
  `valor` double NOT NULL,
  `penalidade` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `regras`
--

INSERT INTO `regras` (`id_regra`, `criada_por`, `criado_em`, `nome`, `descricao`, `valor`, `penalidade`) VALUES
(1, 1, '0000-00-00', 'regra é regra', 'testando as regras', 1234, 50);

-- --------------------------------------------------------

--
-- Estrutura da tabela `token`
--

CREATE TABLE `token` (
  `id_token` int(11) NOT NULL,
  `id_pessoa` int(11) NOT NULL,
  `criado_em` date NOT NULL DEFAULT current_timestamp(),
  `token` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `token`
--

INSERT INTO `token` (`id_token`, `id_pessoa`, `criado_em`, `token`) VALUES
(1, 1, '0000-00-00', 'kjsndf0ehrjgnfdhjubdingdfr');

-- --------------------------------------------------------

--
-- Estrutura da tabela `transacao`
--

CREATE TABLE `transacao` (
  `id_transacao` int(11) NOT NULL,
  `id_carteira` int(11) NOT NULL,
  `tipo` int(11) NOT NULL,
  `criada_em` date NOT NULL DEFAULT current_timestamp(),
  `valor` double NOT NULL,
  `motivo` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `transferencia`
--

CREATE TABLE `transferencia` (
  `id_transferencia` int(11) NOT NULL,
  `id_carteira` int(11) NOT NULL,
  `id_cofrinho` int(11) NOT NULL,
  `tipo` int(11) NOT NULL,
  `valor` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `carteira`
--
ALTER TABLE `carteira`
  ADD PRIMARY KEY (`id_carteira`);

--
-- Índices para tabela `causa`
--
ALTER TABLE `causa`
  ADD PRIMARY KEY (`id_causa`);

--
-- Índices para tabela `cofrinho`
--
ALTER TABLE `cofrinho`
  ADD PRIMARY KEY (`id_cofrinho`);

--
-- Índices para tabela `grau_parentesco`
--
ALTER TABLE `grau_parentesco`
  ADD PRIMARY KEY (`id_grau_parentesco`);

--
-- Índices para tabela `parentesco`
--
ALTER TABLE `parentesco`
  ADD PRIMARY KEY (`id_parentesco`);

--
-- Índices para tabela `pessoa`
--
ALTER TABLE `pessoa`
  ADD PRIMARY KEY (`id_pessoa`);

--
-- Índices para tabela `presente`
--
ALTER TABLE `presente`
  ADD PRIMARY KEY (`id_presente`);

--
-- Índices para tabela `regras`
--
ALTER TABLE `regras`
  ADD PRIMARY KEY (`id_regra`);

--
-- Índices para tabela `token`
--
ALTER TABLE `token`
  ADD PRIMARY KEY (`id_token`);

--
-- Índices para tabela `transacao`
--
ALTER TABLE `transacao`
  ADD PRIMARY KEY (`id_transacao`);

--
-- Índices para tabela `transferencia`
--
ALTER TABLE `transferencia`
  ADD PRIMARY KEY (`id_transferencia`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `carteira`
--
ALTER TABLE `carteira`
  MODIFY `id_carteira` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `causa`
--
ALTER TABLE `causa`
  MODIFY `id_causa` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `cofrinho`
--
ALTER TABLE `cofrinho`
  MODIFY `id_cofrinho` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `grau_parentesco`
--
ALTER TABLE `grau_parentesco`
  MODIFY `id_grau_parentesco` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `parentesco`
--
ALTER TABLE `parentesco`
  MODIFY `id_parentesco` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `pessoa`
--
ALTER TABLE `pessoa`
  MODIFY `id_pessoa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de tabela `presente`
--
ALTER TABLE `presente`
  MODIFY `id_presente` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `regras`
--
ALTER TABLE `regras`
  MODIFY `id_regra` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `token`
--
ALTER TABLE `token`
  MODIFY `id_token` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `transacao`
--
ALTER TABLE `transacao`
  MODIFY `id_transacao` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `transferencia`
--
ALTER TABLE `transferencia`
  MODIFY `id_transferencia` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
