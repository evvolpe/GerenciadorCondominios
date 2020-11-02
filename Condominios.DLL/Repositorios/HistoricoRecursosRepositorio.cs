using Condominios.BLL.Models;
using Condominios.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominios.DAL.Repositorios
{
    public class HistoricoRecursosRepositorio : RepositorioGenerico<HistoricoRecursos>, IHistoricoRecursosRepositorio
    {
        public HistoricoRecursosRepositorio(Contexto contexto) : base(contexto)
        {
        }
    }
}
