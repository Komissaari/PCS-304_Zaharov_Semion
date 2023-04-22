using System;
using _Motor_;

namespace Laba_3
{
    internal partial class Program
    { 
    
    static void Main(string[] args)
    {
        Motor motor = new Motor();
        motor._Event += () => Console.WriteLine("Электричество"); 
        motor._Event += () => Console.WriteLine("Бензин");
        motor._Event += () => Console.WriteLine("Дизель");
        motor.Event(); 
        Console.ReadKey();
    }
    }
}
