namespace SchemaReader
{
    partial class FrmMain
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lstTable = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPilihDatabase = new System.Windows.Forms.Button();
            this.btnProperti = new System.Windows.Forms.Button();
            this.dgvSchema = new System.Windows.Forms.DataGridView();
            this.cmbPilihBahasa = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchema)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.78736F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.21264F));
            this.tableLayoutPanel1.Controls.Add(this.lstTable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvSchema, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.58317F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.416834F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(897, 496);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lstTable
            // 
            this.lstTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTable.FormattingEnabled = true;
            this.lstTable.ItemHeight = 21;
            this.lstTable.Location = new System.Drawing.Point(3, 3);
            this.lstTable.Name = "lstTable";
            this.tableLayoutPanel1.SetRowSpan(this.lstTable, 2);
            this.lstTable.Size = new System.Drawing.Size(216, 490);
            this.lstTable.TabIndex = 0;
            this.lstTable.SelectedIndexChanged += new System.EventHandler(this.lstTable_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnPilihDatabase);
            this.flowLayoutPanel1.Controls.Add(this.cmbPilihBahasa);
            this.flowLayoutPanel1.Controls.Add(this.btnProperti);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(225, 457);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(669, 36);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnPilihDatabase
            // 
            this.btnPilihDatabase.Location = new System.Drawing.Point(3, 3);
            this.btnPilihDatabase.Name = "btnPilihDatabase";
            this.btnPilihDatabase.Size = new System.Drawing.Size(128, 30);
            this.btnPilihDatabase.TabIndex = 0;
            this.btnPilihDatabase.Text = "Pilih Database";
            this.btnPilihDatabase.UseVisualStyleBackColor = true;
            this.btnPilihDatabase.Click += new System.EventHandler(this.btnPilihDatabase_Click);
            // 
            // btnProperti
            // 
            this.btnProperti.Location = new System.Drawing.Point(264, 3);
            this.btnProperti.Name = "btnProperti";
            this.btnProperti.Size = new System.Drawing.Size(75, 30);
            this.btnProperti.TabIndex = 1;
            this.btnProperti.Text = "Properti";
            this.btnProperti.UseVisualStyleBackColor = true;
            this.btnProperti.Click += new System.EventHandler(this.btnProperti_Click);
            // 
            // dgvSchema
            // 
            this.dgvSchema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchema.Location = new System.Drawing.Point(225, 3);
            this.dgvSchema.Name = "dgvSchema";
            this.dgvSchema.RowTemplate.Height = 28;
            this.dgvSchema.Size = new System.Drawing.Size(669, 448);
            this.dgvSchema.TabIndex = 2;
            // 
            // cmbPilihBahasa
            // 
            this.cmbPilihBahasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPilihBahasa.FormattingEnabled = true;
            this.cmbPilihBahasa.Items.AddRange(new object[] {
            "Pilih Bahasa",
            "C#",
            "Java"});
            this.cmbPilihBahasa.Location = new System.Drawing.Point(137, 3);
            this.cmbPilihBahasa.Name = "cmbPilihBahasa";
            this.cmbPilihBahasa.Size = new System.Drawing.Size(121, 29);
            this.cmbPilihBahasa.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 496);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Information Schema";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lstTable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvSchema;
        private System.Windows.Forms.Button btnProperti;
        private System.Windows.Forms.Button btnPilihDatabase;
        private System.Windows.Forms.ComboBox cmbPilihBahasa;


    }
}

