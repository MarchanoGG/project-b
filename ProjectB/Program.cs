using System;

namespace ProjectB
{
    class Program
    {
        static void Main(string[] args)
        {

            Cat kat = new Cat("kat");

            kat.Bark();

            Car renault = new Renault();

            renault.GiveGass();

        }
    }
}