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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public string RandomID()
        {
            Random random = new Random();
            int a = random.Next(1,500);
            string A = a.ToString();
            string B = "EMP#" + A;
            return B;
        }
        
        private void label7_Click(object sender, EventArgs e)
        {
           

        }
        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
        int count = 0;
   
        private void button2_Click(object sender, EventArgs e)
        {
            string id = RandomID();
            label7.Text = id;
            count++;
        }
        public void counting() 
        {
            if (count == 1)
            {
                button2.Dispose();  
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            this.Hide();
            this.Dispose();
            Form1 form = new Form1();
            form.ShowDialog();

          
        }
    }
}
