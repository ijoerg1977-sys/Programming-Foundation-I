namespace A2_1_2
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
            LblAusgabe = new Label();
            CmdLoeschen = new Button();
            CmdAusgeben = new Button();
            TxtNachname = new TextBox();
            LblNachname = new Label();
            TxtFirstname = new TextBox();
            LblFirstname = new Label();
            LblAlter = new Label();
            NumAlter = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NumAlter).BeginInit();
            SuspendLayout();
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(175, 216);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(16, 15);
            LblAusgabe.TabIndex = 13;
            LblAusgabe.Text = "...";
            // 
            // CmdLoeschen
            // 
            CmdLoeschen.Location = new Point(265, 152);
            CmdLoeschen.Name = "CmdLoeschen";
            CmdLoeschen.Size = new Size(75, 23);
            CmdLoeschen.TabIndex = 12;
            CmdLoeschen.Text = "Löschen";
            CmdLoeschen.UseVisualStyleBackColor = true;
            CmdLoeschen.Click += CmdLoeschen_Click;
            // 
            // CmdAusgeben
            // 
            CmdAusgeben.Location = new Point(175, 152);
            CmdAusgeben.Name = "CmdAusgeben";
            CmdAusgeben.Size = new Size(75, 23);
            CmdAusgeben.TabIndex = 11;
            CmdAusgeben.Text = "Ausgeben";
            CmdAusgeben.UseVisualStyleBackColor = true;
            CmdAusgeben.Click += CmdAusgeben_Click;
            // 
            // TxtNachname
            // 
            TxtNachname.Location = new Point(175, 81);
            TxtNachname.Name = "TxtNachname";
            TxtNachname.Size = new Size(165, 23);
            TxtNachname.TabIndex = 10;
            // 
            // LblNachname
            // 
            LblNachname.AutoSize = true;
            LblNachname.Location = new Point(95, 81);
            LblNachname.Name = "LblNachname";
            LblNachname.Size = new Size(68, 15);
            LblNachname.TabIndex = 9;
            LblNachname.Text = "Nachname:";
            // 
            // TxtFirstname
            // 
            TxtFirstname.Location = new Point(175, 35);
            TxtFirstname.Name = "TxtFirstname";
            TxtFirstname.Size = new Size(165, 23);
            TxtFirstname.TabIndex = 8;
            // 
            // LblFirstname
            // 
            LblFirstname.AutoSize = true;
            LblFirstname.Location = new Point(95, 39);
            LblFirstname.Name = "LblFirstname";
            LblFirstname.Size = new Size(62, 15);
            LblFirstname.TabIndex = 7;
            LblFirstname.Text = "Firstname:";
            // 
            // LblAlter
            // 
            LblAlter.AutoSize = true;
            LblAlter.Location = new Point(95, 123);
            LblAlter.Name = "LblAlter";
            LblAlter.Size = new Size(35, 15);
            LblAlter.TabIndex = 14;
            LblAlter.Text = "Alter:";
            // 
            // NumAlter
            // 
            NumAlter.Location = new Point(175, 121);
            NumAlter.Maximum = new decimal(new int[] { 115, 0, 0, 0 });
            NumAlter.Name = "NumAlter";
            NumAlter.Size = new Size(165, 23);
            NumAlter.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NumAlter);
            Controls.Add(LblAlter);
            Controls.Add(LblAusgabe);
            Controls.Add(CmdLoeschen);
            Controls.Add(CmdAusgeben);
            Controls.Add(TxtNachname);
            Controls.Add(LblNachname);
            Controls.Add(TxtFirstname);
            Controls.Add(LblFirstname);
            Name = "Form1";
            Text = "Beispiel Textfeld";
            ((System.ComponentModel.ISupportInitialize)NumAlter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAusgabe;
        private Button CmdLoeschen;
        private Button CmdAusgeben;
        private TextBox TxtNachname;
        private Label LblNachname;
        private TextBox TxtFirstname;
        private Label LblFirstname;
        private Label LblAlter;
        private NumericUpDown NumAlter;
    }
}
