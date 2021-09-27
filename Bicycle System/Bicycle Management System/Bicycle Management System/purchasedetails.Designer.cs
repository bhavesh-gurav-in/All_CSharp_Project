namespace Bicycle_Management_System
{
    partial class purchasedetails
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
            this.modelnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet2 = new Bicycle_Management_System.DatabaseDataSet2();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.purchaseTableAdapter = new Bicycle_Management_System.DatabaseDataSet2TableAdapters.purchaseTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Yellow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelnoDataGridViewTextBoxColumn,
            this.sidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.paidDataGridViewTextBoxColumn,
            this.remainDataGridViewTextBoxColumn,
            this.datetimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.purchaseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // modelnoDataGridViewTextBoxColumn
            // 
            this.modelnoDataGridViewTextBoxColumn.DataPropertyName = "modelno";
            this.modelnoDataGridViewTextBoxColumn.HeaderText = "modelno";
            this.modelnoDataGridViewTextBoxColumn.Name = "modelnoDataGridViewTextBoxColumn";
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "s_id";
            this.sidDataGridViewTextBoxColumn.HeaderText = "s_id";
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // paidDataGridViewTextBoxColumn
            // 
            this.paidDataGridViewTextBoxColumn.DataPropertyName = "paid";
            this.paidDataGridViewTextBoxColumn.HeaderText = "paid";
            this.paidDataGridViewTextBoxColumn.Name = "paidDataGridViewTextBoxColumn";
            // 
            // remainDataGridViewTextBoxColumn
            // 
            this.remainDataGridViewTextBoxColumn.DataPropertyName = "remain";
            this.remainDataGridViewTextBoxColumn.HeaderText = "remain";
            this.remainDataGridViewTextBoxColumn.Name = "remainDataGridViewTextBoxColumn";
            // 
            // datetimeDataGridViewTextBoxColumn
            // 
            this.datetimeDataGridViewTextBoxColumn.DataPropertyName = "datetime";
            this.datetimeDataGridViewTextBoxColumn.HeaderText = "datetime";
            this.datetimeDataGridViewTextBoxColumn.Name = "datetimeDataGridViewTextBoxColumn";
            // 
            // purchaseBindingSource
            // 
            this.purchaseBindingSource.DataMember = "purchase";
            this.purchaseBindingSource.DataSource = this.databaseDataSet2;
            // 
            // databaseDataSet2
            // 
            this.databaseDataSet2.DataSetName = "DatabaseDataSet2";
            this.databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(462, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 56;
            this.button2.Text = "GET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(208, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "Model No";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(329, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 54;
            // 
            // purchaseTableAdapter
            // 
            this.purchaseTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(599, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 57;
            this.button1.Text = "CANCEL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // purchasedetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(798, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "purchasedetails";
            this.Text = "purchasedetails";
            this.Load += new System.EventHandler(this.purchasedetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private DatabaseDataSet2 databaseDataSet2;
        private System.Windows.Forms.BindingSource purchaseBindingSource;
        private DatabaseDataSet2TableAdapters.purchaseTableAdapter purchaseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}