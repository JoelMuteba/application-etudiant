using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationEtudiant
{
    internal class Etudiant
    {
        public int NumeroEtudiant { get; set; }
        

        public string NomEtudiant { get; set; }

        public string PrenomEtudiant { get; set; }


        public Etudiant(int numeroEtudiant, string nomEtudiant, string prenomEtudiant)
        {
            this.NumeroEtudiant = numeroEtudiant;
            this.NomEtudiant = nomEtudiant;
            this.PrenomEtudiant = prenomEtudiant;
        }
    }
}
