
namespace Zoom_API1
{
    partial class Import_All_Hosts_Details
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
            this.button5 = new System.Windows.Forms.Button();
            this.HostListBox2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.progressBar_user_meetinges = new System.Windows.Forms.ProgressBar();
            this.progressBar_users = new System.Windows.Forms.ProgressBar();
            this.button4 = new System.Windows.Forms.Button();
            this.gET_HOSTS_FROM_DB_DATASET = new Zoom_API1.GET_HOSTS_FROM_DB_DATASET();
            this.instructorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instructorsTableAdapter = new Zoom_API1.GET_HOSTS_FROM_DB_DATASETTableAdapters.instructorsTableAdapter();
            this.tableAdapterManager = new Zoom_API1.GET_HOSTS_FROM_DB_DATASETTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.gET_HOSTS_FROM_DB_DATASET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(690, 48);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 19);
            this.button5.TabIndex = 13;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // HostListBox2
            // 
            this.HostListBox2.FormattingEnabled = true;
            this.HostListBox2.Location = new System.Drawing.Point(28, 242);
            this.HostListBox2.Margin = new System.Windows.Forms.Padding(2);
            this.HostListBox2.Name = "HostListBox2";
            this.HostListBox2.Size = new System.Drawing.Size(749, 160);
            this.HostListBox2.TabIndex = 12;
            this.HostListBox2.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Meetinges";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(24, 163);
            this.user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(61, 20);
            this.user.TabIndex = 10;
            this.user.Text = "Users:";
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // progressBar_user_meetinges
            // 
            this.progressBar_user_meetinges.Location = new System.Drawing.Point(115, 190);
            this.progressBar_user_meetinges.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar_user_meetinges.Name = "progressBar_user_meetinges";
            this.progressBar_user_meetinges.Size = new System.Drawing.Size(487, 19);
            this.progressBar_user_meetinges.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_user_meetinges.TabIndex = 9;
            this.progressBar_user_meetinges.Click += new System.EventHandler(this.progressBar_user_meetinges_Click);
            // 
            // progressBar_users
            // 
            this.progressBar_users.Location = new System.Drawing.Point(115, 163);
            this.progressBar_users.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar_users.Name = "progressBar_users";
            this.progressBar_users.Size = new System.Drawing.Size(487, 19);
            this.progressBar_users.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_users.TabIndex = 8;
            this.progressBar_users.Click += new System.EventHandler(this.progressBar_users_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(46, 55);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 33);
            this.button4.TabIndex = 7;
            this.button4.Text = "Run";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // gET_HOSTS_FROM_DB_DATASET
            // 
            this.gET_HOSTS_FROM_DB_DATASET.DataSetName = "GET_HOSTS_FROM_DB_DATASET";
            this.gET_HOSTS_FROM_DB_DATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instructorsBindingSource
            // 
            this.instructorsBindingSource.DataMember = "instructors";
            this.instructorsBindingSource.DataSource = this.gET_HOSTS_FROM_DB_DATASET;
            // 
            // instructorsTableAdapter
            // 
            this.instructorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.instructorsTableAdapter = this.instructorsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Zoom_API1.GET_HOSTS_FROM_DB_DATASETTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Import_All_Hosts_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.HostListBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.user);
            this.Controls.Add(this.progressBar_user_meetinges);
            this.Controls.Add(this.progressBar_users);
            this.Controls.Add(this.button4);
            this.Name = "Import_All_Hosts_Details";
            this.Text = "Import_All_Hosts_Details";
            this.Load += new System.EventHandler(this.Import_All_Hosts_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gET_HOSTS_FROM_DB_DATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox HostListBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.ProgressBar progressBar_user_meetinges;
        private System.Windows.Forms.ProgressBar progressBar_users;
        private System.Windows.Forms.Button button4;
        private GET_HOSTS_FROM_DB_DATASET gET_HOSTS_FROM_DB_DATASET;
        private System.Windows.Forms.BindingSource instructorsBindingSource;
        private GET_HOSTS_FROM_DB_DATASETTableAdapters.instructorsTableAdapter instructorsTableAdapter;
        private GET_HOSTS_FROM_DB_DATASETTableAdapters.TableAdapterManager tableAdapterManager;
    }
}