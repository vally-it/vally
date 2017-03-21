using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectVally.API.ViewModels
{
    public class EntryViewModel
    {
        [Key]
        public int EntryId { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "Preencha o campo {0}")]
        [MaxLength(250, ErrorMessage = "Máximo {1} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {1} caracteres")]
        public string Description { get; set; }

        [DisplayName("Valor")]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal),"0", "99999999999")]
        [Required(ErrorMessage ="Preencha um valor")]
        public decimal Value { get; set; }

        [DisplayName("Saldo Atual")]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal CurrentBalance { get; set; }

        [DisplayName("Tipo (C/D)")]
        [RegularExpression("C|D", ErrorMessage ="Informe C=Crédito ou D=Débito")]
        public char Type { get; set; }

        [DisplayName("Data")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [Required(ErrorMessage ="Informe uma data")]
        public DateTime Date { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RegisterDate { get; set; }

        public int AccountId { get; set; }
        public virtual AccountViewModel Account { get; set; }

        public int EntryKindId { get; set; }
        public virtual EntryKindViewModel EntryKind { get; set; }

    }
}