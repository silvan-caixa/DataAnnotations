using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnnotations.Models
{
    [Table("USUARIO", Schema = "dbo")]
    public class Usuario
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        [MinLength(3)]
        [Column("NOME", TypeName = "VARCHAR")]
        public string? Nome { get; set; }
        [Required]
        [MaxLength(15)]
        [MinLength(3)]
        [Column("CPF", TypeName = "VARCHAR")]
        public string? Cpf { get; set; }

        public List<Post?> Posts { get; set; } = new();
    }
}