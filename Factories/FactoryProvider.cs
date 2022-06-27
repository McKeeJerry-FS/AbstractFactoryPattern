using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.Factories;

namespace AbstractFactoryPattern.Factories
{
    public class FactoryProvider
    {
        public static IAnimalFactory GetAnimalFactory(string factoryType)
        {
            if (factoryType.Contains("wild"))
            {
                // returning a WildAnimalFactory
                return new WildAnimalFactory();
            }
            else if (factoryType.Contains("pet"))
            {
                // returning a PetAnimalFactory
                return new PetAnimalFactory();
            }
            else
            {
                throw new ArgumentException("You need to pass either wild or pet as an argument.");
            }
        }
    }
}
