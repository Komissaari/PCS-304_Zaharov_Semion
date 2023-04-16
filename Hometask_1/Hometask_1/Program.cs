using System;
using ExtentionSerialization;
using ExtentionDeSerialization;

namespace Hometask_1
{
    internal class Program
    {
        static void Main()
        {
            Car RussianCar = new Car
            {
                CarBrand = "Lada",
                CarName = "Vesta",
                CarType = "Sedan"
            };
            Car GermanCar = new Car
            {
                CarBrand = "BMW",
                CarName = "X5",
                CarType = "offroader"
            };
            Car JapanCar = new Car
            {
                CarBrand = "Mitsubishi",
                CarName = "L200",
                CarType = "offroader",
            };
            Console.WriteLine(RussianCar.ExtSer<Car>());
            Console.WriteLine(GermanCar.ExtSer<Car>());
            string s = RussianCar.ExtSer<Car>();
            Console.WriteLine(JapanCar.ExtSer<Car>());
            Console.ReadLine();
            //Console.WriteLine(RussianCar.CarBrand + " " + RussianCar.CarName + " " + RussianCar.CarBrand);
            //Console.WriteLine(GermanCar.CarBrand + " " + GermanCar.CarName + " " + GermanCar.CarBrand);
            //Console.WriteLine(JapanCar.CarBrand + " " + JapanCar.CarName + " " + JapanCar.CarBrand);
            Console.WriteLine(s.ExtDeSer<Car>().CarBrand + " " + s.ExtDeSer<Car>().CarName + " " + s.ExtDeSer<Car>().CarType);
            s = GermanCar.ExtSer<Car>();
            Console.WriteLine(s.ExtDeSer<Car>().CarBrand + " " + s.ExtDeSer<Car>().CarName + " " + s.ExtDeSer<Car>().CarType);
            s = JapanCar.ExtSer<Car>();
            Console.WriteLine(s.ExtDeSer<Car>().CarBrand + " " + s.ExtDeSer<Car>().CarName + " " + s.ExtDeSer<Car>().CarType);
            Console.ReadLine();

        }
    }
}
