using cEs.Domain.Interface.Entities.Seguranca;
using cEs.Infra.CrossCutting.Identity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace cEs.Infra.CrossCutting.IoC
{
    public class SimpleInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAcessoUsuario, AspNetUsuario>();

        }
    }
}
