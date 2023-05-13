using System;
using System.IO;
using System.Windows.Forms;

namespace Security
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Привет, мир!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream stream = File.Create(@"C:\Virus.exe");
            MessageBox.Show("Файл создан!");
        }
    }
}
