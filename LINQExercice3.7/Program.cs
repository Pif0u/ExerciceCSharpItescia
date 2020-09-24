using System;
using System.Collections.Generic;

namespace LINQExercice3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            IArticleDao dao = new ArticleDao();
            IEnumerable<Article> res = dao.GetArticleMinMax(11, 14);
            foreach (var article in res)
            {
                article.Afficher();
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
}
