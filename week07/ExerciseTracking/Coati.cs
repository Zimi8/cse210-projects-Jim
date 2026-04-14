using System;

public class Coati : Animal
{
    public Coati() : base("Coatí") {}

    public override void MakeSound()
    {
        Console.WriteLine("Squeak-chirp! ");
    }
}