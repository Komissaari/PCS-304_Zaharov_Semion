using System;
using System.Windows.Forms;

namespace WFApp1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static void Main()
        {
            MessageBox.Show("App1", AppDomain.CurrentDomain.FriendlyName);
            throw new Exception("Исключение в App1");
            MessageBox.Show("App1", "Продолжение");
        }
    }
}
