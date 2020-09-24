using System;

namespace LINQExercice3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            IArticleDao dao = new ArticleDao();
            Article artPS5 = dao.GetArticles("PS5");
            artPS5.Afficher();

            Article artXbox = dao.GetArticles("Xbox Series S");
            artXbox.Afficher();


        }
    }
}
