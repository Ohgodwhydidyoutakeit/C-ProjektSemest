using System;
using System.Collections.Generic;
using System.Text;


namespace Stamps.Models
{   
    /// <summary>
    /// Stamp model for a database 
    /// </summary>
    public class Stamp
    {
      
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public double Price { get; set; }

        public string PictureUrl { get; set; }

        public int NationalityId { get; set; }

        /// <summary>
        /// creating 'foreign key' to nationality 
        /// </summary>
        public virtual Nationality Nationality { get; set; }

        public int UserId { get; set; }
        /// <summary>
        /// inserting a user dependency 
        /// </summary>
        public User User { get; set; }


        public Stamp() { }

        /// <summary>
        ///  Creating an object 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="price"></param>
        /// <param name="pictureUrl"></param>
        /// <param name="nationalityId"> passing in the nationality id </param>
        /// <param name="userId"> passing in the nationality id</param>
        public Stamp(string name, string description, double price, string pictureUrl, int nationalityId, int userId)
        {
            Name = name;
            Description = description;
            Price = price;
            PictureUrl = pictureUrl;
            NationalityId = nationalityId;
            UserId = userId;
        }


    }
}
