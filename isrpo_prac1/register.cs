using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace isrpo_prac1
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WhiteSpace(surnameTextBox.Text))
                MessageBox.Show("введите фамилию");
            else if (WhiteSpace(textBox1.Text))
                MessageBox.Show("введите имя");
            else if (WhiteSpace(textBox2.Text))
                MessageBox.Show("введите логин");
            else if (WhiteSpace(textBox3.Text))
                MessageBox.Show("введите пароль");
            else if (WhiteSpace(textBox4.Text))
                MessageBox.Show("введите почту");
            else if (!File.Exists("profiles.txt"))
                MessageBox.Show("файл отсутствует");
            else
            {
                StreamWriter sw = File.CreateText("profiles.txt");
                sw.WriteLine(surnameTextBox.Text);
                sw.WriteLine(textBox1.Text);
                sw.WriteLine(textBox2.Text);
                sw.WriteLine(textBox3.Text);
                sw.WriteLine(textBox4.Text);
                sw.WriteLine("=====");
                sw.Close();
                MessageBox.Show("успех!");
            }
            
        }

        public bool WhiteSpace(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsWhiteSpace(text[i]))
                    return true;
            }
            return false;
        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
