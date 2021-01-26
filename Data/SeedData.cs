using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProvinceCity.Models;

namespace ProvinceCity.Data
{
    public static class SeedData {
  // this is an extension method to the ModelBuilder class
        public static void Seed (this ModelBuilder modelBuilder) {
            modelBuilder.Entity<Province>().HasData (
                GetProvinces ()
            );
            modelBuilder.Entity<City>().HasData (
                GetCities ()
            );
        }
        // Teams
        public static List<Province> GetProvinces () {
            List<Province> provinces = new List<Province> {
                new Province () {
                ProvinceCode = "BC",
                ProvinceName = "British Columbia",
                },
                new Province () {
                ProvinceCode = "AB",
                ProvinceName = "Alberta",
                },
                new Province () {
                ProvinceCode = "ON",
                ProvinceName = "Ontario",
                },
            };

            return provinces;
        }

        // Players
        public static List<City> GetCities () {
        List<City> cities = new List<City> () {
            new City {
                CityId = 1,
                CityName = "Vancouver",
                Population = 10,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 2,
                CityName = "Victoria",
                Population = 20,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 3,
                CityName = "Burnaby",
                Population = 30,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 4,
                CityName = "Edmonton",
                Population = 40,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 5,
                CityName = "Calgary",
                Population = 50,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 6,
                CityName = "Red Deer",
                Population = 60,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 7,
                CityName = "Toronto",
                Population = 70,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 8,
                CityName = "Ottawa",
                Population = 80,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 9,
                CityName = "Mississauga",
                Population = 90,
                ProvinceCode = "ON"
            },
        };

        return cities;
        }
    }
}