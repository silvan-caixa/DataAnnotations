# Exercicio DataAnnotations
## Criar categoria, usuario, post ok
## Criar Usuario ja com categoria e post ok
## Relatorio: list(categoria, usuario, post) Agrupamento(Usuario_Post, Categoria_Post)
## Relarorio: Lista os posts de usuario


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
    ## FIM
