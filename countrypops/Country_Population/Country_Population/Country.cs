using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country_Population
{
    internal class Country
    {
        public Country(string name, string code, string region, int population)
        {
            Name = name;
            Code = code;
            Region = region;
            Population = population;
        }

        public string Name { get; }
        public string Code { get; }
        public string Region { get; }
        public int Population { get; }


    }
}