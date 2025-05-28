-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 14 mai 2025 à 10:21
-- Version du serveur : 9.1.0
-- Version de PHP : 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gestionpersonnel`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(2, '2024-05-30 00:00:00', '2024-06-08 00:00:00', 3),
(4, '2023-08-28 00:00:00', '2023-08-30 00:00:00', 1),
(7, '2023-12-01 00:00:00', '2023-12-16 00:00:00', 2),
(5, '2023-12-10 00:00:00', '2023-12-17 00:00:00', 2),
(4, '2023-08-01 00:00:00', '2023-08-05 00:00:00', 3),
(6, '2024-10-29 00:00:00', '2024-11-21 00:00:00', 1),
(3, '2024-10-11 00:00:00', '2024-10-12 00:00:00', 3),
(2, '2024-07-29 00:00:00', '2024-08-02 00:00:00', 3),
(8, '2024-05-27 00:00:00', '2024-06-04 00:00:00', 2),
(3, '2024-04-20 00:00:00', '2024-05-07 00:00:00', 3),
(9, '2023-09-02 00:00:00', '2023-09-05 00:00:00', 3),
(10, '2023-07-02 00:00:00', '2023-07-06 00:00:00', 2),
(7, '2024-10-04 00:00:00', '2024-10-09 00:00:00', 1),
(2, '2024-09-20 00:00:00', '2024-10-01 00:00:00', 2),
(8, '2024-07-23 00:00:00', '2024-07-24 00:00:00', 2),
(8, '2023-06-23 00:00:00', '2023-06-24 00:00:00', 3),
(3, '2023-08-12 00:00:00', '2023-08-13 00:00:00', 2),
(1, '2023-09-04 00:00:00', '2023-09-05 00:00:00', 3),
(3, '2024-06-20 00:00:00', '2024-06-22 00:00:00', 2),
(3, '2023-07-14 00:00:00', '2023-07-17 00:00:00', 3),
(5, '2024-08-31 00:00:00', '2024-09-02 00:00:00', 1),
(2, '2023-12-06 00:00:00', '2023-12-27 00:00:00', 4),
(5, '2024-12-30 00:00:00', '2024-12-31 00:00:00', 3),
(4, '2024-03-22 00:00:00', '2024-04-06 00:00:00', 3),
(7, '2023-05-29 00:00:00', '2023-08-18 00:00:00', 2),
(7, '2024-07-11 00:00:00', '2024-09-02 00:00:00', 2),
(2, '2023-06-04 00:00:00', '2023-06-10 00:00:00', 2),
(5, '2024-08-21 00:00:00', '2024-09-08 00:00:00', 1),
(6, '2024-06-02 00:00:00', '2024-06-05 00:00:00', 2),
(10, '2024-12-07 00:00:00', '2024-12-10 00:00:00', 1),
(10, '2023-07-13 00:00:00', '2023-07-15 00:00:00', 1),
(5, '2024-04-26 00:00:00', '2024-04-28 00:00:00', 3),
(5, '2024-03-25 00:00:00', '2024-03-27 00:00:00', 2),
(5, '2024-10-17 00:00:00', '2024-11-17 00:00:00', 4),
(8, '2024-12-10 00:00:00', '2024-12-11 00:00:00', 3),
(8, '2024-12-12 00:00:00', '2024-12-17 00:00:00', 4),
(7, '2023-11-24 00:00:00', '2023-11-30 00:00:00', 4),
(2, '2023-07-09 00:00:00', '2023-07-11 00:00:00', 3),
(6, '2024-08-22 00:00:00', '2024-08-23 00:00:00', 3),
(9, '2024-02-07 00:00:00', '2024-02-26 00:00:00', 1),
(6, '2023-10-22 00:00:00', '2023-10-28 00:00:00', 2),
(4, '2023-08-14 00:00:00', '2023-08-16 00:00:00', 3),
(5, '2024-08-14 00:00:00', '2024-08-25 00:00:00', 1),
(8, '2023-12-09 00:00:00', '2023-12-10 00:00:00', 3),
(9, '2024-04-03 00:00:00', '2024-04-13 00:00:00', 2),
(2, '2024-07-23 00:00:00', '2024-07-25 00:00:00', 3),
(9, '2023-06-30 00:00:00', '2023-07-03 00:00:00', 3),
(8, '2024-12-20 00:00:00', '2024-12-27 00:00:00', 1),
(9, '2023-08-10 00:00:00', '2023-08-14 00:00:00', 2),
(6, '2023-06-03 00:00:00', '2023-09-30 00:00:00', 4),
(6, '2025-05-11 15:02:55', '2025-05-12 15:02:55', 2),
(6, '2025-06-18 00:00:00', '2025-06-29 18:09:54', 1);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `mail` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Mclean', 'Helen', '04 47 22 27 94', 'eros.non@google.edu', 1),
(2, 'Mcintyre', 'Emery', '03 83 01 49 95', 'mauris@protonmail.edu', 2),
(3, 'Lowery', 'Tara', '05 79 73 68 45', 'augue.id@icloud.couk', 2),
(4, 'Richards', 'Arden', '08 76 08 88 47', 'proin.non@aol.net', 3),
(5, 'Dillon', 'Elton', '04 05 91 87 92', 'molestie.orci@aol.org', 1),
(6, 'Farley', 'Hanna', '08 15 44 83 11', 'viverra@protonmail.ca', 1),
(7, 'Chaney', 'Mia', '08 35 96 54 46', 'ipsum@aol.couk', 3),
(8, 'Crosby', 'Aretha', '07 31 91 67 79', 'metus.aliquam@hotmail.edu', 3),
(9, 'Phillips', 'Alma', '08 75 12 56 61', 'fringilla.purus.mauris@hotmail.com', 1),
(10, 'Stephenson', 'Kiayada', '07 96 43 15 20', 'tempor.arcu.vestibulum@yahoo.ca', 1);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `pwd` varchar(64) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('gestionnairePersonnel', 'e97532ba40916c676ceb9df2516f890c3a5a05d0bf7c3f83c2e86302a04ad7c2');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;


-- Création de l'utilisateur MySQL
CREATE USER 'gestionnairePersonnel'@'localhost' IDENTIFIED BY 'motdepasse';

-- Attribution des droits
GRANT ALL PRIVILEGES ON gestionpersonnel.* TO 'gestionnairePersonnel'@'localhost';

-- Application des changements
FLUSH PRIVILEGES;
