using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask_Country
{
    internal class City
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public City(string name,int population)
        {
            this.Name = name;
            this.Population = population;
        }
    }
}
