using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectVally.API.ViewModels
{
    public class EntryKindViewModel
    {
        [Key]
        public int EntryKindId { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "Preencha o campo {0}")]
        [MaxLength(250, ErrorMessage = "Máximo {1} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {1} caracteres")]
        public string Description { get; set; }

        public int OwnerId { get; set; }
        public virtual EntryKindViewModel Owner { get; set; }

    }
}