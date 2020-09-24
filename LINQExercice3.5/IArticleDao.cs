using System;
using System.Collections.Generic;
using System.Text;

namespace LINQExercice3._5
{
    public interface IArticleDao
    {
        Article GetArticles(string nomArticle);

        ( string, double) GetArticleAndPrice(string nomArticle);
    }
}
