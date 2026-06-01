using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLNongSan
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "File ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFile.Title = "Chọn ảnh nhân viên";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtTenNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ít nhất Mã và Tên nhân viên!", "Thông báo");
                return;
            }

            // Đẩy đủ 9 thông tin xuống bảng theo đúng thứ tự
            dataGridView1.Rows.Add(txtMaNV.Text, txtTenNV.Text, dtpNgaySinh.Text, cboGioiTinh.Text, txtSDT.Text, txtEmail.Text, cboChucVu.Text, cboHopDong.Text, cboTrangThai.Text);

            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult hoiLai = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (hoiLai == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    MessageBox.Show("Đã xóa thành công!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một nhân viên dưới bảng để xóa!", "Nhắc nhở");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtMaNV.Text = dataGridView1.CurrentRow.Cells[0].Value?.ToString();
                txtTenNV.Text = dataGridView1.CurrentRow.Cells[1].Value?.ToString();
                dtpNgaySinh.Text = dataGridView1.CurrentRow.Cells[2].Value?.ToString();
                cboGioiTinh.Text = dataGridView1.CurrentRow.Cells[3].Value?.ToString();
                txtSDT.Text = dataGridView1.CurrentRow.Cells[4].Value?.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells[5].Value?.ToString();
                cboChucVu.Text = dataGridView1.CurrentRow.Cells[6].Value?.ToString();
                cboHopDong.Text = dataGridView1.CurrentRow.Cells[7].Value?.ToString();
                cboTrangThai.Text = dataGridView1.CurrentRow.Cells[8].Value?.ToString();
            }
            if (dataGridView1.CurrentRow != null)
            {
                // Lưu đè dữ liệu mới xuống 9 cột tương ứng
                dataGridView1.CurrentRow.Cells[0].Value = txtMaNV.Text;
                dataGridView1.CurrentRow.Cells[1].Value = txtTenNV.Text;
                dataGridView1.CurrentRow.Cells[2].Value = dtpNgaySinh.Text;
                dataGridView1.CurrentRow.Cells[3].Value = cboGioiTinh.Text;
                dataGridView1.CurrentRow.Cells[4].Value = txtSDT.Text;
                dataGridView1.CurrentRow.Cells[5].Value = txtEmail.Text;
                dataGridView1.CurrentRow.Cells[6].Value = cboChucVu.Text;
                dataGridView1.CurrentRow.Cells[7].Value = cboHopDong.Text;
                dataGridView1.CurrentRow.Cells[8].Value = cboTrangThai.Text;

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtEmail.Clear(); // Mới thêm

            cboGioiTinh.SelectedIndex = -1;
            cboChucVu.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
            cboHopDong.SelectedIndex = -1; // Mới thêm

            dtpNgaySinh.Value = DateTime.Now; // Đưa ngày sinh về ngày hôm nay

            txtMaNV.Focus();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
