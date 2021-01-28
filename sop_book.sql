
 SET NAMES utf8 ;
DROP TABLE IF EXISTS `book`;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `book` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `author` varchar(45) NOT NULL,
  `year` int NOT NULL,
  `price` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16;
LOCK TABLES `book` WRITE;
INSERT INTO `book` VALUES (1,'book1','author1',1990,"3000 HUF");
UNLOCK TABLES;