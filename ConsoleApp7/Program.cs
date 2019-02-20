using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ConsoleApp7
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//}


//namespace ConsoleApp7
//{
//    class Program
//    {
//        class Person
//        {
//            private readonly int age;
//            public Person()
//            {
//                Console.WriteLine("Hi there");
//            }
//        }
//        static void Main(string[] args)
//        {
//            Person p = new Person();
//        }
//    }
//}


namespace ConsoleApp7
{
    class Program
    {
        class Person
        {
            private int age;
            private string name;
            public Person(string nm)
            {
                name = nm;
            }
            public string getName()
            {
                return name;
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person("David");
            Console.WriteLine(p.getName());
        }
    }
}
