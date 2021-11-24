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

namespace MainForm
{
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "generic-food.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<Products> LoadCSV(string csvFile)
        {
            var query = from l in File.ReadAllLines(csvFile)
                        let data = l.Split(',')
                        select new Products
                        {
                            FoodName = data[0],
                            ScientificName = data[1],
                            Group = data[2],
                            SubGroup = data[3],
                            Rates =  data[4],

                        };

            return query.ToList();


        }



        private void button5_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            fileNameTB.Text = openFileDialog1.FileName;
            //ndData(fileNameTB.Text);
            dataGridView1.DataSource = LoadCSV(fileNameTB.Text);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Items_Load(object sender, EventArgs e)
        {
            dataGridView1.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddToCSV(FoodtextBox.Text, ScientifictextBox.Text, GrouptextBox.Text, SubGrouptextBox.Text, RatestextBox.Text, fileNameTB.Text);
          
        }

        public void AddToCSV(string food, string sname, string group, string subgroup, string rate, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    file.WriteLine(food + "," + sname + "," + group + "," + subgroup + "," + rate);

                }
                MessageBox.Show("Added to CSV Successfully", "Success");

            }
            catch (Exception ex)
            {
                throw new ApplicationException("this program did an OOPSIE", ex);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }


    public class Products
    {
        public string FoodName { get; set; }
        public string ScientificName { get; set; }
        public string Group { get; set; }
        public string SubGroup { get; set; }
        public string Rates { get; set; }
    }
}
