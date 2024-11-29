using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVNBuoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLastName.Text) &&
            !string.IsNullOrWhiteSpace(txtFirstName.Text) &&
            !string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                ListViewItem item = new ListViewItem(txtLastName.Text);
                item.SubItems.Add(txtFirstName.Text);
                item.SubItems.Add(txtPhone.Text);
                listView1.Items.Add(item);

                // Clear TextBoxes
                txtLastName.Clear();
                txtFirstName.Clear();
                txtPhone.Clear();
            }
            else
            {
                MessageBox.Show("Điền còn thiếu");
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                selectedItem.Text = txtLastName.Text; 
                selectedItem.SubItems[1].Text = txtFirstName.Text; 
                selectedItem.SubItems[2].Text = txtPhone.Text; 
            }
            else
            {
                MessageBox.Show("Chọn dòng để chỉnh sửa.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Chọn dòng để xóa.");
            }
        }

     

      
    }
}
