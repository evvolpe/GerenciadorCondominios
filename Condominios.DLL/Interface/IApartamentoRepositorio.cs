﻿using Condominios.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Condominios.DAL.Interface
{
    public interface IApartamentoRepositorio : IRepositorioGenerico<Apartamento>
    {
        new Task<IEnumerable<Apartamento>> PegarTodos();

        Task<IEnumerable<Apartamento>> PegarApartamentoPeloUsuario(string usuarioId);
    }
}
