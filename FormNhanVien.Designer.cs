namespace QLNongSan
{
    partial class FormNhanVien
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label9 = new Label();
            cboTrangThai = new ComboBox();
            label8 = new Label();
            cboHopDong = new ComboBox();
            label7 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            cboChucVu = new ComboBox();
            cboGioiTinh = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSDT = new TextBox();
            txtMaNV = new TextBox();
            txtTenNV = new TextBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDarkDark;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cboTrangThai);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cboHopDong);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboChucVu);
            groupBox1.Controls.Add(cboGioiTinh);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(txtTenNV);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Segoe UI", 16.2F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(60, 50);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(1800, 450);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // button4
            // 
            button4.BackColor = Color.Purple;
            button4.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(224, 224, 224);
            button4.Location = new Point(155, 374);
            button4.Name = "button4";
            button4.Size = new Size(65, 30);
            button4.TabIndex = 22;
            button4.Text = "RESET";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 192);
            button3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(0, 64, 0);
            button3.Location = new Point(40, 374);
            button3.Name = "button3";
            button3.Size = new Size(65, 30);
            button3.TabIndex = 21;
            button3.Text = "SỬA";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(255, 192, 192);
            button2.Location = new Point(155, 327);
            button2.Name = "button2";
            button2.Size = new Size(65, 30);
            button2.TabIndex = 20;
            button2.Text = "XÓA";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 64, 0);
            button1.Location = new Point(40, 327);
            button1.Name = "button1";
            button1.Size = new Size(65, 30);
            button1.TabIndex = 19;
            button1.Text = "THÊM";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1303, 250);
            label9.Name = "label9";
            label9.Size = new Size(140, 38);
            label9.TabIndex = 18;
            label9.Text = "Trạng thái";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Đang làm việc", "Nghỉ phép", "Đình chỉ", "Đã nghỉ việc" });
            cboTrangThai.Location = new Point(1457, 250);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(246, 45);
            cboTrangThai.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1303, 154);
            label8.Name = "label8";
            label8.Size = new Size(142, 38);
            label8.TabIndex = 16;
            label8.Text = "Hợp đồng";
            // 
            // cboHopDong
            // 
            cboHopDong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHopDong.FormattingEnabled = true;
            cboHopDong.Items.AddRange(new object[] { "Chính thức", "Thử việc", "Thời vụ", "Thực tập" });
            cboHopDong.Location = new Point(1457, 156);
            cboHopDong.Name = "cboHopDong";
            cboHopDong.Size = new Size(246, 45);
            cboHopDong.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(278, 361);
            label7.Name = "label7";
            label7.Size = new Size(83, 38);
            label7.TabIndex = 14;
            label7.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(419, 361);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(246, 43);
            txtEmail.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(776, 158);
            label6.Name = "label6";
            label6.Size = new Size(141, 38);
            label6.TabIndex = 12;
            label6.Text = "Ngày sinh";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9F);
            dateTimePicker1.Location = new Point(935, 168);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 24);
            dateTimePicker1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1303, 57);
            label5.Name = "label5";
            label5.Size = new Size(116, 38);
            label5.TabIndex = 10;
            label5.Text = "Chức vụ";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(776, 57);
            label4.Name = "label4";
            label4.Size = new Size(123, 38);
            label4.TabIndex = 9;
            label4.Text = "Giới tính";
            // 
            // cboChucVu
            // 
            cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Items.AddRange(new object[] { "Quản lý", "Nhân viên thu mua", "Nhân viên kiểm định", "Thủ kho", "Nhân viên đóng gói", "Nhân viên giao hàng", "Nhân viên chăm sóc khách hàng", "Kế toán" });
            cboChucVu.Location = new Point(1457, 58);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(246, 45);
            cboChucVu.TabIndex = 8;
            cboChucVu.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(935, 57);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(246, 45);
            cboGioiTinh.TabIndex = 7;
            cboGioiTinh.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 257);
            label3.Name = "label3";
            label3.Size = new Size(67, 38);
            label3.TabIndex = 6;
            label3.Text = "SĐT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 158);
            label2.Name = "label2";
            label2.Size = new Size(102, 38);
            label2.TabIndex = 5;
            label2.Text = "Mã NV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 60);
            label1.Name = "label1";
            label1.Size = new Size(106, 38);
            label1.TabIndex = 4;
            label1.Text = "Tên NV";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(419, 257);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(246, 43);
            txtSDT.TabIndex = 3;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(419, 158);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(246, 43);
            txtMaNV.TabIndex = 2;
            txtMaNV.TextChanged += textBox2_TextChanged;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(419, 60);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(246, 43);
            txtTenNV.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Location = new Point(40, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 240);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(60, 538);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1800, 460);
            dataGridView1.TabIndex = 0;
            // 
            // Column2
            // 
            Column2.HeaderText = "Mã NV";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên NV";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "SĐT";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Email";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Giới tính";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Ngày sinh";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Chức vụ";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Hợp đồng";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Trạng thái";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1902, 1033);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 16.2F);
            ForeColor = Color.White;
            Margin = new Padding(6);
            Name = "FormNhanVien";
            Text = "FormNhanVien";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private TextBox txtSDT;
        private TextBox txtMaNV;
        private TextBox txtTenNV;
        private Label label1;
        private ComboBox cboGioiTinh;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private ComboBox cboChucVu;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label7;
        private TextBox txtEmail;
        private Label label8;
        private ComboBox cboHopDong;
        private Label label9;
        private ComboBox cboTrangThai;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button3;
    }
}