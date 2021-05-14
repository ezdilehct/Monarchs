using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Monarchs.Domain.Entities;
using System.Collections.Generic;

namespace Monarchs
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            #region Seed Data
            var countries = new Dictionary<int, Country>
            {
                { 1, new Country
                {
                    Id = 1,
                    Name = "United Kingdom",
                }}
            };

            var houses = new Dictionary<int, House>
            {
                {
                    1,
                    new House
                    {
                        Id = 1,
                        Name = "House of Wessex",
                    }
                },
                 {
                    2,
                    new House
                    {
                        Id = 2,
                        Name = "House of Denmark",
                    }
                }
            };

            services.AddSingleton(new List<Monarch>
            {
                new Monarch
                {
                    Id = 1,
                    FirstName = "Edward",
                    NickName = "the Elder",
                    Country = countries[1],
                    CountryId = 1,
                    House = houses[1],
                    HouseId = 1,
                    RuledFrom = 899,
                    RuledTill = 925
                },
                new Monarch
                {
                    Id = 2,
                    FirstName = "Athelstan",
                    Country = countries[1],
                    CountryId = 1,
                    House = houses[1],
                    HouseId = 1,
                    RuledFrom = 925,
                    RuledTill = 940
                },
                new Monarch
                {
                    Id = 3,
                    FirstName = "Edmund",
                    Country = countries[1],
                    CountryId = 1,
                    House = houses[1],
                    HouseId = 1,
                    RuledFrom = 940,
                    RuledTill = 946
                },
                new Monarch
                {
                    Id = 4,
                    FirstName = "Edred",
                    Country = countries[1],
                    CountryId = 1,
                    House = houses[1],
                    HouseId = 1,
                    RuledFrom = 946,
                    RuledTill = 955
                },
                new Monarch
                {
                    Id = 5,
                    FirstName = "Edgar",
                    Country = countries[1],
                    CountryId = 1,
                    House = houses[1],
                    HouseId = 1,
                    RuledFrom = 959,
                    RuledTill = 975
                },
                new Monarch
                {
                    Id = 6,
                    FirstName = "Edward",
                    NickName = "the Martyr",
                    Country = countries[1],
                    CountryId = 1,
                    House = houses[1],
                    HouseId = 1,
                    RuledFrom = 975,
                    RuledTill = 978
                },
                new Monarch
                {
                    Id = 7,
                    FirstName = "Ethelred",
                    NickName = "II the Unready",
                    Country = countries[1],
                    CountryId = 1,
                    House = houses[1],
                    HouseId = 1,
                    RuledFrom = 978,
                    RuledTill = 1016
                },
                new Monarch
                {
                    Id = 8,
                    FirstName = "Edmund",
                    NickName = "lronside",
                    Country = countries[1],
                    CountryId = 1,
                    House = houses[1],
                    HouseId = 1,
                    RuledFrom = 1016,
                    RuledTill = 1016
                },
                new Monarch
                {
                    Id = 9,
                    FirstName = "Cnut",
                    Country = countries[1],
                    CountryId = 1,
                    House = houses[2],
                    HouseId = 2,
                    RuledFrom = 1016,
                    RuledTill = 1035
                },
                new Monarch
                {
                    Id = 10,
                    FirstName = "Harold",
                    NickName = "I Harefoot",
                    Country = countries[1],
                    CountryId = 1,
                    House = houses[2],
                    HouseId = 2,
                    RuledFrom = 1035,
                    RuledTill = 1040
                },

                // Assume rest.
            });
            #endregion
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
