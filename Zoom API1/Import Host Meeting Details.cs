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
    public partial class Import_Host_Meeting_Details : Form
    {
        ZoomAPI api;
        public Import_Host_Meeting_Details()
        {
            InitializeComponent();
            api = new ZoomAPI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HostProgressBar2.Value = 0;
            HostListBox2.Items.Clear();
            api.ImportMeetingesDtl(comboBox1.SelectedValue.ToString(), HostProgressBar2);
            HostListBox2.Items.AddRange(api.GetLogList());
            Application.DoEvents();
        }

        private void Import_Host_Meeting_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gET_HOSTS_FROM_DB_DATASET.instructors' table. You can move, or remove it, as needed.
            this.instructorsTableAdapter.Fill(this.gET_HOSTS_FROM_DB_DATASET.instructors);
            // TODO: This line of code loads data into the 'gET_HOSTS_FROM_DB_DATASET.instructors' table. You can move, or remove it, as needed.
            // this.instructorsTableAdapter1.Fill(this.gET_HOSTS_FROM_DB_DATASET.instructors);
            // TODO: This line of code loads data into the 'zoomDataSet4.instructors' table. You can move, or remove it, as needed.
            // this.instructorsTableAdapter.Fill(this.zoomDataSet4.instructors);
            comboBox1.AutoCompleteCustomSource = api.GetInstructorData();

        }
    }
}
