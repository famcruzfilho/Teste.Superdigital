using System;

namespace Teste.Superdigital.Domain.ViewModels
{
    public class ContaCorrenteViewModel
    {
        public int ContaCorrenteId { get; set; }
        public int Numero { get; set; }
        public string Titular { get; set; }
        public DateTime Criacao { get; set; }
        public double Saldo { get; set; }
    }
}