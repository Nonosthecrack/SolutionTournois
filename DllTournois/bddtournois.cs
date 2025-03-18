using BddtournoiContext;
using Devart.Data.Linq;
using Devart.Data.MySql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DllTournois
{
    public class Bddtournois
    {
        private BddtournoiDataContext bdd = new BddtournoiDataContext();
        private string chaineConnexion;
        public Bddtournois(string adresse, string hote, string user, string mdp)
        {

            chaineConnexion = $"server={adresse};port={hote};user={user};password={mdp};";

            MySqlConnection c = new MySqlConnection(chaineConnexion);
            try
            {
                c.Open();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + "Échec de la connexion à la base de données."); 
            }
            finally
            {
                c.Close();
            }
        }

        public IQueryable<Tournoi> GetTournois()
        {
            return bdd.Tournois;
        }

        public IQueryable <Gestionnairesappli> GetGestionnaire()
        {
            return bdd.Gestionnairesapplis;
        }

        public IQueryable<Tournoi> GetTournoisBySportName(string sportName)
        {
            return bdd.Tournois.Where(t => t.Sport == this.GetSportByName(sportName).IdSport);
        }

        public Tournoi GetTournoiById(int id)
        {
            return bdd.Tournois.SingleOrDefault(t => t.IdTournoi == id);
        }

        public Tournoi GetTournoiByName(string name)
        {
            return bdd.Tournois.SingleOrDefault(t => t.Intitule == name);
        }

        public IQueryable<Sport> GetSport()
        {
            return bdd.Sports;
        }

        public Sport GetSportById(int id)
        {
            return bdd.Sports.SingleOrDefault(t => t.IdSport == id);
        }

        public Sport GetSportByName(string name)
        {
            return bdd.Sports.SingleOrDefault(t => t.Intitule == name);
        }

        public IQueryable<Participant> GetParticipant()
        {
            return bdd.Participants;
        }

        public IQueryable<Participant> GetAllParticipantsByTournoiName(string tournoiName)
        {
            return bdd.Participants.Where(t => t.Tournoi == this.GetTournoiByName(tournoiName).IdTournoi);
        }

        public Participant GetParticipantByIdentite(string identite)
        {
            string[] ident = identite.Split(' ');
            string nom = ident[0];
            string prenom = ident[1];
            return bdd.Participants.SingleOrDefault(t => t.Prenom == prenom && t.Nom == nom);
        }

        public IQueryable<Participant> GetParticipantContainingPartName(string name)
        {
            return bdd.Participants.Where(p => p.Nom.ToUpper().Contains(name.ToUpper()));
        }

        public Participant GetParticipantById(int id)
        {
            return bdd.Participants.SingleOrDefault(t => t.Id == id);
        }


        public bool verifyLogin(string login, string mdp)
        {
            Gestionnairesappli Login = bdd.Gestionnairesapplis.SingleOrDefault(l => l.Login.ToUpper().Equals(login));
            Gestionnairesappli MotDePasse = bdd.Gestionnairesapplis.SingleOrDefault(m => m.MotDpass.ToUpper().Equals(mdp)); ;
            return (Login != null && MotDePasse != null);
        }

        public void AddParticipant(Participant participant)
        { 
            bdd.Participants.InsertOnSubmit(participant);
            bdd.SubmitChanges();
        }

        public void AddSport(Sport s)
        {
            bdd.Sports.InsertOnSubmit(s);
            bdd.SubmitChanges();
        }

        public void AddTournoi(Tournoi t)
        {
            bdd.Tournois.InsertOnSubmit(t);
            bdd.SubmitChanges();
        }

        public void AddGestionnaire(Gestionnairesappli g)
        {
            bdd.Gestionnairesapplis.InsertOnSubmit(g);
            bdd.SubmitChanges();
        }

        public void RemoveParticipant(Participant participant)
        {
            bdd.Participants.DeleteOnSubmit(participant);
            bdd.SubmitChanges();
        }

        public void RemoveTournoi(Tournoi t)
        {
            bdd.Tournois.DeleteOnSubmit(t);
            bdd.SubmitChanges();
        }

        public void RemoveSport(Sport s)
        {
            bdd.Sports.DeleteOnSubmit(s);
            bdd.SubmitChanges();
        }

        public void RemoveGestionnaire(Gestionnairesappli g)
        {
            bdd.Gestionnairesapplis.DeleteOnSubmit(g);
            bdd.SubmitChanges();
        }

        public void ModifSport(Sport s)
        {
            var existingSport = bdd.Sports.SingleOrDefault(sp => sp.IdSport == s.IdSport);

            if (existingSport != null)
            {
                existingSport.Intitule = s.Intitule;
                bdd.SubmitChanges();
            }
            else
            {
                throw new Exception("Le sport à modifier n'existe pas dans la base de données.");
            }
        }

        public void ModifTournoi(Tournoi t)
        {
            var existingTournoi = bdd.Tournois.SingleOrDefault(tp => tp.IdTournoi == t.IdTournoi);

            if (existingTournoi != null)
            {
                existingTournoi.Intitule = t.Intitule;
                existingTournoi.DateTournoi = t.DateTournoi;
                existingTournoi.Sport = t.Sport;
                bdd.SubmitChanges();
            }
            else
            {
                throw new Exception("Le tournoi à modifier n'existe pas dans la base de données.");
            }
        }

        public void ModifParticipant(Participant p)
        {
            var existingParticipant = bdd.Participants.SingleOrDefault(tp => tp.Id == p.Id);

            if (existingParticipant != null)
            {
                existingParticipant.Nom = p.Nom;
                existingParticipant.Prenom = p.Prenom;
                existingParticipant.DateNaissance = p.DateNaissance;
                existingParticipant.Sexe = p.Sexe;
                existingParticipant.Photo = p.Photo;
                existingParticipant.Tournoi = p.Tournoi;
                bdd.SubmitChanges();
            }
            else
            {
                throw new Exception("Le Participant à modifier n'existe pas dans la base de données.");
            }
        }

        public void ModifGestionnaire(Gestionnairesappli g)
        {
            var existingGestionnaire = bdd.Gestionnairesapplis.SingleOrDefault(tp => tp.Login == g.Login);

            if(existingGestionnaire != null)
            {
                existingGestionnaire.Login = g.Login;
                existingGestionnaire.MotDpass = g.MotDpass;
                bdd.SubmitChanges();
            }
            else
            {
                throw new Exception("Le gestionnaire à modifier n'existe pas dans la base de données.");
            }

        }

    }

}
