using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Agenda
{
    class Persoana
    {
        public string Nume, Prenume;
        public int Telefon, CodPostal;

        public Persoana()
        {
            Nume = "";
            Prenume = "";
            Telefon = 0;
            CodPostal = 0;
        }

        public string Numele()
        {
            return Nume;
        }
        public string Prenumele
        {
            get
            {
                return this.Prenume;
            }
            set
            {
                Prenume = value;
            }
        }

        public string Telefonul
        {
            get
            {
                return this.Telefon.ToString();
            }
            set
            {
                Telefon = int.Parse(value);
            }
        }

        public string CodulPostal
        {
            get
            {
                return this.CodPostal.ToString();
            }
            set
            {
                CodPostal = int.Parse(value);
            }
        }

        public Persoana(string _nume, string _prenume, int _telefone, int _codPostal)
        {
            Nume = _nume;
            Prenume = _prenume;
            Telefon = _telefone;
            CodPostal = _codPostal;
        }
    }


    class Persoane
    {
        Persoana[] p;
        int poz;
        public Persoane()
        {
            poz = 0;
            p = new Persoana[10];
        }

        public int Lungime()
        {
            return poz;
        }

        public void adaugare(string _nume, string _prenume, int _telefone, int _codPostal)
        {
            p[poz] = new Persoana(_nume, _prenume, _telefone, _codPostal);
            poz++;
        }

        public string Numele(int i)
        {
            return p[i].Numele();
        }

        public string Prenumele(int i)
        {
            return p[i].Prenume;
        }

        public string Telefonul(int i)
        {
            return p[i].Telefon.ToString();
        }

        public string CodulPostal(int i)
        {
            return p[i].CodPostal.ToString();
        }

        public void Stergere(string nume)
        {
            int j = 0;
            for (int i = 0; i < poz; i++)
                if (p[i].Nume == nume)
                {
                    j = i;
                    for (int n = j; n < poz - 1; n++)
                        p[n] = p[n + 1];
                    poz--;
                }
        }

        public int Cauta(string nume)
        {
            int ok = -1;
            for (int i = 0; i < poz; i++)

                if (p[i].Nume == nume)
                {
                    ok = i;
                }
            return ok;
        }

        public void Modifica(string _nume, string _prenume, int _telefone, int _codPostal, int i)
        {
            p[i] = new Persoana(_nume, _prenume, _telefone, _codPostal);
        }

        public void Salvare()
        {
            TextWriter fin = new StreamWriter("persoane.txt");
            fin.WriteLine(poz);
            for (int i = 0; i < poz; i++)
            {
                fin.WriteLine(p[i].Nume);
                fin.WriteLine(p[i].Prenume);
                fin.WriteLine(p[i].Telefon.ToString());
                fin.WriteLine(p[i].CodPostal.ToString());
            }
            fin.Close();
        }

        public void Citire()
        {
            int j = 0;
            TextReader fis = new StreamReader("persoane.txt");
            j = Convert.ToInt32(fis.ReadLine());

            for (poz = 0; poz < j; poz++)
            {
                p[poz] = new Persoana(fis.ReadLine(), fis.ReadLine(), Convert.ToInt32(fis.ReadLine()), Convert.ToInt32(fis.ReadLine()));
            }

            fis.Close();
        }
    }
}


