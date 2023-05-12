using System;
namespace Laba_2
{
    internal class Program
    {
        static void Main()
        {
            NewCar RussiaCar = new NewCar
            {
                CarBrand = "Lada",
                CarName = "Vesta",
                CarYear = 2000
            };
            RussiaCar.Val();
            Console.ReadLine();
            NewCar GermanCar = new NewCar
            {
                CarBrand = "MTU",
                CarName = "Schutzenpanzer",
                CarYear = 1890
            };
            GermanCar.Val();

        }
    }
}
