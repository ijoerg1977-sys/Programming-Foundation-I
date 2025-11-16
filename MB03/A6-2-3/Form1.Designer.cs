namespace A6_2_3
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
            Lbl_Zahl1 = new Label();
            Lbl_Zahl2 = new Label();
            Num_Zahl1 = new NumericUpDown();
            Num_Zahl2 = new NumericUpDown();
            Cmd_Bestimme_GGT = new Button();
            Txt_GGT = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Num_Zahl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Num_Zahl2).BeginInit();
            SuspendLayout();
            // 
            // Lbl_Zahl1
            // 
            Lbl_Zahl1.AutoSize = true;
            Lbl_Zahl1.Location = new Point(33, 21);
            Lbl_Zahl1.Name = "Lbl_Zahl1";
            Lbl_Zahl1.Size = new Size(45, 15);
            Lbl_Zahl1.TabIndex = 0;
            Lbl_Zahl1.Text = "1.Zahl :";
            // 
            // Lbl_Zahl2
            // 
            Lbl_Zahl2.AutoSize = true;
            Lbl_Zahl2.Location = new Point(33, 52);
            Lbl_Zahl2.Name = "Lbl_Zahl2";
            Lbl_Zahl2.Size = new Size(39, 15);
            Lbl_Zahl2.TabIndex = 1;
            Lbl_Zahl2.Text = "2.Zahl";
            // 
            // Num_Zahl1
            // 
            Num_Zahl1.Location = new Point(84, 19);
            Num_Zahl1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            Num_Zahl1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Num_Zahl1.Name = "Num_Zahl1";
            Num_Zahl1.Size = new Size(207, 23);
            Num_Zahl1.TabIndex = 2;
            Num_Zahl1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            Num_Zahl1.ValueChanged += Num_Zahl1_ValueChanged;
            // 
            // Num_Zahl2
            // 
            Num_Zahl2.Location = new Point(84, 50);
            Num_Zahl2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            Num_Zahl2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Num_Zahl2.Name = "Num_Zahl2";
            Num_Zahl2.Size = new Size(207, 23);
            Num_Zahl2.TabIndex = 3;
            Num_Zahl2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            Num_Zahl2.ValueChanged += Num_Zahl2_ValueChanged;
            // 
            // Cmd_Bestimme_GGT
            // 
            Cmd_Bestimme_GGT.Location = new Point(33, 92);
            Cmd_Bestimme_GGT.Name = "Cmd_Bestimme_GGT";
            Cmd_Bestimme_GGT.Size = new Size(115, 23);
            Cmd_Bestimme_GGT.TabIndex = 4;
            Cmd_Bestimme_GGT.Text = "Bestimme GGT";
            Cmd_Bestimme_GGT.UseVisualStyleBackColor = true;
            Cmd_Bestimme_GGT.Click += Cmd_Bestimme_GGT_Click;
            // 
            // Txt_GGT
            // 
            Txt_GGT.Location = new Point(165, 93);
            Txt_GGT.Name = "Txt_GGT";
            Txt_GGT.Size = new Size(126, 23);
            Txt_GGT.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 126);
            Controls.Add(Txt_GGT);
            Controls.Add(Cmd_Bestimme_GGT);
            Controls.Add(Num_Zahl2);
            Controls.Add(Num_Zahl1);
            Controls.Add(Lbl_Zahl2);
            Controls.Add(Lbl_Zahl1);
            Name = "Form1";
            Text = "Aufgabe A6-2-3";
            ((System.ComponentModel.ISupportInitialize)Num_Zahl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Num_Zahl2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Zahl1;
        private Label Lbl_Zahl2;
        private NumericUpDown Num_Zahl1;
        private NumericUpDown Num_Zahl2;
        private Button Cmd_Bestimme_GGT;
        private TextBox Txt_GGT;
    }
}
