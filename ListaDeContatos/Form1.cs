using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
namespace ListaDeContatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Contato[] listadecontatos = new Contato[1];

        private void Escerver(Contato contato)
        {
            StreamWriter escrever = new StreamWriter("contatos.txt");

            escrever.WriteLine(listadecontatos.Length + 1);
            escrever.WriteLine(contato.Nome);
            escrever.WriteLine(contato.Sobrenome);
            escrever.WriteLine(contato.Telefone);

            for (int x = 0; x < listadecontatos.Length; x++)
            {
                escrever.WriteLine(listadecontatos[x].Nome);
                escrever.WriteLine(listadecontatos[x].Sobrenome);
                escrever.WriteLine(listadecontatos[x].Telefone);
            }

            escrever.Close();
        }

        private void Ler()
        {
            StreamReader ler = new StreamReader("contatos.ter");

            listadecontatos = new Contato[Convert.ToInt32(ler.ReadLine())];

            for (int x = 0; x < listadecontatos.Length; x++)
            {
                listadecontatos[x] = new Contato();
                listadecontatos[x].Nome = ler.ReadLine();
                listadecontatos[x].Sobrenome = ler.ReadLine();
            }
            ler.Close();
        }
        private void Exibir()
        {
            listBox1.Items.Clear();

            for (int x = 0; x < listadecontatos.Length; x++)
            {
                listBox1.Items.Add(listadecontatos[x].ToString());

            }

            private void limparCampos()
            {
                textBox1
            }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();


contato.Nome = textBox1.Text;
contato.Sobrenome = textBox1.Text; 
contato.Telefone = textBox1.Text;
        }
    }
}
