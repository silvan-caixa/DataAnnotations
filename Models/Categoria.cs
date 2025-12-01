using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnnotations.Models;

[Table("CATEGORIA", Schema = "dbo")]
public class Categoria
{
    [Column("ID")]
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Column("NAME", TypeName = "VARCHAR")]
    [MaxLength(60)]
    [MinLength(3)]
    [Required]
    public string? Nome { get; set; }
    [Column("DESCRICAO", TypeName = "VARCHAR")]
    [MaxLength(60)]
    [MinLength(3)]
    [Required]
    public string? Descricao { get; set; }
}