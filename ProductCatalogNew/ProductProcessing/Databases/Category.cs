using System;
using System.Collections.Generic;
using System.Text;

namespace ProductProcessing.Databases
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string shortcode { get; set; }

        public static List<Category> _category = new List<Category>()

        {
            new Category
            {
                CategoryId = 101,
                shortcode = "bev"
            },

            new Category
            {
                CategoryId = 102,
                shortcode = "choc"
            },
            new Category
            {
                CategoryId = 103,
                shortcode = "spek"
            },
        };
    }
}
