using System;
using System.Collections.Generic;
using System.Text;

namespace Stamps.Models
{
    /// <summary>
    ///  user Model 
    /// </summary>
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        /// <summary>
        /// Each user can have multiple stamps 
        /// </summary>
        public ICollection<Stamp> Stamps { get; set; }

        public User() { }
        
        /// <summary>
        ///  Creating user -- no verification whatsoever
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="email"> </param>
        public User(string userName, string email)
        {
            Username = userName;
            Email = email;
        }
    }
}
