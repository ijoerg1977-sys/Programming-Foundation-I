namespace Aufgabe 9_2_2
{
    public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    //Deklaration des Arry hier damit aus allen Methoden darauf zugegriffen werden kann.
    int[] data;

    private void Cmd_DatenGenerieren_Click(object sender, EventArgs e)
    {
        data = new int[Convert.ToInt32(Txt_GewGroesse.Text)];
        Random rand = new Random();
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = rand.Next(0, 1000);
        }
        Cmd_DatenGenerieren.Enabled = false;

    }

    private void Cmd_WertAuslesen_Click(object sender, EventArgs e)
    {
        int pos = Convert.ToInt32(Txt_PosWaehlen.Text);
        Txt_gespeicherterWert.Text = data[pos].ToString();
        int anzahl = Convert.ToInt32(Txt_erfolgteAbfragen.Text);
        anzahl++;


    }

    private void InitializeComponent()
    {

    }
}
}
