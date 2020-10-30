using Condominios.DAL.Interface;
using Condominios.DAL.Repositorios;
using GerenciadorCondominios.DAL.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Condominios.DAL
{
    public static class ConfiguracaoRepositoriosExtension
    {
        public static void ConfigurarRepositorios(this IServiceCollection services)
        {

            services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddTransient<IFuncaoRepositorio, FuncaoRepositorio>();
            services.AddTransient<IVeiculoRepositorio, VeiculoRepositorio>();
        }
    }
}
