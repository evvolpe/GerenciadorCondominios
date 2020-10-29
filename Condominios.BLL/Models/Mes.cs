﻿using System.Collections.Generic;

namespace Condominios.BLL.Models
{
    public class Mes
    {
        public int MesId { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Aluguel> Alugueis { get; set; }
        public virtual ICollection<HistoricoRecursos> HistoricoRecursos { get; set; }
    }
}
