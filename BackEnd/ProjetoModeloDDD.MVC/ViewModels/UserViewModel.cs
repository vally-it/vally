using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectVally.MVC.ViewModels
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

        [Required(ErrorMessage = "Preencha um CPF")]
        [MaxLength(15, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(11, ErrorMessage = "Mínimo {0} caracteres")]
        public decimal Cpf { get; set; }

        [Required(ErrorMessage = "Preencha o campo Mail")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Preencha o campo Senha")]
        [MaxLength(20, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(4, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Password { get; set; }


        [DisplayName("Ativo?")]
        public bool Enabled { get; set; }

    }
}