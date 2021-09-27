namespace Birth_And_Death_Registration_System
{
    partial class deathrc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.regidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deathdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pmnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ffnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fmnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deathBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new Birth_And_Death_Registration_System.DatabaseDataSet1();
            this.deathTableAdapter = new Birth_And_Death_Registration_System.DatabaseDataSet1TableAdapters.deathTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deathBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regidDataGridViewTextBoxColumn,
            this.deathdateDataGridViewTextBoxColumn,
            this.pfnameDataGridViewTextBoxColumn,
            this.pmnameDataGridViewTextBoxColumn,
            this.plnameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.ffnameDataGridViewTextBoxColumn,
            this.fmnameDataGridViewTextBoxColumn,
            this.flnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deathBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(814, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // regidDataGridViewTextBoxColumn
            // 
            this.regidDataGridViewTextBoxColumn.DataPropertyName = "regid";
            this.regidDataGridViewTextBoxColumn.HeaderText = "regid";
            this.regidDataGridViewTextBoxColumn.Name = "regidDataGridViewTextBoxColumn";
            // 
            // deathdateDataGridViewTextBoxColumn
            // 
            this.deathdateDataGridViewTextBoxColumn.DataPropertyName = "deathdate";
            this.deathdateDataGridViewTextBoxColumn.HeaderText = "deathdate";
            this.deathdateDataGridViewTextBoxColumn.Name = "deathdateDataGridViewTextBoxColumn";
            // 
            // pfnameDataGridViewTextBoxColumn
            // 
            this.pfnameDataGridViewTextBoxColumn.DataPropertyName = "pfname";
            this.pfnameDataGridViewTextBoxColumn.HeaderText = "pfname";
            this.pfnameDataGridViewTextBoxColumn.Name = "pfnameDataGridViewTextBoxColumn";
            // 
            // pmnameDataGridViewTextBoxColumn
            // 
            this.pmnameDataGridViewTextBoxColumn.DataPropertyName = "pmname";
            this.pmnameDataGridViewTextBoxColumn.HeaderText = "pmname";
            this.pmnameDataGridViewTextBoxColumn.Name = "pmnameDataGridViewTextBoxColumn";
            // 
            // plnameDataGridViewTextBoxColumn
            // 
            this.plnameDataGridViewTextBoxColumn.DataPropertyName = "plname";
            this.plnameDataGridViewTextBoxColumn.HeaderText = "plname";
            this.plnameDataGridViewTextBoxColumn.Name = "plnameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
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
            // flnameDataGridViewTextBoxColumn
            // 
            this.flnameDataGridViewTextBoxColumn.DataPropertyName = "flname";
            this.flnameDataGridViewTextBoxColumn.HeaderText = "flname";
            this.flnameDataGridViewTextBoxColumn.Name = "flnameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // deathBindingSource
            // 
            this.deathBindingSource.DataMember = "death";
            this.deathBindingSource.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deathTableAdapter
            // 
            this.deathTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(295, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(289, 26);
            this.label9.TabIndex = 56;
            this.label9.Text = "DEATH REGISTRATION RECORDS";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(211, 67);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(89, 27);
            this.textBox4.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 54;
            this.label2.Text = "Registration No";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(678, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 31);
            this.button2.TabIndex = 57;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(306, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 27);
            this.button1.TabIndex = 58;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deathrc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(838, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "deathrc";
            this.Text = "deathrc";
            this.Load += new System.EventHandler(this.deathrc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deathBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource deathBindingSource;
        private DatabaseDataSet1TableAdapters.deathTableAdapter deathTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn regidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deathdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pfnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pmnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ffnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fmnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}