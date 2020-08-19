using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USteuerbetrag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAusgabe_Click(object sender, EventArgs e)
        {
            int gehalt, steuersatz, steuerbetrag = 0;
            gehalt = Convert.ToInt32(TxtEingabe.Text);

            if (gehalt <= 12000)
                steuersatz = 12;
            else if
                (gehalt <= 20000)
                steuersatz = 15;
            else if (gehalt <= 30000)
                steuersatz = 20;
            else
                steuersatz = 25;

            steuerbetrag = gehalt * steuersatz / 100;
            LblSteuersatz.Text = "Steuersatz: " + steuersatz + "%";
            LblAusgabe.Text = "Steuerbetrag: " + steuerbetrag; 
        }
    }
}
