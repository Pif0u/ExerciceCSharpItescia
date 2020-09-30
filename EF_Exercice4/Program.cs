using System;
using System.Collections.Generic;

namespace EF_Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            Util.InitTable();
            IArticleDao dao = new ArticleDao();
            IEnumerable<Article> res = dao.GetArticleMinMax(11, 14);
            Console.WriteLine(Environment.NewLine);
        }
    }
}
