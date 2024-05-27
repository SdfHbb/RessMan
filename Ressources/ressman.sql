-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 27. Mai 2024 um 14:38
-- Server-Version: 10.4.32-MariaDB
-- PHP-Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `ressman`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `artikel`
--

CREATE TABLE `artikel` (
  `ArtikelID` int(11) NOT NULL,
  `Artikelname` varchar(255) DEFAULT NULL,
  `Beschreibung` longtext DEFAULT NULL,
  `Einzelpreis` decimal(19,2) DEFAULT NULL,
  `Anzahl` int(11) DEFAULT NULL,
  `Farbe` varchar(255) DEFAULT NULL,
  `Material` varchar(255) DEFAULT NULL,
  `Groesse` varchar(255) DEFAULT NULL,
  `Gewicht` varchar(255) DEFAULT NULL,
  `Produktionsland` varchar(255) DEFAULT NULL,
  `KategorieNr` int(11) DEFAULT NULL,
  `Bild` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `artikel`
--

INSERT INTO `artikel` (`ArtikelID`, `Artikelname`, `Beschreibung`, `Einzelpreis`, `Anzahl`, `Farbe`, `Material`, `Groesse`, `Gewicht`, `Produktionsland`, `KategorieNr`, `Bild`) VALUES
(1, 'Mini Tote von Prada ', 'Diese Mini Tote von Prada wurde aus Nappaleder gefertigt und mit einer dreieckigen Steppung versehen, die dezent auf die charakteristischen Silhouetten der Marke anspielt. Das Modell ist mit goldfarbener Logo-Hardware verziert und verfügt über einen Reißverschluss sowie einen abnehmbaren Schulterriemen.', 2100.00, 5, 'SCHWARZ', 'LEDER', 'MEDIUM', '375 g', 'ITALIEN', 1, ''),
(2, 'GG Marmont Mini-Henkeltasche', 'Die inzwischen unverkennbare GG Marmont Mini-Tasche ist hier in neutralem hellgrauem Matelassé-Leder mit Chevron-Muster gehalten. Ein Klappverschluss mit Doppel G Schmuckteil rundet das sanft strukturierte Accessoire ab. Dank des verschiebbaren Kettenriemens lässt sich das Modell im Handumdrehen von einer Schultertasche in eine Henkeltasche verwandeln.', 1980.00, 5, 'SCHWARZ', 'LEDER', 'ONE SIZE', '400 g', 'ITALIEN ', 1, '');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `artikelkategorien`
--

CREATE TABLE `artikelkategorien` (
  `KategorieID` int(11) NOT NULL,
  `Kategoriename` varchar(255) DEFAULT NULL,
  `Beschreibung` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `artikelkategorien`
--

INSERT INTO `artikelkategorien` (`KategorieID`, `Kategoriename`, `Beschreibung`) VALUES
(1, 'Handtasche', 'Wird in der Hand getragen und die Form erinnert an ein Portemonnaie'),
(2, 'Schultertasche', 'Klein und wird mit einer Kette über der Schulter getragen'),
(3, 'Beuteltasche ', ' Als Hobo Bags bezeichnet man große Beuteltaschen mit meist knautschigem Material in einer Sichel-Form. Im Englischen bedeutet „hobo“ Wanderarbeiter oder auch Landstreicher.');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `bestellungen`
--

CREATE TABLE `bestellungen` (
  `BestellID` int(11) NOT NULL,
  `KundenNr` int(11) DEFAULT NULL,
  `Datum` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `bestellungen`
--

INSERT INTO `bestellungen` (`BestellID`, `KundenNr`, `Datum`) VALUES
(1, 1, '2024-02-07'),
(2, 3, '2024-03-12');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `bestellungendetails`
--

CREATE TABLE `bestellungendetails` (
  `BestellNr` int(11) NOT NULL,
  `ArtikelNr` int(11) NOT NULL,
  `Anzahl` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `bestellungendetails`
--

INSERT INTO `bestellungendetails` (`BestellNr`, `ArtikelNr`, `Anzahl`) VALUES
(1, 1, 1),
(1, 2, 1),
(2, 1, 2);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `kunden`
--

CREATE TABLE `kunden` (
  `KundenID` int(11) NOT NULL,
  `Vorname` varchar(255) DEFAULT NULL,
  `Nachname` varchar(255) DEFAULT NULL,
  `Strasse` varchar(255) DEFAULT NULL,
  `HausNr` varchar(255) DEFAULT NULL,
  `PLZ` varchar(255) DEFAULT NULL,
  `Ort` varchar(255) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `Tel` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `kunden`
--

INSERT INTO `kunden` (`KundenID`, `Vorname`, `Nachname`, `Strasse`, `HausNr`, `PLZ`, `Ort`, `Email`, `Tel`) VALUES
(1, 'Susan', 'Sorglos', 'Schlossstrasse', '7', '22023', 'Hamburg', 'susan@sorglos.com', '017633437266'),
(2, 'Peter', 'Heinrich', 'Paulstrasse', '12', '22045', 'Hamburg', 'peter@heinrich.com', '016235627134'),
(3, 'Luna', 'Fischer ', 