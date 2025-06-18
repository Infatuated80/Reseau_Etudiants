using System;
using System.Diagnostics;
using System.Text;

namespace Reseau_Etudiants
{
    public enum matieres { Anglais, Français, Maths, Geographie, Informatique, Philosophie, SVT, Histoire, SciencePhysique }
    internal class Program
    {
        static void Main(string[] args)
        {
            const string url = "http://brisse.frederic.book.free.fr/site_hd/book/dossier/contact/cv/Message.txt"; 

            var reseau = new Reseau();
            var message = reseau.RetournerMessage(url);

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine();
            Console.WriteLine(message);

            var fichier = new Fichiers();
            var listeEtudiants = fichier.ChargerJson();

            var etudiants = new Etudiants();
            etudiants.ListeEtudiants(listeEtudiants); 
        }
    }
}