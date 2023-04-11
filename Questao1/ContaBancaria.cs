using System.Globalization;

namespace Questao1
{
    public class ContaBancaria
    {
        public ContaBancaria(int numero,
                             string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero,
                             string titular,
                             double depositoInicial)
        {
            Numero = numero;
            Titular = titular;
            Saldo = depositoInicial;
        }

        public int Numero { get; private set; }
        public double Saldo { get; private set; }
        public string Titular { get; private set; }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {

            Saldo -= quantia;


        }

        public void AlterarNomeDoTitular(string novoNome)
        {
            Titular = novoNome; 
        }

        public string GetDadosDaConta()
        {
            var info = $"Conta {Numero}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";

            return info;
        }
    }
}
