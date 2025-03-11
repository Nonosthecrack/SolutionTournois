DROP DATABASE  IF EXISTS bddtournois;
CREATE DATABASE IF NOT EXISTS bddtournois;
USE bddtournois;

CREATE TABLE GestionnairesAppli (
  idGestionnaire int(11) NOT NULL auto_increment,
  login text NOT NULL,
  motDpass text NOT NULL,
  PRIMARY KEY (idGestionnaire)
  ) ENGINE=InnoDB;
  
 CREATE TABLE Sport (
  idSport int(11) NOT NULL auto_increment,
  intitule text NOT NULL,
   PRIMARY KEY (idSport)
 ) ENGINE=InnoDB;

 CREATE TABLE Tournoi (
  idTournoi int(11) NOT NULL auto_increment,
  intitule text NOT NULL,
  dateTournoi DATE NOT NULL,
  Sport int(11) NOT NULL,
  PRIMARY KEY (idTournoi)
  ) ENGINE=InnoDB ;
ALTER TABLE Tournoi ADD CONSTRAINT FK_Sport FOREIGN KEY(Sport) REFERENCES Sport(idSport);

CREATE TABLE participant (
  id int(11) NOT NULL auto_increment,
  prenom text CHARACTER SET latin1 NOT NULL,
  nom text CHARACTER SET latin1 NOT NULL,
  dateNaissance DATE NOT NULL,
  sexe text CHARACTER SET latin1,
  photo Longblob,
  tournoi int(11) NOT NULL,
  PRIMARY KEY (id)
  
 ) ENGINE=InnoDB;

ALTER TABLE participant ADD CONSTRAINT FK_tournoi FOREIGN KEY(tournoi) REFERENCES Tournoi(idTournoi);

USE mysql;
GRANT ALL PRIVILEGES ON bddtournois. * TO 'adminTournois'@'%' IDENTIFIED BY 'Password1234@';
FLUSH PRIVILEGES;

--