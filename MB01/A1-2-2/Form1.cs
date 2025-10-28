namespace A1_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cmd1ner_Click(object sender, EventArgs e) // Methode wenn Button 1ner angeklickt wird
        {
            LblAusgabe.Text += ".";                            // ergänzt den Text im Label LblAusgabe um einen Punkt bzw Element zwischen ""
        }

        private void Cmd2er_Click(object sender, EventArgs e) // Methode wenn Button 2er angeklickt wird
        {
            LblAusgabe.Text += "..";                            // ergänzt den Text im Label LblAusgabe um zwei Punkte bzw Element zwischen ""
        }

        private void Cmd3er_Click(object sender, EventArgs e) // Methode wenn Button 2er angeklickt wird
        {
            LblAusgabe.Text += "...";                         // ergänzt den Text im Label LblAusgabe um drei Punkte bzw Element zwischen ""
        }
    }
}
