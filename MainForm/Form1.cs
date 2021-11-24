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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            comboBox1.Items.Add(form.RandomID());

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RegistrationForm frm = new RegistrationForm();
            frm.ShowDialog();
          
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Items items = new Items();
            items.ShowDialog(); 
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

    }
}
