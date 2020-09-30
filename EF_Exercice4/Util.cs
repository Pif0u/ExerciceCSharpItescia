using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using EF_Exercice4.NEf;

namespace EF_Exercice4
{
    static class Util
    {
        public static List<Article> GetArticles()
        {
            List<Article> l = new List<Article>()
            {
                new Article("PS5", 499.99, 12),
                new Article("Xbox Series S", 299.99, 15),
                new Article("Nintendo Switch", 299.99, 13)
            };
            return l;
        }

        public static void CreateTable()
        {
            var initializer = new CreateDatabaseIfNotExists<ContextEf>();
            initializer.InitializeDatabase(new ContextEf());
        }
        public static void InitTable()
        {
            var initializer = new InitArticle();
            initializer.InitializeDatabase(new ContextEf());
        }
    }
}
