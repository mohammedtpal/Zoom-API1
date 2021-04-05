using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoom_API1
{
 
    public partial class Pau_user_percent : Form
    {
        ZoomAPI api;
        public Pau_user_percent()
        {
            InitializeComponent();
            api = new ZoomAPI();
        }

        

        private void test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gET_HOSTS_FROM_DB_DATASET.instructors' table. You can move, or remove it, as needed.
            this.instructorsTableAdapter.Fill(this.gET_HOSTS_FROM_DB_DATASET.instructors);
            comboBox2.AutoCompleteCustomSource = api.GetInstructorData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
 Double percent = Convert.ToDouble( textBox1.Text);
            this.pAU_Final_Percent_ReportTableAdapter.Fill(this.gET_HOSTS_FROM_DB_DATASET.PAU_Final_Percent_Report, FromTimePicker1.Value, TodateTimePicker1.Value, percent, comboBox2.SelectedValue.ToString());

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                throw;
            }
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FromTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TodateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
