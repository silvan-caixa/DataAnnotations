# Exercicio DataAnnotations
## Criar categoria, usuario, post ok
## Criar Usuario ja com categoria e post ok
## Relatorio: list(categoria, usuario, post) Agrupamento(Usuario_Post, Categoria_Post)
## Relarorio: Lista os posts de usuario
## Relarorio: Lista os posts de categoria



## LISTA POSTS COM INCLUDE
```csharp
static void ListarPost()
            {
                using var db = new DataContext();
                var posts = db.Posts
                    .AsNoTracking()
                    .Include(x => x.Usuario)
                    .Include(x => x.Categoria)
                    .Include(x => x.AuthorId)
                    .ToList
                    ();

                System.Console.WriteLine("TITULO        |      SUMARIO      |      DATA CRIACAO     |      DATA ATUALIZACAO     |       USUARIO      |       TÍTULO CATEGORIA");

                foreach (var post in posts)
                {
                    System.Console.WriteLine($"{post.Titulo}    |    {post.Sumario}     |   {post.DataCriacao}  | {post.DataAtualizacao}    |   {post.Usuario.Nome}  |   {post.Categoria.Nome}");
                }
                Console.ReadKey();

            }
    ## Lista Os posts por Categoria 
    ```csharp
     public static void PostsCategoria()
    {
        System.Console.Write("IRFORME O ID DA CATEGORIA: ");
        var op = int.Parse(Console.ReadLine() ?? "");

        var db = new DataContext();
        var postsCategoria = db.Posts
        .AsNoTracking()
        .Where(x => x.CategoriaId == op)
        .Include(x => x.Categoria)
        .ToList();

        foreach (var item in postsCategoria)
        {
            System.Console.WriteLine($"Post: {item.Titulo} | Descricao: {item.Categoria?.Descricao}");

        }
        Console.ReadKey();
    }
    
    ## FIM
