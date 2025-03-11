using BddtournoiContext;
using Devart.Data.MySql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                throw new Exception("Échec de la connexion à la base de données."); 
            }
            finally
            {
                c.Close();
            }
        }

        public List<Tournoi> GetTournois()
        {
            try
            {
                return bdd.Tournois.ToList();
            }
            catch (Exception e) { throw; }

        }

        public List<Participant> GetParticipant()
        {
            try
            {
                return bdd.Participants.ToList();
            }
            catch (Exception e) { throw; }
        }

        public List<Sport> GetSport()
        {
            try
            {
                return bdd.Sports.ToList();
            }catch (Exception e) { throw; }
        }

    }

}
