namespace Lab2
{
    partial class BT1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BT1));
            richTextBox1 = new RichTextBox();
            btn_Read = new Button();
            btn_wri = new Button();
            btn_Exit = new Button();
            btn_clear = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(653, 426);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btn_Read
            // 
            btn_Read.BackColor = SystemColors.ButtonHighlight;
            btn_Read.BackgroundImageLayout = ImageLayout.None;
            btn_Read.FlatStyle = FlatStyle.Flat;
            btn_Read.Font = new Font("Segoe UI Emoji", 7.8F, FontStyle.Bold);
            btn_Read.ForeColor = Color.FromArgb(0, 0, 192);
            btn_Read.Location = new Point(705, 51);
            btn_Read.Name = "btn_Read";
            btn_Read.Size = new Size(124, 43);
            btn_Read.TabIndex = 1;
            btn_Read.Text = "Read File 📚";
            btn_Read.UseVisualStyleBackColor = false;
            btn_Read.Click += btn_Read_Click;
            // 
            // btn_wri
            // 
            btn_wri.BackColor = SystemColors.ButtonHighlight;
            btn_wri.FlatStyle = FlatStyle.Flat;
            btn_wri.Font = new Font("Segoe UI Emoji", 7.8F, FontStyle.Bold);
            btn_wri.ForeColor = Color.DarkMagenta;
            btn_wri.Location = new Point(705, 144);
            btn_wri.Name = "btn_wri";
            btn_wri.Size = new Size(124, 43);
            btn_wri.TabIndex = 2;
            btn_wri.Text = "Write File 📝";
            btn_wri.UseVisualStyleBackColor = false;
            btn_wri.Click += btn_wri_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = SystemColors.ButtonHighlight;
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.Font = new Font("Segoe UI Emoji", 7.8F, FontStyle.Bold);
            btn_Exit.ForeColor = Color.Red;
            btn_Exit.Location = new Point(705, 320);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(124, 43);
            btn_Exit.TabIndex = 3;
            btn_Exit.Text = "Close ❌";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = SystemColors.ButtonHighlight;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Segoe UI Emoji", 7.8F, FontStyle.Bold);
            btn_clear.Location = new Point(705, 236);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(124, 43);
            btn_clear.TabIndex = 4;
            btn_clear.Text = "Clear 🗑";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // BT1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(841, 450);
            Controls.Add(btn_clear);
            Controls.Add(btn_Exit);
            Controls.Add(btn_wri);
            Controls.Add(btn_Read);
            Controls.Add(richTextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BT1";
            Text = "BT1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btn_Read;
        private Button btn_wri;
        private Button btn_Exit;
        private Button btn_clear;
    }
}