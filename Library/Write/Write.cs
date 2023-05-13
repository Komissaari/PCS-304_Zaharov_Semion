using Library;
using System;
using System.Threading;

namespace Write
{
    internal class Write
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
            Console.WriteLine(Singleton.Get());
            while (true)
            {
                Thread.Sleep(1000);
                FileReadWrite.FileNotReWrite((Singleton.Get()), RussianCar.CarBrand);
                FileReadWrite.FileNotReWrite((Singleton.Get()), "\t");
                FileReadWrite.FileNotReWrite((Singleton.Get()), RussianCar.CarName);
                FileReadWrite.FileNotReWrite((Singleton.Get()), "\t");
                FileReadWrite.FileNotReWrite((Singleton.Get()), RussianCar.CarType);
                FileReadWrite.FileNotReWrite((Singleton.Get()), "\n");
                FileReadWrite.FileNotReWrite((Singleton.Get()), GermanCar.CarBrand);
                FileReadWrite.FileNotReWrite((Singleton.Get()), "\t");
                FileReadWrite.FileNotReWrite((Singleton.Get()), GermanCar.CarName);
                FileReadWrite.FileNotReWrite((Singleton.Get()), "\t");
                FileReadWrite.FileNotReWrite((Singleton.Get()), GermanCar.CarType);
                FileReadWrite.FileNotReWrite((Singleton.Get()), "\n");
                FileReadWrite.FileNotReWrite((Singleton.Get()), JapanCar.CarBrand);
                FileReadWrite.FileNotReWrite((Singleton.Get()), "\t");
                FileReadWrite.FileNotReWrite((Singleton.Get()), JapanCar.CarName);
                FileReadWrite.FileNotReWrite((Singleton.Get()), "\t");
                FileReadWrite.FileNotReWrite((Singleton.Get()), JapanCar.CarType);
                FileReadWrite.FileNotReWrite((Singleton.Get()), "\n");
            }
        }
    }
}
