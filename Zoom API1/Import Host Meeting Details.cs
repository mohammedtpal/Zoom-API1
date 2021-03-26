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
    }
}
