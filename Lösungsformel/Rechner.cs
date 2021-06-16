using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lösungsformel
{
    public partial class Rechner : Form
    {
        public Rechner()
        {
            InitializeComponent();
        }

        //Variablen
        double a, b, c, q, p, D, x1, x2;
        bool error;

        //startet Berechnung
        private void rechneMS_Click(object sender, EventArgs e)
        {      
            //Eingabe
            if (String.IsNullOrEmpty(txtbxa.Text))
            {
                MessageBox.Show("Gib a an!", "Fehlende Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            else
            {
                a = Convert.ToDouble(txtbxa.Text);
            }

            if (String.IsNullOrEmpty(txtbxb.Text))
            {
                MessageBox.Show("Gib b an!", "Fehlende Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            else
            {
                b = Convert.ToDouble(txtbxb.Text);
            }

            if (String.IsNullOrEmpty(txtbxc.Text))
            {
                MessageBox.Show("Gib c an!", "Fehlende Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            else
            {
                c = Convert.ToDouble(txtbxc.Text);
            }

            //Anzeige für Gleichung
            lblgl.Text = "0=" + Convert.ToString(a) + "*x²+" + Convert.ToString(b) + "*x+" + Convert.ToString(c);

            //Berechnung
            if (a == 0)
            {
                MessageBox.Show("Keine Quadratische Funktion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (error == false)
                {
                    q = c / a;
                    p = b / a;
                    D = p * p / 4 - q;

                    if (D >= 0)
                    {
                        if (D == 0)
                        {
                            x1 = -p / 2;
                            lblx1.Text = "x1 =" + Convert.ToString(Math.Round(x1, 4));
                            lblns.Text = "Anzahl der Nullstelle: 1";
                            Math.Round(x1, 4);
                        }
                        else
                        {
                            x1 = -(p / 2) + Math.Sqrt(p * p / 4 - q);
                            x2 = -(p / 2) - Math.Sqrt(p * p / 4 - q);
                            // Ausgabe
                            lblx1.Text = "x1 =" + Convert.ToString(Math.Round(x1, 4));
                            lblx2.Text = "x2 =" + Convert.ToString(Math.Round(x2, 4));
                            lblns.Text = "Anzahl der Nullstellen: 2";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Keine Nullstelle", "Keine Nullstellen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblns.Text = "Anzahl der Nullstelle: keine";
                    }
                }

            }


        }    

        //Löscht alle Eingaben
        private void löscheMS_Click(object sender, EventArgs e)
        {
            txtbxa.Clear();
            txtbxb.Clear();
            txtbxc.Clear();
            lblx1.Text = "x1 =";
            lblx2.Text = "x2 =";
            lblgl.Text = "Gleichung";
            lblns.Text = "Anzahl der Nullstellen:";
            error = false;
        }

        //Beendet das Programm
        private void stopMS_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
