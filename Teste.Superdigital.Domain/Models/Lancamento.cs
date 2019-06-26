using System;
using System.Runtime.Serialization;

namespace Teste.Superdigital.Domain.Models
{
    [Serializable]
    public class Lancamento : ISerializable
    {
        public int LancamentoId { get; set; }
        public int ContaCorrenteOrigemId { get; set; }
        public ContaCorrente ContaCorrenteOrigem { get; set; }
        public int ContaCorrenteDestinoId { get; set; }
        public ContaCorrente ContaCorrenteDestino { get; set; }
        public double Valor { get; set; }

        public Lancamento()
        {

        }

        public Lancamento(SerializationInfo info, StreamingContext context)
        {
            ContaCorrenteOrigem = (ContaCorrente)info.GetValue("ContaCorrenteOrigem", typeof(ContaCorrente));
            ContaCorrenteDestino = (ContaCorrente)info.GetValue("ContaCorrenteDestino", typeof(ContaCorrente));
            Valor = info.GetDouble("Valor");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("LancamentoId", LancamentoId);
            info.AddValue("ContaCorrenteOrigem", ContaCorrenteOrigem);
            info.AddValue("ContaCorrenteDestino", ContaCorrenteDestino);
            info.AddValue("Valor", Valor);
        }
    }
}