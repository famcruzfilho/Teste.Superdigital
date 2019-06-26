namespace Teste.Superdigital.Domain.ViewModels
{
    public class LancamentoViewModel
    {
        public int LancamentoId { get; set; }
        public int ContaCorrenteOrigemId { get; set; }
        public ContaCorrenteViewModel ContaCorrenteOrigem { get; set; }
        public int ContaCorrenteDestinoId { get; set; }
        public ContaCorrenteViewModel ContaCorrenteDestino { get; set; }
        public double Valor { get; set; }
    }
}