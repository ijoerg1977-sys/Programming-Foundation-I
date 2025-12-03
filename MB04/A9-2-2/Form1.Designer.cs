namespace A9_2_2
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
            Lbl_GewGroesse = new Label();
            Txt_GewGroesse = new TextBox();
            Cmd_DatenGenerieren = new Button();
            Lbl_PosWaehlen = new Label();
            Txt_PosWaehlen = new TextBox();
            Lbl_gespeicherterWert = new Label();
            Txt_gespeicherterWert = new TextBox();
            Cmd_WertAuslesen = new Button();
            Lbl_erfolgteAbfragen = new Label();
            Txt_erfolgteAbfragen = new TextBox();
            // 
            // Lbl_GewGroesse
            // 
            Lbl_GewGroesse.AutoSize = true;
            Lbl_GewGroesse.Location = new Point(12, 21);
            Lbl_GewGroesse.Name = "Lbl_GewGroesse";
            Lbl_GewGroesse.Size = new Size(110, 15);
            Lbl_GewGroesse.TabIndex = 0;
            Lbl_GewGroesse.Text = "Gewünschte Grösse";
            // 
            // Txt_GewGroesse
            // 
            Txt_GewGroesse.Location = new Point(128, 18);
            Txt_GewGroesse.Name = "Txt_GewGroesse";
            Txt_GewGroesse.Size = new Size(100, 23);
            Txt_GewGroesse.TabIndex = 1;
            // 
            // Cmd_DatenGenerieren
            // 
            Cmd_DatenGenerieren.Location = new Point(345, 18);
            Cmd_DatenGenerieren.Name = "Cmd_DatenGenerieren";
            Cmd_DatenGenerieren.Size = new Size(127, 23);
            Cmd_DatenGenerieren.TabIndex = 2;
            Cmd_DatenGenerieren.Text = "Daten generieren";
            Cmd_DatenGenerieren.UseVisualStyleBackColor = true;
            // 
            // Lbl_PosWaehlen
            // 
            Lbl_PosWaehlen.AutoSize = true;
            Lbl_PosWaehlen.Location = new Point(12, 72);
            Lbl_PosWaehlen.Name = "Lbl_PosWaehlen";
            Lbl_PosWaehlen.Size = new Size(91, 15);
            Lbl_PosWaehlen.TabIndex = 3;
            Lbl_PosWaehlen.Text = "Position wählen";
            // 
            // Txt_PosWaehlen
            // 
            Txt_PosWaehlen.Location = new Point(128, 72);
            Txt_PosWaehlen.Name = "Txt_PosWaehlen";
            Txt_PosWaehlen.Size = new Size(100, 23);
            Txt_PosWaehlen.TabIndex = 4;
            // 
            // Lbl_gespeicherterWert
            // 
            Lbl_gespeicherterWert.AutoSize = true;
            Lbl_gespeicherterWert.Location = new Point(259, 75);
            Lbl_gespeicherterWert.Name = "Lbl_gespeicherterWert";
            Lbl_gespeicherterWert.Size = new Size(107, 15);
            Lbl_gespeicherterWert.TabIndex = 5;
            Lbl_gespeicherterWert.Text = "Gespeicherter Wert";
            // 
            // Txt_gespeicherterWert
            // 
            Txt_gespeicherterWert.Location = new Point(372, 72);
            Txt_gespeicherterWert.Name = "Txt_gespeicherterWert";
            Txt_gespeicherterWert.Size = new Size(100, 23);
            Txt_gespeicherterWert.TabIndex = 6;
            // 
            // Cmd_WertAuslesen
            // 
            Cmd_WertAuslesen.BackColor = Color.Silver;
            Cmd_WertAuslesen.Location = new Point(12, 114);
            Cmd_WertAuslesen.Name = "Cmd_WertAuslesen";
            Cmd_WertAuslesen.Size = new Size(460, 32);
            Cmd_WertAuslesen.TabIndex = 7;
            Cmd_WertAuslesen.Text = "Wert der gewünschten Position auslesen";
            Cmd_WertAuslesen.UseVisualStyleBackColor = false;
            // 
            // Lbl_erfolgteAbfragen
            // 
            Lbl_erfolgteAbfragen.AutoSize = true;
            Lbl_erfolgteAbfragen.Location = new Point(37, 176);
            Lbl_erfolgteAbfragen.Name = "Lbl_erfolgteAbfragen";
            Lbl_erfolgteAbfragen.Size = new Size(106, 15);
            Lbl_erfolgteAbfragen.TabIndex = 8;
            Lbl_erfolgteAbfragen.Text = "Erfolgte Abfragen :";
            // 
            // Txt_erfolgteAbfragen
            // 
            Txt_erfolgteAbfragen.Location = new Point(149, 173);
            Txt_erfolgteAbfragen.Multiline = true;
            Txt_erfolgteAbfragen.Name = "Txt_erfolgteAbfragen";
            Txt_erfolgteAbfragen.Size = new Size(323, 373);
            Txt_erfolgteAbfragen.TabIndex = 9;
            // 
            // Form1

            
  
        
        }

        #endregion

        private Label Lbl_GewGroesse;
        private TextBox Txt_GewGroesse;
        private Button Cmd_DatenGenerieren;
        private Label Lbl_PosWaehlen;
        private TextBox Txt_PosWaehlen;
        private Label Lbl_gespeicherterWert;
        private TextBox Txt_gespeicherterWert;
        private Button Cmd_WertAuslesen;
        private Label Lbl_erfolgteAbfragen;
        private TextBox Txt_erfolgteAbfragen;
    }
}
