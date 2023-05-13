using System;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting;


namespace DomainException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDomain domain = AppDomain.CreateDomain("SeconDomain");
            domain.FirstChanceException += Domain_FirstChanceException; //создаём событие обработика ошибки

            string assemblyName = Assembly.GetExecutingAssembly().GetName().Name; //получаем имя выполняющийся сборки (короткое)
            string teypeName = typeof(_Exception).FullName; //получаем имя экземпляра класса DomainCount
            ObjectHandle handle = domain.CreateInstance(assemblyName, teypeName);
            _Exception instanse = handle.Unwrap() as _Exception;

            try
            {
                instanse.Exp();
            }
            catch(Exception e)
            {
                Console.WriteLine("\nОброботчик исключений try-catch");
                Console.WriteLine("Исключение возникло в домен: {0}", domain.FriendlyName);
                Console.WriteLine("e.Message: {0}", e.Message);
            }
            Console.WriteLine("\nДомен {0} работоспособен.", AppDomain.CurrentDomain.FriendlyName);
            Console.WriteLine("Домен {0} работоспособен.", domain.FriendlyName);
        }

        static void Domain_FirstChanceException(object sender,FirstChanceExceptionEventArgs e)
        {
            AppDomain domain = sender as AppDomain;

            Console.WriteLine("Оброботчик события FirstChanceException");
            Console.WriteLine("Исключение возникло в домен: {0}", domain.FriendlyName);
            Console.WriteLine("e.Exception.Message: ", e.Exception);
        }
    }
}
