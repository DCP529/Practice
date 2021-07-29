using System;
using System.Collections.Generic;
using System.Text;

namespace Dex2
{
    class Coleague : Person
    {
        public override void WriteLine()
        {
            Console.WriteLine($"Ваше имя - {Name}, ваш возраст - {Age} ");
        }
    }
}
