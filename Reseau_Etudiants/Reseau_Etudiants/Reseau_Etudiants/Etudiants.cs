namespace Reseau_Etudiants
{
    class Etudiants
    {
        public string Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }

        public int Age => DateTime.Now.Year - DateNaissance.Year - (DateTime.Now.DayOfYear < DateNaissance.DayOfYear ? 1 : 0); // Calculer l'âge automatiquement
        public List<matieres> Matieres { get; set; }

        // Nouvelle propriété pour obtenir les matières sous forme littérale.
        public List<string> MatieresNom => Matieres.Select(a => a.ToString()).ToList();
        public Dictionary<matieres, List<float>> Notes = new Dictionary<matieres, List<float>>();// EX: Geographie {10.3,15.05,18.25}

        public Etudiants(string id, string nom, string prenom, DateTime dateNaissance, List<matieres> matieres, Dictionary<matieres, List<float>> notes)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Matieres = matieres;
            Notes = notes;
        }

        public Etudiants()
        {

        }

        public List<Etudiants> ListeEtudiants(List<Etudiants> listeEtudiants)
        {
            if(listeEtudiants != null)
            {
                Console.WriteLine($"\nVotre liste contient {listeEtudiants.Count} étudiants !\n\n");
                int index = 1;

                foreach (var etudiant in listeEtudiants)
                {
                    Console.WriteLine($"Étudiant {index}");
                    Console.WriteLine("------------");
                    Console.WriteLine($"Id : {etudiant.Id}");
                    Console.WriteLine($"Nom : {etudiant.Nom}");
                    Console.WriteLine($"Prénom : {etudiant.Prenom}");
                    Console.WriteLine($"Née le : {etudiant.DateNaissance.ToString("dd MMMM yyyy")}");
                    Console.WriteLine($"Age : {etudiant.Age} ans");
                    Console.WriteLine();
                    Console.WriteLine($"Matières choisies : {string.Join(", ", etudiant.MatieresNom)}");
                    Console.WriteLine();
                    Console.WriteLine($"Ses notes :");
                    Console.WriteLine("-------------");

                    foreach (var matiere in etudiant.Matieres)
                    {
                        var notesList = string.Join(" - ", etudiant.Notes[matiere]);
                        Console.WriteLine($"   {matiere} : {notesList}");
                    }

                    Console.WriteLine();
                    Console.WriteLine("*******************************************************\n");
                    index++;
                }
                    return listeEtudiants;
            }
            else
            {
                Console.WriteLine("\nOups, il semblerait que la liste d'étudiants soit nulle ou inexistante !");
                return null;
            }
        }
    }
}