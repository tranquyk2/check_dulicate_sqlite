namespace Scanner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            TextBox txtBarcode;
            panelMain = new Panel();
            btnDelete = new Button();
            btnAdd = new Button();
            btnLoadDB = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnExportMonth = new Button();
            dtpMonth = new DateTimePicker();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            cbCasx = new ComboBox();
            dtpDate = new DateTimePicker();
            btnStatus = new Button();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtSTTscan = new TextBox();
            label2 = new Label();
            txtStartscan = new TextBox();
            label1 = new Label();
            txtBarcode = new TextBox();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(btnDelete);
            panelMain.Controls.Add(btnAdd);
            panelMain.Controls.Add(btnLoadDB);
            panelMain.Controls.Add(txtSearch);
            panelMain.Controls.Add(btnSearch);
            panelMain.Controls.Add(btnExportMonth);
            panelMain.Controls.Add(dtpMonth);
            panelMain.Controls.Add(dataGridView1);
            panelMain.Controls.Add(cbCasx);
            panelMain.Controls.Add(dtpDate);
            panelMain.Controls.Add(btnStatus);
            panelMain.Controls.Add(label4);
            panelMain.Controls.Add(label5);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(txtSTTscan);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(txtStartscan);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(txtBarcode);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1773, 679);
            panelMain.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(488, 92);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 48);
            btnDelete.TabIndex = 49;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 192, 192);
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Transparent;
            btnAdd.Location = new Point(488, 37);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 54);
            btnAdd.TabIndex = 48;
            btnAdd.Text = "ADD MODEL";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button2_Click;
            // 
            // btnLoadDB
            // 
            btnLoadDB.BackColor = Color.FromArgb(0, 150, 255);
            btnLoadDB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadDB.ForeColor = Color.White;
            btnLoadDB.Location = new Point(742, 37);
            btnLoadDB.Name = "btnLoadDB";
            btnLoadDB.Size = new Size(111, 103);
            btnLoadDB.TabIndex = 51;
            btnLoadDB.Text = "LOAD DATA";
            btnLoadDB.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(26, 231);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập barcode cần tìm...";
            txtSearch.Size = new Size(300, 34);
            txtSearch.TabIndex = 52;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 128, 0);
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(332, 231);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 34);
            btnSearch.TabIndex = 53;
            btnSearch.Text = "TÌM KIẾM";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnExportMonth
            // 
            btnExportMonth.BackColor = Color.FromArgb(0, 192, 0);
            btnExportMonth.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportMonth.ForeColor = Color.White;
            btnExportMonth.Location = new Point(613, 92);
            btnExportMonth.Name = "btnExportMonth";
            btnExportMonth.Size = new Size(119, 46);
            btnExportMonth.TabIndex = 55;
            btnExportMonth.Text = "XUẤT EXCEL ";
            btnExportMonth.UseVisualStyleBackColor = false;
            // 
            // dtpMonth
            // 
            dtpMonth.CustomFormat = "MM/yyyy";
            dtpMonth.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpMonth.Format = DateTimePickerFormat.Custom;
            dtpMonth.Location = new Point(616, 54);
            dtpMonth.Name = "dtpMonth";
            dtpMonth.ShowUpDown = true;
            dtpMonth.Size = new Size(120, 32);
            dtpMonth.TabIndex = 54;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 271);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1737, 405);
            dataGridView1.TabIndex = 47;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.FillWeight = 5F;
            dataGridViewTextBoxColumn1.HeaderText = "STT";
            dataGridViewTextBoxColumn1.MinimumWidth = 40;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.FillWeight = 45F;
            dataGridViewTextBoxColumn2.HeaderText = "Barcode";
            dataGridViewTextBoxColumn2.MinimumWidth = 100;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.FillWeight = 30F;
            dataGridViewTextBoxColumn3.HeaderText = "Ngày";
            dataGridViewTextBoxColumn3.MinimumWidth = 100;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.FillWeight = 10F;
            dataGridViewTextBoxColumn4.HeaderText = "Result";
            dataGridViewTextBoxColumn4.MinimumWidth = 80;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.FillWeight = 10F;
            dataGridViewTextBoxColumn5.HeaderText = "Ca sản xuất";
            dataGridViewTextBoxColumn5.MinimumWidth = 80;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // cbCasx
            // 
            cbCasx.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbCasx.FormattingEnabled = true;
            cbCasx.Items.AddRange(new object[] { "Ngày", "Đêm" });
            cbCasx.Location = new Point(411, 179);
            cbCasx.Name = "cbCasx";
            cbCasx.Size = new Size(110, 36);
            cbCasx.TabIndex = 46;
            // 
            // dtpDate
            // 
            dtpDate.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDate.Location = new Point(603, 181);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 34);
            dtpDate.TabIndex = 45;
            // 
            // btnStatus
            // 
            btnStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStatus.BackColor = Color.LimeGreen;
            btnStatus.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatus.ForeColor = Color.White;
            btnStatus.Location = new Point(987, 12);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(762, 253);
            btnStatus.TabIndex = 44;
            btnStatus.Text = "OK";
            btnStatus.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(405, 148);
            label4.Name = "label4";
            label4.Size = new Size(125, 28);
            label4.TabIndex = 43;
            label4.Text = "Ca Sản Xuất";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(603, 150);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 42;
            label5.Text = "Ngày Scan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(216, 150);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 41;
            label3.Text = "STT Scan";
            // 
            // txtSTTscan
            // 
            txtSTTscan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSTTscan.Location = new Point(215, 183);
            txtSTTscan.Name = "txtSTTscan";
            txtSTTscan.ReadOnly = true;
            txtSTTscan.Size = new Size(117, 34);
            txtSTTscan.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(26, 150);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 39;
            label2.Text = "STT Start Scan";
            // 
            // txtStartscan
            // 
            txtStartscan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStartscan.Location = new Point(26, 183);
            txtStartscan.Name = "txtStartscan";
            txtStartscan.Size = new Size(117, 34);
            txtStartscan.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 12);
            label1.Name = "label1";
            label1.Size = new Size(233, 46);
            label1.TabIndex = 37;
            label1.Text = "Scan Barcode";
            label1.Click += label1_Click_1;
            // 
            // txtBarcode
            // 
            txtBarcode.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBarcode.Location = new Point(27, 74);
            txtBarcode.Multiline = true;
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(452, 64);
            txtBarcode.TabIndex = 36;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1773, 679);
            Controls.Add(panelMain);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtStartscan;
        private Label label2;
        private TextBox txtSTTscan;
        private Label label3;
        private Label label5;
        private Label label4;
        private Button btnStatus;
        private DateTimePicker dtpDate;
        private ComboBox cbCasx;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnLoadDB;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnExportMonth;
        private DateTimePicker dtpMonth;
        private Panel panelMain;
        private DataGridView dataGridView1;
        private TextBox txtBarcode;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

