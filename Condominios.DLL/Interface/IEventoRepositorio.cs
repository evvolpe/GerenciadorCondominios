﻿using Condominios.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Condominios.DAL.Interface
{
    public interface IEventoRepositorio : IRepositorioGenerico<Evento>
    {
        Task<IEnumerable<Evento>> PegarEventosPeloId(string usuarioId);
    }
}
