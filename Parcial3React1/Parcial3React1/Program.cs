using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial3React1.Clases;

namespace Parcial3React1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog doggo = new Dog();
            Console.WriteLine("Doggo dice: " + doggo.talk()); // DOG.TALK

            Cat keto = new Cat();
            Console.WriteLine("Keto dice: " + keto.talk()); // CAT.TALK
        }
    }
}
