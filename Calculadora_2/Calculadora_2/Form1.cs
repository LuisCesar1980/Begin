using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Faço os métodos para as respectivas operações matemáticas
        public void Somar()
        {
            //Código executado se não houver erros
            try
            {
                int valor1, valor2, resultado;

                valor1 = Convert.ToInt32(textBox1.Text);
                valor2 = Convert.ToInt32(textBox2.Text);

                resultado = valor1 + valor2;

                labelResultado.Text = resultado.ToString();
            }

            //Se o usuário clicar no botão sem antes digitar um número será disparado 
            //uma msg de erro
            catch (System.FormatException)
            {
                MessageBox.Show("Digite um número inteiro por favor");
            }
        }

        public void Subtrair()
        {
            try
            {
                int valor1, valor2, resultado;

                valor1 = Convert.ToInt32(textBox1.Text);
                valor2 = Convert.ToInt32(textBox2.Text);

                resultado = valor1 - valor2;

                labelResultado.Text = resultado.ToString();
            }

            catch (System.FormatException)
            {
                MessageBox.Show("Digite um número inteiro por favor");
            }
        }

        public void Multiplicar()
        {
            try
            {
                int valor1, valor2, resultado;

                valor1 = Convert.ToInt32(textBox1.Text);
                valor2 = Convert.ToInt32(textBox2.Text);

                resultado = valor1 * valor2;

                labelResultado.Text = resultado.ToString();
            }

            catch (System.FormatException)
            {
                MessageBox.Show("Digite um número inteiro por favor");
            }

        }

        //Aqui faço a verificação se o número é divisível por 0, se for, 
        //disparo uma mensagem ao usuário
        public void Dividir()
        {
            try
            {
                int valor1, valor2, resultado;

                valor1 = Convert.ToInt32(textBox1.Text);
                valor2 = Convert.ToInt32(textBox2.Text);

                resultado = valor1 / valor2;

                labelResultado.Text = resultado.ToString();
            }

            catch (System.FormatException)
            {
                MessageBox.Show("Digite um número inteiro por favor");
            }

            //Se o número for tentar ser dividido por 0 disparo a mensagem de erro e 
            //limpo os valores
            catch (System.DivideByZeroException)
            {
                MessageBox.Show("Impossível dividir por 0");
                Limpar();
            }
        }

        //Aqui faço o método para limpar os valores
        public void Limpar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            labelResultado.Text = "";
        }

		//Nos botões faço as chamadas aos métodos récem-criados
        private void buttonSomar_Click(object sender, EventArgs e)
        {
            Somar();
        }

        private void buttonSubtrair_Click(object sender, EventArgs e)
        {
            Subtrair();
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            Multiplicar();
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            Dividir();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            DialogResult result; // result vai ser do tipo DialogResult.

            result = MessageBox.Show("Deseja sair do sistema?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        //No evento KeyPress faço a verificação para permitir apenas números.
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Digite um número válido por favor");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Digite um número válido por favor");
            }
        }

    }
}
