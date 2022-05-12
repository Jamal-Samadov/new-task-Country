using System;

namespace FinalTask_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country Spain = new Country("Spain");
            City Madrid = new City("Madrid", 400000);
            City Barcelona = new City("Barcelona", 500000);
            City Valencia = new City("Valencia", 600000);
            City Bilbao = new City("Bilbao", 700000);
            City Sevillia = new City("Sevillia", 800000);
            City Malaga = new City("Malaga", 900000);

            Spain.Add(Madrid);
            Spain.Add(Barcelona);
            Spain.Add(Valencia);
            Spain.Add(Bilbao);
            Spain.Add(Sevillia);
            Spain.Add(Malaga);

            Spain.FindAllByPopulation(300000, 1000000);
        }
    }
}
