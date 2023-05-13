using System;

namespace Domain
{
    //[Serializable]
    class DomainCount :MarshalByRefObject
    {
        public void Operation()
        {
            Console.WriteLine("Метод Operation выполняется в домене под номером: {0}", AppDomain.CurrentDomain.Id); //выводим id домена
            Console.WriteLine("istance {0}", this.GetHashCode()); //хэш код экземпляра класса DomainCount
        }
    }
}