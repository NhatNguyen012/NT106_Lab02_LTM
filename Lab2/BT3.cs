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
            if (input != "")
            {
                string inpFilePath = @"D:\0. UIT\HK3\LTMCB\3. Thuc Hanh\LAB_02\NT106_Lab2\Testcase\BT3\input.txt";
                UnicodeEncoding uniencoding = new UnicodeEncoding();
                byte[] result = uniencoding.GetBytes(input);
                using (FileStream writer = new FileStream(inpFilePath, FileMode.OpenOrCreate))
                {
                    writer.Seek(0, SeekOrigin.End);
                    await writer.WriteAsync(result, 0, result.Length);
                }
                MessageBox.Show("Ghi file thành công.");
            }
            /*else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào textbox Input");
            }*/
        }

        private async void btn_Read_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Tệp văn bản (*.txt) | *.txt";
            ofd.ShowDialog();
            string filePath = ofd.FileName;

            try
            {
                Byte[] bytes;
                using (FileStream reader = File.Open(filePath, FileMode.Open))
                {
                    bytes = new Byte[reader.Length];
                    await reader.ReadAsync(bytes, 0, (int)reader.Length); // Sử dụng 'reader' thay vì 'fs'
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
                else output += line + res + Environment.NewLine;
                content = content.Substring(index + 1);
                index = content.IndexOf('\n');
            }
            content = content.Replace("\n","");
            if (content.Length > 0)
            {
                line = content.Replace("\r", "");
                indexLine++;
                res = CalculateExpression(line, indexLine);
                if (res == "Không thể chia hết cho 0" || res == "Lỗi biểu thức")
                {
                    output += res + Environment.NewLine;

                }
                else output += line + " = " + res + Environment.NewLine;
                /*MessageBox.Show("Bugggg: " + content.IndexOf("\n"));*/
            }

            string outFilePath = @"D:\0. UIT\HK3\LTMCB\3. Thuc Hanh\LAB_02\NT106_Lab2\Testcase\BT3\output.txt";
            UnicodeEncoding uniencoding = new UnicodeEncoding();
            byte[] result = uniencoding.GetBytes(output);
            using (FileStream writer = new FileStream(outFilePath, FileMode.OpenOrCreate))
            {
                writer.Seek(0, SeekOrigin.End);
                await writer.WriteAsync(result, 0, result.Length);
            }
            tb_Output.Text = output;

        }

        // Kiểm tra và thực hiện tính toán trong file
        // Hàm startCalculator() sẽ trả về 0 nếu các phép tính trong file thỏa điều kiện
        // Ngược lại, trả về indexLine

        private static int startCalculator(string line, int indexLine, ref long res)
        {
            string[] elements = line.Split();
            if (elements.Length == 0)
            {
                return indexLine;

            }
            else
            {
                int num1 = 0;
                int num2 = 0;
                bool checkNum1 = Int32.TryParse(elements[0], out num1);
                bool checkNum2 = Int32.TryParse(elements[2], out num2);
                char operation = elements[1][0];
                string operations = "+ - * /";
                if (!checkNum1)
                {
                    MessageBox.Show($"Phép tính số {indexLine} có các toán hạng thứ nhất không đúng định dạng hoặc quá giới hạn cho phép.\nVui lòng kiểm trả lại.");
                    return indexLine;
                }
                else if (!checkNum2)
                {
                    MessageBox.Show($"Phép tính số {indexLine} có các toán hạng thứ hai không đúng định dạng hoặc quá giới hạn cho phép.\nVui lòng kiểm trả lại.");
                    return indexLine;
                }
                else if (operations.IndexOf(operation) != -1)
                {
                    switch (operation)
                    {
                        case '+':
                            res += num1 + num2;
                            break;
                        case '-':
                            res += num1 - num2;
                            break;
                        case '*':
                            res = 1;
                            res *= num1 * num2;
                            break;
                        case '/':
                            res = 1;
                            if (num2 == 0)
                            {
                                MessageBox.Show($"Phép tính ở dòng {indexLine} lỗi do chia cho số 0", "Cảnh báo: Đang chia cho số 0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return indexLine;
                            }
                            res = num1 / num2;
                            break;
                    }
                    return 0;
                }
                else
                {
                    MessageBox.Show($"Phép tính thứ {indexLine} không tồn tại.\nVui lòng kiểm tra lại.");
                    return indexLine;
                }
            }
        }

        // Function to check if the character is an operator
        public static bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        // Function to check if the character is a digit
        public static bool IsDigit(char c)
        {
            return char.IsDigit(c) || c == '.';
        }

        // Function to return precedence of operators
        public static int Precedence(char op)
        {
            if (op == '+' || op == '-') return 1;
            if (op == '*' || op == '/') return 2;
            return 0;
        }

        // Function to apply an operation to two numbers
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

        // Function to convert infix expression to postfix
        public static string InfixToPostfix(string expr)
        {
            Stack<char> ops = new Stack<char>();
            string output = "";
            bool lastWasOperator = true; // Track if the last character was an operator for handling negative numbers

            for (int i = 0; i < expr.Length; i++)
            {
                char c = expr[i];

                // If the character is a digit or part of a negative number, add it to output
                if (IsDigit(c) || (c == '-' && lastWasOperator))
                {
                    output += c;
                    lastWasOperator = false;
                    while (i + 1 < expr.Length && IsDigit(expr[i + 1]))
                    {
                        output += expr[++i]; // handle multi-digit numbers
                    }
                    output += " "; // Add space to separate numbers
                }
                // If the character is '(', push it to stack
                else if (c == '(')
                {
                    ops.Push(c);
                    lastWasOperator = true;
                }
                // If the character is ')', pop and output until '(' is found
                else if (c == ')')
                {
                    while (ops.Count > 0 && ops.Peek() != '(')
                    {
                        output += ops.Pop() + " ";
                    }
                    ops.Pop(); // Remove '('
                    lastWasOperator = false;
                }
                // If the character is an operator
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

            // Pop all the operators from the stack
            while (ops.Count > 0)
            {
                output += ops.Pop() + " ";
            }

            return output.Trim();
        }

        // Function to evaluate a postfix expression
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

        // Function to validate and calculate the expression
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
    }
}
