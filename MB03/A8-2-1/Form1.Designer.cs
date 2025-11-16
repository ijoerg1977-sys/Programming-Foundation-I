namespace A8_2_1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            Lbl_Resultat = new Label();
            Cmd_Berechne = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl_Zahl1
            // 
            Lbl_Zahl1.AutoSize = true;
            Lbl_Zahl1.Location = new Point(12, 9);
            Lbl_Zahl1.Name = "Lbl_Zahl1";
            Lbl_Zahl1.Size = new Size(39, 15);
            Lbl_Zahl1.TabIndex = 0;
            Lbl_Zahl1.Text = "1.Zahl";
            // 
            // Lbl_Zahl2
            // 
            Lbl_Zahl2.AutoSize = true;
            Lbl_Zahl2.Location = new Point(12, 50);
            Lbl_Zahl2.Name = "Lbl_Zahl2";
            Lbl_Zahl2.Size = new Size(39, 15);
            Lbl_Zahl2.TabIndex = 1;
            Lbl_Zahl2.Text = "2.Zahl";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(64, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 23);
            textBox2.TabIndex = 3;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(27, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(33, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "+";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(66, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(30, 19);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "-";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(105, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(30, 19);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "*";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(141, 22);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(30, 19);
            radioButton4.TabIndex = 7;
            radioButton4.TabStop = true;
            radioButton4.Text = "/";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(53, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(174, 51);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mathematische Operationen";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(70, 162);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(189, 23);
            textBox3.TabIndex = 9;
            // 
            // Lbl_Resultat
            // 
            Lbl_Resultat.AutoSize = true;
            Lbl_Resultat.Location = new Point(12, 165);
            Lbl_Resultat.Name = "Lbl_Resultat";
            Lbl_Resultat.Size = new Size(52, 15);
            Lbl_Resultat.TabIndex = 10;
            Lbl_Resultat.Text = "Resultat:";
            // 
            // Cmd_Berechne
            // 
            Cmd_Berechne.BackColor = Color.Silver;
            Cmd_Berechne.Location = new Point(12, 202);
            Cmd_Berechne.Name = "Cmd_Berechne";
            Cmd_Berechne.Size = new Size(247, 31);
            Cmd_Berechne.TabIndex = 11;
            Cmd_Berechne.Text = "Berechne";
            Cmd_Berechne.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 254);
            Controls.Add(Cmd_Berechne);
            Controls.Add(Lbl_Resultat);
            Controls.Add(textBox3);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Lbl_Zahl2);
            Controls.Add(Lbl_Zahl1);
            Name = "Form1";
            Text = "Aufgabe A8-2-1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Zahl1;
        private Label Lbl_Zahl2;
        private TextBox textBox1;
        private TextBox textBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private Label Lbl_Resultat;
        private Button Cmd_Berechne;
    }
}
