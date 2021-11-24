using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class RegistrationForm : Form
    {

        public RegistrationForm()
        {
            InitializeComponent();
 

        }
        public string RandomID()
        {
            Random random = new Random();
            int a = random.Next(1, 500);
            string A = a.ToString();
            string B = "EMP#" + A;
            return B;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        int count = 0;
        

        public void counting()
        {
            if (count == 1)
            {
                button2.Dispose();
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string id = RandomID();
            label7.Text = id;
            count++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
