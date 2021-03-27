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

namespace Zoom_API1
{
    public partial class Host_Meeting_Aggregation_Report : Form
    {
        ZoomAPI api;
        public Host_Meeting_Aggregation_Report()
        {
            InitializeComponent();
            api = new ZoomAPI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.hostMeetingsAggregateReportTableAdapter.Fill(this.gET_HOSTS_FROM_DB_DATASET.HostMeetingsAggregateReport, FromTimePicker1.Value, comboBox2.SelectedValue.ToString(), TodateTimePicker1.Value);
            this.hostMeetingsAggregateReportTableAdapter.Fill(this.gET_HOSTS_FROM_DB_DATASET.HostMeetingsAggregateReport, FromTimePicker1.Value, comboBox2.SelectedValue.ToString(), TodateTimePicker1.Value);
        }

        private void Host_Meeting_Aggregation_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gET_HOSTS_FROM_DB_DATASET.instructors' table. You can move, or remove it, as needed.
            this.instructorsTableAdapter.Fill(this.gET_HOSTS_FROM_DB_DATASET.instructors);
            // TODO: This line of code loads data into the 'gET_HOSTS_FROM_DB_DATASET.instructors' table. You can move, or remove it, as needed.
            this.instructorsTableAdapter.Fill(this.gET_HOSTS_FROM_DB_DATASET.instructors);
            comboBox2.AutoCompleteCustomSource = api.GetInstructorData();
        }

        private void instructorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.instructorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gET_HOSTS_FROM_DB_DATASET);

        }
        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(28596);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
         
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                ToCsV(hostMeetingsAggregateReportDataGridView, sfd.FileName); // Here dataGridview1 is your grid view name
            }
        }
    }
}
