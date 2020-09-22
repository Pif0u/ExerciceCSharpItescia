using System;

namespace SocieteEnumeration.Societe
{
    public class Personne
    {
        public string Nom { get; set; }

        public string Prenom { get; set; }

        public int Age { get; set; }

        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public Personne(string nom, string prenom, int age)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }


        public virtual void Afficher()
        {
            Console.WriteLine("Nom : " + Nom);
            Console.WriteLine("Prenom : " + Prenom);
            if (Age != 0)
            {
                Console.WriteLine("Age : " + Age);
            }
        }

        public override string ToString()
        {
            return "Cette personne a " + Age + " ans";
        }



    }
}
