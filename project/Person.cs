using System;

namespace HelloWorld
{
    public class Person
    {
        public int age { get; set; }
        public string gender { get; set; }
        public string happyBirthday()
        {
            return "Happy birthday!";
        }
    }
}