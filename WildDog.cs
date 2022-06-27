using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern
{
    public class WildDog : IDog
    {
        public void AboutMe()
        {
            Console.WriteLine("Wild Dog says, \"I prefer to roam freely in the jungle. Bow-wow.\"");
        }
    }
}
