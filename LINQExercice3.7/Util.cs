﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LINQExercice3._7
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
    }
}
