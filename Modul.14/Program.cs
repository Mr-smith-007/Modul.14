﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTest
{
    class Program
    {

        static void Main(string[] args)
        {
            
            var russianCities = new List<City>();
            russianCities.Add(new City("Москва", 11900000));
            russianCities.Add(new City("Санкт-Петербург", 4991000));
            russianCities.Add(new City("Волгоград", 1099000));
            russianCities.Add(new City("Казань", 1169000));
            russianCities.Add(new City("Севастополь", 449138));

            var nameCities = russianCities.Where(c => c.Name.Length <= 10).OrderBy(c => c.Name.Length);
            foreach (var c in nameCities)
            {
                Console.WriteLine($"Город {c.Name} имеет в названии {c.Name.Length} букв");
            }
        }


        public class City
        {
            public City(string name, long population)
            {
                Name = name;
                Population = population;
            }

            public string Name { get; set; }
            public long Population { get; set; }
        }
    }
}