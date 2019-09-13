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
    public partial class Modifica : Form
    {
        ComboBox cbxNume = new ComboBox();
        ComboBox cbxTelefon = new ComboBox();
        ComboBox cbxCodPostal = new ComboBox();

        Persoane p = new Persoane();
        int contor = 0;

        public Modifica()
        {
            InitializeComponent();
        }

        private void Modifica_Load(object sender, EventArgs e)
        {
            cbxNume.Enabled = false;
            prenumeTxt.Enabled = false;
            cbxNume.Enabled = false;
            cbxTelefon.Enabled = false;
            cbxCodPostal.Enabled = false;
            p.Citire();
            for (int i = 0; i < p.Lungime(); i++)
            {
                lstAfisare.Items.Add(p.Numele(i));
            }

            cbxNume.Items.Add("Popescu");
            cbxNume.Items.Add("Ionescu");
            cbxNume.Items.Add("Enescu");
            cbxNume.Items.Add("Creanga");
            cbxNume.SelectedIndexChanged += new EventHandler(numeCmb_SelectedIndexChanged);

            this.Controls.Add(cbxNume);
            this.Controls.Add(cbxCodPostal);
            this.Controls.Add(cbxTelefon);

            cbxNume.Location = new System.Drawing.Point(152, 300);
            cbxNume.Name = "cbxNume";
            cbxNume.Size = new System.Drawing.Size(220, 21);

            cbxTelefon.Location = new System.Drawing.Point(152, 340);
            cbxTelefon.Size = new System.Drawing.Size(220, 21);

            cbxCodPostal.Location = new System.Drawing.Point(152, 385);
            cbxCodPostal.Size = new System.Drawing.Size(220, 21);
        }

        private void lstAfisare_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxNume.Enabled = true;
            prenumeTxt.Enabled = true;
            cbxTelefon.Enabled = true;
            cbxNume.Enabled = true;
            cbxCodPostal.Enabled = true;

            if (p.Cauta(lstAfisare.Text) != -1)
            {
                cbxCodPostal.Text = "";
                cbxNume.Text = "";
                cbxNume.Text = "";
                cbxTelefon.Text = "";
                prenumeTxt.Text = "";
                contor = p.Cauta(lstAfisare.Text);
                cbxNume.Text = p.Numele(p.Cauta(lstAfisare.Text));
                prenumeTxt.Text = p.Prenumele(p.Cauta(lstAfisare.Text));
                cbxNume.Text = p.Numele(p.Cauta(lstAfisare.Text));
                cbxTelefon.Text = p.Telefonul(p.Cauta(lstAfisare.Text));
                cbxCodPostal.Text = p.CodulPostal(p.Cauta(lstAfisare.Text));
            }
        }
        private void numeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNume.SelectedItem.Equals("Popescu"))
            {
                cbxTelefon.Items.Clear();
                cbxCodPostal.Items.Clear();
                cbxTelefon.Items.Add("0754879456");
                cbxTelefon.Items.Add("0754884566");
                cbxCodPostal.Items.Add("720001");
                cbxCodPostal.Items.Add("720403");
            }
            else if (cbxNume.SelectedItem.Equals("Ionescu"))
            {
                cbxTelefon.Items.Clear();
                cbxCodPostal.Items.Clear();
                cbxTelefon.Items.Add("0754326894");
                cbxTelefon.Items.Add("0754897545");
                cbxTelefon.Items.Add("0759468962");
                cbxCodPostal.Items.Add("720005");
                cbxCodPostal.Items.Add("720002");
            }

            else if (cbxNume.SelectedItem.Equals("Enescu"))
            {
                cbxCodPostal.Items.Clear();
                cbxTelefon.Items.Clear();
                cbxTelefon.Items.Add("0765984512");
                cbxTelefon.Items.Add("0754894565");
                cbxCodPostal.Items.Add("875168");
                cbxCodPostal.Items.Add("658754");
                cbxCodPostal.Items.Add("720003");
            }
            else if (cbxNume.SelectedItem.Equals("Creanga"))
            {
                cbxCodPostal.Items.Clear();
                cbxTelefon.Items.Clear();
                cbxTelefon.Items.Add("0754891245");
                cbxTelefon.Items.Add("0745845126");
                cbxTelefon.Items.Add("0789445621");
                cbxTelefon.Items.Add("0745662133");
                cbxCodPostal.Items.Add("457861");
                cbxCodPostal.Items.Add("256784");
                cbxCodPostal.Items.Add("720004");
                cbxCodPostal.Items.Add("789456");
            }
        }

        private void SalvareBtn_Click(object sender, EventArgs e)
        {
            if ((cbxNume.Text == "") || (prenumeTxt.Text == "") || (cbxTelefon.Text == "") || (cbxCodPostal.Text == ""))
                MessageBox.Show("Completati toate campurile!");
            else
            {
                p.Modifica(cbxNume.Text, prenumeTxt.Text, Convert.ToInt32(cbxTelefon.Text), Convert.ToInt32(cbxCodPostal.Text), contor);
                p.Salvare();

                cbxNume.Text = "";
                prenumeTxt.Text = "";
                cbxCodPostal.Text = "";
                cbxNume.Text = "";
                cbxTelefon.Text = "";
                cbxNume.Items.Clear();
                cbxCodPostal.Items.Clear();
                cbxTelefon.Items.Clear();
                lstAfisare.Items.Clear();

                cbxNume.Items.Add("Popescu");
                cbxNume.Items.Add("Ionescu");
                cbxNume.Items.Add("Enescu");
                cbxNume.Items.Add("Creanga");

                cbxNume.Enabled = false;
                prenumeTxt.Enabled = false;
                cbxTelefon.Enabled = false;
                cbxNume.Enabled = false;
                cbxCodPostal.Enabled = false;

                p.Citire();
                for (int i = 0; i < p.Lungime(); i++)
                {
                    lstAfisare.Items.Add(p.Numele(i));
                }
            }
        }

        private void IesireBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
