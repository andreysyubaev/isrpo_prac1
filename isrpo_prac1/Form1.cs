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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;

            profileListBox.Items.AddRange(File.ReadAllLines("profiles.txt", Encoding.Default));
            tasksListBox.Items.AddRange(File.ReadAllLines("tasks.txt", Encoding.Default));
            contactsListBox.Items.AddRange(File.ReadAllLines("contacts.txt", Encoding.Default));

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {

        }

        private void changeToOrange_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
            panel4.Visible = false;
        }

        private void changeToBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            panel4.Visible = false;
        }

        private void changeToGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            panel4.Visible = false;
        }

        private void changeToWhite_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            panel4.Visible = false;
        }

        private void addContacts_Click(object sender, EventArgs e)
        {
            Contacts newForm = new Contacts();
            newForm.ShowDialog();
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void addProfile_Click(object sender, EventArgs e)
        {
            register newForm = new register();
            newForm.ShowDialog();
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            Tasks newForm = new Tasks();
            newForm.ShowDialog();
        }

        private void addTask_Click_1(object sender, EventArgs e)
        {
            Tasks newForm = new Tasks();
            newForm.ShowDialog();
        }

        private void clearProfiles_Click(object sender, EventArgs e)
        {
            File.WriteAllText("profiles.txt", string.Empty);
            MessageBox.Show("успех!");
        }

        private void clearTasks_Click(object sender, EventArgs e)
        {
            File.WriteAllText("tasks.txt", string.Empty);
            MessageBox.Show("успех!");
        }

        private void clearContacts_Click(object sender, EventArgs e)
        {
            File.WriteAllText("cpntacts.txt", string.Empty);
            MessageBox.Show("успех!");
        }

        private void profileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
