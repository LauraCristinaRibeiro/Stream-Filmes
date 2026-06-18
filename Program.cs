Filme filme = new Filme();

Console.WriteLine("Título: ");
filme.titulo = Console.ReadLine();

Console.WriteLine("Gênero: ");
filme.genero = Console.ReadLine();

Console.WriteLine("Ano de lançamento: ");
filme.anoLancamento = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Classificação indicativa: ");
filme.classificacaoIndicativa = Convert.ToInt32(Console.ReadLine());

filme.ExibirInformacoes();