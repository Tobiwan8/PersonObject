using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Konrad";
            person1.DoB = new DateTime(1990, 3, 2);
            person1.Email = "konrad@email.com";
            person1.Password = "HejKonrad1990";

            Person person2 = new Person();
            person2.Name = "Connie";
            person2.DoB = new DateTime(1991, 9, 16);
            person2.Email = "connie@email,com";
            person2.Password = "HejConnie1991";

            Person person3 = new Person();
            person3.Name = "Bent";
            person3.DoB = new DateTime(1971, 5, 27);
            person3.Email = "bent@email.com";
            person3.Password = "hejbent1971";

            Person person4 = new Person();
            person4.Name = "Bitten";
            person4.DoB = new DateTime(1974, 12, 24);
            person4.Email = "bitten@email.com";
            person4.Password = "HejBitten";

            Console.WriteLine("\n" + person1.Name);
            Console.WriteLine(person1.Age);
            Console.WriteLine(person1.Email);
            Console.WriteLine(person1.Password);

            Console.ReadKey();
        }
    }
}
