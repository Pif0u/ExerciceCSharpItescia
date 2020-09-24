using System;
using System.Collections.Generic;
using System.Text;

namespace LINQExercice3._4
{
    public interface IArticleDao
    {
        Article GetArticles(string nomArticle);
    }
}
