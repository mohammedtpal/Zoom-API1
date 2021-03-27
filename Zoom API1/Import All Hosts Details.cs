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
    public partial class Import_All_Hosts_Details : Form
    {
        ZoomAPI api;
        public Import_All_Hosts_Details()
        {
            InitializeComponent();
            api = new ZoomAPI();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            HostListBox2.Items.Clear();
            int i = 0;
            var uuids = new List<string>();
            int errorCode = 0;
            progressBar_users.Maximum = instructorsTableAdapter.GetData().Count;

            progressBar_users.Value = 0;

            while (i < instructorsTableAdapter.GetData().Count)
            {
                progressBar_users.Value += 1;
                string email = instructorsTableAdapter.GetData().Rows[i].ItemArray[1].ToString();
                errorCode = api.ImportMeetingesDtl(email, progressBar_user_meetinges);
                HostListBox2.Items.AddRange(api.GetLogList());
                Application.DoEvents();
                if (errorCode == 0)
                {
                    break;

                }
                i++;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void progressBar_user_meetinges_Click(object sender, EventArgs e)
        {

        }

        private void progressBar_users_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void instructorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.instructorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gET_HOSTS_FROM_DB_DATASET);

        }

        private void Import_All_Hosts_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gET_HOSTS_FROM_DB_DATASET.instructors' table. You can move, or remove it, as needed.
            this.instructorsTableAdapter.Fill(this.gET_HOSTS_FROM_DB_DATASET.instructors);

        }
    }
}
