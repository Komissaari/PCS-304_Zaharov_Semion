using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultyDomain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDomain domain1 = AppDomain.CreateDomain("Domain 1");
            AppDomain domain2 = AppDomain.CreateDomain("Domain 2");

            try
            {
                domain1.ExecuteAssembly("WFApp1.exe");
                domain1.ExecuteAssembly("WFApp2.exe");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\nГлавный домен работоспособен {0}", AppDomain.CurrentDomain.FriendlyName);
            Console.ReadKey();

        }
    }
}
