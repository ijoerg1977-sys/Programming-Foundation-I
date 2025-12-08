namespace A12_1_3
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
            Lbl1 = new Label();
            Cmd_Aufgabe_A = new Button();
            Cmd_Aufgabe_B = new Button();
            Cmd_Aufgabe_C = new Button();
            Cmd_Aufgabe_D = new Button();
            SuspendLayout();
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(41, 52);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(16, 15);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "...";
            // 
            // Cmd_Aufgabe_A
            // 
            Cmd_Aufgabe_A.Location = new Point(41, 104);
            Cmd_Aufgabe_A.Name = "Cmd_Aufgabe_A";
            Cmd_Aufgabe_A.Size = new Size(75, 23);
            Cmd_Aufgabe_A.TabIndex = 1;
            Cmd_Aufgabe_A.Text = "Aufgabe A";
            Cmd_Aufgabe_A.UseVisualStyleBackColor = true;
            Cmd_Aufgabe_A.Click += Cmd_Aufgabe_Click;
            // 
            // Cmd_Aufgabe_B
            // 
            Cmd_Aufgabe_B.Location = new Point(149, 104);
            Cmd_Aufgabe_B.Name = "Cmd_Aufgabe_B";
            Cmd_Aufgabe_B.Size = new Size(75, 23);
            Cmd_Aufgabe_B.TabIndex = 2;
            Cmd_Aufgabe_B.Text = "Aufgabe B";
            Cmd_Aufgabe_B.UseVisualStyleBackColor = true;
            Cmd_Aufgabe_B.Click += Cmd_Aufgabe_Click;
            // 
            // Cmd_Aufgabe_C
            // 
            Cmd_Aufgabe_C.Location = new Point(41, 155);
            Cmd_Aufgabe_C.Name = "Cmd_Aufgabe_C";
            Cmd_Aufgabe_C.Size = new Size(75, 23);
            Cmd_Aufgabe_C.TabIndex = 3;
            Cmd_Aufgabe_C.Text = "Aufgabe C";
            Cmd_Aufgabe_C.UseVisualStyleBackColor = true;
            Cmd_Aufgabe_C.Click += Cmd_Aufgabe_Click;
            // 
            // Cmd_Aufgabe_D
            // 
            Cmd_Aufgabe_D.Location = new Point(149, 155);
            Cmd_Aufgabe_D.Name = "Cmd_Aufgabe_D";
            Cmd_Aufgabe_D.Size = new Size(75, 23);
            Cmd_Aufgabe_D.TabIndex = 4;
            Cmd_Aufgabe_D.Text = "Aufgabe D";
            Cmd_Aufgabe_D.UseVisualStyleBackColor = true;
            Cmd_Aufgabe_D.Click += Cmd_Aufgabe_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 226);
            Controls.Add(Cmd_Aufgabe_D);
            Controls.Add(Cmd_Aufgabe_C);
            Controls.Add(Cmd_Aufgabe_B);
            Controls.Add(Cmd_Aufgabe_A);
            Controls.Add(Lbl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl1;
        private Button Cmd_Aufgabe_A;
        private Button Cmd_Aufgabe_B;
        private Button Cmd_Aufgabe_C;
        private Button Cmd_Aufgabe_D;
    }
}
