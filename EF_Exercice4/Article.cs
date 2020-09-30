using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_Exercice4
{
    public class Article
    {
        [Column("IdArticle")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdArticle { get; set; }

        [Column("A_Nom")]
        [Required]
        [MaxLength(20)]
        public string NomArticle { get; set; }
        [Column("A_Prix")]
        [DataType("Real")]
        public double PrixArticle { get; set; }
        [Column("A_Quantite")]
        [DataType("Int")]
        public int QuantiteArticle { get; set; }

        public Article(string nomArticle, double prixArticle, int quantiteArticle)
        {
            NomArticle = nomArticle;
            PrixArticle = prixArticle;
            QuantiteArticle = quantiteArticle;
        }

        public Article(string nomArticle)
        {
            NomArticle = nomArticle;
            PrixArticle = 0.0;
            QuantiteArticle = 0;
        }

        public Article() : this("Undefined") { }


        public void Deconstruct(out long idArticle, out string nomArticle, out double prixArticle, out int quantiteArticle)
        {
            idArticle = IdArticle;
            nomArticle = NomArticle;
            prixArticle = PrixArticle;
            quantiteArticle = QuantiteArticle;
        }
    }

}
