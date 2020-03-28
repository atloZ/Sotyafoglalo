CREATE USER 'Sotyafoglalo'@'localhost' IDENTIFIED BY 'pin';
GRANT ALL PRIVILEGES ON * . * TO 'Sotyafoglalo'@'localhost';
FLUSH PRIVILEGES;

CREATE DATABASE db_sotyafoglalo;

CREATE TABLE kerdesek (
   id INT AUTO_INCREMENT PRIMARY KEY ,
   kerdes VARCHAR(255) NOT NULL UNIQUE
);

CREATE TABLE valaszok(
   id INT AUTO_INCREMENT PRIMARY KEY ,
   valasz VARCHAR(255) NOT NULL,
   valaszHelyesE boolean NOT NULL,
   kerdes_id INT NOT NULL,
   FOREIGN KEY (kerdes_id)
   REFERENCES kerdesek(id)
);

CREATE TABLE tippKerdes(
   id INT AUTO_INCREMENT PRIMARY KEY,
   kerdes VARCHAR(255) NOT NULL UNIQUE,
   valasz INT NOT NULL
);