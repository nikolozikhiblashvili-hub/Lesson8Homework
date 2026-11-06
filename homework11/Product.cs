using System;
using System.Collections.Generic;
using System.Text;

namespace homework11
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public override string? ToString()
        {
            return $"{Id}|{Name}|{Price}|{Description}";
        }
    }
}
