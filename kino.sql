-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Cze 02, 2024 at 08:46 PM
-- Wersja serwera: 10.4.32-MariaDB
-- Wersja PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kino`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `movies`
--

CREATE TABLE `movies` (
  `Id` int(11) NOT NULL,
  `Title` varchar(50) NOT NULL,
  `Director` varchar(50) DEFAULT NULL,
  `Duration` float NOT NULL,
  `Description` varchar(600) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `movies`
--

INSERT INTO `movies` (`Id`, `Title`, `Director`, `Duration`, `Description`) VALUES
(1, 'Auta', 'John Lasseter', 1.57, 'Samochód wyścigowy Zygzak McQueen to prawdziwy wybraniec losu, żyje na najwyższych obrotach i jest zwycięzcą sezonu. Teraz jednak, zamiast na kolejny wyścig, trafia przypadkowo do małego, zapomnianego miasteczka, leżącego nieopodal słynnej amerykańskiej trasy numer 66. Poznaje niezwykłych mieszkańców osady, Sally, Złomka, Wójta Hudsona i innych, dzięki którym przekonuje się, że wygrane wyścigi, trofea i sława nie są w życiu najważniejsze.'),
(2, 'OPPENHEIMER', 'Christopher Nolan', 3, 'Oppenheimer w czasie II wojny światowej był dyrektorem programu rozwoju broni jądrowej \"Manhattan\".  Poza działalnością związaną z bronią atomową Oppenheimer miał ogromne osiągnięcia w innych dziedzinach fizyki, między innymi w badaniach czarnych dziur oraz promieniowania kosmicznego. Resztę życia po opracowaniu bomby atomowej poświęcił na działalność na rzecz ograniczania rozprzestrzeniania się broni jądrowej. Był oskarżany przez amerykański rząd i służby o powiązania z ruchem komunistycznym oraz działalność szpiegowską. W latach 50. został pozbawiony dostępu do tajnych dokumentów. ');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `users`
--

CREATE TABLE `users` (
  `Id` int(11) NOT NULL,
  `User_name` varchar(30) NOT NULL,
  `User_pass` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`Id`, `User_name`, `User_pass`) VALUES
(1, 'Admin', 'WSB'),
(2, 'Kamil_P', 'Ananasek'),
(3, 'Marysia_K', 'Kotek');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `movies`
--
ALTER TABLE `movies`
  ADD PRIMARY KEY (`Id`);

--
-- Indeksy dla tabeli `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `movies`
--
ALTER TABLE `movies`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=44;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
