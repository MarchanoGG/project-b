using System;
namespace ProjectB
{
    public class Cat
    {

        string name;
        public Cat(string catsname)
        {
            name = catsname;
        }
        public void Bark()
        {
            Console.WriteLine($"{name} says MEIWU! MEIWU!");
        }
    }
}
