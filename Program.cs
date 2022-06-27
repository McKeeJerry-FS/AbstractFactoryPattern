using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.Factories;

namespace AbstractFactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Abstract Factory Pattern Demo ***");
            // Making Wild Dog and Wild Tiger through WildAnimalFactory
            IAnimalFactory animalFactory = FactoryProvider.GetAnimalFactory("wild");
            IDog dog = animalFactory.GetDog();
            ITiger tiger = animalFactory.GetTiger();    
            dog.AboutMe();
            tiger.AboutMe();
            Console.WriteLine("****************************");
            // Making Pet Dog and Pet Tiger through PetFactory now
            animalFactory = FactoryProvider.GetAnimalFactory("pet");
            dog = animalFactory.GetDog();
            tiger = animalFactory.GetTiger();
            dog.AboutMe();
            tiger.AboutMe();

            Console.ReadKey();
        }
    }
}