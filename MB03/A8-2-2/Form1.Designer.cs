namespace A9_2_1
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
            Cmd_Start = new Button();
            Txt_Ausgabe = new TextBox();
            Lbl_Anzeige = new Label();
            TxtAusgabe = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Cmd_Start
            // 
            Cmd_Start.Location = new Point(26, 30);
            Cmd_Start.Name = "Cmd_Start";
            Cmd_Start.Size = new Size(75, 23);
            Cmd_Start.TabIndex = 0;
            Cmd_Start.Text = "Start";
            Cmd_Start.UseVisualStyleBackColor = true;
            Cmd_Start.Click += Cmd_Start_Click;
            // 
            // Txt_Ausgabe
            // 
            Txt_Ausgabe.Location = new Point(26, 91);
            Txt_Ausgabe.Multiline = true;
            Txt_Ausgabe.Name = "Txt_Ausgabe";
            Txt_Ausgabe.ReadOnly = true;
            Txt_Ausgabe.Size = new Size(247, 47);
            Txt_Ausgabe.TabIndex = 1;
            // 
            // Lbl_Anzeige
            // 
            Lbl_Anzeige.AutoSize = true;
            Lbl_Anzeige.Location = new Point(28, 194);
            Lbl_Anzeige.Name = "Lbl_Anzeige";
            Lbl_Anzeige.Size = new Size(16, 15);
            Lbl_Anzeige.TabIndex = 3;
            Lbl_Anzeige.Text = "...";
            // 
            // TxtAusgabe
            // 
            TxtAusgabe.AutoSize = true;
            TxtAusgabe.Location = new Point(28, 73);
            TxtAusgabe.Name = "TxtAusgabe";
            TxtAusgabe.Size = new Size(73, 15);
            TxtAusgabe.TabIndex = 4;
            TxtAusgabe.Text = "Txt_Ausgabe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 174);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 5;
            label1.Text = "Label Anzeige";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 234);
            Controls.Add(label1);
            Controls.Add(TxtAusgabe);
            Controls.Add(Lbl_Anzeige);
            Controls.Add(Txt_Ausgabe);
            Controls.Add(Cmd_Start);
            Name = "Form1";
            Text = "Test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cmd_Start;
        private TextBox Txt_Ausgabe;
        private Label Lbl_Anzeige;
        private Label TxtAusgabe;
        private Label label1;
    }
}
