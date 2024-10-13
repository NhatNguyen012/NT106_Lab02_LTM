namespace Lab2
{
    partial class TTinSV
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
            lb_Title = new Label();
            lb_Hoten = new Label();
            lb_mssv = new Label();
            lb_Van = new Label();
            lb_Toan = new Label();
            lb_DT = new Label();
            tb_ten = new TextBox();
            tb_Toan = new TextBox();
            tb_Van = new TextBox();
            tb_dt = new TextBox();
            tb_mssv = new TextBox();
            btn_Input = new Button();
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // lb_Title
            // 
            lb_Title.AutoSize = true;
            lb_Title.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Title.ForeColor = Color.Red;
            lb_Title.Location = new Point(249, 9);
            lb_Title.Name = "lb_Title";
            lb_Title.Size = new Size(322, 32);
            lb_Title.TabIndex = 0;
            lb_Title.Text = "THÔNG TIN SINH VIÊN";
            // 
            // lb_Hoten
            // 
            lb_Hoten.AutoSize = true;
            lb_Hoten.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lb_Hoten.Location = new Point(49, 63);
            lb_Hoten.Name = "lb_Hoten";
            lb_Hoten.Size = new Size(62, 20);
            lb_Hoten.TabIndex = 1;
            lb_Hoten.Text = "Họ tên";
            // 
            // lb_mssv
            // 
            lb_mssv.AutoSize = true;
            lb_mssv.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lb_mssv.Location = new Point(49, 120);
            lb_mssv.Name = "lb_mssv";
            lb_mssv.Size = new Size(59, 20);
            lb_mssv.TabIndex = 2;
            lb_mssv.Text = "MSSV";
            // 
            // lb_Van
            // 
            lb_Van.AutoSize = true;
            lb_Van.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lb_Van.Location = new Point(49, 269);
            lb_Van.Name = "lb_Van";
            lb_Van.Size = new Size(87, 20);
            lb_Van.TabIndex = 3;
            lb_Van.Text = "Điểm Văn";
            // 
            // lb_Toan
            // 
            lb_Toan.AutoSize = true;
            lb_Toan.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lb_Toan.Location = new Point(49, 220);
            lb_Toan.Name = "lb_Toan";
            lb_Toan.Size = new Size(93, 20);
            lb_Toan.TabIndex = 4;
            lb_Toan.Text = "Điểm Toán";
            // 
            // lb_DT
            // 
            lb_DT.AutoSize = true;
            lb_DT.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lb_DT.Location = new Point(49, 171);
            lb_DT.Name = "lb_DT";
            lb_DT.Size = new Size(112, 20);
            lb_DT.TabIndex = 5;
            lb_DT.Text = "Số điện thoại";
            // 
            // tb_ten
            // 
            tb_ten.Location = new Point(165, 56);
            tb_ten.Name = "tb_ten";
            tb_ten.Size = new Size(496, 27);
            tb_ten.TabIndex = 6;
            // 
            // tb_Toan
            // 
            tb_Toan.Location = new Point(165, 213);
            tb_Toan.Name = "tb_Toan";
            tb_Toan.Size = new Size(496, 27);
            tb_Toan.TabIndex = 7;
            // 
            // tb_Van
            // 
            tb_Van.Location = new Point(165, 262);
            tb_Van.Name = "tb_Van";
            tb_Van.Size = new Size(496, 27);
            tb_Van.TabIndex = 8;
            // 
            // tb_dt
            // 
            tb_dt.Location = new Point(165, 164);
            tb_dt.Name = "tb_dt";
            tb_dt.Size = new Size(496, 27);
            tb_dt.TabIndex = 9;
            // 
            // tb_mssv
            // 
            tb_mssv.Location = new Point(165, 113);
            tb_mssv.Name = "tb_mssv";
            tb_mssv.Size = new Size(496, 27);
            tb_mssv.TabIndex = 10;
            // 
            // btn_Input
            // 
            btn_Input.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Input.Location = new Point(249, 346);
            btn_Input.Name = "btn_Input";
            btn_Input.Size = new Size(94, 29);
            btn_Input.TabIndex = 11;
            btn_Input.Text = "Nhập";
            btn_Input.UseVisualStyleBackColor = true;
            btn_Input.Click += btn_Input_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(431, 346);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(94, 29);
            btn_Exit.TabIndex = 12;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // TTinSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 450);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Input);
            Controls.Add(tb_mssv);
            Controls.Add(tb_dt);
            Controls.Add(tb_Van);
            Controls.Add(tb_Toan);
            Controls.Add(tb_ten);
            Controls.Add(lb_DT);
            Controls.Add(lb_Toan);
            Controls.Add(lb_Van);
            Controls.Add(lb_mssv);
            Controls.Add(lb_Hoten);
            Controls.Add(lb_Title);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TTinSV";
            Text = "Thông tin sinh viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Title;
        private Label lb_Hoten;
        private Label lb_mssv;
        private Label lb_Van;
        private Label lb_Toan;
        private Label lb_DT;
        private TextBox tb_ten;
        private TextBox tb_Toan;
        private TextBox tb_Van;
        private TextBox tb_dt;
        private TextBox tb_mssv;
        private Button btn_Input;
        private Button btn_Exit;
    }
}