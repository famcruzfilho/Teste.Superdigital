using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Teste.Superdigital.AppServices.AppServices;
using Teste.Superdigital.Business.Services;
using Teste.Superdigital.Domain.Contracts.AppServices;
using Teste.Superdigital.Domain.Contracts.Repositories;
using Teste.Superdigital.Domain.Contracts.Repositories.UnityOfWork;
using Teste.Superdigital.Domain.Contracts.Services;
using Teste.Superdigital.Infraestructure.Data.Context;
using Teste.Superdigital.Infraestructure.Data.Repositories;
using Teste.Superdigital.Infraestructure.Data.Repositories.UnityOfWork;

namespace Teste.Superdigital.Crosscutting.DI
{
    public class Register
    {
        public IServiceCollection RegisterClass(IServiceCollection services, string stringConexao)
        {
            #region [ Repositories ]

            services.AddTransient<IContaCorrenteRepository, ContaCorrenteRepository>();
            services.AddTransient<ILancamentoRepository, LancamentoRepository>();

            #endregion

            #region [ Unity Of Work ]

            services.AddTransient<IUnityOfWork, UnityOfWork>();

            #endregion

            #region [ Services ]

            services.AddTransient<IContaCorrenteService, ContaCorrenteService>();
            services.AddTransient<ILancamentoService, LancamentoService>();

            #endregion

            #region [ Application Services ]

            services.AddTransient<IContaCorrenteAppService, ContaCorrenteAppService>();
            services.AddTransient<ILancamentoAppService, LancamentoAppService>();

            #endregion

            //#region [ Authentication ]

            //services.AddTransient<IAutenticacaoAppService, AutenticacaoAppService>();
            //services.AddTransient<IAutenticacaoService, AutenticacaoService>();

            //#endregion

            return services.AddDbContext<DataContext>(options => options.UseSqlServer(stringConexao));
        }
    }
}