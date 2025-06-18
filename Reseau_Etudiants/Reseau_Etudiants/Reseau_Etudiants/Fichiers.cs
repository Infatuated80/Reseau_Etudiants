using Newtonsoft.Json;

namespace Reseau_Etudiants
{
    class Fichiers
    {
        public Fichiers() // Constructeur
        {

        }

        public List<Etudiants> ChargerJson()
        {
            const string url = "http://brisse.frederic.book.free.fr/site_hd/book/dossier/contact/cv/Etudiants.json";
            List<Etudiants> listeEtudiants = new List<Etudiants>();
            string json = "";

                var reseau = new Reseau();
                json = reseau.RetournerJson(url);  // On charge le Json en provenance du serveur web.
        
            try
            {
                /*On désérialise le contenu de notre json
                 * Pour que JSON Fonction dans le gestionnaire de package faire : Install-Package Newtonsoft.Json
                 * Inclure using Newtonsoft.Json; pour avoir accès à la bibliothèque.
                */
                listeEtudiants = JsonConvert.DeserializeObject<List<Etudiants>>(json);
                return listeEtudiants;
            }

            catch(Exception ex)
            {
                Console.WriteLine($"\nUne erreur est survenu lors du chargement du JSon !\nVoici l'erreur précise :{ex}");
                return null;
            }
        }
    }
}