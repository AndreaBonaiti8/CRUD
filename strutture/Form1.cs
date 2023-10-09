using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace strutture
{
    public partial class Form1 : Form
    {   public struct prodotto
        {
            public string nome;
            public float prezzo;
        }
        public prodotto [] p;
        public int dim;
        public Form1()
        {
            InitializeComponent();
            p=new prodotto[100];
            dim = 0;
        }
        string file = "prodotti.txt";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salva_Click(object sender, EventArgs e)
        {
            p[dim].nome = nome.Text;
            p[dim].prezzo = float.Parse(prezzo.Text);
            dim++;
            visualizza(p);
            if (nome.Text == "" || prezzo.Text == "" || nome.Text == "" && prezzo.Text == "")
            {
                MessageBox.Show("Inserire almeno un valore in untrambe le box sovrastanti");
            }
            nome.Text = "";
            prezzo.Text = "";
        }
        public string prodString(prodotto p)
        {
            return "Nome:"+p.nome+" prezzo:"+p.prezzo.ToString();
        }

        private void modifi_Click(object sender, EventArgs e)
        {
            modifica();
            visualizza(p);
            if (nome1.Text == "" || prezzo2.Text == "" || nome2.Text == "" || prez2.Text == "")
            {
                MessageBox.Show("Inserire almeno un valore in untrambe le box sovrastanti");
            }
            nome1.Text = "";
            prezzo2.Text = "";
            nome2.Text = "";
            prez2.Text = "";
        }
        private void canc_Click(object sender, EventArgs e)
        {
            cancella();
            visualizza(p);
            if (nome1.Text == "" || prezzo2.Text == "")
            {
                MessageBox.Show("Inserire almeno un valore in untrambe le box sovrastanti");
            }
            nome1.Text = "";
            prezzo2.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void min_Click(object sender, EventArgs e)
        {
             MessageBox.Show($"il Prodotto con il prezzo minimo è {Trovamin(p).ToString()}");
        }

        private void sfile_Click(object sender, EventArgs e)
        {
            StreamWriter FileDaL = new StreamWriter(@"file.txt");
            for (int i = 0; i < dim; i++)
            {
                FileDaL.WriteLine($"{p[i].nome};{p[i].prezzo.ToString()}");
            }

        }

        private void lfile_Click(object sender, EventArgs e)
        {
            StreamReader FileDaL = new StreamReader(@"file.txt");
            string riga;
            do
            {
                riga = FileDaL.ReadLine();
                if (riga != null)
                {
                    listView1.Clear();
                    for (int i = 0; i < dim; i++)
                    {
                        listView1.Items.Add($"{p[i].nome};{p[i].prezzo.ToString()}");
                    }
                }
            }
            while (!FileDaL.EndOfStream);
            FileDaL.Close();
        }

        private void max_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"il Prodotto con il prezzo massimo è {Trovamax(p).ToString()}");
        }

        private void totprezzo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Il totale è {Somma(p).ToString()}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ordine();
            visualizza(p);
        }

        private void somperc_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dim; i++)
            {
                percentuale();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void modifica()
        {
            for (int i = 0; i < dim; i++)
            {
                string a = nome1.Text;
                if (a == p[i].nome)
                {
                    p[i].nome = nome2.Text;
                    p[i].prezzo = float.Parse(prez2.Text);
                }
            }
        }
        public void cancella()
        {
            for (int i = 0; i < dim; i++)
            {
                string a = nome1.Text;
                if (a == p[i].nome)
                {
                    p[i].nome = p[i + 1].nome;
                    p[i].prezzo = p[i + 1].prezzo;
                }
            }
            dim--;
        }
        public float Somma(prodotto[] p)
        {
            float tot = 0;
            for (int i = 0; i < dim; i++)
            {
                tot += p[i].prezzo;
            }
            return tot;
        }
        public float Trovamax(prodotto[] p)
        {
            float max = 0;
            for (int i = 0; i < dim; i++)
            {
                if (p[i].prezzo > max)
                {
                    max = p[i].prezzo;
                }
            }
            return max;
        }
        public float Trovamin(prodotto[] p)
        {
            float min = 1000;
            for (int i = 0; i < dim; i++)
            {
                if (p[i].prezzo < min)
                {
                    min = p[i].prezzo;
                }
            }
            return min;
        }
        public void visualizza(prodotto[] pp)
        {
            listView1.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                listView1.Items.Add(prodString(p[i]));
            }
        }
        public void Ordine()
        {
            for (int i = 0; i < dim; i++)
            {
                for (int j = i + 1; j < dim; j++)
                {
                    if (string.Compare(p[i].nome, p[j].nome) > 0)
                    {
                        string tempProdotto = p[i].nome;
                        float tempPrezzo = p[i].prezzo;
                        p[i].nome = p[j].nome;
                        p[i].prezzo = p[j].prezzo;
                        p[j].nome = tempProdotto;
                        p[j].prezzo = tempPrezzo;
                    }
                }
            }
        }
        public void percentuale()
        {
            float nperc = 0;
            nperc = float.Parse(perc.Text);
            for (int i = 0; i < dim; i++)
            {
                p[i].prezzo += (p[i].prezzo / 100) * nperc;
                visualizza(p);
            }
        }
        public void sottpercentuale()
        {
            float nperc = 0;
            nperc = float.Parse(perc.Text);
            for (int i = 0; i < dim; i++)
            {
                p[i].prezzo -= (p[i].prezzo / 100) * nperc;
                visualizza(p);
            }
        }

        private void sotperc_Click(object sender, EventArgs e)
        {
            sottpercentuale();
        }
    }
}
