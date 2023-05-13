using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainException
{
    class _Exception : MarshalByRefObject
    {
        public void Exp()
        {
            throw new Exception("Ошибка в методе Operation");
        }
    }
}
