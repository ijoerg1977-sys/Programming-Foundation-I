using System.Windows.Forms;

namespace A6_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int _zahl = 0;
        private void Num_ganze_Zahl_ValueChanged(object sender, EventArgs e)
        {
            _zahl = (int)Num_ganze_Zahl.Value;
        }
        


        private void Cmd_Binaerwert_berechnen_Click(object sender, EventArgs e)
        {

            if (_zahl <= 0)
            {
                MessageBox.Show("Bitte zuerst eine Zahl generieren!");
                return;
            }

            Txt_Ausgabe.Text = ""; // Ausgabe zurücksetzen
            int temp = _zahl;

            while (temp > 0)
            {
                int rest = temp % 2; // Rest bei Division durch 2 (0 oder 1)
                Txt_Ausgabe.Text = rest.ToString() + Txt_Ausgabe.Text; // vorne anhängen
                temp = temp / 2; // Zahl halbieren
            }
        }

       
    }
}
