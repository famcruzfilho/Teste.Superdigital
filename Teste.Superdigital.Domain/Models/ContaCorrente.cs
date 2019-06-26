using System;
using System.Runtime.Serialization;

namespace Teste.Superdigital.Domain.Models
{
    [Serializable]
    public class ContaCorrente : ISerializable
    {
        public int ContaCorrenteId { get; set; }
        public int Numero { get; set; }
        public string Titular { get; set; }
        public DateTime Criacao { get; set; }
        public double Saldo { get; set; }

        public ContaCorrente()
        {

        }

        public ContaCorrente(SerializationInfo info, StreamingContext context)
        {
            Numero = info.GetInt32("Numero");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ContaCorrenteId", ContaCorrenteId);
            info.AddValue("Numero", Numero);
            info.AddValue("Titular", Titular);
            info.AddValue("Criacao", Criacao);
            info.AddValue("Saldo", Saldo);
        }
    }
}