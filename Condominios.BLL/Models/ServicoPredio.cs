using System;

namespace Condominios.BLL.Models
{
    public class ServicoPredio
    {
        public int ServicoPredioId { get; set; }
        public int ServicoId { get; set; }
        public virtual Servico Servicos { get; set; }
        public DateTime DataExecucao { get; set; }
    }
}
