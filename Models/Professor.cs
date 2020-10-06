using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Prova_Sistema_web_Ex4.Models
{
    [Table("Professor")]
    public class Professor
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Endereço: ")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "E-Mail: ")]
        [EmailAddress(ErrorMessage = "E-mail Invalido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Telefone: ")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "E-Disciplina : ")]
        public string Disciplina { get; set; }
    }
}