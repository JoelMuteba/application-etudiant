using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationEtudiant
{
    internal class Etudiant
    {
        private static int nbEtudiant = 0;

        public int NumeroEtudiant { get; }
        

        public string NomEtudiant { get; set; }

        public string PrenomEtudiant { get; set; }


        public Etudiant(string nomEtudiant, string prenomEtudiant)
        {
            this.NumeroEtudiant = ++nbEtudiant;
            this.NomEtudiant = nomEtudiant;
            this.PrenomEtudiant = prenomEtudiant;
        }

        public override string ToString()
        {
            string etudiantInfo = string.Format("Le nom de l'étudiant est {0}" +
                ", son prénom est {1} et son numéro d'étudiant est {2}"
                , NomEtudiant, PrenomEtudiant, NumeroEtudiant);
            return etudiantInfo;
        }
    }
}
