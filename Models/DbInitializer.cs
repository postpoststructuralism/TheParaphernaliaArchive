using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaphernaliaArchive.Models
{
    public class DbInitializer
    {
        public static void Initialize(ParaphernaliaContext context)
        {
            context.Database.EnsureCreated();

            if (context.Items.Any())
            {
                return;
            }

            var items = new List<Item>()
            {
                new Item
                {
                    Title = "Broom",
                    Description = "For sweeping",
                    DateAcquired = DateTime.Now,
                    ExpirationDate = DateTime.MaxValue
                },
                new Item
                {
                    Title = "Shovel",
                    Description = "For digging",
                    DateAcquired = DateTime.Now,
                    ExpirationDate = DateTime.MaxValue
                }
            };

            context.Items.AddRange(items);

            context.SaveChanges();
        }
    }
}
