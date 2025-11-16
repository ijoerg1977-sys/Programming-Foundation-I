namespace A3_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum DayOfWeek
        {
            Montag = 1,
            Dienstag,
            Mittwoch,
            Donnerstag,
            Freitag,
            Samstag,
            Sonntag
        }

        private const string TAG_TEXT = ". Tag der Woche"; // Konstanter Text für die Ausgabe

        private void CmdMontag_Click(object sender, EventArgs e) //Button-Klick-Ereignis für Montag
        {
            DayOfWeek tag = DayOfWeek.Montag; // Montag als DaOfWeek definieren
            LblWochentag.Text = ((int)tag).ToString() + TAG_TEXT; // Ausgabe des Werts des Tages
        }

        private void CmdDienstag_Click(object sender, EventArgs e) //Button-Klick-Ereignis für Dienstag
        {
            DayOfWeek tag = DayOfWeek.Dienstag;// Tag als DaOfWeek definieren
            LblWochentag.Text = ((int)tag).ToString() + TAG_TEXT; // Ausgabe des Werts des Tages
        }

        private void CmdMittwoch_Click(object sender, EventArgs e) //Button-Klick-Ereignis für Mittwoch
        {
            DayOfWeek tag = DayOfWeek.Mittwoch; // Tag als DaOfWeek definieren
            LblWochentag.Text = ((int)tag).ToString() + TAG_TEXT;// Ausgabe des Werts des Tages
        }

        private void CmdDonnerstag_Click(object sender, EventArgs e) //Button-Klick-Ereignis für Donnerstag
        {
            DayOfWeek tag = DayOfWeek.Donnerstag; // Tag als DaOfWeek definieren
            LblWochentag.Text = ((int)tag).ToString() + TAG_TEXT;// Ausgabe des Werts des Tages
        }

        private void CmdFreitag_Click(object sender, EventArgs e) //Button-Klick-Ereignis für Freitag
        {
            DayOfWeek tag = DayOfWeek.Freitag; // Tag als DaOfWeek definieren
            LblWochentag.Text = ((int)tag).ToString() + TAG_TEXT;// Ausgabe des Werts des Tages
        }

        private void CmdSamstag_Click(object sender, EventArgs e) //Button-Klick-Ereignis für Samstag
        {
            DayOfWeek tag = DayOfWeek.Samstag; // Tag als DaOfWeek definieren
            LblWochentag.Text = ((int)tag).ToString() + TAG_TEXT;// Ausgabe des Werts des Tages
        }

        private void CmdSonntag_Click(object sender, EventArgs e) //Button-Klick-Ereignis für Sonntag
        {
            DayOfWeek tag = DayOfWeek.Sonntag; // Tag als DaOfWeek definieren
            LblWochentag.Text = ((int)tag).ToString() + TAG_TEXT;// Ausgabe des Werts des Tages
        }

    }
}
