using System;
using System.Collections.Generic;
using System.Text;

namespace Stamps.Models
{
    /// <summary>
    /// Simple Nationality model with no constraints 
    /// </summary>
    public class Nationality
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public Nationality() { }

        public Nationality(string name)
        {
            this.Name = name;
        }
    }
}
