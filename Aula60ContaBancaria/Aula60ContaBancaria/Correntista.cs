using System;
using System.Collections.Generic;
using System.Text;

namespace Aula60ContaBancaria
{
    class Correntista
    {
        public int Conta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Correntista()
        {

        }
        public Correntista(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;
        }
        public Correntista(int conta, string nome, double saldo) : this(conta, nome)
        {
            Depositar(saldo);
        }


        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public void Sacar(double valor)
        {
            Saldo -= valor + 5;
        }
        public override string ToString()
        {
            return "Conta nº " + Conta
                + " - Nome: " + Nome
                + " - Saldo atual R$ " + Saldo.ToString("f2");
        }
    }
}
