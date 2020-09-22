using System;

namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            var article1 = new ArticleType("PS5", 499.99, 5, TypeArticleEnum.Loisir);
            var article2 = new ArticleType("Jus d'" + "orange", 1.50, 25, TypeArticleEnum.Alimentaire);
            var article3 = new ArticleType("Jeans", 15.0, 7, TypeArticleEnum.Habillement);

            var tableauArticle = new ArticleType[] {article1, article2, article3};

          
            for(int i = 0; i < tableauArticle.Length; i++)
            {
                tableauArticle[i].Afficher();
            }


            Console.WriteLine("[Modification quantité Jeans]");
            tableauArticle[2].Retirer();
            tableauArticle[2].Afficher();





        }
    }
}
