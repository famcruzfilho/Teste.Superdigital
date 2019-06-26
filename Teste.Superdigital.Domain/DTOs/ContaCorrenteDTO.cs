using System;

namespace Teste.Superdigital.Domain.DTOs
{
    public class ContaCorrenteDTO
    {
        public int ContaCorrenteId { get; set; }
        public int Numero { get; set; }
        public string Titular { get; set; }
        public DateTime Criacao { get; set; }
        public double Saldo { get; set; }
    }
}