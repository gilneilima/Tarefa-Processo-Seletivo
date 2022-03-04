using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProcessoSeletivo.Models
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Column("Cpf")]
        [Display(Name = "CPF")]
        public string? Cpf { get; set; }

        [Column("Datanasc")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNasc { get; set; }

        [Column("Endereco")]
        [Display(Name = "Endereco")]
        public string? Endereco { get; set; }

        [Column("Sexo")]
        [Display(Name = "Sexo")]
        public string? Sexo { get; set; }
    }
}
