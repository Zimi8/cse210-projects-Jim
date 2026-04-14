using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> natureReserve = new List<Animal>();

        natureReserve.Add(new Yaguarete());
        natureReserve.Add(new Carpincho());
        natureReserve.Add(new Urutau());
        natureReserve.Add(new Coati());

        Console.WriteLine("Argentinian Wildlife Sounds:");
        Console.WriteLine("----------------------------");

        foreach (Animal animal in natureReserve)
        {
            Console.Write($"{animal.GetName()} says: ");
        
            animal.MakeSound();
        }
    }
}