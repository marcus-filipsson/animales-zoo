using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animales_zoo
{
    class Cat : Animal
    {
        public Cat(string name)
        {
            species = 0;
            canFly = false;
            base.name = name;
        }
        public override void IntroduceYourself()
        {
            Console.WriteLine("Mjau. Jag är en cat som heter" + name);
            base.IntroduceYourself()
        }
    }
}
