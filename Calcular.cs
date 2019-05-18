using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadoragrafica
{
    //Calculo
   public class Calcular
    {
        private double total = 0;
        private char sinal;
        private bool validar = false;

        public double getTotal()
        {
            return this.total;
        }

        public void limpar()
        {
            this.total = 0;

        }
        public double MaisMenos(double numero)
        {
            return numero *= -1;
        }
        public void Mais(double numero)
        {
            if (this.validar == true)
            {
                this.total += numero;
            }
            else
            {
                this.total = numero;
                this.validar = true;
            }
            this.sinal = '+';
        }

        public void Menos(double numero)
        {
            if (this.validar == true)
            {
                this.total -= numero;
            }
            else
            {
                this.total = numero;
                this.validar = true;
            }
            this.sinal = '-';
        }
        public void Multiplicacao(double numero)
        {
            if (this.validar == true)
            {
                this.total *= numero;
            }
            else
            {
                this.total = numero;
                this.validar = true;
            }
            this.sinal = '*';
        }
        public void Divisao(double numero)
        {
            if (this.validar == true)
            {
                this.total /= numero;
            }
            else
            {
                this.total = numero;
                this.validar = true;
            }
            this.sinal = '/';
        }
        public void Igual(double numero)
        {

            if (sinal == '+')
            {
                this.total += numero;
            }
            else if (sinal == '-')
            {
                this.total -= numero;
            }
            else if (sinal == '*')
            {
                this.total *= numero;
            }
            else if (sinal == '/')
            {
                this.total /= numero;
            }
            this.validar = false;

        }

        public double Porcentagem(double numero)
        {
            double result = numero / 100;
            return result;
        }
    }
}
    

