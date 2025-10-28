namespace A2_1_1
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
            LblFirstname = new Label();
            TxtFirstname = new TextBox();
            LblNachname = new Label();
            TxtNachname = new TextBox();
            CmdAusgeben = new Button();
            CmdLoeschen = new Button();
            LblAusgabe = new Label();
            SuspendLayout();
            // 
            // LblFirstname
            // 
            LblFirstname.AutoSize = true;
            LblFirstname.Location = new Point(79, 45);
            LblFirstname.Name = "LblFirstname";
            LblFirstname.Size = new Size(62, 15);
            LblFirstname.TabIndex = 0;
            LblFirstname.Text = "Firstname:";
            // 
            // TxtFirstname
            // 
            TxtFirstname.Location = new Point(159, 41);
            TxtFirstname.Name = "TxtFirstname";
            TxtFirstname.Size = new Size(165, 23);
            TxtFirstname.TabIndex = 1;
            // 
            // LblNachname
            // 
            LblNachname.AutoSize = true;
            LblNachname.Location = new Point(79, 87);
            LblNachname.Name = "LblNachname";
            LblNachname.Size = new Size(68, 15);
            LblNachname.TabIndex = 2;
            LblNachname.Text = "Nachname:";
            // 
            // TxtNachname
            // 
            TxtNachname.Location = new Point(159, 87);
            TxtNachname.Name = "TxtNachname";
            TxtNachname.Size = new Size(165, 23);
            TxtNachname.TabIndex = 3;
            // 
            // CmdAusgeben
            // 
            CmdAusgeben.Location = new Point(159, 131);
            CmdAusgeben.Name = "CmdAusgeben";
            CmdAusgeben.Size = new Size(75, 23);
            CmdAusgeben.TabIndex = 4;
            CmdAusgeben.Text = "Ausgeben";
            CmdAusgeben.UseVisualStyleBackColor = true;
            CmdAusgeben.Click += CmdAusgeben_Click;
            // 
            // CmdLoeschen
            // 
            CmdLoeschen.Location = new Point(249, 131);
            CmdLoeschen.Name = "CmdLoeschen";
            CmdLoeschen.Size = new Size(75, 23);
            CmdLoeschen.TabIndex = 5;
            CmdLoeschen.Text = "Löschen";
            CmdLoeschen.UseVisualStyleBackColor = true;
            CmdLoeschen.Click += CmdLoeschen_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(159, 183);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(16, 15);
            LblAusgabe.TabIndex = 6;
            LblAusgabe.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAusgabe);
            Controls.Add(CmdLoeschen);
            Controls.Add(CmdAusgeben);
            Controls.Add(TxtNachname);
            Controls.Add(LblNachname);
            Controls.Add(TxtFirstname);
            Controls.Add(LblFirstname);
            Name = "Form1";
            Text = "Beispiel Textfeld";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblFirstname;
        private TextBox TxtFirstname;
        private Label LblNachname;
        private TextBox TxtNachname;
        private Button CmdAusgeben;
        private Button CmdLoeschen;
        private Label LblAusgabe;
    }
}
