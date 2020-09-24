using System;

namespace LINQExercice3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            IArticleDao dao = new ArticleDao(); 
            (string nomAritcle, double prixArticle) = dao.GetArticleAndPrice("PS5");
            Console.WriteLine($"Nom de l'article: {nomAritcle}, Prix de l'article : {prixArticle}");
            Console.WriteLine(Environment.NewLine);
        }
    }
}
