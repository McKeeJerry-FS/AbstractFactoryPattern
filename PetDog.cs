using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern
{
    public class PetDog : IDog
    {
        public void AboutMe()
        {
            Console.WriteLine("Pet Dog says, \"I prefer to stay at home. Bow-wow.\"");

        }
    }
}
