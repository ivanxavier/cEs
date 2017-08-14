using cEs.Application.Administrativo;
using cEs.Application.Comercial;
using cEs.Application.Seguranca;
using cEs.DataAccess.Administrativo;
using cEs.DataAccess.Comercial;
using cEs.Domain.Interface.Entities.Seguranca;
using cEs.Domain.Interface.Repositories.Administrativo;
using cEs.Domain.Interface.Repositories.Comercial;
using cEs.Infra.Authentication.Class;
using cEs.Infra.Email;
using cEs.Infra.Email.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace cEs.Infra
{
    public class SimpleInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspNetUser>();
            //services.AddScoped<Conexao>();
            services.AddScoped<ContatoAppService>();
            services.AddTransient<IContatoRepository, ContatoRepository>();
            services.AddTransient<IEmailService, EmailService>();
            services.AddScoped<AcessoAppService>();
            services.AddScoped<SolicitacaoAppService>();
            services.AddScoped<UfAppService>();
            services.AddTransient<ISolicitacaoRepository, SolicitacaoRepository>();
            services.AddTransient<IUfRepository, UfRepository>();
            services.AddScoped<SolicitacaoStatusAppService>();
            services.AddTransient<ISolicitacaoStatusRepository, SolicitacaoStatusRepository>();

        }
    }
}