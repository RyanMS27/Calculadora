using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculadora
{


    public partial class Calculadora : Form
    {

        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao,
            porcentagem

        }

        public Calculadora()
        {
            InitializeComponent();
            this.Text = "Calculadora";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(','))
                txtResultado.Text += ",";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtResultado.Text, out decimal numero))
            {
                MessageBox.Show("Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal percentual = 10; // Pode substituir por outro valor ou receber como entrada do usuário
            decimal resultado = (numero * percentual) / 100;

            txtResultado.Text = resultado.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.porcentagem:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;

            }
            txtResultado.Text = Convert.ToString(Resultado);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";

                    }


        private void button4_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";

        }
       
    }
    
}
