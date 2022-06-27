using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern
{
    public class PetTiger : ITiger
    {
        public void AboutMe()
        {
            Console.WriteLine("Wild Tiger says, \"I prefer to play at the zoo. Halum.\"");

        }
    }
}
