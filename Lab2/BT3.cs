using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab2
{
    public partial class BT3 : Form
    {
        public BT3()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        FileStream fs;
        private async void btn_Write_Click(object sender, EventArgs e)
        {
            string input = tb_Input.Text;
            if (!string.IsNullOrEmpty(input))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // Bộ lọc loại tệp
                saveFileDialog.Title = "Chọn vị trí lưu tệp";
                saveFileDialog.FileName = "input.txt"; // Tên tệp mặc định

                // Hiển thị hộp thoại chọn file và kiểm tra xem người dùng có bấm OK hay không
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    UnicodeEncoding uniencoding = new UnicodeEncoding();
                    byte[] result = uniencoding.GetBytes(input);

                    using (FileStream writer = new FileStream(filePath, FileMode.OpenOrCreate))
                    {
                        writer.Seek(0, SeekOrigin.End);
                        await writer.WriteAsync(result, 0, result.Length);
                    }
                }
                MessageBox.Show("Ghi file thành công!", "Ghi file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào textbox Input", "Không có thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }


        private async void btn_Read_Click(object sender, EventArgs e)
        {
            tb_Output.Text = "";
            ofd.Filter = "Tệp văn bản (*.txt) | *.txt";
            ofd.ShowDialog();
            string filePath = ofd.FileName;

            try
            {
                Byte[] bytes;
                using (FileStream reader = File.Open(filePath, FileMode.Open))
                {
                    bytes = new Byte[reader.Length];
                    await reader.ReadAsync(bytes, 0, (int)reader.Length);
                }

                string content = Encoding.UTF8.GetString(bytes);
                tb_Input.Text = content.ToString();
                tb_Input.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc tệp: " + ex.Message);
            }

        }


        private async void btn_Calculator_Click(object sender, EventArgs e)
        {
            if (tb_Input.Text == "")
            {
                MessageBox.Show("Không có dữ liệu ở textbox input\nVui lòng nhập dữ liệu.");
                return;
            }

            tb_Output.Text = String.Empty;
            string content = tb_Input.Text;
            int indexLine = 0;
            int index = content.IndexOf('\n');
            string output = "";
            string res;
            string line;
            while (index >= 0)
            {
                line = content.Substring(0, index);
                indexLine++;
                res = CalculateExpression(line, indexLine);
                if (res == "Không thể chia hết cho 0" || res == "Lỗi biểu thức")
                {
                    output += res + Environment.NewLine;
                }
                else
                {
                    output += line + " = " + res + Environment.NewLine;
                }
                content = content.Substring(index + 1);
                index = content.IndexOf('\n');
            }

            // Xử lý dòng cuối cùng nếu còn nội dung
            content = content.Replace("\n", "");
            if (content.Length > 0)
            {
                line = content.Replace("\r", "");
                indexLine++;
                res = CalculateExpression(line, indexLine);
                if (res == "Không thể chia hết cho 0" || res == "Lỗi biểu thức")
                {
                    output += res + Environment.NewLine;
                }
                else
                {
                    output += line + " = " + res + Environment.NewLine;
                }
            }

            // Hỏi người dùng có muốn chọn vị trí lưu tệp không
            DialogResult result = MessageBox.Show(
                "Bạn có muốn chọn vị trí lưu file không?\nNếu không thì sẽ lưu ở vị trí mặc định.",
                "Chọn vị trí lưu",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Khai báo biến lưu vị trí
            string inputFilePath;
            string outputFilePath;
            UnicodeEncoding unicodeEncoding = new UnicodeEncoding();

            if (result == DialogResult.Yes)
            {
                // Người dùng muốn chọn vị trí lưu tệp
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Chọn vị trí lưu file input";
                saveFileDialog.FileName = "input.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFilePath = saveFileDialog.FileName;
                }
                else
                {
                    MessageBox.Show("Lưu file input bị hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                saveFileDialog.Title = "Chọn vị trí lưu file output";
                saveFileDialog.FileName = "output.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    outputFilePath = saveFileDialog.FileName;
                }
                else
                {
                    MessageBox.Show("Lưu file output bị hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                // Người dùng không muốn chọn vị trí -> lưu tại thư mục mặc định
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                inputFilePath = Path.Combine(baseDirectory, "input.txt");
                outputFilePath = Path.Combine(baseDirectory, "output.txt");
            }

            // Ghi đè nội dung vào input.txt
            byte[] inputBytes = unicodeEncoding.GetBytes(tb_Input.Text);
            using (FileStream writer = new FileStream(inputFilePath, FileMode.Create))
            {
                await writer.WriteAsync(inputBytes, 0, inputBytes.Length);
            }

            // Ghi đè nội dung vào output.txt
            byte[] outputBytes = unicodeEncoding.GetBytes(output);
            using (FileStream writer = new FileStream(outputFilePath, FileMode.Create))
            {
                await writer.WriteAsync(outputBytes, 0, outputBytes.Length);
            }

            // Hiển thị kết quả trên tbOutput
            tb_Output.Text = output;
        }




        // Hàm check các phép toán toán học
        public static bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        // Hàm check số đó có phải là số thập phân
        public static bool IsDigit(char c)
        {
            return char.IsDigit(c) || c == '.';
        }

        // Set độ ưu tiên cho các phép tính
        public static int Precedence(char op)
        {
            if (op == '+' || op == '-') return 1;
            if (op == '*' || op == '/') return 2;
            return 0;
        }

        // Thực hiện tính toán
        public static double ApplyOperation(char op, double b, double a)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/':
                    if (b == 0) throw new DivideByZeroException("Không thể chia hết cho 0");
                    return a / b;
                default: return 0;
            }
        }

        // đưa về cấu trúc stack
        public static string InfixToPostfix(string expr)
        {
            Stack<char> ops = new Stack<char>();
            string output = "";
            bool lastWasOperator = true;

            for (int i = 0; i < expr.Length; i++)
            {
                char c = expr[i];

                if (IsDigit(c) || (c == '-' && lastWasOperator))
                {
                    output += c;
                    lastWasOperator = false;
                    while (i + 1 < expr.Length && IsDigit(expr[i + 1]))
                    {
                        output += expr[++i];
                    }
                    output += " ";
                }
                else if (c == '(')
                {
                    ops.Push(c);
                    lastWasOperator = true;
                }
                else if (c == ')')
                {
                    while (ops.Count > 0 && ops.Peek() != '(')
                    {
                        output += ops.Pop() + " ";
                    }
                    ops.Pop();
                    lastWasOperator = false;
                }
                else if (IsOperator(c))
                {
                    while (ops.Count > 0 && Precedence(ops.Peek()) >= Precedence(c))
                    {
                        output += ops.Pop() + " ";
                    }
                    ops.Push(c);
                    lastWasOperator = true;
                }
            }

            while (ops.Count > 0)
            {
                output += ops.Pop() + " ";
            }

            return output.Trim();
        }

        // Tính giá trị biểu thưcs
        public static double EvaluatePostfix(string postfix)
        {
            Stack<double> values = new Stack<double>();
            string[] tokens = postfix.Split(' ');

            foreach (string token in tokens)
            {
                // If the token is a number, push it to stack
                if (double.TryParse(token, out double num))
                {
                    values.Push(num);
                }
                // If the token is an operator, apply it to the top two elements
                else if (token.Length == 1 && IsOperator(token[0]))
                {
                    double b = values.Pop();
                    double a = values.Pop();
                    values.Push(ApplyOperation(token[0], b, a));
                }
            }

            return values.Pop();
        }

        // Thông báo trả về của biểu thức
        public static string CalculateExpression(string expr, int indexLine)
        {
            try
            {
                // Remove spaces and check for valid characters
                expr = expr.Replace(" ", "").Replace("\n", "").Replace("\r", "");
                foreach (char c in expr)
                {
                    if (!char.IsDigit(c) && !IsOperator(c) && c != '(' && c != ')' && c != '.')
                    {

                        return "Lỗi biểu thức";
                    }
                }

                // Convert the expression to postfix and evaluate it
                string postfix = InfixToPostfix(expr);
                double result = EvaluatePostfix(postfix);
                return result.ToString();
            }
            catch (Exception ex)
            {
                if (ex.Message != "Không thể chia hết cho 0")
                    return "Lỗi biểu thức";
                return $"{ex.Message}";
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
