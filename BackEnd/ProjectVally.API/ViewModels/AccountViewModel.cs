using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectVally.API.ViewModels
{
    public class AccountViewModel
    {
        [Key]
        public int AccountId { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "Preencha o campo {0}")]
        [MaxLength(250, ErrorMessage = "Máximo {1} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {1} caracteres")]
        public string Description { get; set; }

        [DisplayName("Ativo?")]
        public bool Enabled { get; set; }

        [DisplayName("Saldo Atual")]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal CurrentBalance { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RegisterDate { get; set; }

        public int UserId { get; set; }
        public virtual UserViewModel User { get; set; }

        public int AccountKindId { get; set; }
        public virtual AccountKindViewModel AccoundKind { get; set; }
        
    }
}