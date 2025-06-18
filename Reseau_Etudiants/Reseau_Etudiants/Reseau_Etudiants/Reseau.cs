using System.Net;

namespace Reseau_Etudiants
{
    class Reseau
    {
        public String Message { get; set; }
        public String UrlJson { get; set; }

        public Reseau()
        {

        }

        public String RetournerMessage(string url)
        {
            var webClient = new WebClient();
            try
            {
                Message = webClient.DownloadString(url);
                Console.WriteLine($"\nLa connexion au serveur {url} pour récupérer le titre a réussi !");
                return Message;
            }

            catch(Exception ex)  
            {
                Console.WriteLine($"\nUne erreur s'est produite lors du chargement du message via le serveur :\n{url}\n\nVoici l'erreur précise : {ex}");
                return null;
            }
        }

        public String RetournerJson(string url)
        {
            var webClient = new WebClient();

            try
            {
                UrlJson = webClient.DownloadString(url);
                Console.WriteLine($"\nLa connexion au Json depuis le serveur {url} a réussi !");
                return UrlJson;
            }

            catch (Exception ex)
            {
                Console.WriteLine($"\nUne erreur s'est produite lors du chargement du Json via le serveur.\nVoici l'erreur précise : {ex}");
                return null;
            }
        }
    }
}