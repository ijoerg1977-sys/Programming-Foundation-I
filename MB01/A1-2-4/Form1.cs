namespace A1_2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CenterWindow() // Methode um Fenster zu zentrieren
        {
            Rectangle screen = Screen.PrimaryScreen.WorkingArea; // greift auf den Primären Monitor zu
            int x = (screen.Width - this.Width) / 2; 
            // misst die Bildschirmbreite (screen) und zieht das Fenster ab und halbiert es damit Abstand links und rechts gleich
            int y = (screen.Height - this.Height) / 2;
            // misst die Bildschirmhöhe (screen) und zieht das Fenster ab und halbiert es damit Abstand oben und unten gleich
            this.Location = new Point(x, y); // definiert die neue Position.
        }

        private void Form1_Move(object sender, EventArgs e) // Methode was nach jeder Bewegung des Fensters passiert
        {
            Lbl_Position.Text = $"X={this.Left}, Y={this.Top}"; // gibt die Fensterposition in x und y aus
            Lbl_Grösse.Text = $"Breite={this.Width}, Höhe={this.Height}"; // gibt die Fenstergrösse aus.
        }

        private void Form1_Resize(object sender, EventArgs e) // Methode was nach einer Grössenäderung passiert
        {
            Lbl_Position.Text = $"X={this.Left}, Y={this.Top}"; // gibt die Fensterposition in x und y aus
            Lbl_Grösse.Text = $"Breite={this.Width}, Höhe={this.Height}"; // gibt die Fenstergrösse aus.
            CenterWindow(); // Zentriert das Fenster nach der Grössenänderung
        }

        private void CmdFensterhöhegrösser_Click(object sender, EventArgs e) // Methode um Fenster höher zu machen
        {
            this.Height += 50; // macht Fenster um 50 Pixel höher
        }

        private void CmdFensterhöhekleiner_Click(object sender, EventArgs e) // Methode um Fenster tiefer zu machen
        {
            this.Height -= 50; // macht Fenster um 50 Pixel tiefer

        }

        private void CmdFensterbreitegrösser_Click(object sender, EventArgs e) // Methode um Fenster breiter zu machen
        {
            this.Width += 50; // macht Fenster 50 Pixel breiter
        }
    
        private void CmdFensterbreitekleiner_Click(object sender, EventArgs e) // Methode um Fenster schmaler zu machen
        {
            this.Width -= 50; // macht Fenster 50 Pixel schmaler
        }
    }
}
