namespace MB01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdGelb_Click(object sender, EventArgs e)  // Methode wenn der Button CmdGelb geklickt wird
        {
            LblGelb.Text = "Gelbe Hintergrundfarbe";            // Das Label LblGelb erhält den Text "Gelbe Hintergrundfarbe"
            LblGelb.BackColor = Color.Yellow;                   // Das Label LblGelb erhält die Hintergrundfarbe "Yellow"     
        }

        private void CmdRot_Click(object sender, EventArgs e)   // Methode wenn der Button CmdRot geklickt wird
        {
            LblRot.Text = "Rote Hintergrundfarbe";              // Das Label LblRot erhält den Text "Rote Hintergrundfarbe"
            LblRot.BackColor = Color.Red;                       // Das Label LblRot erhält die Hintergrundfarbe "Red" 
        }

        private void CmdGrün_Click(object sender, EventArgs e)  // Methode wenn der Button CmdGrün geklickt wird
        {
            LblGrün.Text = "Grüne Hintergrundfarbe";            // Das Label LblGrün erhält den Text "Grüne Hintergrundfarbe"
            LblGrün.BackColor = Color.Green;                    // Das Label LblGrün erhält die Hintergrundfarbe "Green" 
        }

        private void CmdBlau_Click(object sender, EventArgs e)  // Methode wenn der Button CmdBlau geklickt wird
        {
            LblBlau.Text = "Blaue Hintergrundfarbe";            // Das Label LblBlau erhält den Text "Blaue Hintergrundfarbe"
            LblBlau.BackColor = Color.Blue;                     // Das Label LblBlau erhält die Hintergrundfarbe "Blue" 
        }
    }

}
