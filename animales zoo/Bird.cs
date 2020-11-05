using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animales_zoo
{
    class Bird : Animal
    {
        public Bird(string name)
        {
            species = 2;
            canFly = true;
            base.name = name;
        }
    }
}