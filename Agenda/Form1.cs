using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        Persoane pOb = new Persoane();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pOb.Citire();
            for (int i = 0; i < pOb.Lungime(); i++)
                InfoCmb.Items.Add(pOb.Numele(i));
        }

        private void IesireBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AfisareBtn_Click(object sender, EventArgs e)
        {
            Afisare frmAfisare = new Afisare();
            frmAfisare.ShowDialog();
        }

        private void AdaugareBtn_Click(object sender, EventArgs e)
        {
            AdaugarePersoana formAdauga = new AdaugarePersoana();
            formAdauga.ShowDialog();
        }

        private void ModificareBtn_Click(object sender, EventArgs e)
        {
            Modifica frmAfisare = new Modifica();
            frmAfisare.ShowDialog();
        }

        private void InfoCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InfoCmb.Text != "")
            {
                numeTxt.Text = pOb.Numele(pOb.Cauta(InfoCmb.Text));
                prenumeTxt.Text = pOb.Prenumele(pOb.Cauta(InfoCmb.Text));
                telefonTxt.Text = pOb.Telefonul(pOb.Cauta(InfoCmb.Text));
                codPostalTxt.Text = pOb.CodulPostal(pOb.Cauta(InfoCmb.Text));
            }
        }
    }
}
