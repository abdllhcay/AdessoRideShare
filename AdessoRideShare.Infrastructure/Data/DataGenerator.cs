using AdessoRideShare.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace AdessoRideShare.Infrastructure.Data
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Cities.Any() && context.Trips.Any())
                {
                    return;        
                }

                context.Cities.AddRange(
                    new City
                    {
                        Name = "Dawnstar",
                        X = 0,
                        Y = 0
                    },
                    new City
                    {
                        Name = "Falkreath",
                        X = 1,
                        Y = 0
                    },
                    new City
                    {
                        Name = "Markarth",
                        X = 2,
                        Y = 0
                    },
                    new City
                    {
                        Name = "Morthal",
                        X = 3,
                        Y = 0
                    },
                    new City
                    {
                        Name = "Riften",
                        X = 0,
                        Y = 1
                    },
                    new City
                    {
                        Name = "Solitude",
                        X = 0,
                        Y = 2
                    },
                    new City
                    {
                        Name = "Whiterun",
                        X = 1,
                        Y = 1
                    },
                    new City
                    {
                        Name = "Balmora",
                        X = 1,
                        Y = 2
                    },
                    new City
                    {
                        Name = "Sadrith Mora",
                        X = 2,
                        Y = 1
                    },
                    new City
                    {
                        Name = "Anvil",
                        X = 2,
                        Y = 2
                    },
                    new City
                    {
                        Name = "Bravil",
                        X = 3,
                        Y = 1
                    },
                    new City
                    {
                        Name = "Kvatch",
                        X = 3,
                        Y = 2
                    }
                );

                context.Trips.AddRange(
                    new Trip
                    {
                        Capacity = 4,
                        OriginId = 1,
                        DestinationId = 2,
                        Description = "Müthiş bir yolculuk",
                        Date = DateTime.Now
                    },
                    new Trip
                    {
                        Capacity = 3,
                        OriginId = 1,
                        DestinationId = 10,
                        Description = "Müthiş bir yolculuk",
                        Date = DateTime.Now
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
