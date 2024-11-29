using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class Form1 : Form
    {
        private List<NhanVien> employees = new List<NhanVien>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
      {
          employees.Add(new NhanVien { MSNV = "NV001", TenNhanVien = "Nguyễn Văn A", LuongCanBan = 8500000 });
          employees.Add(new NhanVien { MSNV = "NV002", TenNhanVien = "Trần Thị B", LuongCanBan = 9500000 });
          LoadDataToGrid();
      }

        private void LoadDataToGrid()
        {
            dataGridView1.DataSource = null; 
            dataGridView1.DataSource = employees; 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var formNhanVien = new NhanVienForm())
            {
                if (formNhanVien.ShowDialog() == DialogResult.OK)
                {
                    employees.Add(formNhanVien.NhanVien);
                    LoadDataToGrid();
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                employees.RemoveAt(index);
                LoadDataToGrid();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            employees.Add(new NhanVien { MSNV = "NV001", TenNhanVien = "Nguyễn Văn A", LuongCanBan = 8500000 });
            employees.Add(new NhanVien { MSNV = "NV002", TenNhanVien = "Trần Thị B", LuongCanBan = 9500000 });
            LoadDataToGrid();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                var selectedEmployee = employees[index];

                using (var formNhanVien = new NhanVienForm(selectedEmployee))
                {
                    if (formNhanVien.ShowDialog() == DialogResult.OK)
                    {
                        employees[index] = formNhanVien.NhanVien; 
                        LoadDataToGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class NhanVien
    {
        public string MSNV { get; set; }
        public string TenNhanVien { get; set; }
        public decimal LuongCanBan { get; set; }
    }
}
