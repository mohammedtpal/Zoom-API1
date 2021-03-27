
namespace Zoom_API1
{
    partial class Import_Host_Meeting_Details
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.HostListBox2 = new System.Windows.Forms.ListBox();
            this.HostProgressBar2 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.instructorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gET_HOSTS_FROM_DB_DATASET = new Zoom_API1.GET_HOSTS_FROM_DB_DATASET();
            this.gETHOSTSFROMDBDATASETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instructorsTableAdapter = new Zoom_API1.GET_HOSTS_FROM_DB_DATASETTableAdapters.instructorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_HOSTS_FROM_DB_DATASET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETHOSTSFROMDBDATASETBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(23, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "This tab used to: Import details of Meetings for a specific Host";
            // 
            // HostListBox2
            // 
            this.HostListBox2.FormattingEnabled = true;
            this.HostListBox2.Location = new System.Drawing.Point(19, 164);
            this.HostListBox2.Margin = new System.Windows.Forms.Padding(2);
            this.HostListBox2.Name = "HostListBox2";
            this.HostListBox2.Size = new System.Drawing.Size(752, 199);
            this.HostListBox2.TabIndex = 8;
            // 
            // HostProgressBar2
            // 
            this.HostProgressBar2.Location = new System.Drawing.Point(19, 145);
            this.HostProgressBar2.Margin = new System.Windows.Forms.Padding(2);
            this.HostProgressBar2.Name = "HostProgressBar2";
            this.HostProgressBar2.Size = new System.Drawing.Size(752, 19);
            this.HostProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.HostProgressBar2.TabIndex = 7;
            this.HostProgressBar2.UseWaitCursor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(26, 62);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "Import Meeting Details";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox1.DataSource = this.instructorsBindingSource;
            this.comboBox1.DisplayMember = "NAME";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(315, 64);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 26);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "email";
            // 
            // instructorsBindingSource
            // 
            this.instructorsBindingSource.DataMember = "instructors";
            this.instructorsBindingSource.DataSource = this.gET_HOSTS_FROM_DB_DATASET;
            // 
            // gET_HOSTS_FROM_DB_DATASET
            // 
            this.gET_HOSTS_FROM_DB_DATASET.DataSetName = "GET_HOSTS_FROM_DB_DATASET";
            this.gET_HOSTS_FROM_DB_DATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gETHOSTSFROMDBDATASETBindingSource
            // 
            this.gETHOSTSFROMDBDATASETBindingSource.DataSource = this.gET_HOSTS_FROM_DB_DATASET;
            this.gETHOSTSFROMDBDATASETBindingSource.Position = 0;
            // 
            // instructorsTableAdapter
            // 
            this.instructorsTableAdapter.ClearBeforeFill = true;
            // 
            // Import_Host_Meeting_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HostListBox2);
            this.Controls.Add(this.HostProgressBar2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Name = "Import_Host_Meeting_Details";
            this.Text = "Import_Host_Meeting_Details";
            this.Load += new System.EventHandler(this.Import_Host_Meeting_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.instructorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_HOSTS_FROM_DB_DATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETHOSTSFROMDBDATASETBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox HostListBox2;
        private System.Windows.Forms.ProgressBar HostProgressBar2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource gETHOSTSFROMDBDATASETBindingSource;
        private GET_HOSTS_FROM_DB_DATASET gET_HOSTS_FROM_DB_DATASET;
        private System.Windows.Forms.BindingSource instructorsBindingSource;
        private GET_HOSTS_FROM_DB_DATASETTableAdapters.instructorsTableAdapter instructorsTableAdapter;
    }
}