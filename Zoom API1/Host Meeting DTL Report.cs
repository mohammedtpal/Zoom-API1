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
    public partial class Host_Meeting_DTL_Report : Form
    {
        ZoomAPI api;
        public Host_Meeting_DTL_Report()
        {
            InitializeComponent();
            api = new ZoomAPI();

        }

        private void Host_Meeting_DTL_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gET_HOSTS_FROM_DB_DATASET.instructors' table. You can move, or remove it, as needed.
            this.instructorsTableAdapter.Fill(this.gET_HOSTS_FROM_DB_DATASET.instructors);
            comboBox2.AutoCompleteCustomSource = api.GetInstructorData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.hostMeetingsAggregateReportTableAdapter.Fill(this.zoomDataSet2.HostMeetingsAggregateReport, FromTimePicker1.Value, comboBox2.SelectedValue.ToString(), TodateTimePicker1.Value);
            this.hostMeetingsDtlReportTableAdapter.Fill(this.zoomDataSet3.HostMeetingsDtlReport, comboBox2.SelectedValue.ToString(), FromTimePicker1.Value, TodateTimePicker1.Value);

        }

       
    }
}
