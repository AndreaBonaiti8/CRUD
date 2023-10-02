using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

        }
        public string prodString(prodotto p)
        {
            return "Nome:"+p.nome+" prezzo:"+p.prezzo.ToString();
        }
        public void visualizza(prodotto[] pp)
        {
            listView1.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                listView1.Items.Add(prodString(p[i]));
            }
        }
        public void modifica()
        {
            for (int i = 0;i < dim; i++)
            {
                string a = nome1.Text;
                if (a == p[i].nome)
                {
                    p[i].nome = nome2.Text;
                }
            }
        }
        public void cancella () 
        {
            for (int i = 0; i < dim; i++)
            {
                string a = nome1.Text;
                string b = prezzo2.Text;
                if (a == p[i].nome)
                {
                    p[i].nome = p[i+1].nome;
                    p[i].prezzo = p[i + 1].prezzo;
                }
            }
        }

        private void modifi_Click(object sender, EventArgs e)
        {
            modifica();
            visualizza(p);
        }
        private void canc_Click(object sender, EventArgs e)
        {
            cancella();
            visualizza(p);
        }
        
    }
}
