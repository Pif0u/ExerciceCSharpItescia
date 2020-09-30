using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace EF_Exercice4.NEf
{
    public class InitArticle : CreateDatabaseIfNotExists<ContextEf>
    {
        protected override void Seed(ContextEf context)
        {
            base.Seed(context);
            context.ArticleEntities.Add(new Article("PS5", 499.99, 12));
            context.ArticleEntities.Add(new Article("Xbox Series S", 299.99, 15));
            context.ArticleEntities.Add(new Article("Nintendo Switch", 299.99, 13));
            context.SaveChanges();
        }
    }
}
