namespace MB01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CmdGelb = new Button();
            CmdRot = new Button();
            CmdGrün = new Button();
            CmdBlau = new Button();
            LblGelb = new Label();
            LblRot = new Label();
            LblGrün = new Label();
            LblBlau = new Label();
            SuspendLayout();
            // 
            // CmdGelb
            // 
            CmdGelb.Location = new Point(57, 35);
            CmdGelb.Name = "CmdGelb";
            CmdGelb.Size = new Size(75, 23);
            CmdGelb.TabIndex = 0;
            CmdGelb.Text = "Gelb";
            CmdGelb.UseVisualStyleBackColor = true;
            CmdGelb.Click += CmdGelb_Click;
            // 
            // CmdRot
            // 
            CmdRot.Location = new Point(57, 64);
            CmdRot.Name = "CmdRot";
            CmdRot.Size = new Size(75, 23);
            CmdRot.TabIndex = 1;
            CmdRot.Text = "Rot";
            CmdRot.UseVisualStyleBackColor = true;
            CmdRot.Click += CmdRot_Click;
            // 
            // CmdGrün
            // 
            CmdGrün.Location = new Point(57, 93);
            CmdGrün.Name = "CmdGrün";
            CmdGrün.Size = new Size(75, 23);
            CmdGrün.TabIndex = 2;
            CmdGrün.Text = "Grün";
            CmdGrün.UseVisualStyleBackColor = true;
            CmdGrün.Click += CmdGrün_Click;
            // 
            // CmdBlau
            // 
            CmdBlau.Location = new Point(57, 122);
            CmdBlau.Name = "CmdBlau";
            CmdBlau.Size = new Size(75, 23);
            CmdBlau.TabIndex = 3;
            CmdBlau.Text = "Blau";
            CmdBlau.UseVisualStyleBackColor = true;
            CmdBlau.Click += CmdBlau_Click;
            // 
            // LblGelb
            // 
            LblGelb.AutoSize = true;
            LblGelb.Location = new Point(172, 44);
            LblGelb.Name = "LblGelb";
            LblGelb.Size = new Size(16, 15);
            LblGelb.TabIndex = 4;
            LblGelb.Text = ",,,";
            // 
            // LblRot
            // 
            LblRot.AutoSize = true;
            LblRot.Location = new Point(172, 72);
            LblRot.Name = "LblRot";
            LblRot.Size = new Size(16, 15);
            LblRot.TabIndex = 5;
            LblRot.Text = ",,,";
            // 
            // LblGrün
            // 
            LblGrün.AutoSize = true;
            LblGrün.Location = new Point(172, 97);
            LblGrün.Name = "LblGrün";
            LblGrün.Size = new Size(16, 15);
            LblGrün.TabIndex = 6;
            LblGrün.Text = ",,,";
            // 
            // LblBlau
            // 
            LblBlau.AutoSize = true;
            LblBlau.Location = new Point(172, 130);
            LblBlau.Name = "LblBlau";
            LblBlau.Size = new Size(16, 15);
            LblBlau.TabIndex = 7;
            LblBlau.Text = ",,,";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 249);
            Controls.Add(LblBlau);
            Controls.Add(LblGrün);
            Controls.Add(LblRot);
            Controls.Add(LblGelb);
            Controls.Add(CmdBlau);
            Controls.Add(CmdGrün);
            Controls.Add(CmdRot);
            Controls.Add(CmdGelb);
            Name = "Form1";
            Text = "Aufbage A1-2-1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdGelb;
        private Button CmdRot;
        private Button CmdGrün;
        private Button CmdBlau;
        private Label LblGelb;
        private Label LblRot;
        private Label LblGrün;
        private Label LblBlau;
    }
}
