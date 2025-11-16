namespace A41_4_4
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
            Lbl_Zahl_A = new Label();
            Lbl_Zahl_B = new Label();
            TxtZahlA = new TextBox();
            TxtZahlB = new TextBox();
            Cmd_Bestimmen = new Button();
            Lbl_Ergebnis = new Label();
            SuspendLayout();
            // 
            // Lbl_Zahl_A
            // 
            Lbl_Zahl_A.AutoSize = true;
            Lbl_Zahl_A.Location = new Point(12, 23);
            Lbl_Zahl_A.Name = "Lbl_Zahl_A";
            Lbl_Zahl_A.Size = new Size(47, 15);
            Lbl_Zahl_A.TabIndex = 0;
            Lbl_Zahl_A.Text = "Zahl A :";
            // 
            // Lbl_Zahl_B
            // 
            Lbl_Zahl_B.AutoSize = true;
            Lbl_Zahl_B.Location = new Point(13, 58);
            Lbl_Zahl_B.Name = "Lbl_Zahl_B";
            Lbl_Zahl_B.Size = new Size(46, 15);
            Lbl_Zahl_B.TabIndex = 1;
            Lbl_Zahl_B.Text = "Zahl B :";
            // 
            // TxtZahlA
            // 
            TxtZahlA.Location = new Point(65, 20);
            TxtZahlA.Name = "TxtZahlA";
            TxtZahlA.Size = new Size(143, 23);
            TxtZahlA.TabIndex = 2;
            // 
            // TxtZahlB
            // 
            TxtZahlB.Location = new Point(65, 55);
            TxtZahlB.Name = "TxtZahlB";
            TxtZahlB.Size = new Size(143, 23);
            TxtZahlB.TabIndex = 3;
            // 
            // Cmd_Bestimmen
            // 
            Cmd_Bestimmen.Location = new Point(65, 101);
            Cmd_Bestimmen.Name = "Cmd_Bestimmen";
            Cmd_Bestimmen.Size = new Size(143, 22);
            Cmd_Bestimmen.TabIndex = 4;
            Cmd_Bestimmen.Text = "Bestimme grössere Zahl ";
            Cmd_Bestimmen.UseVisualStyleBackColor = true;
            Cmd_Bestimmen.Click += Cmd_Bestimmen_Click;
            // 
            // Lbl_Ergebnis
            // 
            Lbl_Ergebnis.AutoSize = true;
            Lbl_Ergebnis.Location = new Point(75, 149);
            Lbl_Ergebnis.Name = "Lbl_Ergebnis";
            Lbl_Ergebnis.Size = new Size(16, 15);
            Lbl_Ergebnis.TabIndex = 5;
            Lbl_Ergebnis.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 450);
            Controls.Add(Lbl_Ergebnis);
            Controls.Add(Cmd_Bestimmen);
            Controls.Add(TxtZahlB);
            Controls.Add(TxtZahlA);
            Controls.Add(Lbl_Zahl_B);
            Controls.Add(Lbl_Zahl_A);
            Name = "Form1";
            Text = "Aufgabe_A41-1-6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Zahl_A;
        private Label Lbl_Zahl_B;
        private TextBox TxtZahlA;
        private TextBox TxtZahlB;
        private Button Cmd_Bestimmen;
        private Label Lbl_Ergebnis;
    }
}
