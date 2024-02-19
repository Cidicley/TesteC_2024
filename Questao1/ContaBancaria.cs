using System.Globalization;

namespace Questao1
{
    class ContaBancaria {
        public int Conta { get; }
        public string Titular { get; set; }
        public bool DepositoInicial { get; set; }
        public decimal Saldo { get; }


        public ContaBancaria(int conta, string titular, bool depositoInicial, decimal saldo)
        {
            this.Conta = conta;
            this.Titular = titular;
            this.DepositoInicial = depositoInicial;
            this.Saldo = !(depositoInicial) ? saldo : 0;
        }
    }



}
