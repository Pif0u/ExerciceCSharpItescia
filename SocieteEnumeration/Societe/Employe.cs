using System;

namespace SocieteEnumeration.Societe
{
    public class Employe : Personne
    {
        public Employe(string nom, string prenom, int salaire) : base(nom, prenom)
        {
            Salaire = salaire;
        }

        public Employe(string nom, string prenom, int age, int salaire) : base(nom, prenom, age)
        {
            Salaire = salaire;
        }

        public int Salaire { get; set; }


        public override string ToString() => "Cet employé se nomme " + Nom + " " + Prenom + Environment.NewLine +
                                             "Il a " + Age + " ans " + Environment.NewLine +
                                             "Son salaire est de " + Salaire;

        public override void Afficher()
        {
            Console.WriteLine("Nom : " + Nom);
            Console.WriteLine("Prenom : " + Prenom);
            if (Age != 0)
            {
                Console.WriteLine("Age : " + Age);
            }
            Console.WriteLine("Salaire : " + Salaire);
        }


    }
}
