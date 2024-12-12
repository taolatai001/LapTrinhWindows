using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_02
{
    public partial class frmSoanVanBan : Form
    {
        public frmSoanVanBan()
        {
            InitializeComponent();
        }
        private void loadFont()
        {
            foreach (FontFamily fontFamily in new InstalledFontCollection().Families)
            {
                cbxFont.Items.Add(fontFamily.Name);
            }

            cbxFont.SelectedItem = "Tahoma";
        }

        private void loadSize()
        {

            int[] sizeValues = new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            cbxSize.ComboBox.DataSource = sizeValues;
            cbxSize.SelectedItem = 14;
        }

        private void frmSoanVanBan_Load(object sender, EventArgs e)
        {
            loadFont();
            loadSize();
            rtbVanBan.Font = new Font("Tahoma", 14, FontStyle.Regular);
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            rtbVanBan.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true; 
            openFileDialog.CheckPathExists = true;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|RichText files (*.rtf)|*.rtf"; 
            openFileDialog.Multiselect = false; 

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                saveFilePath = openFileDialog.FileName;

                try
                {
                    if (Path.GetExtension(selectedFileName).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        rtbVanBan.LoadFile(selectedFileName, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        rtbVanBan.LoadFile(selectedFileName, RichTextBoxStreamType.RichText);
                    }

                    MessageBox.Show("Tập tin đã được mở thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình mở tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.ShowApply = true;
            fontDialog.ShowEffects = true;
            fontDialog.ShowHelp = true;

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                rtbVanBan.ForeColor = fontDialog.Color;
                rtbVanBan.Font = fontDialog.Font;
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            if (rtbVanBan.SelectionFont != null)
            {
                FontStyle style = rtbVanBan.SelectionFont.Style;

                if (rtbVanBan.SelectionFont.Bold)
                {
                    style &= ~FontStyle.Bold;
                }
                else
                {
                    style |= FontStyle.Bold;
                }
                rtbVanBan.SelectionFont = new Font(rtbVanBan.SelectionFont, style);
            }
        }

        private void btnItaly_Click(object sender, EventArgs e)
        {
            if (rtbVanBan.SelectionFont != null)
            {
                FontStyle style = rtbVanBan.SelectionFont.Style;

                if (rtbVanBan.SelectionFont.Italic)
                {
                    style &= ~FontStyle.Italic;
                }
                else
                {
                    style |= FontStyle.Italic;
                }

                rtbVanBan.SelectionFont = new Font(rtbVanBan.SelectionFont, style);
            }
        }

        private void btnGachChan_Click(object sender, EventArgs e)
        {
            if (rtbVanBan.SelectionFont != null)
            {
                FontStyle style = rtbVanBan.SelectionFont.Style;

                if (rtbVanBan.SelectionFont.Underline)
                {
                    style &= ~FontStyle.Underline;
                }
                else
                {
                    style |= FontStyle.Underline;
                }

                rtbVanBan.SelectionFont = new Font(rtbVanBan.SelectionFont, style);
            }
        }
        private string saveFilePath = "";

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnNewText_Click(object sender, EventArgs e)
        {
            // Xóa nội dung RichTextBox
            rtbVanBan.Clear();

            // Đặt lại font và size về mặc định
            rtbVanBan.Font = new Font("Tahoma", 14, FontStyle.Regular);

            // Đặt lại các ComboBox về giá trị mặc định (nếu cần thiết)
            cbxFont.SelectedItem = "Tahoma";
            cbxSize.SelectedItem = 14;

        }

        private void cbxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rtbVanBan.SelectionFont != null)
            {
                int newSize = (int)cbxSize.SelectedItem;
                rtbVanBan.SelectionFont = new Font(rtbVanBan.SelectionFont.FontFamily, newSize, rtbVanBan.SelectionFont.Style);
            }
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|RichText files (*.rtf)|*.rtf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (Path.GetExtension(saveFileDialog.FileName).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        rtbVanBan.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        rtbVanBan.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                    }

                    MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbxSize_Click(object sender, EventArgs e)
        {

        }

        private void cbxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rtbVanBan.SelectionFont != null)
            {
                string newFontName = cbxFont.SelectedItem.ToString();
                rtbVanBan.SelectionFont = new Font(newFontName, rtbVanBan.SelectionFont.Size, rtbVanBan.SelectionFont.Style);
            }
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.ShowApply = true;
            fontDialog.ShowEffects = true;
            fontDialog.ShowHelp = true;

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                rtbVanBan.ForeColor = fontDialog.Color;
                rtbVanBan.Font = fontDialog.Font;
            }
        }
    }
 }

