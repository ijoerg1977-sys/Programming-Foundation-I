namespace ArrayUebung1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] zahlen = new int[10];
        int neuezahl = 0;
        int index = 0;


        //Zahl zur Liste hinzufügen
        private void Cmd_Hinzufuegen_Click(object sender, EventArgs e)
        {
           if (index == 0) 
            {
        }

        private void Num_Eingabe_ValueChanged(object sender, EventArgs e)
        {
            neuezahl = (int)Num_Eingabe.Value;
        }
    }
}
