namespace Lab2
{
    partial class BT4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BT4));
            btn_Nhapttsv = new Button();
            btn_Luuttsv = new Button();
            btn_ShowDSSV = new Button();
            dataGview_QLSV = new DataGridView();
            btn_Exit = new Button();
            btn_Clear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGview_QLSV).BeginInit();
            SuspendLayout();
            // 
            // btn_Nhapttsv
            // 
            btn_Nhapttsv.BackColor = SystemColors.ButtonHighlight;
            btn_Nhapttsv.FlatStyle = FlatStyle.Flat;
            btn_Nhapttsv.Font = new Font("Georgia", 9F, FontStyle.Bold);
            btn_Nhapttsv.ForeColor = Color.Blue;
            btn_Nhapttsv.Location = new Point(685, 38);
            btn_Nhapttsv.Name = "btn_Nhapttsv";
            btn_Nhapttsv.Size = new Size(173, 35);
            btn_Nhapttsv.TabIndex = 1;
            btn_Nhapttsv.Text = "Nhập thông tin ✍";
            btn_Nhapttsv.UseVisualStyleBackColor = false;
            btn_Nhapttsv.Click += btn_Nhapttsv_Click;
            // 
            // btn_Luuttsv
            // 
            btn_Luuttsv.BackColor = SystemColors.ButtonHighlight;
            btn_Luuttsv.FlatStyle = FlatStyle.Flat;
            btn_Luuttsv.Font = new Font("Georgia", 9F, FontStyle.Bold);
            btn_Luuttsv.ForeColor = Color.Teal;
            btn_Luuttsv.Location = new Point(685, 120);
            btn_Luuttsv.Name = "btn_Luuttsv";
            btn_Luuttsv.Size = new Size(173, 35);
            btn_Luuttsv.TabIndex = 2;
            btn_Luuttsv.Text = "Lưu File Excel 💾";
            btn_Luuttsv.UseVisualStyleBackColor = false;
            btn_Luuttsv.Click += btn_Luuttsv_Click;
            // 
            // btn_ShowDSSV
            // 
            btn_ShowDSSV.BackColor = SystemColors.ButtonHighlight;
            btn_ShowDSSV.FlatStyle = FlatStyle.Flat;
            btn_ShowDSSV.Font = new Font("Georgia", 9F, FontStyle.Bold);
            btn_ShowDSSV.ForeColor = Color.DarkOrange;
            btn_ShowDSSV.Location = new Point(685, 205);
            btn_ShowDSSV.Name = "btn_ShowDSSV";
            btn_ShowDSSV.Size = new Size(173, 35);
            btn_ShowDSSV.TabIndex = 3;
            btn_ShowDSSV.Text = "Hiển thị 👀";
            btn_ShowDSSV.UseVisualStyleBackColor = false;
            btn_ShowDSSV.Click += btn_ShowDSSV_Click;
            // 
            // dataGview_QLSV
            // 
            dataGview_QLSV.BackgroundColor = SystemColors.Control;
            dataGview_QLSV.BorderStyle = BorderStyle.Fixed3D;
            dataGview_QLSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGview_QLSV.Location = new Point(21, 21);
            dataGview_QLSV.Name = "dataGview_QLSV";
            dataGview_QLSV.RowHeadersWidth = 51;
            dataGview_QLSV.Size = new Size(645, 400);
            dataGview_QLSV.TabIndex = 4;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = SystemColors.ButtonHighlight;
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.Font = new Font("Georgia", 9F, FontStyle.Bold);
            btn_Exit.ForeColor = Color.Red;
            btn_Exit.Location = new Point(685, 361);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(173, 35);
            btn_Exit.TabIndex = 5;
            btn_Exit.Text = "Thoát 🚪";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = SystemColors.ButtonHighlight;
            btn_Clear.FlatStyle = FlatStyle.Flat;
            btn_Clear.Font = new Font("Georgia", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Clear.Location = new Point(685, 286);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(173, 35);
            btn_Clear.TabIndex = 6;
            btn_Clear.Text = "Xóa Files (.txt||.xlsx)";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // BT4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(879, 450);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Exit);
            Controls.Add(dataGview_QLSV);
            Controls.Add(btn_ShowDSSV);
            Controls.Add(btn_Luuttsv);
            Controls.Add(btn_Nhapttsv);
            Name = "BT4";
            Text = "Quản lí sinh viên";
            ((System.ComponentModel.ISupportInitialize)dataGview_QLSV).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_Nhapttsv;
        private Button btn_Luuttsv;
        private Button btn_ShowDSSV;
        private DataGridView dataGview_QLSV;
        private Button btn_Exit;
        private Button btn_Clear;
    }
}