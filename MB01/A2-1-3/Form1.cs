namespace A2_1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CdmAddition_Click(object sender, EventArgs e) // Methode um beide Zahlen zu addieren
        {
            int zahl1 = int.Parse(TxtZahl1.Text); // wandelt die erste Zahl in int um
            int zahl2 = int.Parse(TxtZahl2.Text); // wandelt die zweite Zahl in int um
            int ergebnis = zahl1 + zahl2; // addiert beide Zahlen und speichert sie in int ergebnis
            TxtResultat.Text = $"{ergebnis}"; // wandelt int ergebnis in string um und zeigt in textbox Resultat an
        }

        private void CmdSubtraction_Click(object sender, EventArgs e) // Methode um beide Zahlen zu subtrahieren
        {
            int zahl1 = int.Parse(TxtZahl1.Text); // wandelt die erste Zahl in int um
            int zahl2 = int.Parse(TxtZahl2.Text); // wandelt die zweite Zahl in int um
            int ergebnis = zahl1 - zahl2; // subtrahiert beide Zahlen und speichert sie in int ergebnis
            TxtResultat.Text = $"{ergebnis}"; // wandelt int ergebnis in string um und zeigt in textbox Resultat an
        }

        private void CmdMultiplikation_Click(object sender, EventArgs e) // Methode um beide Zahlen zu multiplizieren
        {
            int zahl1 = int.Parse(TxtZahl1.Text); // wandelt die erste Zahl in int um
            int zahl2 = int.Parse(TxtZahl2.Text); // wandelt die zweite Zahl in int um
            int ergebnis = zahl1 * zahl2; // multipliziert beide Zahlen und speichert sie in int ergebnis
            TxtResultat.Text = $"{ergebnis}"; // wandelt int ergebnis in string um und zeigt in textbox Resultat an
        }

        private void CmdDiffision_Click(object sender, EventArgs e) // Methode um beide Zahlen zu difidieren
        {
            int zahl1 = int.Parse(TxtZahl1.Text); // wandelt die erste Zahl in int um
            int zahl2 = int.Parse(TxtZahl2.Text); // wandelt die zweite Zahl in int um
            int ergebnis = zahl1 / zahl2; // difidiert beide Zahlen und speichert sie in int ergebnis
            TxtResultat.Text = $"{ergebnis}"; // wandelt int ergebnis in string um und zeigt in textbox Resultat an
        }
    }
}
