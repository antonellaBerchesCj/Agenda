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
    public partial class AdaugarePersoana : Form
    {
        Persoane p = new Persoane();

        public AdaugarePersoana()
        {
            InitializeComponent();
        }

        private void AdaugarePersoana_Load(object sender, EventArgs e)
        {
            p.Citire();
        }

        private void AdaugareBtn_Click(object sender, EventArgs e)
        {
            if ((numeCmb.Text == "") || (prenumeCmb.Text == "") || (telefonCmb.Text == "") || (codPostalCmb.Text == ""))
                MessageBox.Show("Nu ati completat toate campurile!");
            else
            {
                if (p.Cauta(numeCmb.Text) != -1)
                {
                    MessageBox.Show("Numele respectiv exista deja in baza.");
                }
                else
                {
                    p.adaugare(numeCmb.Text, prenumeCmb.Text, Convert.ToInt32(telefonCmb.Text), Convert.ToInt32(codPostalCmb.Text));
                    numeCmb.Text = "";
                    telefonCmb.Text = "";
                    codPostalCmb.Text = "";

                    numeCmb.Items.Clear();
                    telefonCmb.Items.Clear();
                    p.Salvare();
                }
            }
        }

        private void IesireBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (numeCmb.SelectedItem.Equals("Popescu"))
            {
                prenumeCmb.Items.Clear();
                telefonCmb.Items.Clear();
                codPostalCmb.Items.Clear();
                prenumeCmb.Items.Add("Ioan");
                prenumeCmb.Items.Add("Gabriel");
                prenumeCmb.Items.Add("Florin");
                telefonCmb.Items.Add("0754879456");
                telefonCmb.Items.Add("0754884566");
                codPostalCmb.Items.Add("720001");
                codPostalCmb.Items.Add("720403");
            }
            else if (numeCmb.SelectedItem.Equals("Ionescu"))
            {
                prenumeCmb.Items.Clear();
                telefonCmb.Items.Clear();
                codPostalCmb.Items.Clear();
                prenumeCmb.Items.Add("Petrica");
                prenumeCmb.Items.Add("Vasile");
                telefonCmb.Items.Add("0754326894");
                telefonCmb.Items.Add("0754897545");
                telefonCmb.Items.Add("0759468962");
                codPostalCmb.Items.Add("720005");
                codPostalCmb.Items.Add("720002");
            }

            else if (numeCmb.SelectedItem.Equals("Enescu"))
            {
                prenumeCmb.Items.Clear();
                codPostalCmb.Items.Clear();
                telefonCmb.Items.Clear();
                prenumeCmb.Items.Add("George");
                prenumeCmb.Items.Add("Razvan");
                prenumeCmb.Items.Add("Eugen");
                telefonCmb.Items.Add("0765984512");
                telefonCmb.Items.Add("0754894565");
                codPostalCmb.Items.Add("875168");
                codPostalCmb.Items.Add("658754");
                codPostalCmb.Items.Add("720003");
            }
            else if (numeCmb.SelectedItem.Equals("Creanga"))
            {
                prenumeCmb.Items.Clear();
                codPostalCmb.Items.Clear();
                telefonCmb.Items.Clear();
                prenumeCmb.Items.Add("Daniel");
                prenumeCmb.Items.Add("Ion");
                prenumeCmb.Items.Add("Emanuel");
                prenumeCmb.Items.Add("Samuel");
                telefonCmb.Items.Add("0754891245");
                telefonCmb.Items.Add("0745845126");
                telefonCmb.Items.Add("0789445621");
                telefonCmb.Items.Add("0745662133");
                codPostalCmb.Items.Add("457861");
                codPostalCmb.Items.Add("256784");
                codPostalCmb.Items.Add("720004");
                codPostalCmb.Items.Add("789456");
            }
        }

    }
}
