using System;
using System.Collections.Generic;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] newArray = {"one", "two", "three"};

            Console.WriteLine(newArray[2]);
            
            Dictionary<string, string[]> worldCupGroups = new Dictionary<string, string[]>();
            worldCupGroups.Add("A", new string[]{"Russia", "Saudia Arabia", "Egypt", "Uruguay"});
            worldCupGroups.Add("B", new string[]{"Portugal", "Spain", "Iran", "Morocco"});
            worldCupGroups.Add("C", new string[]{"France", "Australia", "Peru", "Denmark"});
            worldCupGroups.Add("D", new string[]{"Argentina", "Iceland", "Croatia", "Nigeria"});
            worldCupGroups.Add("E", new string[]{"Costa Rica", "Serbia", "Brazil", "Switzerland"});
            worldCupGroups.Add("F", new string[]{"Germany", "Mexico", "Sweden", "South Korea"});
            worldCupGroups.Add("G", new string[]{"Belgium", "Panama", "Tunisia", "England"});
            worldCupGroups.Add("H", new string[]{"Columbia", "Japan", "Poland", "Senegal"});

            foreach (var group in worldCupGroups)
            {
                Console.WriteLine(group.Key);
                foreach (var team in group.Value)
                {
                    Console.WriteLine(team);
                }
            }

            List<string> carBrands = new List<string>();
            carBrands.Add("Ford");
            carBrands.Add("Audi");
            carBrands.Add("Dodge");
        }
    }
}
