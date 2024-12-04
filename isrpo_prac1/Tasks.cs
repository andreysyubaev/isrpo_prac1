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
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            accept.Visible = false;

            //comboBox1.Items.AddRange(File.ReadAllLines("profiles.txt", Encoding.Default));
            LoadData();
        }

        private void LoadData()
        {
            string filePath = "contacts.txt";
            string[] lines = File.ReadAllLines(filePath);

            string name = string.Empty;

            foreach (string line in lines)
            {
                if (line.Trim() == "=====")
                {
                    if (!string.IsNullOrEmpty(name))
                    {
                        comboBox1.Items.Add(name);
                    }

                    name = string.Empty;
                }
                else
                {
                    name = line.Trim();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("укажите ответственного");
            else if (WhiteSpace(button2.Text))
                MessageBox.Show("укажите срок");
            else if (WhiteSpace(textBox1.Text))
                MessageBox.Show("укажите задачу");
            else if (!File.Exists("tasks.txt"))
                MessageBox.Show("файл отсутствует");
            else
            {
                StreamWriter sw = File.AppendText("tasks.txt");
                sw.WriteLine(comboBox1.Text);
                sw.WriteLine(button2.Text);
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            accept.Visible = true;
            monthCalendar1.Visible = true;
        }

        private void accept_Click(object sender, EventArgs e)
        {
            DateTime select = monthCalendar1.SelectionStart;


            button2.Visible = true;
            accept.Visible = false;
            monthCalendar1.Visible = false;

            button2.Text = select.ToString("d");
        }
    }
}
