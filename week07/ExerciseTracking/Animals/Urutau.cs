using System;

public class Urutau : Animal
{
    public Urutau() : base("Urutaú") {}

    public override void MakeSound()
    {
        Console.WriteLine("Uuu-u-u-u... (Melancholic, ghost-like cry of the rainforest)");
    }
}