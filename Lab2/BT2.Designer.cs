namespace Lab2
{
    partial class BT2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Read = new Button();
            lbl_FileName = new Label();
            tb_FileName = new TextBox();
            tb_URL = new TextBox();
            lbl_URL = new Label();
            tb_ShowText = new TextBox();
            tb_Line = new TextBox();
            lbl_Line = new Label();
            tb_Word = new TextBox();
            lbl_Word = new Label();
            tb_Char = new TextBox();
            lbl_Char = new Label();
            lbl_Title = new Label();
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // btn_Read
            // 
            btn_Read.BackColor = Color.SteelBlue;
            btn_Read.Cursor = Cursors.Hand;
            btn_Read.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Read.ForeColor = SystemColors.Window;
            btn_Read.Image = Properties.Resources.archive;
            btn_Read.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Read.Location = new Point(159, 457);
            btn_Read.Name = "btn_Read";
            btn_Read.Padding = new Padding(4, 0, 4, 0);
            btn_Read.Size = new Size(164, 55);
            btn_Read.TabIndex = 1;
            btn_Read.Text = "ĐỌC FILE";
            btn_Read.TextAlign = ContentAlignment.MiddleRight;
            btn_Read.UseVisualStyleBackColor = false;
            btn_Read.Click += btn_Read_Click;
            // 
            // lbl_FileName
            // 
            lbl_FileName.AutoSize = true;
            lbl_FileName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_FileName.Location = new Point(24, 99);
            lbl_FileName.Name = "lbl_FileName";
            lbl_FileName.Size = new Size(79, 23);
            lbl_FileName.TabIndex = 2;
            lbl_FileName.Text = "Tên file";
            // 
            // tb_FileName
            // 
            tb_FileName.BackColor = SystemColors.Window;
            tb_FileName.BorderStyle = BorderStyle.FixedSingle;
            tb_FileName.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_FileName.Location = new Point(119, 99);
            tb_FileName.Name = "tb_FileName";
            tb_FileName.ReadOnly = true;
            tb_FileName.Size = new Size(204, 31);
            tb_FileName.TabIndex = 3;
            // 
            // tb_URL
            // 
            tb_URL.BackColor = SystemColors.Window;
            tb_URL.BorderStyle = BorderStyle.FixedSingle;
            tb_URL.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_URL.Location = new Point(119, 178);
            tb_URL.Name = "tb_URL";
            tb_URL.ReadOnly = true;
            tb_URL.ScrollBars = ScrollBars.Horizontal;
            tb_URL.Size = new Size(204, 31);
            tb_URL.TabIndex = 11;
            // 
            // lbl_URL
            // 
            lbl_URL.AutoSize = true;
            lbl_URL.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_URL.Location = new Point(24, 178);
            lbl_URL.Name = "lbl_URL";
            lbl_URL.Size = new Size(48, 23);
            lbl_URL.TabIndex = 10;
            lbl_URL.Text = "URL";
            // 
            // tb_ShowText
            // 
            tb_ShowText.Location = new Point(350, 70);
            tb_ShowText.Multiline = true;
            tb_ShowText.Name = "tb_ShowText";
            tb_ShowText.ScrollBars = ScrollBars.Vertical;
            tb_ShowText.Size = new Size(427, 442);
            tb_ShowText.TabIndex = 0;
            // 
            // tb_Line
            // 
            tb_Line.BackColor = SystemColors.Window;
            tb_Line.BorderStyle = BorderStyle.FixedSingle;
            tb_Line.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Line.Location = new Point(119, 249);
            tb_Line.Name = "tb_Line";
            tb_Line.ReadOnly = true;
            tb_Line.Size = new Size(204, 31);
            tb_Line.TabIndex = 13;
            // 
            // lbl_Line
            // 
            lbl_Line.AutoSize = true;
            lbl_Line.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Line.Location = new Point(24, 249);
            lbl_Line.Name = "lbl_Line";
            lbl_Line.Size = new Size(80, 23);
            lbl_Line.TabIndex = 12;
            lbl_Line.Text = "Số dòng";
            // 
            // tb_Word
            // 
            tb_Word.BackColor = SystemColors.Window;
            tb_Word.BorderStyle = BorderStyle.FixedSingle;
            tb_Word.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Word.Location = new Point(119, 321);
            tb_Word.Name = "tb_Word";
            tb_Word.ReadOnly = true;
            tb_Word.Size = new Size(204, 31);
            tb_Word.TabIndex = 15;
            // 
            // lbl_Word
            // 
            lbl_Word.AutoSize = true;
            lbl_Word.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Word.Location = new Point(24, 321);
            lbl_Word.Name = "lbl_Word";
            lbl_Word.Size = new Size(56, 23);
            lbl_Word.TabIndex = 14;
            lbl_Word.Text = "Số từ";
            // 
            // tb_Char
            // 
            tb_Char.BackColor = SystemColors.Window;
            tb_Char.BorderStyle = BorderStyle.FixedSingle;
            tb_Char.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Char.Location = new Point(119, 390);
            tb_Char.Name = "tb_Char";
            tb_Char.ReadOnly = true;
            tb_Char.Size = new Size(204, 31);
            tb_Char.TabIndex = 17;
            // 
            // lbl_Char
            // 
            lbl_Char.AutoSize = true;
            lbl_Char.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Char.Location = new Point(24, 390);
            lbl_Char.Name = "lbl_Char";
            lbl_Char.Size = new Size(78, 23);
            lbl_Char.TabIndex = 16;
            lbl_Char.Text = "Số kí tự";
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.Location = new Point(227, 18);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(332, 33);
            lbl_Title.TabIndex = 18;
            lbl_Title.Text = "ĐỌC THÔNG TIN TẬP TIN";
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.LemonChiffon;
            btn_Exit.Cursor = Cursors.Hand;
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Exit.ForeColor = Color.LemonChiffon;
            btn_Exit.Image = Properties.Resources.left_arrow_in_circular_button_black_symbol1;
            btn_Exit.Location = new Point(2, 3);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(57, 62);
            btn_Exit.TabIndex = 19;
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += button1_Click;
            // 
            // BT2
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(800, 526);
            Controls.Add(btn_Exit);
            Controls.Add(lbl_Title);
            Controls.Add(tb_Char);
            Controls.Add(lbl_Char);
            Controls.Add(tb_Word);
            Controls.Add(lbl_Word);
            Controls.Add(tb_Line);
            Controls.Add(lbl_Line);
            Controls.Add(tb_URL);
            Controls.Add(lbl_URL);
            Controls.Add(tb_FileName);
            Controls.Add(lbl_FileName);
            Controls.Add(btn_Read);
            Controls.Add(tb_ShowText);
            Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BT2";
            Text = "BT2 _ Đọc thông tin tập tin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Read;
        private Label lbl_FileName;
        private TextBox tb_FileName;
        private TextBox tb_URL;
        private Label lbl_URL;
        private TextBox tb_ShowText;
        private TextBox tb_Line;
        private Label lbl_Line;
        private TextBox tb_Word;
        private Label lbl_Word;
        private TextBox tb_Char;
        private Label lbl_Char;
        private Label lbl_Title;
        private Button btn_Exit;
    }
}