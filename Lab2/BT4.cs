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
using ClosedXML.Excel;

namespace Lab2
{
    public partial class BT4 : Form
    {
        public BT4()
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
            public double DTB;
        }

        List<SinhVien> dsSinhVien = new List<SinhVien>();

        private void ReadFiletxt()
        {
            string filePath = "input.txt";
            dsSinhVien.Clear();
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] str = line.Split(';');
                        SinhVien sv = new SinhVien
                        {
                            MSSV = str[0],
                            HoTen = str[1],
                            DienThoai = str[2],
                            DiemToan = double.Parse(str[3]),
                            DiemVan = double.Parse(str[4])
                        };
                        sv.DTB = (sv.DiemToan + sv.DiemVan) / 2;
                        dsSinhVien.Add(sv);
                    }
                }
            }
        }

        private void LuuVaoFileExcel()
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Danh sách sinh viên");

                    worksheet.Cell(1, 1).Value = "MSSV";
                    worksheet.Cell(1, 2).Value = "Họ Tên";
                    worksheet.Cell(1, 3).Value = "Điện Thoại";
                    worksheet.Cell(1, 4).Value = "Điểm Toán";
                    worksheet.Cell(1, 5).Value = "Điểm Văn";
                    worksheet.Cell(1, 6).Value = "Điểm Trung Bình";

                    int row = 2;
                    foreach (SinhVien sv in dsSinhVien)
                    {
                        worksheet.Cell(row, 1).Value = sv.MSSV;
                        worksheet.Cell(row, 2).Value = sv.HoTen;
                        worksheet.Cell(row, 3).Value = sv.DienThoai;
                        worksheet.Cell(row, 4).Value = sv.DiemToan;
                        worksheet.Cell(row, 5).Value = sv.DiemVan;
                        worksheet.Cell(row, 6).Value = sv.DTB;
                        row++;
                    }

                    string savePath = "QLSV.xlsx";
                    workbook.SaveAs(savePath);
                }

                MessageBox.Show("Dữ liệu đã được lưu vào file Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void btn_Nhapttsv_Click(object sender, EventArgs e)
        {
            TTinSV form = new TTinSV();
            form.Show();
        }

        private void btn_Luuttsv_Click(object sender, EventArgs e)
        {
            ReadFiletxt();
            LuuVaoFileExcel();
        }

        private void btn_ShowDSSV_Click(object sender, EventArgs e)
        {
            try
            {
                using (var workbook = new XLWorkbook("QLSV.xlsx"))
                {
                    var worksheet = workbook.Worksheet(1);
                    var rows = worksheet.RowsUsed().Skip(1);

                    var dataTable = new DataTable();
                    dataTable.Columns.Add("MSSV");
                    dataTable.Columns.Add("Họ Tên");
                    dataTable.Columns.Add("Điện Thoại");
                    dataTable.Columns.Add("Điểm Toán");
                    dataTable.Columns.Add("Điểm Văn");
                    dataTable.Columns.Add("Điểm Trung Bình");

                    foreach (var row in rows)
                    {
                        dataTable.Rows.Add(
                            row.Cell(1).Value.ToString(),
                            row.Cell(2).Value.ToString(),
                            row.Cell(3).Value.ToString(),
                            double.Parse(row.Cell(4).Value.ToString()),
                            double.Parse(row.Cell(5).Value.ToString()),
                            double.Parse(row.Cell(6).Value.ToString())
                        );
                    }
                    dataGview_QLSV.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi đọc file Excel: {ex.Message}");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa dữ liệu trong file input.txt và QLSV.xlsx không ?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                try
                {
                    string FilePath = "input.txt";
                    if (File.Exists(FilePath))
                    {
                        File.WriteAllText(FilePath, string.Empty);
                    }

                    string excelFilePath = "QLSV.xlsx";
                    if (File.Exists(excelFilePath))
                    {
                        using (var workbook = new XLWorkbook(excelFilePath))
                        {
                            var worksheet = workbook.Worksheet(1);
                            worksheet.Clear();
                            workbook.Save();
                        }
                    }

                    MessageBox.Show($"Đã xóa thành công !");
                }
                catch (Exception ex) {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
            }
        }
    }
}
