namespace A3_1_2
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
            numericUpDown1 = new NumericUpDown();
            LblAuswahl = new Label();
            LblAusgabe = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(150, 43);
            numericUpDown1.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // LblAuswahl
            // 
            LblAuswahl.AutoSize = true;
            LblAuswahl.Location = new Point(28, 45);
            LblAuswahl.Name = "LblAuswahl";
            LblAuswahl.Size = new Size(116, 15);
            LblAuswahl.TabIndex = 1;
            LblAuswahl.Text = "Wählen Sie eine Zahl";
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.BackColor = Color.Black;
            LblAusgabe.ForeColor = Color.White;
            LblAusgabe.Location = new Point(70, 93);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(86, 15);
            LblAusgabe.TabIndex = 2;
            LblAusgabe.Text = "Monatausgabe";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 450);
            Controls.Add(LblAusgabe);
            Controls.Add(LblAuswahl);
            Controls.Add(numericUpDown1);
            Name = "Form1";
            Text = "Monatsauswahl";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label LblAuswahl;
        private Label LblAusgabe;
    }
}
