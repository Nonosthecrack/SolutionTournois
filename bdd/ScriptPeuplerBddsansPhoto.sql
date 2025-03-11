USE bddtournois;

INSERT INTO `gestionnairesappli` (`idGestionnaire`, `login`, `motDpass`) VALUES (NULL, 'nouzy', 'PasswdN');

INSERT INTO `Sport` (`idSport`,`intitule`) VALUES (NULL,'tennis');
INSERT INTO `Sport` (`idSport`,`intitule`) VALUES (NULL,'padel');
INSERT INTO `Sport` (`idSport`,`intitule`) VALUES (NULL,'badminton');

INSERT INTO `Tournoi` (`idTournoi`,`intitule`,`dateTournoi`,`Sport`) VALUES (NULL,'badmintonJunior','2025-03-10',3);
INSERT INTO `Tournoi` (`idTournoi`,`intitule`,`dateTournoi`,`Sport`) VALUES (NULL,'tennisSenior','2025-03-10',1);

INSERT INTO `participant` (`id`, `prenom`, `nom`, `dateNaissance`, `sexe`, `photo`, `tournoi`) VALUES
(NULL, 'roger', 'federer', '1981-08-08', 'masculin', null, 1);
INSERT INTO `participant` (`id`, `prenom`, `nom`, `dateNaissance`, `sexe`, `photo`, `tournoi`) VALUES
(NULL, 'raphael', 'NADAL', '1986-06-03', 'masculin', null, 1);
INSERT INTO `participant` (`id`, `prenom`, `nom`, `dateNaissance`, `sexe`, `photo`, `tournoi`) VALUES
(NULL, 'novak', 'DJOKOVIC', '1987-05-22', 'masculin', null, 1);
INSERT INTO `participant` (`id`, `prenom`, `nom`, `dateNaissance`, `sexe`, `photo`, `tournoi`) VALUES
(NULL, 'alexander', 'ZVEREV', '1997-04-20', 'masculin', null, 1);
INSERT INTO `participant` (`id`, `prenom`, `nom`, `dateNaissance`, `sexe`, `photo`, `tournoi`) VALUES
(NULL, 'stan', 'wawrinka', '1985-03-25', 'masculin', null, 2);
INSERT INTO `participant` (`id`, `prenom`, `nom`, `dateNaissance`, `sexe`, `photo`, `tournoi`) VALUES
(NULL, 'gael', 'monfils', '1986-09-01', 'masculin', null, 2);
