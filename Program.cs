namespace ApplicationEtudiant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donnez le nombre d'étudiant à créer");
            int nbEtudiantACreer = Int32.Parse(Console.ReadLine());

            while(nbEtudiantACreer > 0) 
            {
                Console.WriteLine("Donnez le nom de l'étudiant svp");
                string nomEtudiant = Console.ReadLine();
                Console.WriteLine("Donnez le prénom de l'étudiant svp");
                string prenomEtudiant = Console.ReadLine();
                Console.WriteLine("Donnez le numéro de l'étudiant svp");
                int numeroEtudiant = Int32.Parse(Console.ReadLine());

                Etudiant etudiant = new Etudiant(numeroEtudiant, nomEtudiant, prenomEtudiant);
            }           

        }
    }
}