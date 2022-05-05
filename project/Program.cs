using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var olivier = new Person();
            Console.WriteLine($"Hello World! {olivier.happyBirthday()}");
        }
    }
}