using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel1 person = new PersonModel1
            {
                FirstName = "Mike",
                LastName = "Shodamola",
                Email = "mike@micheal.com",

            };

            Console.WriteLine(person);

            Console.ReadLine();
        }
    }

}
