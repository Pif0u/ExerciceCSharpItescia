using System;

namespace SocieteListe.Societe
{
    public class Directeur : Chef
    {
        public string Societe { get; set; }

        public Directeur(string nom, string prenom, int salaire, string service, string societe) : base(nom, prenom, salaire, service)
        {
            Societe = societe;
        }

        public Directeur(string nom, string prenom, int age, int salaire, string service, string societe) : base(nom, prenom, age, salaire, service)
        {
            Societe = societe;
        }

        public override string ToString()
        {
            if (Age == 0)
            {
                return "Ce directeur se nomme " + Nom + " " + Prenom + Environment.NewLine +
                       "Son salaire est de " + Salaire +
                       Environment.NewLine + "Il travail au service " + Service
                       + Environment.NewLine + "Sa société se nomme " + Societe;
            }
            else
            {
                return "Ce chef se nomme " + Nom + " " + Prenom + Environment.NewLine +
                       "Il a " + Age + "ans " + Environment.NewLine + "Son salaire est de " + Salaire +
                       Environment.NewLine + "Il travail au service " + Service
                       + Environment.NewLine + "Sa société se nomme " + Societe; ;
            }
        }

        public override void Afficher()
        {
            Console.WriteLine("Nom : " + Nom);
            Console.WriteLine("Prenom : " + Prenom);
            if (Age != 0)
            {
                Console.WriteLine("Age : " + Age);
            }
            Console.WriteLine("Salaire : " + Salaire);
            Console.WriteLine("Service : " + Service);
            Console.WriteLine("Societe : " + Societe);
        }
    }
}
