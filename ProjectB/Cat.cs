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
        public void Tobias(string name = "Tobias")
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
