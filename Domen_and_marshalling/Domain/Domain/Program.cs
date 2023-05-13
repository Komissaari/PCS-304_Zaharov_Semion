using System;
using System.Reflection;
using System.Runtime.Remoting;

namespace Domain
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Метод Main выполняетс в домене: {0}", AppDomain.CurrentDomain.Id); //выводим id домена 
            AppDomain domain = AppDomain.CreateDomain("Second Domain"); //создание второго домена и присваиваваем ему "дружеское имя" Second Domain
            string assemblyName = Assembly.GetExecutingAssembly().GetName().Name; //получаем имя выполняющийся сборки (короткое)
            string teypeName = typeof(DomainCount).FullName; //получаем имя экземпляра класса DomainCount

            //начала содания экземпляра класса во вторичном домене
            ObjectHandle handle = domain.CreateInstance(assemblyName, teypeName); //создание объекта во втором домене с помощью специального объекта (прокси-переходника) данные получаются
            //за счёт мехнизма рефлексии 

            DomainCount instanse = handle.Unwrap() as DomainCount; //создание прозрачного прокси-переходника для взаимодействия с объектом во втором домене 
            //в общем благодаря этому мы можем пользоваться данным классом handle это что-то вроде обёртки нашего класса

            Console.WriteLine("istance {0}", instanse.GetHashCode()); //хэш код экземпляра класса DomainCount
            Console.WriteLine("Проверяем прозрачность прокси-переходника: {0}", RemotingServices.IsTransparentProxy(instanse));
            instanse.Operation(); //вызов метода втором домене
            Console.ReadKey();
        }
    }
}
