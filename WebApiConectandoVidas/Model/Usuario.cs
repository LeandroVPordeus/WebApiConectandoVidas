using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using WebApiCV.Validation;



namespace WebApiCV.Model
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Column("Nome")]
        [MaxLength(120, ErrorMessage = "O campo nome deve conter até 120 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Email")]
        [Column("Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [StringLength(100, ErrorMessage = "{0} deve ter pelo menos {2} caracteres de comprimento.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }


        [Required(ErrorMessage = "Campo Obrigatorio")]
        [NotMapped]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar senha")]
        [Compare("Senha", ErrorMessage = "Senha e confirmação não são as mesmas.")]
        public string ComFirmaSenha { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "CPF")]
        [CustomValidationCPF(ErrorMessage = "Cpf Invalido")]
        [Column("Cpf")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Idade")]
        [Column("Idade")]
        public string DataDeNacimente { get; set; }

        [Display(Name = "Biografia")]
        [Column("Biografia")]
        public string Biografia { get; set; }

        [Display(Name = "Tipo Sanguinio")]
        [Column("TipoSanguinio")]
        public string TipoSangue { get; set; }


        [Display(Name = "Rua")]
        [Column("Rua")]
        public string Rua { get; set; }

        [Display(Name = "Numero Da Casa")]
        [Column("NumeroDaCasa")]
        public string NumeroDaCasa { get; set; }

    }

}
