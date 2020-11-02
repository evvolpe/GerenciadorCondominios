﻿using Condominios.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Condominios.DAL.Interface
{
    public interface IServicoRepositorio : IRepositorioGenerico<Servico>
    {
        Task<IEnumerable<Servico>> PegarServicosPeloUsuario(string usuarioId);
    }
}
