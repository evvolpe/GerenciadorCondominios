using Condominios.BLL.Models;
using Condominios.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominios.DAL.Repositorios
{
    public class FuncaoRepositorio : RepositorioGenerico<Funcao>, IFuncaoRepositorio
    {
        public FuncaoRepositorio(Contexto contexto) : base(contexto)
        {
        }
    }
}
