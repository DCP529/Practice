using System;

namespace Dex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person() { Name = "Василий", Age = 15 };

            var friend1 = new Friend() { Name = "Bob", Age = 22};

            var coulegue1 = new Coleague() { Name = "Лев", Age = 1231654561};

            Person[] people = new Person[] {person1, friend1, coulegue1 };

            foreach (var item in people)
            {
                item.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
