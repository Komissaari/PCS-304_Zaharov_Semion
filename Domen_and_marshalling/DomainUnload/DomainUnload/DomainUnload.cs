using System;


namespace DomainUnload
{
    internal class DomainUnload
    {
        static void Main()
        {
            AppDomain domain = AppDomain.CreateDomain("SeconDomain");
            Console.WriteLine("Головной домен: " + AppDomain.CurrentDomain.FriendlyName);
            Console.WriteLine("Дочерний домен: " + domain.FriendlyName);
            AppDomain.Unload(domain); //выгрузка домена

            try
            {
                Console.WriteLine("Головной домен: " + AppDomain.CurrentDomain.FriendlyName);
                Console.WriteLine("Дочерний домен: " + domain.FriendlyName);
            }
            catch(AppDomainUnloadedException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
