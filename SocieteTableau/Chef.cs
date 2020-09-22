using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteTableau
{
    public class Chef : Employe
    {
        public string Service { get; set; }

        public Chef(string nom, string prenom, int salaire, string service) : base(nom, prenom, salaire)
        {
            Service = service;
        }

        public Chef(string nom, string prenom, int age, int salaire, string service) : base(nom, prenom, age, salaire)
        {
            Service = service;
        }

        public override string ToString()
        {
            if (Age == 0)
            {
                return "Ce chef se nomme " + Nom + " " + Prenom + Environment.NewLine +
                       "Son salaire est de " + Salaire +
                       Environment.NewLine + "Il travail au service " + Service;
            }
            else
            {
                return "Ce chef se nomme " + Nom + " " + Prenom + Environment.NewLine +
                       "Il a " + Age + Environment.NewLine + "Son salaire est de " + Salaire +
                       Environment.NewLine + "Il travail au service " + Service;
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
        }

    }
}
