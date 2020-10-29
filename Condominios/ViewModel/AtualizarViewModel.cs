﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Condominios.ViewModel
{
    public class AtualizarViewModel
    {
        public string UsuarioId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(40, ErrorMessage = "Use no máximo 40 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Telefone { get; set; }

        public string Foto { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(40, ErrorMessage = "Use no máximo 40 caracteres")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }
    }
}
