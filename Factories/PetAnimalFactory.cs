using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Factories
{
    public class PetAnimalFactory : IAnimalFactory
    {
        public IDog GetDog()
        {
            throw new NotImplementedException();
        }

        public ITiger GetTiger()
        {
            throw new NotImplementedException();
        }
    }
}
