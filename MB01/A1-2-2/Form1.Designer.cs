namespace A1_2_2
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
            Cmd1ner = new Button();
            Cmd2er = new Button();
            Cmd3er = new Button();
            LblAusgabe = new Label();
            SuspendLayout();
            // 
            // Cmd1ner
            // 
            Cmd1ner.Location = new Point(41, 29);
            Cmd1ner.Name = "Cmd1ner";
            Cmd1ner.Size = new Size(75, 23);
            Cmd1ner.TabIndex = 0;
            Cmd1ner.Text = "1ner";
            Cmd1ner.UseVisualStyleBackColor = true;
            Cmd1ner.Click += Cmd1ner_Click;
            // 
            // Cmd2er
            // 
            Cmd2er.Location = new Point(133, 29);
            Cmd2er.Name = "Cmd2er";
            Cmd2er.Size = new Size(75, 23);
            Cmd2er.TabIndex = 1;
            Cmd2er.Text = "2er";
            Cmd2er.UseVisualStyleBackColor = true;
            Cmd2er.Click += Cmd2er_Click;
            // 
            // Cmd3er
            // 
            Cmd3er.Location = new Point(230, 29);
            Cmd3er.Name = "Cmd3er";
            Cmd3er.Size = new Size(75, 23);
            Cmd3er.TabIndex = 2;
            Cmd3er.Text = "3er";
            Cmd3er.UseVisualStyleBackColor = true;
            Cmd3er.Click += Cmd3er_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(50, 89);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(10, 15);
            LblAusgabe.TabIndex = 3;
            LblAusgabe.Text = ".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 340);
            Controls.Add(LblAusgabe);
            Controls.Add(Cmd3er);
            Controls.Add(Cmd2er);
            Controls.Add(Cmd1ner);
            Name = "Form1";
            Text = "Aufgabe A1-2-2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cmd1ner;
        private Button Cmd2er;
        private Button Cmd3er;
        private Label LblAusgabe;
    }
}
