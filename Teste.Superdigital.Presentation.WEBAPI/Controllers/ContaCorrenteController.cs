using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Teste.Superdigital.Domain.Contracts.AppServices;
using Teste.Superdigital.Domain.Models;

namespace Teste.Superdigital.Presentation.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaCorrenteController : ControllerBase
    {
        private readonly IContaCorrenteAppService _contaCorrenteAppService;

        public ContaCorrenteController(IContaCorrenteAppService contaCorrenteAppService)
        {
            _contaCorrenteAppService = contaCorrenteAppService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ContaCorrente>> Get()
        {
            return _contaCorrenteAppService.ObterTodos().ToList();
        }
    }
}