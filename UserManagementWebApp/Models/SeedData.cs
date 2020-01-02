using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementWebApp.Models;

namespace UserManagementWebApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UserManagementDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<UserManagementDbContext>>()))
            {
                
                if(context.User.Any())
                {
                    return;
                }

                context.User.AddRange
                (
                    new User
                    {
                        Username = "john",
                        Password = "john",
                        FirstName = "John",
                        LastName = "Vick",
                        Sex = "Male",
                        BirthDate = DateTime.Parse("1964-9-2"),
                        Description = "Basically, John was one of the greatest assassins who ever lived. He was so deadly that he earned the nickname Baba Yaga, which means The Boogeyman.",
                        RegistrationDate = DateTime.Parse("2019-12-31")
                    },
                    new User
                    {
                        Username = "modestas",
                        Password = "modestas",
                        FirstName = "Modestas",
                        LastName = "Jurčius",
                        Sex = "Male",
                        BirthDate = DateTime.Parse("1998-5-12"),
                        Description = "A software engineering student who loves to do some coding magic.",
                        RegistrationDate = DateTime.Parse("2019-12-31")
                    },
                    new User
                    {
                        Username = "dalia",
                        Password = "dalia",
                        FirstName = "Dalia",
                        LastName = "Grybauskaitė",
                        Sex = "Female",
                        BirthDate = DateTime.Parse("1956-3-1"),
                        Description = "Lithuanian politician who served as the eighth President of Lithuania from 2009 until 2019.",
                        RegistrationDate = DateTime.Parse("2019-12-31")
                    },
                    new User
                    {
                        Username = "johnnny",
                        Password = "the_beatles",
                        FirstName = "John",
                        LastName = "Lennon",
                        Sex = "Male",
                        BirthDate = DateTime.Parse("1940-10-9"),
                        Description = "John Lennon was an English singer, songwriter and peace activist who gained worldwide fame as the founder, co-lead vocalist, and rhythm guitarist of the Beatles.",
                        RegistrationDate = DateTime.Parse("2020-1-2")
                    },
                    new User
                    {
                        Username = "magnus",
                        Password = "magnus",
                        FirstName = "Magnus",
                        LastName = "Carlsen",
                        Sex = "Male",
                        BirthDate = DateTime.Parse("1990-11-30"),
                        Description = "Magnus Carlsen is a Norwegian chess grandmaster who is the current World Chess Champion, three-time World Rapid Chess Champion and five-time World Blitz Chess Champion.",
                        RegistrationDate = DateTime.Parse("2020-1-2")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
