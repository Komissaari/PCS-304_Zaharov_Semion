using System;
using System.Threading;
using Library;

namespace Read
{
    internal class Read
    {
        static void Main()
        {
            while (true)
            {
                Thread.Sleep(1000);
                Console.Clear();
                FileReadWrite.FileRead((Singleton.Get().d_path));
            }
        }
    }
}
