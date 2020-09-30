using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Exercice4
{
    public interface IArticleDao
    {
        Article GetArticles(string nomArticle);

        ( string, double) GetArticleAndPrice(string nomArticle);

        Tuple<string, double> GetArticleAndPriceTuple(string nomArticle);

        IEnumerable<Article> GetArticleMinMax(int min, int max);

    }
}
