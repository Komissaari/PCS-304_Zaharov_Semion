using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFApp2
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static void Main()
        {
            MessageBox.Show("App2", AppDomain.CurrentDomain.FriendlyName);
            throw new Exception("Исключение в App1");
            MessageBox.Show("App2", "Продолжение");
        }
    }
}
