using Microsoft.AspNetCore.Identity;

namespace Condominios.BLL.Models
{
    public class Funcao : IdentityRole<string>
    {
        public string Descricao { get; set; }
    }
}
