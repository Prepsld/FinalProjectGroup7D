-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.11.2-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for oopfinal
DROP DATABASE IF EXISTS `oopfinal`;
CREATE DATABASE IF NOT EXISTS `oopfinal` /*!40100 DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci */;
USE `oopfinal`;

-- Dumping structure for table oopfinal.history
DROP TABLE IF EXISTS `history`;
CREATE TABLE IF NOT EXISTS `history` (
  `utility_#` int(11) NOT NULL,
  `address_#` int(11) NOT NULL,
  `usage` float(6,2) NOT NULL DEFAULT 0.00,
  `start` date NOT NULL,
  `end` date NOT NULL,
  PRIMARY KEY (`utility_#`,`address_#`) USING BTREE,
  KEY `FK_history_location` (`address_#`) USING BTREE,
  CONSTRAINT `FK_history_location` FOREIGN KEY (`address_#`) REFERENCES `location` (`address_#`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_history_utility` FOREIGN KEY (`utility_#`) REFERENCES `utility` (`utility_#`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `CC1` CHECK (`start` < `end`),
  CONSTRAINT `CC2` CHECK (`end` > `start`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Dumping data for table oopfinal.history: ~9 rows (approximately)
DELETE FROM `history`;
/*!40000 ALTER TABLE `history` DISABLE KEYS */;
INSERT INTO `history` (`utility_#`, `address_#`, `usage`, `start`, `end`) VALUES
	(1, 1, 192.35, '2022-03-04', '2022-11-27'),
	(2, 2, 516.75, '2021-05-31', '2022-04-26'),
	(3, 3, 547.98, '2022-02-23', '2023-01-07'),
	(4, 1, 288.43, '2021-07-18', '2022-07-13'),
	(5, 2, 220.31, '2022-01-08', '2022-06-14'),
	(6, 3, 736.16, '2022-03-22', '2023-02-25'),
	(7, 1, 165.48, '2021-06-21', '2022-05-24'),
	(8, 2, 256.62, '2021-08-26', '2023-03-09'),
	(9, 3, 7.94, '2021-06-17', '2022-05-21');
/*!40000 ALTER TABLE `history` ENABLE KEYS */;

-- Dumping structure for table oopfinal.location
DROP TABLE IF EXISTS `location`;
CREATE TABLE IF NOT EXISTS `location` (
  `address_#` int(11) NOT NULL,
  `account_#` int(11) NOT NULL,
  `location` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`address_#`,`account_#`) USING BTREE,
  UNIQUE KEY `location` (`location`),
  KEY `FK_location_user` (`account_#`) USING BTREE,
  CONSTRAINT `FK_location_user` FOREIGN KEY (`account_#`) REFERENCES `user` (`account_#`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Dumping data for table oopfinal.location: ~3 rows (approximately)
DELETE FROM `location`;
/*!40000 ALTER TABLE `location` DISABLE KEYS */;
INSERT INTO `location` (`address_#`, `account_#`, `location`) VALUES
	(3, 1, '0 Johnson Drive'),
	(1, 1, '43612 Autumn Leaf Parkway'),
	(2, 1, '714 Hauk Point');
/*!40000 ALTER TABLE `location` ENABLE KEYS */;

-- Dumping structure for table oopfinal.user
DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `account_#` int(11) NOT NULL DEFAULT 0,
  `first_name` varchar(50) NOT NULL DEFAULT '',
  `last_name` varchar(50) NOT NULL,
  `mailing_address` varchar(50) NOT NULL,
  `phone_number` varchar(10) NOT NULL DEFAULT '0',
  `e_mail` varchar(50) NOT NULL,
  `credit_card` varchar(16) NOT NULL DEFAULT '0',
  PRIMARY KEY (`account_#`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Dumping data for table oopfinal.user: ~1 rows (approximately)
DELETE FROM `user`;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` (`account_#`, `first_name`, `last_name`, `mailing_address`, `phone_number`, `e_mail`, `credit_card`) VALUES
	(1, 'Jeanne', 'Wallicker', '7 Thackeray Street', '7882850419', 'jwallicker0@csmonitor.com', '6709135806627514');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;

-- Dumping structure for table oopfinal.utility
DROP TABLE IF EXISTS `utility`;
CREATE TABLE IF NOT EXISTS `utility` (
  `utility_#` int(11) NOT NULL,
  `type` int(1) NOT NULL,
  `rate` float(5,4) NOT NULL DEFAULT 0.0000,
  PRIMARY KEY (`utility_#`) USING BTREE,
  CONSTRAINT `CC1` CHECK (`type` = 1 or 2 or 3)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Dumping data for table oopfinal.utility: ~9 rows (approximately)
DELETE FROM `utility`;
/*!40000 ALTER TABLE `utility` DISABLE KEYS */;
INSERT INTO `utility` (`utility_#`, `type`, `rate`) VALUES
	(1, 1, 1.2706),
	(2, 1, 5.9952),
	(3, 1, 1.1516),
	(4, 2, 2.6255),
	(5, 2, 5.6204),
	(6, 2, 5.7566),
	(7, 3, 5.2280),
	(8, 3, 5.6528),
	(9, 3, 2.4916);
/*!40000 ALTER TABLE `utility` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
