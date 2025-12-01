using DataAnnotations.Data;
using DataAnnotations.Models;

namespace DataAnnotations;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== MENU BLOG =====");
            Console.WriteLine("1 - Criar Categoria");
            Console.WriteLine("2 - Criar Usuário");
            Console.WriteLine("3 - Criar Post");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": CriarCategoria(); break;
                case "2": CriarUsuario(); break;
                case "3": CriarPost(); break;
                case "0": return;
                default:
                    Console.WriteLine("Opção inválida");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void CriarCategoria()
    {
        using var db = new DataContext();

        Console.Write("Nome da categoria: ");
        string nome = Console.ReadLine() ?? "";
        Console.Write("Descricao da categoria: ");
        string descricao = Console.ReadLine() ?? "";

        var categoria = new Categoria
        {
            Nome = nome,
            Descricao = descricao
            
        };
        db.Categorias.Add(categoria);
        db.SaveChanges();

        Console.WriteLine("Categoria criada com sucesso!");
        Console.ReadKey();
    }

    static void CriarUsuario()
    {
        using var db = new DataContext();

        Console.Write("Nome: ");
        string nome = Console.ReadLine() ?? "";

        Console.Write("CPF: ");
        string cpf = Console.ReadLine() ?? "";

        var usuario = new Usuario { Nome = nome, Cpf = cpf };
        db.Usuarios.Add(usuario);
        db.SaveChanges();

        Console.WriteLine("Usuário criado com sucesso!");
        Console.ReadKey();
    }

    static void CriarPost()
    {
        using var db = new DataContext();

        Console.Write("Título: ");
        string titulo = Console.ReadLine() ?? "";

        Console.Write("Sumário: ");
        string sumario = Console.ReadLine() ?? "";

        Console.Write("ID da Categoria: ");
        int categoriaId = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("ID do Usuário: ");
        int usuarioId = int.Parse(Console.ReadLine() ?? "0");

        var post = new Post
        {
            Titulo = titulo,
            Sumario = sumario,
            CategoriaId = categoriaId,
            AuthorId = usuarioId
        };

        db.Posts.Add(post);
        db.SaveChanges();

        Console.WriteLine("Post criado com sucesso!");
        Console.ReadKey();
    }
}