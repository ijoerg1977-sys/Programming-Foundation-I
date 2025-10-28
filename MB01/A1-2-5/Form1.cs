namespace A1_2_5
{
    public partial class Form1 : Form
    {
        //Variablen initialisieren
        int w1 = 0;
        int w2 = 0;
        int w4 = 0;
        int w8 = 0;
        int w16 = 0;
        int w32 = 0;
        int w64 = 0;
        int w128 = 0;
        int wresult = 0;
        
        public Form1()
        {
            InitializeComponent();
            LblResultat.Text = "0"; // Anzeigewert auf 0 Setzen für den Beginn
        }
        // Methode wenn Button CmdWert1 geklickt wird
        private void CmdWert1_Click(object sender, EventArgs e) 
        {
            CmdWert1.Text = "1"; //Setzt den Button auf "1"
            w1 = 1; // Setzt den Variablenwert auf 1
        }

        // Methode wenn Button CmdWert2 geklickt wird
        private void CmdWert2_Click(object sender, EventArgs e) 
        {
            CmdWert2.Text = "1"; //Setzt den Button auf "1"
            w2 = 2; // Setzt den Variablenwert auf 2
        }

        // Methode wenn Button CmdWert4 geklickt wird
        private void CmdWert4_Click(object sender, EventArgs e) 
        {
            CmdWert4.Text = "1"; //Setzt den Button auf "1"
            w4 = 4; // Setzt den Variablenwert auf 4
        }

        // Methode wenn Button CmdWert8 geklickt wird
        private void CmdWert8_Click(object sender, EventArgs e) 
        {
            CmdWert8.Text = "1"; //Setzt den Button auf "1"
            w8 = 8; // Setzt den Variablenwert auf 8
        }

        // Methode wenn Button CmdWert16 geklickt wird
        private void CmdWert16_Click(object sender, EventArgs e)
        {
            CmdWert16.Text = "1"; //Setzt den Button auf "1"
            w16 = 16; // Setzt den Variablenwert auf 16
        }

        // Methode wenn Button CmdWert32 geklickt wird
        private void CmdWert32_Click(object sender, EventArgs e)
        {
            CmdWert32.Text = "1"; //Setzt den Button auf "1"
            w32 = 32; // Setzt den Variablenwert auf 32
        }

        // Methode wenn Button CmdWert64 geklickt wird
        private void CmdWert64_Click(object sender, EventArgs e)
        {
            CmdWert64.Text = "1"; //Setzt den Button auf "1"
            w64 = 64; // Setzt den Variablenwert auf 64
        }

        // Methode wenn Button CmdWert128 geklickt wird
        private void CmdWert128_Click(object sender, EventArgs e)
        {
            CmdWert128.Text = "1"; //Setzt den Button auf "1"
            w128 = 128; // Setzt den Variablenwert auf 128
        }

        // Methode wenn Button CmdBerechneDezimalwert geklickt wird
        private void CmdBerechneDezimalwert_Click(object sender, EventArgs e)
        {
            int wresult = w1 + w2 + w4 + w8 + w16 + w32 + w64 + w128; // Zusammenzählen aller Werte
            string resultat = wresult.ToString(); // Resultat in String umwandeln
            LblResultat.Text = resultat; // Resultat ausgeben
        }

        // Methode wenn Button CmdSetzeZurück geklickt wird
        private void CmdSetzeZurück_Click(object sender, EventArgs e)
        {
            CmdWert1.Text = "0";  //Setzt den Button wieder auf "0"
            CmdWert2.Text = "0";  //Setzt den Button wieder auf "0"
            CmdWert4.Text = "0";  //Setzt den Button wieder auf "0"
            CmdWert8.Text = "0";  //Setzt den Button wieder auf "0"
            CmdWert16.Text = "0"; //Setzt den Button wieder auf "0"
            CmdWert32.Text = "0"; //Setzt den Button wieder auf "0"
            CmdWert64.Text = "0"; //Setzt den Button wieder auf "0"
            CmdWert128.Text = "0";//Setzt den Button wieder auf "0"
            w1 = 0; //Setzt den Variablen Wert wieder auf "0"
            w2 = 0; //Setzt den Variablen Wert wieder auf "0"
            w4 = 0; //Setzt den Variablen Wert wieder auf "0"
            w8 = 0; //Setzt den Variablen Wert wieder auf "0"
            w16 = 0; //Setzt den Variablen Wert wieder auf "0"
            w32 = 0; //Setzt den Variablen Wert wieder auf "0"
            w64 = 0; //Setzt den Variablen Wert wieder auf "0"
            w128 = 0; //Setzt den Variablen Wert wieder auf "0"
            LblResultat.Text = "0";
        }
    }
}
