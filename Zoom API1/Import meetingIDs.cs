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
    public partial class Import_meetings : Form
    {
        ZoomAPI api;

        public Import_meetings()
        {
            InitializeComponent();
            api = new ZoomAPI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Import_meetingsListBox.Items.Clear();
            progressBar1.Value = 0;
            api.ImportMeetingesIDs(FromdateTimePicker1.Value, TodateTimePicker2.Value, progressBar1);
            Import_meetingsListBox.Items.AddRange(api.GetLogList());
            Application.DoEvents();

        }

        private void DeleteMeetinges_btn_Click(object sender, EventArgs e)
        {
            try
            {
               
                int result;
                result = api.deleteMeetinges();
                if (result == 1)
                    MessageBox.Show("Delete Done");
                else
                    MessageBox.Show("Delete Done", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FromdateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TodateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
