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
            Console.WriteLine(Singleton.Get().d_path);
            while (true)
            {
                Thread.Sleep(1000);
                FileReadWrite.FileNotReWrite((Singleton.Get().d_path), RussianCar.CarBrand);
                FileReadWrite.FileNotReWrite((Singleton.Get().d_path), "\t");
                FileReadWrite.FileNotReWrite((Singleton.Get().d_path), RussianCar.CarName);
                FileReadWrite.FileNotReWrite((Singleton.Get().d_path), "\t");
                FileReadWrite.FileNotReWrite((Singleton.Get().d_path), RussianCar.CarType);
                FileReadWrite.FileNotReWrite((Singleton.Get().d_path), "\n");
                FileReadWrite.FileNotReWrite((Singleton.Get().d_path), GermanCar.CarBrand);
                FileReadWrite.FileNotReWrite((Singleton.Get().d_path), "\t");
                FileReadWrite.FileNotReWrite((Singleton.Get().d_path), GermanCar.CarName);
                FileReadWrite.FileNotReWrite((Singleton.Get().d_path), "\t");
                FileReadWrite.FileNotReWrite((Singleton.Get().d_path), GermanCar.CarType);
                FileReadWrite.FileNotReWrite((Singleton.Get().d_path), "\n");
                FileReadWrite.FileNotReWrite((Singleton.Get().d_path), JapanCar.CarBrand);
                FileReadWrite.FileNotReWrite((Singleton.Get().d_path), "\t");
                FileReadWrite.FileNotReWrite((Singleton.Get().d_path), JapanCar.CarName);
                FileReadWrite.FileNotReWrite((Singleton.Get().d_path), "\t");
                FileReadWrite.FileNotReWrite((Singleton.Get().d_path), JapanCar.CarType);
                FileReadWrite.FileNotReWrite((Singleton.Get().d_path), "\n");
            }
        }
    }
}
