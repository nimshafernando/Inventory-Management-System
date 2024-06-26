-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 28, 2023 at 09:46 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mystocksystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `logincredentials`
--

CREATE TABLE `logincredentials` (
  `Username` varchar(250) NOT NULL,
  `Password` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `logincredentials`
--

INSERT INTO `logincredentials` (`Username`, `Password`) VALUES
('admin', 'nimsha123'),
('nimsha', 'nimsha123'),
('Riveen', 'riveen123');

-- --------------------------------------------------------

--
-- Table structure for table `newstocktable`
--

CREATE TABLE `newstocktable` (
  `StockCode` varchar(20) NOT NULL,
  `StockName` varchar(50) NOT NULL,
  `StockQuantity` int(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `newstocktable`
--

INSERT INTO `newstocktable` (`StockCode`, `StockName`, `StockQuantity`) VALUES
('XYZ01', 'bottle', 9);

-- --------------------------------------------------------

--
-- Table structure for table `transactiontable`
--

CREATE TABLE `transactiontable` (
  `DateTime` varchar(16) NOT NULL,
  `TransactionType` varchar(255) NOT NULL,
  `StockCode` varchar(255) NOT NULL,
  `StockName` varchar(255) NOT NULL,
  `QuantityAdded` int(11) NOT NULL,
  `NewQuantityInStock` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transactiontable`
--

INSERT INTO `transactiontable` (`DateTime`, `TransactionType`, `StockCode`, `StockName`, `QuantityAdded`, `NewQuantityInStock`) VALUES
('29-09-2023 01:00', 'Item added', 'XYZ01', 'bottle', 5, 5),
('29-09-2023 01:10', 'Quantity added', 'XYZ01', 'bottle', 4, 9);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `newstocktable`
--
ALTER TABLE `newstocktable`
  ADD PRIMARY KEY (`StockCode`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
