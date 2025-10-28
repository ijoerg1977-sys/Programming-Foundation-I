namespace Stromverbrauch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdBerechnen_Click(object sender, EventArgs e)
        {
            double eingabe = (double)NumStromverbrauch.Value;
            double ausgabe = eingabe * 0.15;

            LblResult.Text = "Kosten sind " + ausgabe.ToString() + "Fr.";

        }
    }
}
