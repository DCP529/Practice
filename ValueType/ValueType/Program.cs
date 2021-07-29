using System;

namespace ValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            #region struct and class
            var sergey = new Person() { Name = "Bob", Age = 22 };

            var accaunt1 = new Accaunt() { AccauntId = 1, person = sergey };
            var accaunt2 = accaunt1;

            accaunt2.AccauntId = 2;
            accaunt2.person.Name = "Jane";
            #endregion

            Person andrey = new Person() { Name = "Andrey", Age = 10 };
            Person anatolii = RenamePerson(andrey);

            int a = 2;
            int bb = 1;

            Calc(a, bb);
                        
            Console.ReadLine();
        }

        public static object Calc(object a, object b)
        {
            return (int)a + (int)b;
        }
        public static Person RenamePerson(Person person)
        {
            // person.Name = "Vova";
            person = new Person() { Name = "Vova" };
            return person;
        }
    }
}
