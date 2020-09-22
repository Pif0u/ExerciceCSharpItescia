using System;

namespace Personnes
{
    class TestPersonne
    {
        static void Main(string[] args)
        {

            Personne personne1 = new Personne("Jean", "Paul", 18);
            Personne personne2 = new Personne("John", "Doe", 24);


            

            Console.WriteLine("Nombre de personnes : " + personne2.Combien());
        }
    }
}
