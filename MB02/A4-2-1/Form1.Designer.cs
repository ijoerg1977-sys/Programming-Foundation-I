namespace A4_2_1
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
            Cmd_Bestimmen = new Button();
            Lbl_Zahl_2 = new Label();
            Lbl_Zahl_1 = new Label();
            NumZahl1 = new NumericUpDown();
            NumZahl2 = new NumericUpDown();
            LblZahl1 = new Label();
            LblZahl2 = new Label();
            ((System.ComponentModel.ISupportInitialize)NumZahl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumZahl2).BeginInit();
            SuspendLayout();
            // 
            // Cmd_Bestimmen
            // 
            Cmd_Bestimmen.Location = new Point(94, 132);
            Cmd_Bestimmen.Name = "Cmd_Bestimmen";
            Cmd_Bestimmen.Size = new Size(143, 22);
            Cmd_Bestimmen.TabIndex = 10;
            Cmd_Bestimmen.Text = "Bestimme grössere Zahl ";
            Cmd_Bestimmen.UseVisualStyleBackColor = true;
            Cmd_Bestimmen.Click += Cmd_Bestimmen_Click;
            // 
            // Lbl_Zahl_2
            // 
            Lbl_Zahl_2.AutoSize = true;
            Lbl_Zahl_2.Location = new Point(54, 88);
            Lbl_Zahl_2.Name = "Lbl_Zahl_2";
            Lbl_Zahl_2.Size = new Size(45, 15);
            Lbl_Zahl_2.TabIndex = 7;
            Lbl_Zahl_2.Text = "Zahl 2 :";
            // 
            // Lbl_Zahl_1
            // 
            Lbl_Zahl_1.AutoSize = true;
            Lbl_Zahl_1.Location = new Point(54, 37);
            Lbl_Zahl_1.Name = "Lbl_Zahl_1";
            Lbl_Zahl_1.Size = new Size(42, 15);
            Lbl_Zahl_1.TabIndex = 6;
            Lbl_Zahl_1.Text = "Zahl 1:";
            // 
            // NumZahl1
            // 
            NumZahl1.Location = new Point(117, 35);
            NumZahl1.Name = "NumZahl1";
            NumZahl1.Size = new Size(120, 23);
            NumZahl1.TabIndex = 11;
            NumZahl1.ValueChanged += ValueChanged;
            // 
            // NumZahl2
            // 
            NumZahl2.Location = new Point(117, 86);
            NumZahl2.Name = "NumZahl2";
            NumZahl2.Size = new Size(120, 23);
            NumZahl2.TabIndex = 12;
            NumZahl2.ValueChanged += ValueChanged;
            // 
            // LblZahl1
            // 
            LblZahl1.AutoSize = true;
            LblZahl1.Location = new Point(117, 9);
            LblZahl1.Name = "LblZahl1";
            LblZahl1.Size = new Size(98, 15);
            LblZahl1.TabIndex = 13;
            LblZahl1.Text = "Zahl 1 ist grösser!";
            LblZahl1.Visible = false;
            // 
            // LblZahl2
            // 
            LblZahl2.AutoSize = true;
            LblZahl2.Location = new Point(117, 68);
            LblZahl2.Name = "LblZahl2";
            LblZahl2.Size = new Size(98, 15);
            LblZahl2.TabIndex = 14;
            LblZahl2.Text = "Zahl 2 ist grösser!";
            LblZahl2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 202);
            Controls.Add(LblZahl2);
            Controls.Add(LblZahl1);
            Controls.Add(NumZahl2);
            Controls.Add(NumZahl1);
            Controls.Add(Cmd_Bestimmen);
            Controls.Add(Lbl_Zahl_2);
            Controls.Add(Lbl_Zahl_1);
            Name = "Form1";
            Text = "A4-2-1";
            ((System.ComponentModel.ISupportInitialize)NumZahl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumZahl2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cmd_Bestimmen;
        private Label Lbl_Zahl_2;
        private Label Lbl_Zahl_1;
        private NumericUpDown NumZahl1;
        private NumericUpDown NumZahl2;
        private Label LblZahl1;
        private Label LblZahl2;
    }
}
