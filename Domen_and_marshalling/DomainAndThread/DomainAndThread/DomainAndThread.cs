using System;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.Remoting;
using System.Threading;


namespace DomainAndThread
{
    internal class DomainAndThread
    {

        static void Main()
        {
            AppDomain domain = AppDomain.CreateDomain("Second Domain");
            string assemblyName = Assembly.GetExecutingAssembly().GetName().Name; //получаем имя выполняющийся сборки (короткое)
            string teypeName = typeof(DomAndThr).FullName;
            ObjectHandle handle = domain.CreateInstance(assemblyName, teypeName);
            DomAndThr instance = handle.Unwrap() as DomAndThr;
            Console.WriteLine("Operation DomainID: {0}", AppDomain.CurrentDomain.Id);
            Console.WriteLine("Operation ThreadID: {0}", Thread.CurrentThread.ManagedThreadId);
            instance.Operation();
            Console.ReadKey();
        }
    }
}
