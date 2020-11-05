using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animales_zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] allAnimals;

            allAnimals = new Animal[3];
            /*           Cat c = new Cat();
                       c.name = "Kurre";*/
            allAnimals[0] = new Cat("Kurre");
            allAnimals[1] = new Dog("Vilma");
            allAnimals[2] = new Cat("Bamse");

            foreach (Animal a in allAnimals)
            {
                Console.WriteLine("Nu kommer" + a.name);
                a.IntroduceYourself();
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
