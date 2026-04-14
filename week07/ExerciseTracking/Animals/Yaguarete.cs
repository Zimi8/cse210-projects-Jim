using System;

public class Yaguarete : Animal
{
    public Yaguarete() : base("Yaguareté") {}

    public override void MakeSound()
    {
        Console.WriteLine("Grrr! (Deep, powerful jungle roar)");
    }
}