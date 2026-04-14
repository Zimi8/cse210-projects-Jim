using System;

public class Carpincho : Animal
{
    public Carpincho() : base("Carpincho") {}

    public override void MakeSound()
    {
        Console.WriteLine("Click-click-grunt! (Relaxed semi-aquatic clicking)");
    }
}