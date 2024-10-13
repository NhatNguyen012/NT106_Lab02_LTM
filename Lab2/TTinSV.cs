using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class TTinSV : Form
    {
        public TTinSV()
        {
            InitializeComponent();
        }
        struct SinhVien
        {
            public string MSSV;
            public string HoTen;
            public string DienThoai;
            public float DiemToan;
            public float DiemVan;
        }
        private void btn_Input_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = tb_mssv.Text;
            sv.HoTen = tb_ten.Text;
            sv.DienThoai = tb_dt.Text;
            sv.DiemToan = float.Parse(tb_Toan.Text);
            sv.DiemVan = float.Parse(tb_Van.Text);

            LuuSV(sv);

            MessageBox.Show("Thông tin sinh viên đã được lưu!");
            tb_mssv.Text = "";
            tb_ten.Text = "";
            tb_dt.Text = "";
            tb_Toan.Text = "";
            tb_Van.Text = "";
        }

        private void LuuSV(SinhVien sv)
        {
            string FilePath = "input.txt";
            string content = $"{sv.MSSV};{sv.HoTen};{sv.DienThoai};{sv.DiemToan};{sv.DiemVan}";
            using (StreamWriter sw = new StreamWriter(FilePath, true))
            {
                sw.WriteLine(content);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
