using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminder.Forms
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void ButtonCancel(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new MainForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void titleBox(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonCreate(object sender, EventArgs e)
        {

            if(!String.IsNullOrEmpty(textBox2.Text)&&!String.IsNullOrEmpty(textBox1.Text))
            {

            }
            else
            {
                MessageBox.Show("Please write a description and title", "Missing user input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DescriptionBox(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
