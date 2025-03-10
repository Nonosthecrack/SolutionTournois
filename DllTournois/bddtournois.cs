using BddtournoiContext;
using Devart.Data.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllTournois
{
    public class Bddtournois
    {
        private BddtournoiDataContext bdd = null;

        private String chaineConnexion;
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
                throw new Exception("Échec de la connexion à la base de données."); 
            }
            finally
            {
                    c.Close();
            }
        }

        public List<Tournoi> GetTournois()
        {
            using (BddtournoiDataContext context = new BddtournoiDataContext())
            {
                return context.Tournois.ToList();
            }
        }

        public List<Participant> GetParticipant()
        {
            using (BddtournoiDataContext context = new BddtournoiDataContext())
            {
                return context.Participants.ToList();
            }
        }

        public List<Sport> GetSport()
        {
            using (BddtournoiDataContext context = new BddtournoiDataContext())
            {
                return context.Sports.ToList();
            }
        }

    }

}
