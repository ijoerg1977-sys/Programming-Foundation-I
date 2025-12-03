namespace A10_1_1
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
            Lbl_BestimmeMaximum = new Label();
            Lbl_ErsteZahl = new Label();
            Lbl_zweiteZahl = new Label();
            Lbl_dritteZahl = new Label();
            Txt_ErsteZahl = new TextBox();
            Txt_ZweiteZahl = new TextBox();
            Txt_DritteZahl = new TextBox();
            Lbl_Maximum = new Label();
            Lbl_AusgabeMaximum = new Label();
            Cmd_Max_1_2 = new Button();
            Cmd_Max_2_3 = new Button();
            Cmd_Max_1_3 = new Button();
            SuspendLayout();
            // 
            // Lbl_BestimmeMaximum
            // 
            Lbl_BestimmeMaximum.AutoSize = true;
            Lbl_BestimmeMaximum.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Lbl_BestimmeMaximum.Location = new Point(12, 18);
            Lbl_BestimmeMaximum.Name = "Lbl_BestimmeMaximum";
            Lbl_BestimmeMaximum.Size = new Size(207, 28);
            Lbl_BestimmeMaximum.TabIndex = 0;
            Lbl_BestimmeMaximum.Text = "Bestimme Maximum";
            // 
            // Lbl_ErsteZahl
            // 
            Lbl_ErsteZahl.AutoSize = true;
            Lbl_ErsteZahl.Location = new Point(12, 61);
            Lbl_ErsteZahl.Name = "Lbl_ErsteZahl";
            Lbl_ErsteZahl.Size = new Size(64, 15);
            Lbl_ErsteZahl.TabIndex = 1;
            Lbl_ErsteZahl.Text = "Erste Zahl :";
            // 
            // Lbl_zweiteZahl
            // 
            Lbl_zweiteZahl.AutoSize = true;
            Lbl_zweiteZahl.Location = new Point(12, 90);
            Lbl_zweiteZahl.Name = "Lbl_zweiteZahl";
            Lbl_zweiteZahl.Size = new Size(74, 15);
            Lbl_zweiteZahl.TabIndex = 2;
            Lbl_zweiteZahl.Text = "Zweite Zahl :";
            // 
            // Lbl_dritteZahl
            // 
            Lbl_dritteZahl.AutoSize = true;
            Lbl_dritteZahl.Location = new Point(12, 119);
            Lbl_dritteZahl.Name = "Lbl_dritteZahl";
            Lbl_dritteZahl.Size = new Size(68, 15);
            Lbl_dritteZahl.TabIndex = 3;
            Lbl_dritteZahl.Text = "Dritte Zahl :";
            // 
            // Txt_ErsteZahl
            // 
            Txt_ErsteZahl.Location = new Point(93, 58);
            Txt_ErsteZahl.Name = "Txt_ErsteZahl";
            Txt_ErsteZahl.Size = new Size(100, 23);
            Txt_ErsteZahl.TabIndex = 4;
            // 
            // Txt_ZweiteZahl
            // 
            Txt_ZweiteZahl.Location = new Point(93, 87);
            Txt_ZweiteZahl.Name = "Txt_ZweiteZahl";
            Txt_ZweiteZahl.Size = new Size(100, 23);
            Txt_ZweiteZahl.TabIndex = 5;
            // 
            // Txt_DritteZahl
            // 
            Txt_DritteZahl.Location = new Point(93, 116);
            Txt_DritteZahl.Name = "Txt_DritteZahl";
            Txt_DritteZahl.Size = new Size(100, 23);
            Txt_DritteZahl.TabIndex = 6;
            // 
            // Lbl_Maximum
            // 
            Lbl_Maximum.AutoSize = true;
            Lbl_Maximum.Location = new Point(12, 164);
            Lbl_Maximum.Name = "Lbl_Maximum";
            Lbl_Maximum.Size = new Size(67, 15);
            Lbl_Maximum.TabIndex = 7;
            Lbl_Maximum.Text = "Maximum :";
            // 
            // Lbl_AusgabeMaximum
            // 
            Lbl_AusgabeMaximum.AutoSize = true;
            Lbl_AusgabeMaximum.Location = new Point(103, 166);
            Lbl_AusgabeMaximum.Name = "Lbl_AusgabeMaximum";
            Lbl_AusgabeMaximum.Size = new Size(16, 15);
            Lbl_AusgabeMaximum.TabIndex = 8;
            Lbl_AusgabeMaximum.Text = "...";
            // 
            // Cmd_Max_1_2
            // 
            Cmd_Max_1_2.BackColor = Color.Silver;
            Cmd_Max_1_2.Location = new Point(12, 197);
            Cmd_Max_1_2.Name = "Cmd_Max_1_2";
            Cmd_Max_1_2.Size = new Size(181, 27);
            Cmd_Max_1_2.TabIndex = 9;
            Cmd_Max_1_2.Text = "Maximum 1. und 2. Zahl";
            Cmd_Max_1_2.UseVisualStyleBackColor = false;
            Cmd_Max_1_2.Click += Cmd_Max_1_2_Click;
            // 
            // Cmd_Max_2_3
            // 
            Cmd_Max_2_3.BackColor = Color.Silver;
            Cmd_Max_2_3.Location = new Point(12, 230);
            Cmd_Max_2_3.Name = "Cmd_Max_2_3";
            Cmd_Max_2_3.Size = new Size(181, 27);
            Cmd_Max_2_3.TabIndex = 10;
            Cmd_Max_2_3.Text = "Maximum 2. und 3. Zahl";
            Cmd_Max_2_3.UseVisualStyleBackColor = false;
            Cmd_Max_2_3.Click += Cmd_Max_2_3_Click;
            // 
            // Cmd_Max_1_3
            // 
            Cmd_Max_1_3.BackColor = Color.Silver;
            Cmd_Max_1_3.Location = new Point(12, 263);
            Cmd_Max_1_3.Name = "Cmd_Max_1_3";
            Cmd_Max_1_3.Size = new Size(181, 27);
            Cmd_Max_1_3.TabIndex = 11;
            Cmd_Max_1_3.Text = "Maximum 1. und 3. Zahl";
            Cmd_Max_1_3.UseVisualStyleBackColor = false;
            Cmd_Max_1_3.Click += Cmd_Max_1_3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 303);
            Controls.Add(Cmd_Max_1_3);
            Controls.Add(Cmd_Max_2_3);
            Controls.Add(Cmd_Max_1_2);
            Controls.Add(Lbl_AusgabeMaximum);
            Controls.Add(Lbl_Maximum);
            Controls.Add(Txt_DritteZahl);
            Controls.Add(Txt_ZweiteZahl);
            Controls.Add(Txt_ErsteZahl);
            Controls.Add(Lbl_dritteZahl);
            Controls.Add(Lbl_zweiteZahl);
            Controls.Add(Lbl_ErsteZahl);
            Controls.Add(Lbl_BestimmeMaximum);
            Name = "Form1";
            Text = "Aufgabe A10-1-1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_BestimmeMaximum;
        private Label Lbl_ErsteZahl;
        private Label Lbl_zweiteZahl;
        private Label Lbl_dritteZahl;
        private TextBox Txt_ErsteZahl;
        private TextBox Txt_ZweiteZahl;
        private TextBox Txt_DritteZahl;
        private Label Lbl_Maximum;
        private Label Lbl_AusgabeMaximum;
        private Button Cmd_Max_1_2;
        private Button Cmd_Max_2_3;
        private Button Cmd_Max_1_3;
    }
}
