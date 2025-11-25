using DataAnnotations.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DataAnnotations.Data;

public class DataContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Post> Posts { get; set; }

    public static string ConnectionString =>
        "Server=develope.database.windows.net;Database=develope;User Id=dev;Password=Silvan@12345;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionString);
    }


    public static void TestarConexao()
    {
        using var conection = new SqlConnection(ConnectionString);

        try
        {
            conection.Open();
            Console.WriteLine("Conexão aberta com sucesso!");
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
        }
    }
}