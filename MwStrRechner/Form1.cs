namespace MwStrRechner
{
    public partial class Form1 : Form
    {
        private double gesamtSteuern = 0;  // Gesamtsumme der Steuern
        private double gesamtNetto = 0;   // Gesamtsumme des Netto-Werts
        private double gesamtBrutto = 0;  // Gesamtsumme des Brutto-Werts

        private string MeineConfig = "MwStConfig.txt";  // Name der Konfigurationsdatei
        private bool isNettoselected = true;  // Auswahl zwischen Netto und Brutto (Standard: Netto)

        public Form1()
        {
            InitializeComponent();
        }

        // Methode zur Berechnung der Werte
        private void BerechneWerte()
        {
            try
            {
                if (tbxEingabe.Text.Length > 0 && tbxMwSt.Text.Length > 0)
                {
                    double eingabe = Convert.ToDouble(tbxEingabe.Text);
                    double mwst = Convert.ToDouble(tbxMwSt.Text);

                    double netto, steuern, brutto;

                    if (rbtnNetto.Checked)
                    {
                        netto = eingabe;
                        steuern = eingabe * (mwst / 100);
                        brutto = eingabe * ((mwst / 100) + 1);
                    }
                    else
                    {
                        brutto = eingabe;
                        steuern = brutto * (mwst / 100);
                        netto = brutto / ((mwst / 100) + 1);
                    }

                    tbxNetto.Text = netto.ToString("N2");
                    tbxSteuern.Text = steuern.ToString("N2");
                    tbxBrutto.Text = brutto.ToString("N2");
                }
            }
            catch
            {
                tbxEingabe.Text = "";
                MessageBox.Show("Eingabewert ist falsch", "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event-Handler für den Button "Rechner"
        private void btnRechner_Click(object sender, EventArgs e)
        {
            BerechneWerte();
        }

        // Event-Handler für den Button "Reset"
        private void resetbtn_Click(object sender, EventArgs e)
        {
            // Zurücksetzen der Gesamtsummen und Eingabefelder
            gesamtSteuern = 0;
            gesamtNetto = 0;
            gesamtBrutto = 0;

            tbxSteuernGes.Text = gesamtSteuern.ToString("N2");
            tbxNettoGes.Text = gesamtNetto.ToString("N2");
            tbxBruttoGes.Text = gesamtBrutto.ToString("N2");

            tbxEingabe.Text = "";

            tbxNetto.Text = "";
            tbxSteuern.Text = "";
            tbxBrutto.Text = "";
            tbxEingabe.Focus();
        }

        // Event-Handler für das KeyDown-Ereignis des Eingabefelds
        private void tbxEingabe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (tbxEingabe.Text.Length > 0 && tbxMwSt.Text.Length > 0)
                    {
                        double eingabe = Convert.ToDouble(tbxEingabe.Text);
                        double mwst = Convert.ToDouble(tbxMwSt.Text);

                        double netto, steuern, brutto;

                        if (isNettoselected)
                        {
                            netto = eingabe;
                            steuern = eingabe * (mwst / 100);
                            brutto = eingabe * ((mwst / 100) + 1);
                        }
                        else
                        {
                            brutto = eingabe;
                            steuern = brutto * (mwst / 100);
                            netto = brutto / ((mwst / 100) + 1);
                        }

                        tbxNetto.Text = netto.ToString("N2");
                        tbxSteuern.Text = steuern.ToString("N2");
                        tbxBrutto.Text = brutto.ToString("N2");

                        // Aktualisieren der Gesamtsummen
                        gesamtSteuern += steuern;
                        gesamtNetto += netto;
                        gesamtBrutto += brutto;

                        tbxSteuernGes.Text = gesamtSteuern.ToString("N2");
                        tbxNettoGes.Text = gesamtNetto.ToString("N2");
                        tbxBruttoGes.Text = gesamtBrutto.ToString("N2");
                    }
                }
                catch
                {
                    tbxEingabe.Text = "";
                    MessageBox.Show("Eingabewert ist falsch", "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event-Handler für das KeyUp-Ereignis des Eingabefelds
        private void tbxEingabe_KeyUp(object sender, KeyEventArgs e)
        {
            BerechneWerte();
        }

        // Event-Handler für das CheckedChanged-Ereignis des Radio Buttons "Netto"
        private void rbtnNetto_CheckedChanged(object sender, EventArgs e)
        {
            isNettoselected = true;
            BerechneWerte();
        }

        // Event-Handler für das CheckedChanged-Ereignis des Radio Buttons "Brutto"
        private void rbtnBrutto_CheckedChanged(object sender, EventArgs e)
        {
            isNettoselected = false;
            BerechneWerte();
        }

        // Event-Handler für das Leave-Ereignis des MwSt-Eingabefelds
        private void tbxMwSt_Leave(object sender, EventArgs e)
        {
            SchreibConfigDatei(baueConfigString());
        }

        // Event-Handler für das Load-Ereignis des Formulars
        private void Form1_Load(object sender, EventArgs e)
        {
            // Überprüfen, ob die Konfigurationsdatei existiert
            if (!System.IO.File.Exists(MeineConfig))
            {
                SchreibConfigDatei(baueConfigString());
            }

            // Konfigurationsdaten aus der Datei lesen und in die entsprechenden Felder setzen
            string ConfigLineGesamt = LeseConfigDatei();
            string[] ConfigSplitted = ConfigLineGesamt.Split(";");

            tbxMwSt.Text = ConfigSplitted[0];
            tbxSteuernGes.Text = ConfigSplitted[1];
            tbxNettoGes.Text = ConfigSplitted[2];
            tbxBruttoGes.Text = ConfigSplitted[3];

            // Auswahl zwischen Netto und Brutto wiederherstellen
            if (ConfigSplitted[4] == "True")
            {
                rbtnNetto.Checked = true;
                isNettoselected = true;
            }
            else
            {
                rbtnBrutto.Checked = true;
                isNettoselected = false;
            }
        }

        // Methode zum Lesen der Konfigurationsdatei
        private string LeseConfigDatei()
        {
            StreamReader sr = new StreamReader(MeineConfig);
            string Eingelesenertext = sr.ReadToEnd();
            sr.Close();

            return Eingelesenertext;
        }

        // Methode zum Schreiben in die Konfigurationsdatei
        private void SchreibConfigDatei(string wasauchimmerduwillst)
        {
            StreamWriter sw = new StreamWriter(MeineConfig);
            sw.Write(wasauchimmerduwillst);
            sw.Close();
        }

        // Event-Handler für das FormClosed-Ereignis des Formulars
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SchreibConfigDatei(baueConfigString());
        }

        // Methode zum Erstellen des Konfigurationsstrings
        private string baueConfigString()
        {
            return tbxMwSt.Text + ";" + tbxSteuernGes.Text + ";" + tbxNettoGes.Text + ";" + tbxBruttoGes.Text + ";" + rbtnNetto.Checked;
        }
    }
}
