using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExercice3._6
{
    internal class ArticleDao : IArticleDao
    {
        public ArticleDao()
        {
            ListeArticles = Util.GetArticles();
        }

        public ArticleDao(List<Article> listeArticles)
        {
            ListeArticles = listeArticles;
        }

        public List<Article> ListeArticles { get; }

        public Article GetArticles(string nomArticle)
        {
            return ListeArticles
                .FirstOrDefault(art => art.nomArticle.Equals(nomArticle));
        }

        public (string, double) GetArticleAndPrice(string nomArticle)
        {
            var res = ListeArticles
                .Where(art => art.nomArticle.Equals(nomArticle))
                .Select(art => new {art.nomArticle, art.prixArticle})
                .FirstOrDefault();
            if (res != null)
                return (res.nomArticle, res.prixArticle);
            return ("Article non trouvé", 0);
        }

        public Tuple<string, double> GetArticleAndPriceTuple(string nomArticle)
        {
            var res = ListeArticles
                .Where(art => art.nomArticle.Equals(nomArticle))
                .Select(art => new Tuple<string, double>(art.nomArticle, art.prixArticle))
                .FirstOrDefault();
            return res;
        }
    }
}