using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace isrpo_prac1
{
    public partial class Contacts : Form
    {
        public Contacts()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WhiteSpace(textBox1.Text))
                MessageBox.Show("введите имя");
            else if (!File.Exists("contacts.txt"))
                MessageBox.Show("файл отсутствует");
            else
            {
                StreamWriter sw = File.AppendText("contacts.txt");
                sw.WriteLine(maskedTextBox1.Text);
                sw.WriteLine(textBox1.Text);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
