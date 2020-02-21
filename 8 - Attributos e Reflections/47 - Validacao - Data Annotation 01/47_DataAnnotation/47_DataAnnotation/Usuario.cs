using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _47_DataAnnotation
{
    class Usuario
    {
        [Required(ErrorMessage = "O campo 'Nome' é de preenchimento obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Idiomas.Linguagem), ErrorMessageResourceName = "MSG_OBRIGATORIO")]
        [EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(11, MinimumLength = 6)]
        public string Senha { get; set; }
    }
}
