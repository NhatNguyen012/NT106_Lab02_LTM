using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Net.WebRequestMethods;

namespace Lab2
{
    public partial class BT1 : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        FileStream fs;
        string content;
        byte[] bytes;
        public BT1()
        {
            InitializeComponent();
        }

        private async void btn_Read_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string FileName in ofd.FileNames)
                {
                    using (StreamReader sr = new StreamReader(FileName))
                    {
                        string content = await sr.ReadToEndAsync();
                        string filenames = Path.GetFileName(FileName);
                        richTextBox1.AppendText($"Nội dung của file '{filenames}':\n{content}\n");
                    }
                }

            }
        }
        private void btn_wri_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                OverwritePrompt = false
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string FileName = sfd.FileName;
                string content = richTextBox1.Text.ToUpper();
                string filenames = Path.GetFileName(FileName);

                if (System.IO.File.Exists(FileName))
                {
                    var result = MessageBox.Show($"File {filenames} đã tồn tại. Bạn có muốn chỉnh sửa nội dung file không?",
                                                  "Cảnh báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        System.IO.File.WriteAllText(FileName,string.Empty);

                        using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
                        {
                            byte[] ct = Encoding.UTF8.GetBytes(content);
                            fs.Write(ct, 0, ct.Length);
                        }
                        MessageBox.Show($"Nội dung của file {filenames} đã được cập nhật!");
                    }
                    else
                    {
                        btn_wri_Click(sender, e);
                    }
                }
                else
                {
                    using (FileStream fs = new FileStream(FileName, FileMode.Create))
                    {
                        byte[] ct = Encoding.UTF8.GetBytes(content);
                        fs.Write(ct, 0, ct.Length);
                    }
                    MessageBox.Show($"Tạo file {filenames} mới thành công");
                }
            }
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
