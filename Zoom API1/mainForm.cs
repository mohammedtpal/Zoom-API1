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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        

        private void meetingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //meetinges meetinge = new meetinges();
            //meetinge.TopMost = true;
            //meetinge.Show();

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtnGroup1.Visible= !(BtnGroup1.Visible);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Visible = !(panel2.Visible);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel3.Visible = !(panel3.Visible);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Auoth a = new Auoth();
            a.TopMost = true;
            a.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Import_meetings i = new Import_meetings();
            i.TopMost = true;
            i.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            Import_Host_Meeting_Details i = new Import_Host_Meeting_Details();
            i.TopMost = true;
            i.Show();
        }
    }
}
