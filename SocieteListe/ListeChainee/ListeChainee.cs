using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteListe.ListeChainee
{
    public class Element
    {
        public object Objet { get; set; }

        public Element Suivant { get; set; }

        public Element(object objet)
        {
            Objet = objet;
        }
    }

    public class Liste
    {
        public Element Debut { get; set; }

        public int NbElement { get; set; }

        public Liste()
        {
            Debut = null;
            NbElement = 0;
        }

        public void InsererDebut(object objet)
        {
            Element toAdd = new Element(objet);


            toAdd.Suivant = Debut;
            Debut = toAdd;
            NbElement++;
        }

        public void InsererFin(object objet)
        {
            if (Debut == null)
            {
                Debut = new Element(objet);
                Debut.Suivant = null;
            }
            else
            {
                Element toAdd = new Element(objet);
                Element current = Debut;
                while (current.Suivant != null)
                {
                    current = current.Suivant;
                }

                current.Suivant = toAdd;
                NbElement++;
            }
        }

        public void Lister()
        {
            Element current = Debut;
            while (current != null)
            {
                Console.WriteLine(current.Objet.ToString());
                Console.WriteLine(Environment.NewLine);
                current = current.Suivant;
            }
        }

        public void Vider()
        {
            Element current = Debut;
            while (current != null)
            {
                current = null;
            }
            Debut = null;
            NbElement = 0;
            Console.WriteLine("La liste a été vidé");
            Console.Write(Environment.NewLine);
        }





    }


}

  
