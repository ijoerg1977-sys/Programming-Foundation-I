namespace A4_2_3
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
            Lbl_Länge = new Label();
            Lbl_Breite = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Lbl_Werte = new Label();
            Cmd_Zeichne = new Button();
            label1 = new Label();
            Lbl_Mass_Länge = new Label();
            Lbl_Mass_Breite = new Label();
            SuspendLayout();
            // 
            // Lbl_Länge
            // 
            Lbl_Länge.AutoSize = true;
            Lbl_Länge.Location = new Point(55, 57);
            Lbl_Länge.Name = "Lbl_Länge";
            Lbl_Länge.Size = new Size(45, 15);
            Lbl_Länge.TabIndex = 0;
            Lbl_Länge.Text = "Länge :";
            // 
            // Lbl_Breite
            // 
            Lbl_Breite.AutoSize = true;
            Lbl_Breite.Location = new Point(59, 101);
            Lbl_Breite.Name = "Lbl_Breite";
            Lbl_Breite.Size = new Size(43, 15);
            Lbl_Breite.TabIndex = 1;
            Lbl_Breite.Text = "Breite :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // Lbl_Werte
            // 
            Lbl_Werte.AutoSize = true;
            Lbl_Werte.Location = new Point(55, 154);
            Lbl_Werte.Name = "Lbl_Werte";
            Lbl_Werte.Size = new Size(192, 15);
            Lbl_Werte.TabIndex = 4;
            Lbl_Werte.Text = "Werte zwischen 50 und 200 erlaubt:";
            // 
            // Cmd_Zeichne
            // 
            Cmd_Zeichne.Location = new Point(108, 197);
            Cmd_Zeichne.Name = "Cmd_Zeichne";
            Cmd_Zeichne.Size = new Size(75, 23);
            Cmd_Zeichne.TabIndex = 5;
            Cmd_Zeichne.Text = "Zeichne";
            Cmd_Zeichne.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.Location = new Point(383, 72);
            label1.Name = "label1";
            label1.Size = new Size(141, 97);
            label1.TabIndex = 6;
            // 
            // Lbl_Mass_Länge
            // 
            Lbl_Mass_Länge.Anchor = AnchorStyles.Bottom;
            Lbl_Mass_Länge.AutoSize = true;
            Lbl_Mass_Länge.Location = new Point(445, 53);
            Lbl_Mass_Länge.Name = "Lbl_Mass_Länge";
            Lbl_Mass_Länge.Size = new Size(16, 15);
            Lbl_Mass_Länge.TabIndex = 7;
            Lbl_Mass_Länge.Text = "...";
            // 
            // Lbl_Mass_Breite
            // 
            Lbl_Mass_Breite.Anchor = AnchorStyles.Left;
            Lbl_Mass_Breite.AutoSize = true;
            Lbl_Mass_Breite.Location = new Point(548, 116);
            Lbl_Mass_Breite.Name = "Lbl_Mass_Breite";
            Lbl_Mass_Breite.Size = new Size(16, 15);
            Lbl_Mass_Breite.TabIndex = 8;
            Lbl_Mass_Breite.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Lbl_Mass_Breite);
            Controls.Add(Lbl_Mass_Länge);
            Controls.Add(label1);
            Controls.Add(Cmd_Zeichne);
            Controls.Add(Lbl_Werte);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Lbl_Breite);
            Controls.Add(Lbl_Länge);
            Name = "Form1";
            Text = "Aufgabe 4-2-3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Länge;
        private Label Lbl_Breite;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label Lbl_Werte;
        private Button Cmd_Zeichne;
        private Label label1;
        private Label Lbl_Mass_Länge;
        private Label Lbl_Mass_Breite;
    }
}
