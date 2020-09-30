using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace EF_Exercice4.NEf
{
    public class ContextEf : DbContext
    {
        public ContextEf() : base ("C_BdArticle") { }
        public DbSet<Article>ArticleEntities { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Article>().ToTable("T_Articles", "dbo");
            modelBuilder.Entity<Article>().Property(art => art.NomArticle).HasColumnName("A_Nom");
            modelBuilder.Entity<Article>().Property(art => art.NomArticle).HasMaxLength(20);
        }
    }
}
