using System;
using System.Collections.Generic;

namespace TopTenPlaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\AnthonyChiara\Downloads\csharp-collections-beginning\Pop by Largest Final.csv";
            CVSReader ourReader = new CVSReader(filePath);

            Dictionary<string,Country> countries = ourReader.ReadAllCountries();

            //Country lilliput = new Country("Lilliput", "LIL", "Somewhere", 2_000_000);
            //int lilliputIndex = countries.FindIndex(x=>x.Population < 2_000_000); //lambda expression
            //x=>x.Population called predicate
            //A predicate is an expression that returns a true or false boolean 
            //x=>x.Population < 2_000_000 -- saying the expression is only true if x is a country with a population 
            //less than 2 million
            //countries.Insert(lilliputIndex,lilliput);
            //countries.RemoveAt(lilliputIndex); //RemoveAt -- removes element/object at that exact index

            Console.WriteLine("Which country code do you want to look up?");
            string userInput = Console.ReadLine();

            bool getCountry = countries.TryGetValue(userInput, out Country country);
            if(!getCountry)
                Console.WriteLine($"Sorry! There is no country with code, {userInput}.");
            else
                Console.WriteLine($"{country.Name} has population {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}.");
            

            //Console.WriteLine($"There are {countries.Count} countries in this csv file.");
        }
    }
}
