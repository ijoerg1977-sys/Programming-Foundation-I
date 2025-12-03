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
            SuspendLayout();
            // 
            // Cmd_Start
            // 
            Cmd_Start.Location = new Point(37, 27);
            Cmd_Start.Name = "Cmd_Start";
            Cmd_Start.Size = new Size(69, 27);
            Cmd_Start.TabIndex = 0;
            Cmd_Start.Text = "Start";
            Cmd_Start.UseVisualStyleBackColor = true;
            Cmd_Start.Click += Cmd_Start_Click;
            // 
            // Txt_Ausgabe
            // 
            Txt_Ausgabe.Location = new Point(37, 75);
            Txt_Ausgabe.Multiline = true;
            Txt_Ausgabe.Name = "Txt_Ausgabe";
            Txt_Ausgabe.Size = new Size(266, 327);
            Txt_Ausgabe.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Txt_Ausgabe);
            Controls.Add(Cmd_Start);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cmd_Start;
        private TextBox Txt_Ausgabe;
    }
}
