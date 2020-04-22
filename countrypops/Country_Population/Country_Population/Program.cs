using System;
using System.Collections.Generic;

namespace Country_Population
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\pasan.premaratne\Google Drive\_coding_\cs-collections\countrypops\worldbank_pop_data.csv";
            CsvReader reader = new CsvReader(filepath);

            List<Country> countries = reader.ReadAllCountries();

            foreach (Country country in countries)
            {
                Console.WriteLine($"Country is {country.Name} and the population is {country.Population}");
            }
        }
    }
}
