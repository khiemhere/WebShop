﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webShopSolution.Data.Entities
{
    public class CategoryTranslation
    {
        public long Id { set; get; }
        public long CategoryId { set; get; }
        public string Name { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string LanguageId { set; get; }
        public string SeoAlias { set; get; }

        public Category Category { get; set; }

        //public Language Language { get; set; }
    }
}
