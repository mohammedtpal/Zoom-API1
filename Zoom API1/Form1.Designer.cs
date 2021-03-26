
namespace Zoom_API1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participantsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zoomDataSet = new Zoom_API1.ZoomDataSet();
            this.meetingesTableAdapter = new Zoom_API1.ZoomDataSetTableAdapters.meetingesTableAdapter();
            this.meetingesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.instructorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zoomDataSet1 = new Zoom_API1.ZoomDataSet1();
            this.zoomDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instructorsTableAdapter = new Zoom_API1.ZoomDataSet1TableAdapters.instructorsTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(523, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(713, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(732, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Token:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uuidDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.topicDataGridViewTextBoxColumn,
            this.hostDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.usertypeDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.endtimeDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.participantsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.meetingesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1303, 414);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // uuidDataGridViewTextBoxColumn
            // 
            this.uuidDataGridViewTextBoxColumn.DataPropertyName = "uuid";
            this.uuidDataGridViewTextBoxColumn.HeaderText = "uuid";
            this.uuidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uuidDataGridViewTextBoxColumn.Name = "uuidDataGridViewTextBoxColumn";
            this.uuidDataGridViewTextBoxColumn.Visible = false;
            this.uuidDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // topicDataGridViewTextBoxColumn
            // 
            this.topicDataGridViewTextBoxColumn.DataPropertyName = "topic";
            this.topicDataGridViewTextBoxColumn.HeaderText = "topic";
            this.topicDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.topicDataGridViewTextBoxColumn.Name = "topicDataGridViewTextBoxColumn";
            this.topicDataGridViewTextBoxColumn.Width = 125;
            // 
            // hostDataGridViewTextBoxColumn
            // 
            this.hostDataGridViewTextBoxColumn.DataPropertyName = "host";
            this.hostDataGridViewTextBoxColumn.HeaderText = "host";
            this.hostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hostDataGridViewTextBoxColumn.Name = "hostDataGridViewTextBoxColumn";
            this.hostDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // usertypeDataGridViewTextBoxColumn
            // 
            this.usertypeDataGridViewTextBoxColumn.DataPropertyName = "user_type";
            this.usertypeDataGridViewTextBoxColumn.HeaderText = "user_type";
            this.usertypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usertypeDataGridViewTextBoxColumn.Name = "usertypeDataGridViewTextBoxColumn";
            this.usertypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "start_time";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "start_time";
            this.starttimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            this.starttimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // endtimeDataGridViewTextBoxColumn
            // 
            this.endtimeDataGridViewTextBoxColumn.DataPropertyName = "end_time";
            this.endtimeDataGridViewTextBoxColumn.HeaderText = "end_time";
            this.endtimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endtimeDataGridViewTextBoxColumn.Name = "endtimeDataGridViewTextBoxColumn";
            this.endtimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.Width = 125;
            // 
            // participantsDataGridViewTextBoxColumn
            // 
            this.participantsDataGridViewTextBoxColumn.DataPropertyName = "participants";
            this.participantsDataGridViewTextBoxColumn.HeaderText = "participants";
            this.participantsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.participantsDataGridViewTextBoxColumn.Name = "participantsDataGridViewTextBoxColumn";
            this.participantsDataGridViewTextBoxColumn.Width = 125;
            // 
            // meetingesBindingSource
            // 
            this.meetingesBindingSource.DataMember = "meetinges";
            this.meetingesBindingSource.DataSource = this.zoomDataSet;
            // 
            // zoomDataSet
            // 
            this.zoomDataSet.DataSetName = "ZoomDataSet";
            this.zoomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // meetingesTableAdapter
            // 
            this.meetingesTableAdapter.ClearBeforeFill = true;
            // 
            // meetingesBindingSource1
            // 
            this.meetingesBindingSource1.DataMember = "meetinges";
            this.meetingesBindingSource1.DataSource = this.zoomDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.instructorsBindingSource;
            this.comboBox1.DisplayMember = "Column1";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(557, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(301, 33);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "email";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // instructorsBindingSource
            // 
            this.instructorsBindingSource.DataMember = "instructors";
            this.instructorsBindingSource.DataSource = this.zoomDataSet1;
            // 
            // zoomDataSet1
            // 
            this.zoomDataSet1.DataSetName = "ZoomDataSet1";
            this.zoomDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zoomDataSetBindingSource
            // 
            this.zoomDataSetBindingSource.DataSource = this.zoomDataSet;
            this.zoomDataSetBindingSource.Position = 0;
            // 
            // instructorsTableAdapter
            // 
            this.instructorsTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(890, 96);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 33);
            this.button5.TabIndex = 11;
            this.button5.Text = "Diplay";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1039, 96);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 33);
            this.button6.TabIndex = 12;
            this.button6.Text = "API";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1176, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 22);
            this.textBox2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 606);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ZoomDataSet zoomDataSet;
        private System.Windows.Forms.BindingSource meetingesBindingSource;
        private ZoomDataSetTableAdapters.meetingesTableAdapter meetingesTableAdapter;
        private System.Windows.Forms.BindingSource meetingesBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource zoomDataSetBindingSource;
        private ZoomDataSet1 zoomDataSet1;
        private System.Windows.Forms.BindingSource instructorsBindingSource;
        private ZoomDataSet1TableAdapters.instructorsTableAdapter instructorsTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn uuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn participantsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
    }
}

