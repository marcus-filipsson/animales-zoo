using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animales_zoo
{
    class Animal
    {
        public string name;
        public int species;
        public bool canFly;


        public virtual void  IntroduceYourself()
        {
            Console.WriteLine("Morr. Jag är ett djur som heter" + name);
            if (canFly == true)
            {
                Console.WriteLine("I can fly!");
            }
            else
            {
                Console.WriteLine("No can do.. I cannot fly...");
            }
        }
    }
}
