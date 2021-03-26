
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
            this.Hosts_bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Zoom_API1.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.Hosts_bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(31, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(460, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "This tab used to: Import details of Meetings for a specific Host";
            // 
            // HostListBox2
            // 
            this.HostListBox2.FormattingEnabled = true;
            this.HostListBox2.ItemHeight = 16;
            this.HostListBox2.Location = new System.Drawing.Point(25, 202);
            this.HostListBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HostListBox2.Name = "HostListBox2";
            this.HostListBox2.Size = new System.Drawing.Size(1001, 244);
            this.HostListBox2.TabIndex = 8;
            // 
            // HostProgressBar2
            // 
            this.HostProgressBar2.Location = new System.Drawing.Point(25, 178);
            this.HostProgressBar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HostProgressBar2.Name = "HostProgressBar2";
            this.HostProgressBar2.Size = new System.Drawing.Size(1003, 23);
            this.HostProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.HostProgressBar2.TabIndex = 7;
            this.HostProgressBar2.UseWaitCursor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(35, 76);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(292, 34);
            this.button3.TabIndex = 6;
            this.button3.Text = "Import Meeting Details";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox1.DataSource = this.Hosts_bindingSource1;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(420, 79);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 30);
            this.comboBox1.TabIndex = 5;
            // 
            // Hosts_bindingSource1
            // 
            this.Hosts_bindingSource1.DataSource = this.dataSet1;
            this.Hosts_bindingSource1.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Import_Host_Meeting_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HostListBox2);
            this.Controls.Add(this.HostProgressBar2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Import_Host_Meeting_Details";
            this.Text = "Import_Host_Meeting_Details";
            ((System.ComponentModel.ISupportInitialize)(this.Hosts_bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox HostListBox2;
        private System.Windows.Forms.ProgressBar HostProgressBar2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource Hosts_bindingSource1;
        private DataSet1 dataSet1;
    }
}