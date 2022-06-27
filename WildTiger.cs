using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern
{
    public class WildTiger : ITiger
    {
        public void AboutMe()
        {
            Console.WriteLine("Wild Tiger says, \"I prefer hunting in the jungle. Halum!\"");
        }
    }
}
