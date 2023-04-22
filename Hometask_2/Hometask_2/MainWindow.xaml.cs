using Microsoft.Win32;
using System.Windows;
using System.IO;

namespace Hometask_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_Del(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\User\Desktop\1.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
                MessageBox.Show("Файл удалён!");
            }
            else
            {
                MessageBox.Show("Вероятно файл уже удалён или что-то ещй... :/");
            }
        }
        private void Button_Click_Write(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\User\Desktop\1.txt";
            if (File.Exists(path))
            {
                string str = TB.Text;
                File.AppendAllText(path, str);
                MessageBox.Show("Данные записаны!");
            }
            else
            {
                MessageBox.Show("Что-то сломалось :(");
            }
        }
        private void Button_Click_Read(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\User\Desktop\1.txt";
            string str = File.ReadAllText(path);
            if (str != null)
                MessageBox.Show(str);
            else
                MessageBox.Show("Что-то ты делаешь не правильно... -_-");
        }
        private void Button_Click_Edit(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() != DialogResult)
            {
                TB.Text = File.ReadAllText(openFile.FileName);
            }
        }
        private void Button_Click_Create(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\User\Desktop\1.txt";
            File.Create(path);
            if (File.Exists(path))
                MessageBox.Show("Файл создан!");
            else
                MessageBox.Show("Что-то пошло не так... 0_0");
        }
    }
}
