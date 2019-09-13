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
    public partial class Afisare : Form
    {
        ComboBox cbxNume = new ComboBox();
        ComboBox cbxTelefon = new ComboBox();
        ComboBox cbxCodPostal = new ComboBox();
        Persoane p = new Persoane();
        int pozit = 0;

        public Afisare()
        {
            InitializeComponent();
        }

        private void Afisare_Load(object sender, EventArgs e)
        {
            p.Citire();
            for (int i = 0; i < p.Lungime(); i++)
            {
                if (SortareCmb.Items.Contains((p.Numele(i)[0]).ToString()) == false)
                    SortareCmb.Items.Add((p.Numele(i)[0]).ToString());


                AfisareList.Items.Add(p.Numele(i));
            }
        }

        private void AfisareBtn_Click(object sender, EventArgs e)
        {
            AfisareList.Items.Clear();
            p.Citire();
            for (int i = 0; i < p.Lungime(); i++)
            {
                if (SortareCmb.Items.Contains((p.Numele(i)[0]).ToString()) == false)
                    SortareCmb.Items.Add((p.Numele(i)[0]).ToString());


                AfisareList.Items.Add(p.Numele(i));
            }
        }

        private void StergereBtn_Click(object sender, EventArgs e)
        {
            if (AfisareList.Items.Count == 0)
                MessageBox.Show("Nu mai exista nici o persoana!");
            else
            {
                if (AfisareList.Text == "")
                {
                    MessageBox.Show("Nu ai selectat nici o persoana!");
                }
                else
                {
                    p.Stergere(AfisareList.Text);
                    AfisareList.Items.RemoveAt(Convert.ToInt32(AfisareList.SelectedIndex));
                    p.Salvare();

                    numeTxt.Text = "";
                    prenumeTxt.Text = "";
                    telefonTxt.Text = "";
                    codPostalTxt.Text = "";
                }
            }
        }

        private void numeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNume.SelectedItem.Equals("Popescu"))
            {
                cbxTelefon.Items.Clear();
                cbxCodPostal.Items.Clear();
                cbxTelefon.Items.Add("0754879456");
                cbxTelefon.Items.Add("0754879456");
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
                cbxTelefon.Items.Add("0757894567");
                cbxTelefon.Items.Add("0745697884");
                cbxCodPostal.Items.Add("457861");
                cbxCodPostal.Items.Add("256784");
                cbxCodPostal.Items.Add("720004");
                cbxCodPostal.Items.Add("789456");
            }
        }

        private void InapoiBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AfisareList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (p.Cauta(AfisareList.Text) != -1)
            {
                numeTxt.Text = "";
                prenumeTxt.Text = "";
                telefonTxt.Text = "";
                codPostalTxt.Text = "";

                numeTxt.Text = p.Numele(p.Cauta(AfisareList.Text));
                prenumeTxt.Text = p.Prenumele(p.Cauta(AfisareList.Text));
                telefonTxt.Text = p.Telefonul(p.Cauta(AfisareList.Text));
                codPostalTxt.Text = p.CodulPostal(p.Cauta(AfisareList.Text));
            }
        }

        private void SortareCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            numeTxt.Text = "";
            prenumeTxt.Text = "";
            telefonTxt.Text = "";
            codPostalTxt.Text = "";

            AfisareList.Items.Clear();
            for (pozit = 0; pozit < p.Lungime(); pozit++)
            {
                if (p.Numele(pozit)[0].ToString() == SortareCmb.Text)
                    AfisareList.Items.Add(p.Numele(pozit));
            }
        }
    }
}
