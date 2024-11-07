using System;
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading; 
using System.Threading.Tasks; 


class KittenTest
{
    static int space = 20;
    
    public static void Main (string[] args)
    {
        Random r = new Random(); 
        int seed = r;
        Random rnd = new Random(seed);
        Kitten[] kittens = new Kitten[space];

        Console.WriteLine("Kittens are scaled from 0 to 1");

        for (int i = 0; i < space; i++)
        {
            double cute = rnd.NextDouble();
            kittens [i] = new Kitten("Kitten #"+i, Math.Round(cute, 2));
        }

        foreach (Kitten kitten in kittens)
        {
            Console.WriteLine (kitten.name + " is " + kitten.GetCuteness() + " on the cuteness scale");
        }
    }
}

class Animal
{
    public string name;
    public Animal (string name){
    this.name = name;
    }
}

class Kitten : Animal
{
    private double Cuteness;
    public static int count;
    public Kitten(string name, double Cuteness) : base(name)
    {
        this.Cuteness = Cuteness;
        count++;
    } 
    public double GetCuteness()
    {
        return Cuteness;
    } 
}

