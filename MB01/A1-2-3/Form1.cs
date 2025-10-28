namespace A1_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdRauf_Click(object sender, EventArgs e) // Methode wenn Button CmdRauf angeklickt wird
        {
            CmdMove.Top -= 1;                                    // Verschiebt den Button CmdMove 1 Pixel nach oben (Achtung .Top += dann geht es nach unten)
        }

        private void CmdRunter_Click(object sender, EventArgs e) // Methode wenn Button CmdRunter angeklickt wird
        {
            CmdMove.Top += 1;                                   // Verschiebt den Button CmdMove 1 Pixel nach unten
        }

        private void CmdLinks_Click(object sender, EventArgs e) // Methode wenn Button CmdLinks angeklickt wird
        {
            CmdMove.Left -= 1;                                  // Verscheibt den Button CmdMove 1 Pixel nach links
        }

        private void CmdRechts_Click(object sender, EventArgs e) // Methode wenn Button CmdRechts angeklickt wird
        {
            CmdMove.Left += 1;                                 //Verschiebt den Button CmdMove 1 Pixel nach rechts (Rechts als Befehl gibt es nicht darum +)
        }

        private void CmdHome_Click(object sender, EventArgs e) // Methode wenn Button CmdHome angeklickt wird
        {
            CmdMove.Location = new Point(241, 282);            // Setzt den Button wieder auf die Anfangsposition (x,y)

        }
    }
}
