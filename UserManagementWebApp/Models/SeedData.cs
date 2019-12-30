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
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
