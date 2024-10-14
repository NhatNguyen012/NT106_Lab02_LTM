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
            public double DiemToan;
            public double DiemVan;
        }

        private static bool checkSDT(string sdt)
        {
            foreach (char x in sdt)
            {
                if( x < '0' || x > '9') return false;
            }
            return true;
        }
        private void btn_Input_Click(object sender, EventArgs e)
        {
            if (!checkSDT(tb_dt.Text))
            {
                MessageBox.Show($"Vui lòng nhập đúng định dạng của số điện thoại !");
                return;
            }

            if (!double.TryParse(tb_Toan.Text, out double diemtoan) || diemtoan < 0 || diemtoan > 10) {
                MessageBox.Show("Điểm Toán phải nằm trong phạm vi 0 - 10!","Lỗi nhập điểm",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(tb_Van.Text, out double diemvan) || diemvan < 0 || diemvan > 10)
            {
                MessageBox.Show("Điểm Văn phải nằm trong phạm vi 0 - 10!", "Lỗi nhập điểm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SinhVien sv = new SinhVien();
            sv.MSSV = tb_mssv.Text;
            sv.HoTen = tb_ten.Text;
            sv.DienThoai = tb_dt.Text;
            sv.DiemToan = diemtoan;
            sv.DiemVan = diemvan;

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
