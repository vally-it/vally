using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectVally.API.ViewModels
{
    public class UserViewModel
    {
        [Key]
        public int UserId { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Name { get; set; }

        
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(15, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(11, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Mail { get; set; }

        [ScaffoldColumn(false)]
        public string Password { get; set; }

        [DisplayName("Ativo?")]
        public bool Enabled { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RegisterDate { get; set; }
        
    }
}