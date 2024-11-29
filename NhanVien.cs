using System;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class NhanVienForm : Form
    {
        public NhanVien NhanVien { get; private set; }

        public NhanVienForm()
        {
            InitializeComponent();
        }

        public NhanVienForm(NhanVien nhanVien) : this()
        {
            txtMSNV.Text = nhanVien.MSNV;
            txtTen.Text = nhanVien.TenNhanVien;
            txtLuong.Text = nhanVien.LuongCanBan.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien = new NhanVien
                {
                    MSNV = txtMSNV.Text,
                    TenNhanVien = txtTen.Text,
                    LuongCanBan = decimal.Parse(txtLuong.Text)
                };
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
