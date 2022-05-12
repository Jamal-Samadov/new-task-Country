using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask_Country
{
    internal class Country
    {
        List<City> cities = new List<City>();

        public string Name { get; set; }
        public int TotalPopulation { get; set; } = 0;

        public Country(string Name)
        {
            this.Name = Name;
        }

        public void Add(City city)
        {
            cities.Add(city);
            this.TotalPopulation += city.Population;
        }

        public void FindAllByPopulation(int min, int max)
        {
            Console.WriteLine($"\n *** {this.Name} ***");
            Console.WriteLine("--------");
            foreach (City city in this.cities)
            {
                if(city.Population >= min && city.Population<= max)
                {
                    Console.WriteLine("{0} : {1:N0}", city.Name, city.Population);
                }
            }
            Console.WriteLine("-------");
        }


    }
}
