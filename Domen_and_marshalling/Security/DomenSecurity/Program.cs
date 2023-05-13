using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DomenSecurity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDomain domain = AppDomain.CreateDomain("Second Domain");
            Zone[] hostEvidence = { new Zone(SecurityZone.Internet) }; //MyComputer
            Evidence evidence = new Evidence(hostEvidence, null);
            try
            {
                domain.ExecuteAssembly("Security.exe", evidence);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
