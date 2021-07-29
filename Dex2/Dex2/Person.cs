using System;
using System.Collections.Generic;
using System.Text;

namespace Dex2
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void WriteLine()
        {
            Console.WriteLine($"Ваш возраст - {Age}, ваше имя - {Name}");
        }

    }
}
