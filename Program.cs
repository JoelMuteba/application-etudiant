namespace ApplicationEtudiant
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Donnez le numéro de l'étudiant en chiffre svp!");
            int nbEtudiantACreer = Int32.Parse(Console.ReadLine());

            while (nbEtudiantACreer > 0)
            {
                Console.WriteLine("Donnez le nom de l'étudiant svp");
                string nomEtudiant = Console.ReadLine();
                Console.WriteLine("Donnez le prénom de l'étudiant svp");
                string prenomEtudiant = Console.ReadLine();

                Etudiant etudiant = new Etudiant(nomEtudiant, prenomEtudiant);

                Console.WriteLine(etudiant);
            }
        }
    }
}