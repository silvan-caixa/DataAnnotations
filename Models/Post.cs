namespace DataAnnotations.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
[Table("POST", Schema = "dbo")]
public class Post
{
    [Column("Id")]
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Column("Titulo", TypeName = "VARCHAR")]
    [MaxLength(60)]
    [MinLength(5)]
    [Required]
    public string? Titulo { get; set; }
    [Column("Sumario", TypeName = "TEXT")]
    [Required]
    public string? Sumario { get; set; }
    [Column("DataCriacao", TypeName = "DATETIME")]
    [Required]
    public DateTime DataCriacao { get; set; }

    [ForeignKey("Categoria")]
    [Required]
    public int CategoriaId { get; set; }
    public Categoria? Categoria { get; set; }

    [ForeignKey("Usuario")]
    [Required]
    public int AuthorId { get; set; }
    public Usuario? Usuario { get; set; }
}
