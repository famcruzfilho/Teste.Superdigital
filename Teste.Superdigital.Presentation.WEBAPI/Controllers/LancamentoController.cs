using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Teste.Superdigital.Domain.Contracts.AppServices;
using Teste.Superdigital.Domain.Contracts.Repositories.UnityOfWork;
using Teste.Superdigital.Domain.Models;

namespace Teste.Superdigital.Presentation.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LancamentoController : ControllerBase
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IContaCorrenteAppService _contaCorrenteAppService;

        public LancamentoController(IUnityOfWork unityOfWork, IContaCorrenteAppService contaCorrenteAppService)
        {
            _unityOfWork = unityOfWork;
            _contaCorrenteAppService = contaCorrenteAppService;
        }

        #region Exemplo - Json
        //Exemplo de Json para realização da chamada do endpoint
        //'{
        // "ContaCorrenteOrigem": {
        //  "Numero": 123
        // },
        // "ContaCorrenteDestino": {
        //  "Numero": 123
        // },
        // "Valor": 1000
        //}'
        #endregion

        [HttpPost]
        public ActionResult Lancamento([FromBody] string json)
        {
            try
            {
                var lancamento = JsonConvert.DeserializeObject<Lancamento>(json);
                _contaCorrenteAppService.Debitar(lancamento.ContaCorrenteOrigem, lancamento.Valor);
                _contaCorrenteAppService.Creditar(lancamento.ContaCorrenteDestino, lancamento.Valor);
                _unityOfWork.SaveChanges();
                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}