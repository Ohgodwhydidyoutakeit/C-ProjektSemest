using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Stamps.Models;

namespace Stamps.Data
{
     /// <summary>
     /// On start of the program after database is initialized the test data is created and inserted 
     /// </summary>
    public static class InitializeDb
    {
        public static void Initialize(ApplicationDbContext context)
        {
            InsertTestData(context);
        }

        private static void InsertTestData(ApplicationDbContext context)
        {
            // creating  products 
            if (context.Products.Any())
                return;
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Tshirt", Description = "Red", Price = 19.99, Unit =5},
                new Product { Id = 2, Name = "Tshirt", Description = "Blue Color", Price = 10.99, Unit =50},
                new Product { Id = 3, Name = "Shirt", Description = "Formal Shirt", Price = 10.99, Unit =25},
                new Product { Id = 4, Name = "Socks", Description = "Yellow ", Price = 2, Unit =500}
            };
            // adding products and saving 
            foreach (Product p in products)
            {
                context.Products.Add(p);
                context.SaveChanges();
            }
            //creatin a list of nationalities 
            var nationalities = new List<Nationality>()
            {
                new Nationality("Poland"),
                new Nationality("Germany"),
                new Nationality("USA")
            };
            //inserting nationalities into context 
            foreach (Nationality n in nationalities)
            {
                context.Nationalities.Add(n);
            }
            context.SaveChanges();
            //// creating users
            var users = new List<User>()
            {
                new User("Olea", "olea@gmail.com"),
                new User("Ben", "ben.bona@gmail.com"),
                new User("James Bond", "bond@email.com"),
                new User("Teresa", "teresa@email.com"),
                new User("Tomek", "tomek@email.com"),
                new User("Killer", "killer@email.com"),
                new User("Jacek343", "jacek3434@email.com"),
                new User("Tomek", "tomek3434@email.com"),
                new User("James Bond", "bond@email.com"),
                new User("Jacek2", "jacek2@email.com"),
                new User("Tomek3", "tomek3@email.com"),
                new User("James3 Bond", "bond@email.com"),
                new User("Jacek3", "jacek3@email.com"),
                new User("Tomek5", "tomek5@email.com"),
                new User("James Bond3", "bond3@email.com")
            };
            //inserting users 
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();
            //creating users 
            var stamps = new List<Stamp>()
            {
                new Stamp("Znaczek 1", "Opis 1", 1.23, "c:\\url\\1.jpg", nationalities.ElementAt(0).Id, users.ElementAt(0).Id),
                new Stamp("Znacek 2", "Opis 2", 1.23, "c:\\url\\2.jpg", nationalities.ElementAt(0).Id, users.ElementAt(0).Id),
                new Stamp("Znacek 3", "Opis 3", 1.23, "c:\\url\\3.jpg", nationalities.ElementAt(1).Id, users.ElementAt(1).Id),
                new Stamp("Znacek 4", "Opis 4", 1.23, "c:\\url\\4.jpg", nationalities.ElementAt(1).Id, users.ElementAt(2).Id),
                new Stamp("Znacek 5", "Opis 5", 1.23, "c:\\url\\5.jpg", nationalities.ElementAt(2).Id, users.ElementAt(3).Id)
            };
            //inserting users 
            foreach (Stamp s in stamps)
            {
                context.Stamps.Add(s);
            }
            context.SaveChanges();
        }
    }
}