
namespace Zoom_API1
{
    partial class Import_meetings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteMeetinges_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FromdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TodateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Import_meetingsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 106);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "Import Meetings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteMeetinges_btn
            // 
            this.DeleteMeetinges_btn.Enabled = false;
            this.DeleteMeetinges_btn.Location = new System.Drawing.Point(364, 106);
            this.DeleteMeetinges_btn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteMeetinges_btn.Name = "DeleteMeetinges_btn";
            this.DeleteMeetinges_btn.Size = new System.Drawing.Size(114, 28);
            this.DeleteMeetinges_btn.TabIndex = 15;
            this.DeleteMeetinges_btn.Text = "Delete Meetinges";
            this.DeleteMeetinges_btn.UseVisualStyleBackColor = true;
            this.DeleteMeetinges_btn.Click += new System.EventHandler(this.DeleteMeetinges_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pages:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(61, 197);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(470, 19);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "To";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "From";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FromdateTimePicker1
            // 
            this.FromdateTimePicker1.Location = new System.Drawing.Point(75, 27);
            this.FromdateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.FromdateTimePicker1.Name = "FromdateTimePicker1";
            this.FromdateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.FromdateTimePicker1.TabIndex = 9;
            this.FromdateTimePicker1.ValueChanged += new System.EventHandler(this.FromdateTimePicker1_ValueChanged);
            // 
            // TodateTimePicker2
            // 
            this.TodateTimePicker2.Location = new System.Drawing.Point(328, 27);
            this.TodateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.TodateTimePicker2.Name = "TodateTimePicker2";
            this.TodateTimePicker2.Size = new System.Drawing.Size(151, 20);
            this.TodateTimePicker2.TabIndex = 10;
            this.TodateTimePicker2.ValueChanged += new System.EventHandler(this.TodateTimePicker2_ValueChanged);
            // 
            // Import_meetingsListBox
            // 
            this.Import_meetingsListBox.FormattingEnabled = true;
            this.Import_meetingsListBox.Location = new System.Drawing.Point(61, 242);
            this.Import_meetingsListBox.Name = "Import_meetingsListBox";
            this.Import_meetingsListBox.Size = new System.Drawing.Size(470, 186);
            this.Import_meetingsListBox.TabIndex = 17;
            // 
            // Import_meetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Import_meetingsListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteMeetinges_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FromdateTimePicker1);
            this.Controls.Add(this.TodateTimePicker2);
            this.Name = "Import_meetings";
            this.Text = "Import_meetings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteMeetinges_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FromdateTimePicker1;
        private System.Windows.Forms.DateTimePicker TodateTimePicker2;
        private System.Windows.Forms.ListBox Import_meetingsListBox;
    }
}