using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HelpRon.Data;
using System;
using System.Linq;

namespace HelpRon.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new HelpRonContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<HelpRonContext>>()))
            {
                // Look for any movies.
                if (context.Need.Any())
                {
                    return;   // DB has been seeded
                }

                context.Need.AddRange(
                    new Need
                    {
                        Name = "Buy more Oak",
                        DueDate = DateTime.Parse("2022-5-12"),
                        Helper = "Ann",
                       
                    },

                    new Need
                    {
                        Name = "Get Eggs",
                        DueDate = DateTime.Parse("2022-8-2"),
                        Helper = "Leslie",

                    },

                     new Need
                     {
                         Name = "Buy a cow",
                         DueDate = DateTime.Parse("2022-2-12"),
                         Helper = "April",

                     },

                   new Need
                   {
                       Name = "Buy a shovel",
                       DueDate = DateTime.Parse("2021-6-19"),
                       Helper = "Andy",
                   }


               );
                context.SaveChanges();
            }
        }
    }
}

