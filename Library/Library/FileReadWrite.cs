using System;
using System.IO;
using System.Text;


namespace Library
{
    public class FileReadWrite
    {
        public static string FileRead(string d_path)
        {
            using (FileStream fileStream = File.OpenRead(d_path))
            {
                byte[] buffer = new byte[fileStream.Length];
                fileStream.Read(buffer, 0, buffer.Length);
                string contentFile = Encoding.Default.GetString(buffer);
                Console.WriteLine($"Содержимое файла: {contentFile} \n");
                return contentFile;
            }
        }
        public static void FileWrite(string d_path, string input)
        {
            if (File.Exists(d_path))
            {
                using (FileStream fileStream = new FileStream(d_path, FileMode.Truncate))
                {
                    byte[] buffer = Encoding.Default.GetBytes(input);
                    fileStream.Write(buffer, 0, buffer.Length);
                }
            }
            else
            {
                using (FileStream fileStream = new FileStream(d_path, FileMode.Create))
                {
                    byte[] buffer = Encoding.Default.GetBytes(input);
                    fileStream.Write(buffer, 0, buffer.Length);
                }
            }
        }
        public static void FileNotReWrite(string d_path, string input)
        {

            using (FileStream fileStream = new FileStream(d_path, FileMode.Append))
            {
                byte[] buffer = Encoding.Default.GetBytes(input);
                fileStream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
