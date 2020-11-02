using Condominios.BLL.Models;
using Condominios.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominios.DAL.Repositorios
{
    public class ServicoPredioRepositorio : RepositorioGenerico<ServicoPredio>, IServicoPredioRepositorio
    {
        public ServicoPredioRepositorio(Contexto contexto) : base(contexto)
        {
        }
    }
}
