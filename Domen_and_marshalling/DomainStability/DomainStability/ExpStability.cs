using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainStability
{
    class ExpStability : MarshalByRefObject
    {
        public void Operation1()
        {
            Console.WriteLine("ExpStability.Operation1 {0}", this.GetHashCode());
            throw new Exception("Ошибка в методе Operation1");
        }
        public void Operation2()
        {
            Console.WriteLine("ExpStability.Operation2 {0}", this.GetHashCode());
           
        }
    }
}
