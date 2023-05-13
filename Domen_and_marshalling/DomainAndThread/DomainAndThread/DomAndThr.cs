using System;
using System.Threading;

namespace DomainAndThread
{
    class DomAndThr:MarshalByRefObject
    {
        public void Operation()
        {
            Console.WriteLine("Operation DomainID: {0}", AppDomain.CurrentDomain.Id);
            Console.WriteLine("Operation ThreadID: {0}", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
