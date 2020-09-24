using System;

namespace LINQExercice3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            IArticleDao dao = new ArticleDao();
            Tuple<string,double> res = dao.GetArticleAndPriceTuple("PS5");
            Console.WriteLine($"Nom de l'article: {res.Item1}, Prix de l'article : {res.Item2}");
            Console.WriteLine(Environment.NewLine);
        }
    }
}
