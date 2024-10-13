using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public partial class BT5 : Form
    {
        public BT5()
        {
            InitializeComponent();
        }
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        private ImageList imageList;
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.ShowNewFolderButton = true;
            fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = fbd.SelectedPath;
                tb_Path.Text = selectedPath;

                DirectoryInfo directoryInfo = new DirectoryInfo(selectedPath);
                DirectoryInfo[] folderArr = directoryInfo.GetDirectories();
                FileInfo[] fileArr = directoryInfo.GetFiles();
                foreach (DirectoryInfo folder in folderArr)
                {
                    ListViewItem item = new ListViewItem(folder.Name, "folder");
                    item.SubItems.Add(folder.LastWriteTime.ToString());
                    item.SubItems.Add("File Folder");
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                    listView_InforFile.Items.Add(item);
                }
                foreach (FileInfo file in fileArr)
                {
                    ListViewItem item = new ListViewItem(file.Name.Substring(0, file.Name.LastIndexOf('.')), "file");
                    item.SubItems.Add(file.LastWriteTime.ToString());
                    item.SubItems.Add(file.Extension.Substring(1).ToUpper());
                    double sizeInKb = file.Length / 1024.0;
                    string fileSize;
                    if (sizeInKb < 1024)
                    {
                        fileSize = sizeInKb.ToString("F2") + " KB";
                    }
                    else
                    {
                        fileSize = (sizeInKb / 1024.0).ToString("F2") + " MB";
                    }
                    item.SubItems.Add(fileSize);
                    item.SubItems.Add("");
                    listView_InforFile.Items.Add(item);

                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            string selectedPath = fbd.SelectedPath;
            MessageBox.Show(fbd.SelectedPath.ToString());
            int index = selectedPath.LastIndexOf('\\');
            if (index != -1)
            {

                selectedPath = selectedPath.Substring(0, index);
                if (selectedPath.EndsWith(":"))
                {
                    selectedPath = selectedPath + "\\";
                }
                tb_Path.Text = selectedPath;
                fbd.SelectedPath = selectedPath;
                listView_InforFile.Items.Clear();

                DirectoryInfo directoryInfo = new DirectoryInfo(selectedPath);
                DirectoryInfo[] folderArr = directoryInfo.GetDirectories();
                FileInfo[] fileArr = directoryInfo.GetFiles();
                foreach (DirectoryInfo folder in folderArr)
                {
                    ListViewItem item = new ListViewItem(folder.Name, "folder");
                    item.SubItems.Add(folder.LastWriteTime.ToString());
                    item.SubItems.Add("File Folder");
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                    listView_InforFile.Items.Add(item);
                }
                foreach (FileInfo file in fileArr)
                {
                    ListViewItem item = new ListViewItem(file.Name.Substring(0, file.Name.LastIndexOf('.')), "file");
                    item.SubItems.Add(file.LastWriteTime.ToString());
                    item.SubItems.Add(file.Extension.Substring(1).ToUpper());
                    double sizeInKb = file.Length / 1024.0;
                    string fileSize;
                    if (sizeInKb < 1024)
                    {
                        fileSize = sizeInKb.ToString("F2") + " KB";
                    }
                    else
                    {
                        fileSize = (sizeInKb / 1024.0).ToString("F2") + " MB";
                    }
                    item.SubItems.Add(fileSize);
                    item.SubItems.Add("");
                    listView_InforFile.Items.Add(item);

                }
                if (selectedPath.EndsWith(":\\"))
                {
                    selectedPath = selectedPath.Substring(0, index - 1);
                }
            }
            else
            {
                selectedPath = String.Empty;
            }

        }
        private void tb_Path_KeyPress(object sender, KeyPressEventArgs e)
        {
            string rootPath = fbd.SelectedPath;
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                string selectedPath = tb_Path.Text;
                if (Directory.Exists(selectedPath))
                {
                    tb_Path.Text = selectedPath;
                    fbd.SelectedPath = selectedPath;
                    listView_InforFile.Items.Clear();

                    DirectoryInfo directoryInfo = new DirectoryInfo(selectedPath);
                    DirectoryInfo[] folderArr = directoryInfo.GetDirectories();
                    FileInfo[] fileArr = directoryInfo.GetFiles();
                    foreach (DirectoryInfo folder in folderArr)
                    {
                        ListViewItem item = new ListViewItem(folder.Name, "folder");
                        item.SubItems.Add(folder.LastWriteTime.ToString());
                        item.SubItems.Add("File Folder");
                        item.SubItems.Add("");
                        item.SubItems.Add("");
                        listView_InforFile.Items.Add(item);
                    }
                    foreach (FileInfo file in fileArr)
                    {
                        ListViewItem item = new ListViewItem(file.Name.Substring(0, file.Name.LastIndexOf('.')), "file");
                        item.SubItems.Add(file.LastWriteTime.ToString());
                        item.SubItems.Add(file.Extension.Substring(1).ToUpper());
                        double sizeInKb = file.Length / 1024.0;
                        string fileSize;
                        if (sizeInKb < 1024)
                        {
                            fileSize = sizeInKb.ToString("F2") + " KB";
                        }
                        else
                        {
                            fileSize = (sizeInKb / 1024.0).ToString("F2") + " MB";
                        }
                        item.SubItems.Add(fileSize);
                        item.SubItems.Add("");
                        listView_InforFile.Items.Add(item);

                    }
                    fbd.SelectedPath = selectedPath;
                }
                else
                {
                    MessageBox.Show("Thư mục không tồn tại.");
                    fbd.SelectedPath = rootPath;
                    tb_Path.Text = rootPath;
                }
            }
        }
    }
}
