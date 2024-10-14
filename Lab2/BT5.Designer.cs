namespace Lab2
{
    partial class BT5
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
            panel1 = new Panel();
            btn_Back = new Button();
            btn_Browse = new Button();
            tb_Path = new TextBox();
            lbl_Path = new Label();
            listView_InforFile = new ListView();
            columnHeader_Name = new ColumnHeader("(none)");
            columnHeader_DateModifed = new ColumnHeader();
            columnHeader_Type = new ColumnHeader();
            columnHeader_Size = new ColumnHeader();
            columnHeader_Other = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(btn_Back);
            panel1.Controls.Add(btn_Browse);
            panel1.Controls.Add(tb_Path);
            panel1.Controls.Add(lbl_Path);
            panel1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 83);
            panel1.TabIndex = 0;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.LightYellow;
            btn_Back.Cursor = Cursors.Hand;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Location = new Point(704, 26);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(84, 38);
            btn_Back.TabIndex = 3;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // btn_Browse
            // 
            btn_Browse.BackColor = Color.LightYellow;
            btn_Browse.Cursor = Cursors.Hand;
            btn_Browse.FlatStyle = FlatStyle.Flat;
            btn_Browse.Location = new Point(587, 26);
            btn_Browse.Name = "btn_Browse";
            btn_Browse.Size = new Size(100, 38);
            btn_Browse.TabIndex = 2;
            btn_Browse.Text = "Browse";
            btn_Browse.UseVisualStyleBackColor = false;
            btn_Browse.Click += btn_Browse_Click;
            // 
            // tb_Path
            // 
            tb_Path.Location = new Point(79, 26);
            tb_Path.Multiline = true;
            tb_Path.Name = "tb_Path";
            tb_Path.Size = new Size(492, 38);
            tb_Path.TabIndex = 1;
            tb_Path.KeyPress += tb_Path_KeyPress;
            // 
            // lbl_Path
            // 
            lbl_Path.AutoSize = true;
            lbl_Path.Location = new Point(19, 34);
            lbl_Path.Name = "lbl_Path";
            lbl_Path.Size = new Size(54, 23);
            lbl_Path.TabIndex = 0;
            lbl_Path.Text = "Path:";
            // 
            // listView_InforFile
            // 
            listView_InforFile.Columns.AddRange(new ColumnHeader[] { columnHeader_Name, columnHeader_DateModifed, columnHeader_Type, columnHeader_Size, columnHeader_Other });
            listView_InforFile.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            listView_InforFile.Location = new Point(0, 80);
            listView_InforFile.Name = "listView_InforFile";
            listView_InforFile.Size = new Size(801, 306);
            listView_InforFile.TabIndex = 1;
            listView_InforFile.UseCompatibleStateImageBehavior = false;
            listView_InforFile.View = View.Details;
            // 
            // columnHeader_Name
            // 
            columnHeader_Name.Text = "Name";
            columnHeader_Name.Width = 250;
            // 
            // columnHeader_DateModifed
            // 
            columnHeader_DateModifed.Text = "Date Modified";
            columnHeader_DateModifed.Width = 180;
            // 
            // columnHeader_Type
            // 
            columnHeader_Type.Text = "Type";
            columnHeader_Type.Width = 140;
            // 
            // columnHeader_Size
            // 
            columnHeader_Size.Text = "Size";
            columnHeader_Size.Width = 100;
            // 
            // columnHeader_Other
            // 
            columnHeader_Other.Text = "";
            columnHeader_Other.Width = 150;
            // 
            // BT5
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(800, 382);
            Controls.Add(listView_InforFile);
            Controls.Add(panel1);
            Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Name = "BT5";
            Text = "BT5_File Explore";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tb_Path;
        private Label lbl_Path;
        private Button button2;
        private Button btn_Browse;
        private ListView listView_InforFile;
        private ColumnHeader columnHeader_Name;
        private ColumnHeader columnHeader_DateModifed;
        private ColumnHeader columnHeader_Type;
        private ColumnHeader columnHeader_Size;
        private ColumnHeader columnHeader_Other;
        private Button btn_Back;
    }
}