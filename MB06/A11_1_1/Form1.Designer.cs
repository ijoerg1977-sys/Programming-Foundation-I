namespace A11_1_1
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
            Cmd_erzeugePerson1 = new Button();
            Cmd_erzeugePerson2 = new Button();
            Cmd_erzeugePerson3 = new Button();
            Txt_Ausgabe = new TextBox();
            SuspendLayout();
            // 
            // Cmd_erzeugePerson1
            // 
            Cmd_erzeugePerson1.Location = new Point(35, 46);
            Cmd_erzeugePerson1.Name = "Cmd_erzeugePerson1";
            Cmd_erzeugePerson1.Size = new Size(153, 24);
            Cmd_erzeugePerson1.TabIndex = 0;
            Cmd_erzeugePerson1.Text = "Erzeuge erste Person";
            Cmd_erzeugePerson1.UseVisualStyleBackColor = true;
            Cmd_erzeugePerson1.Click += Cmd_erzeugePerson1_Click;
            // 
            // Cmd_erzeugePerson2
            // 
            Cmd_erzeugePerson2.Location = new Point(35, 76);
            Cmd_erzeugePerson2.Name = "Cmd_erzeugePerson2";
            Cmd_erzeugePerson2.Size = new Size(153, 24);
            Cmd_erzeugePerson2.TabIndex = 1;
            Cmd_erzeugePerson2.Text = "Erzeuge zweite Person";
            Cmd_erzeugePerson2.UseVisualStyleBackColor = true;
            Cmd_erzeugePerson2.Click += Cmd_erzeugePerson2_Click;
            // 
            // Cmd_erzeugePerson3
            // 
            Cmd_erzeugePerson3.Location = new Point(35, 106);
            Cmd_erzeugePerson3.Name = "Cmd_erzeugePerson3";
            Cmd_erzeugePerson3.Size = new Size(153, 24);
            Cmd_erzeugePerson3.TabIndex = 2;
            Cmd_erzeugePerson3.Text = "Erzeuge dritte Person";
            Cmd_erzeugePerson3.UseVisualStyleBackColor = true;
            Cmd_erzeugePerson3.Click += Cmd_erzeugePerson3_Click;
            // 
            // Txt_Ausgabe
            // 
            Txt_Ausgabe.Location = new Point(35, 177);
            Txt_Ausgabe.Multiline = true;
            Txt_Ausgabe.Name = "Txt_Ausgabe";
            Txt_Ausgabe.Size = new Size(657, 411);
            Txt_Ausgabe.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(Txt_Ausgabe);
            Controls.Add(Cmd_erzeugePerson3);
            Controls.Add(Cmd_erzeugePerson2);
            Controls.Add(Cmd_erzeugePerson1);
            Name = "Form1";
            Text = "Aufgabe A11_1_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cmd_erzeugePerson1;
        private Button Cmd_erzeugePerson2;
        private Button Cmd_erzeugePerson3;
        private TextBox Txt_Ausgabe;
    }
}
