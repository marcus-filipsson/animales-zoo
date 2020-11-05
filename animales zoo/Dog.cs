﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animales_zoo
{
    class Dog : Animal
    {
        public Dog(string name)
        {
            species = 1;
            canFly = false;
            base.name = name;

        }
        public override void IntroduceYourself()
        {
            Console.WriteLine("Vov. Jag är en hund som heter" + name);
            base.IntroduceYourself();
        }
    }
}
