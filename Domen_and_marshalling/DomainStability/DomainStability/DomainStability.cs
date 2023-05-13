using System;
using System.Reflection;
using System.Runtime.Remoting;


namespace DomainStability
{
    internal class DomainStability
    {
        static void Main()
        {
            AppDomain domain = AppDomain.CreateDomain("SeconDomain");
            string assemblyName = Assembly.GetExecutingAssembly().GetName().Name; //получаем имя выполняющийся сборки (короткое)
            string teypeName = typeof(ExpStability).FullName; //получаем имя экземпляра класса DomainCount
            ObjectHandle handle = domain.CreateInstance(assemblyName, teypeName);
            ExpStability instance = handle.Unwrap() as ExpStability;
            try
            {
                instance.Operation1();
            }
            catch(Exception e)
            {
                Console.WriteLine("e.Message: {0}", e.Message);
            }
            instance.Operation2();
            Console.ReadKey();
        }
    }
}
