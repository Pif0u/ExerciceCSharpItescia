using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteEnumeration.ListeChainee
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

        public object this[int index] => Get(index);


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

        public bool Empty
        {
            get { return this.NbElement == 0; }
        }

        public object Get(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index: " + index);
            }

            if (this.Empty)
            {
                return null;
            }

            if (index >= this.NbElement)
            {
                index = this.NbElement - 1;
            }

            Element current = this.Debut;

            for (int i = 0; i < index; i++)
            {
                current = current.Suivant;
            }

            return current.Objet;


        }
    }



}


