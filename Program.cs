Filme filme = new Filme();

<<<<<<< HEAD
Console.Write("Título: ");
filme.titulo = Console.ReadLine();

Console.Write("Gênero: ");
filme.genero = Console.ReadLine();

Console.Write("Ano de lançamento: ");
filme.anoLancamento = Convert.ToInt32(Console.ReadLine());

Console.Write("Classificação indicativa: ");
=======
Console.WriteLine("Título: ");
filme.titulo = Console.ReadLine();

Console.WriteLine("Gênero: ");
filme.genero = Console.ReadLine();

Console.WriteLine("Ano de lançamento: ");
filme.anoLancamento = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Classificação indicativa: ");
>>>>>>> feat/cadastro-filme
filme.classificacaoIndicativa = Convert.ToInt32(Console.ReadLine());

filme.ExibirInformacoes();