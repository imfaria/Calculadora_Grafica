using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoragrafica
{
    public partial class Form1 : Form
    {
        Calcular c = new Calcular();
        double numero = 0;

        public Form1()
        {
            InitializeComponent();
        }
    
        private void num1_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text = "";
            visor.Text = visor.Text = "1";
        }

        private void nove_click(object sender, EventArgs e)
        {
            visor.Text += "9";
        }

        private void oito_click(object sender, EventArgs e)
        {
            visor.Text += "8";
        }

        private void sete_click(object sender, EventArgs e)
        {
            visor.Text += "7";
        }

        private void seis_click(object sender, EventArgs e)
        {
            visor.Text += "6";
        }

        private void cinco_click(object sender, EventArgs e)
        {
            visor.Text += "5";
        }

        private void quatro_click(object sender, EventArgs e)
        {
            visor.Text += "4";
        }

        private void tres_click(object sender, EventArgs e)
        {
            visor.Text += "3";
        }

        private void dois_click(object sender, EventArgs e)
        {
            visor.Text += "2";
        }

        private void um_click(object sender, EventArgs e)
        {
            visor.Text += "1";
        }

        private void zero_click(object sender, EventArgs e)
        {
            visor.Text += "0";
        }

        private void limpar_click(object sender, EventArgs e)
        {
            visor.Text = "";
            c.limpar();
        }

        private void virgula_click(object sender, EventArgs e)
        {
            visor.Text += ",";
        }

        private void divisao_click(object sender, EventArgs e)
        {
            numero = double.Parse(visor.Text);
            c.Divisao(numero);
            visor.Text = "";
        }

        private void multiplicacao_click(object sender, EventArgs e)
        {
            numero = double.Parse(visor.Text);
            c.Multiplicacao(numero);
            visor.Text = "";
        }

        private void subtracao_click(object sender, EventArgs e)
        {
            numero = double.Parse(visor.Text);
            c.Menos(numero);
            visor.Text = "";
        }

        private void soma_click(object sender, EventArgs e)
        {
            numero = double.Parse(visor.Text);
            c.Mais(numero);
            visor.Text = "";
        }

        private void igual_click(object sender, EventArgs e)
        {
            numero = double.Parse(visor.Text);
            c.Igual(numero);
            numero = 0;
            visor.Text = c.getTotal().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void porcentagem_click(object sender, EventArgs e)
        {
            numero = double.Parse(visor.Text);
            visor.Text = c.Porcentagem(numero).ToString();
        }

        private void visor_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
