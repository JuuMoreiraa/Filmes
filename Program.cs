
inicio:
Console.WriteLine("Bem vindo(a) ao cadastro de filmes \nEscolha a opção desejada: \n[1] Cadastrar novo filme [2] Sair");
string opcao = Console.ReadLine();

List<string> lista = new List<string>();

string CadastroFilme(string Titulo, string Produtora, string AnoLancamento, string UrlImg)
{
    return $"Nome filme: {Titulo} \nProdutora: {Produtora} \nAno de lançamento: {AnoLancamento} \nUrl Imagem: {UrlImg}";
}

Filme filme = new Filme();


switch (opcao)
{
    case "1":
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Dados do " + (i + 1) + "º filme: ");
            Console.Write("Entre com o nome do filme:  ");
            filme.Titulo = Console.ReadLine();
            Console.Write("Entre com o nome da produtora:  ");
            filme.Produtora = Console.ReadLine();
            Console.Write("Entre com o ano de lançamento:  ");
            filme.AnoLancamento = Console.ReadLine();
            Console.Write("Entre com o url da capa do filme:  ");
            filme.UrlImg = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(CadastroFilme(filme.Titulo, filme.Produtora, filme.AnoLancamento, filme.UrlImg));
            Thread.Sleep(3000);
            Console.WriteLine();
        }
        
        break;
    case "2":
        Console.WriteLine("Obrigado por nos escolher!\nVolte sempre!! ;)");
        break;
    default:
        Console.WriteLine("Opção inválida. Tente novamente. ;)");
        goto inicio;
}