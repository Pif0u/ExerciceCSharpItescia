using System.Collections.Generic;
using System.Linq;

namespace LINQExercice3._4
{
    internal class ArticleDao : IArticleDao
    {
        public List<Article> ListeArticles { get; }

        public ArticleDao()
        {
            ListeArticles = Util.GetArticles();
        }

        public ArticleDao(List<Article> listeArticles)
        {
            ListeArticles = listeArticles;
        }

        public Article GetArticles(string nomArticle)
        {
            return ListeArticles
                .FirstOrDefault(art => art.nomArticle.Equals(nomArticle));
        }
    }
}