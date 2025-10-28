namespace A2_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Methode was beim Klicken von Ausgeben geschehen soll
        private void CmdAusgeben_Click(object sender, EventArgs e)
        {
            string vorname = TxtFirstname.Text;//speichert den Vornamen im string vorname  ab
            string nachname = TxtNachname.Text; // speichert den Nachnamen im string nachname ab
            string alter = NumAlter.Text; // speichert das Alter im string alter ab
            LblAusgabe.Text = vorname + " " + nachname+ " " + alter; // Gibt den Vorname und Nachnamen im Label aus
        }

        private void CmdLoeschen_Click(object sender, EventArgs e) // Methode um die Felder wieder zu löschen
        {
            TxtFirstname.Clear();// Löscht die Textbox Firstname
            TxtNachname.Clear(); // Löscht die Textbox Nachname
            LblAusgabe.Text = "..."; // Ueberschreibt das Label Ausgabe mit ...
            NumAlter.Text= "0"; // Ueberschreibt den Inhalt im Feld Alter mit 0
            TxtFirstname.Focus(); // Setzt den Cursor in die Textbox Firstname
        }
    }
}

   
