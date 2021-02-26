using System;
using System.Collections.Generic;
using System.Text;

namespace Stamps.Models
{
    /// <summary>
    /// Simple Product model with no constraints 
    /// </summary>
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Unit { get; set; }
    }
}
