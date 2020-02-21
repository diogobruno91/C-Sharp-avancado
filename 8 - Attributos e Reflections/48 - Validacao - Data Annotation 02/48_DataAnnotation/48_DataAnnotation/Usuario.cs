using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _48_DataAnnotation
{
    class Usuario
    {
        [Required(ErrorMessage = "O campo 'Nome' é de preenchimento obrigatório!")]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(11, MinimumLength = 6)]
        [MyValidacao (ErrorMessage = "O campo senha deve possuir 10 caracteres.")]
        public string Senha { get; set; }
    }
}
