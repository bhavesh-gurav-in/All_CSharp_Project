namespace Birth_And_Death_Registration_System
{
    partial class birthrc
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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.regidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ffnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fmnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mmnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mlnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet2 = new Birth_And_Death_Registration_System.DatabaseDataSet2();
            this.birthTableAdapter = new Birth_And_Death_Registration_System.DatabaseDataSet2TableAdapters.birthTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(306, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 27);
            this.button1.TabIndex = 63;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(664, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 31);
            this.button2.TabIndex = 62;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(211, 94);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(89, 27);
            this.textBox4.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 60;
            this.label2.Text = "Registration No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regidDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.mnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.ffnameDataGridViewTextBoxColumn,
            this.fmnameDataGridViewTextBoxColumn,
            this.lfnameDataGridViewTextBoxColumn,
            this.mfnameDataGridViewTextBoxColumn,
            this.mmnameDataGridViewTextBoxColumn,
            this.mlnameDataGridViewTextBoxColumn,
            this.religionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.birthBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(951, 292);
            this.dataGridView1.TabIndex = 59;
            // 
            // regidDataGridViewTextBoxColumn
            // 
            this.regidDataGridViewTextBoxColumn.DataPropertyName = "regid";
            this.regidDataGridViewTextBoxColumn.HeaderText = "regid";
            this.regidDataGridViewTextBoxColumn.Name = "regidDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // mnameDataGridViewTextBoxColumn
            // 
            this.mnameDataGridViewTextBoxColumn.DataPropertyName = "mname";
            this.mnameDataGridViewTextBoxColumn.HeaderText = "mname";
            this.mnameDataGridViewTextBoxColumn.Name = "mnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // ffnameDataGridViewTextBoxColumn
            // 
            this.ffnameDataGridViewTextBoxColumn.DataPropertyName = "ffname";
            this.ffnameDataGridViewTextBoxColumn.HeaderText = "ffname";
            this.ffnameDataGridViewTextBoxColumn.Name = "ffnameDataGridViewTextBoxColumn";
            // 
            // fmnameDataGridViewTextBoxColumn
            // 
            this.fmnameDataGridViewTextBoxColumn.DataPropertyName = "fmname";
            this.fmnameDataGridViewTextBoxColumn.HeaderText = "fmname";
            this.fmnameDataGridViewTextBoxColumn.Name = "fmnameDataGridViewTextBoxColumn";
            // 
            // lfnameDataGridViewTextBoxColumn
            // 
            this.lfnameDataGridViewTextBoxColumn.DataPropertyName = "lfname";
            this.lfnameDataGridViewTextBoxColumn.HeaderText = "lfname";
            this.lfnameDataGridViewTextBoxColumn.Name = "lfnameDataGridViewTextBoxColumn";
            // 
            // mfnameDataGridViewTextBoxColumn
            // 
            this.mfnameDataGridViewTextBoxColumn.DataPropertyName = "mfname";
            this.mfnameDataGridViewTextBoxColumn.HeaderText = "mfname";
            this.mfnameDataGridViewTextBoxColumn.Name = "mfnameDataGridViewTextBoxColumn";
            // 
            // mmnameDataGridViewTextBoxColumn
            // 
            this.mmnameDataGridViewTextBoxColumn.DataPropertyName = "mmname";
            this.mmnameDataGridViewTextBoxColumn.HeaderText = "mmname";
            this.mmnameDataGridViewTextBoxColumn.Name = "mmnameDataGridViewTextBoxColumn";
            // 
            // mlnameDataGridViewTextBoxColumn
            // 
            this.mlnameDataGridViewTextBoxColumn.DataPropertyName = "mlname";
            this.mlnameDataGridViewTextBoxColumn.HeaderText = "mlname";
            this.mlnameDataGridViewTextBoxColumn.Name = "mlnameDataGridViewTextBoxColumn";
            // 
            // religionDataGridViewTextBoxColumn
            // 
            this.religionDataGridViewTextBoxColumn.DataPropertyName = "religion";
            this.religionDataGridViewTextBoxColumn.HeaderText = "religion";
            this.religionDataGridViewTextBoxColumn.Name = "religionDataGridViewTextBoxColumn";
            // 
            // birthBindingSource
            // 
            this.birthBindingSource.DataMember = "birth";
            this.birthBindingSource.DataSource = this.databaseDataSet2;
            // 
            // databaseDataSet2
            // 
            this.databaseDataSet2.DataSetName = "DatabaseDataSet2";
            this.databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // birthTableAdapter
            // 
            this.birthTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(333, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(285, 26);
            this.label9.TabIndex = 64;
            this.label9.Text = "BIRTH REGISTRATION RECORDS";
            // 
            // birthrc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(975, 460);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "birthrc";
            this.Text = "birthrc";
            this.Load += new System.EventHandler(this.birthrc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet2 databaseDataSet2;
        private System.Windows.Forms.BindingSource birthBindingSource;
        private DatabaseDataSet2TableAdapters.birthTableAdapter birthTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn regidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ffnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fmnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lfnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mfnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mmnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mlnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn religionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
    }
}