namespace Teste.Superdigital.Domain.DTOs
{
    public class LancamentoDTO
    {
        public int LancamentoId { get; set; }
        public int ContaCorrenteOrigemId { get; set; }
        public ContaCorrenteDTO ContaCorrenteOrigem { get; set; }
        public int ContaCorrenteDestinoId { get; set; }
        public ContaCorrenteDTO ContaCorrenteDestino { get; set; }
        public double Valor { get; set; }
    }
}