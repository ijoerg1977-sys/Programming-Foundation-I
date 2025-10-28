namespace A1_2_3
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
            CmdHome = new Button();
            CmdRauf = new Button();
            CmdRunter = new Button();
            CmdRechts = new Button();
            CmdLinks = new Button();
            CmdMove = new Button();
            SuspendLayout();
            // 
            // CmdHome
            // 
            CmdHome.Location = new Point(213, 75);
            CmdHome.Name = "CmdHome";
            CmdHome.Size = new Size(75, 23);
            CmdHome.TabIndex = 0;
            CmdHome.Text = "home";
            CmdHome.UseVisualStyleBackColor = true;
            CmdHome.Click += CmdHome_Click;
            // 
            // CmdRauf
            // 
            CmdRauf.Location = new Point(213, 46);
            CmdRauf.Name = "CmdRauf";
            CmdRauf.Size = new Size(75, 23);
            CmdRauf.TabIndex = 1;
            CmdRauf.Text = "rauf";
            CmdRauf.UseVisualStyleBackColor = true;
            CmdRauf.Click += CmdRauf_Click;
            // 
            // CmdRunter
            // 
            CmdRunter.Location = new Point(213, 104);
            CmdRunter.Name = "CmdRunter";
            CmdRunter.Size = new Size(75, 23);
            CmdRunter.TabIndex = 2;
            CmdRunter.Text = "runter";
            CmdRunter.UseVisualStyleBackColor = true;
            CmdRunter.Click += CmdRunter_Click;
            // 
            // CmdRechts
            // 
            CmdRechts.Location = new Point(294, 75);
            CmdRechts.Name = "CmdRechts";
            CmdRechts.Size = new Size(75, 23);
            CmdRechts.TabIndex = 3;
            CmdRechts.Text = "rechts";
            CmdRechts.UseVisualStyleBackColor = true;
            CmdRechts.Click += CmdRechts_Click;
            // 
            // CmdLinks
            // 
            CmdLinks.Location = new Point(132, 75);
            CmdLinks.Name = "CmdLinks";
            CmdLinks.Size = new Size(75, 23);
            CmdLinks.TabIndex = 4;
            CmdLinks.Text = "links";
            CmdLinks.UseVisualStyleBackColor = true;
            CmdLinks.Click += CmdLinks_Click;
            // 
            // CmdMove
            // 
            CmdMove.BackColor = Color.Gray;
            CmdMove.Location = new Point(241, 282);
            CmdMove.Name = "CmdMove";
            CmdMove.Size = new Size(23, 23);
            CmdMove.TabIndex = 5;
            CmdMove.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 450);
            Controls.Add(CmdMove);
            Controls.Add(CmdLinks);
            Controls.Add(CmdRechts);
            Controls.Add(CmdRunter);
            Controls.Add(CmdRauf);
            Controls.Add(CmdHome);
            Name = "Form1";
            Text = "Aufgabe A1-2-3";
            ResumeLayout(false);
        }

        #endregion

        private Button CmdHome;
        private Button CmdRauf;
        private Button CmdRunter;
        private Button CmdRechts;
        private Button CmdLinks;
        private Button CmdMove;
    }
}
