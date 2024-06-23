-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Cze 23, 2024 at 08:35 AM
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
-- Struktura tabeli dla tabeli `filmy`
--

CREATE TABLE `filmy` (
  `Id` int(11) NOT NULL,
  `Tytul` varchar(50) DEFAULT NULL,
  `Rezyser` varchar(50) DEFAULT NULL,
  `Ocena` double DEFAULT NULL,
  `Data` date NOT NULL,
  `Dlugosc` double DEFAULT NULL,
  `Opis` varchar(400) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `filmy`
--

INSERT INTO `filmy` (`Id`, `Tytul`, `Rezyser`, `Ocena`, `Data`, `Dlugosc`, `Opis`) VALUES
(1, 'Dywizjon 303', 'Denis Delić', 4, '2024-06-22', 2, 'Film „Dywizjon 303” to prawdziwa historia polskich asów przestworzy, inspirowana bestsellerem Arkadego Fiedlera o tym samym tytule. Polscy lotnicy, początkowo niedoceniani i wyśmiewani, stają się legendą. W ramach Królewskich Sił Powietrznych Wielkiej Brytanii (RAF-u) tworzą elitarną jednostkę - Dywizjon 303, który nie ma sobie równych.'),
(2, 'Kamienie na szaniec', 'Robert Gliński', 3.8, '2024-06-23', 1.5, 'Trzech warszawskich maturzystów, Alek, Zośka i Rudy, planuje rozpocząć dorosłe życie. Ich plany burzy wybuch II wojny światowej.'),
(3, 'Auta', 'John Lasseter', 5, '2024-06-23', 2, 'Samochód wyścigowy Zygzak McQueen to prawdziwy wybraniec losu, żyje na najwyższych obrotach i jest zwycięzcą sezonu. Teraz jednak, zamiast na kolejny wyścig, trafia przypadkowo do małego, zapomnianego miasteczka, leżącego nieopodal słynnej amerykańskiej trasy numer 66.'),
(4, 'Chłopiec w pasiastej piżamie', 'Mark Herman', 4, '2024-06-23', 1.3, 'Lata 40. XX wieku, czas wojny. Bruno ma 8 lat; mieszka w Berlinie razem z siostrą i rodzicami. Pewnego dnia rodzina przenosi się na wieś, aby towarzyszyć ojcu – niemieckiemu oficerowi – w jego nowej pracy.'),
(5, 'Człowiek z blizną', 'Brian De Palma', 4.1, '2024-06-24', 2.5, 'Kubański emigrant Tony Montana (Al Pacino) opuszcza swoją ojczyznę i przybywa do Miami. Razem ze swoim przyjacielem, Manolem Rayem (Steven Bauer), zaczyna pracę dla narkotykowej mafii. Brutalny mężczyzna staje się bardzo ważną postacią w przestępczym świecie, aż w końcu staje na czele gangu.');

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
(2, 'Alicja', 'czary'),
(3, 'Maciek', 'klan');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `filmy`
--
ALTER TABLE `filmy`
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
-- AUTO_INCREMENT for table `filmy`
--
ALTER TABLE `filmy`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
