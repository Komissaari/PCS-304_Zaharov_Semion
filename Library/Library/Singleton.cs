﻿using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Library
{
    public class Singleton
    {
        private static Singleton instance;
        public string d_path;
        private Singleton() { }
        [MethodImpl()]
        public static string Get()
        {
            if (instance == null)
            {
                instance = new Singleton();
                string f_path = "C:\\Users\\User\\Documents\\ReadWrite\\config.txt";
                using (FileStream stream = File.OpenRead(f_path))
                {
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);
                    instance.d_path = Encoding.Default.GetString(buffer);
                }
            }
            return instance.d_path;
        }
    }
}
