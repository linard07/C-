using System.Reflection.Metadata;
using System.Xml;

void aula()
{
Console.WriteLine(@"

█▀▀█ █▀▀█ █▀▀█ █▀▀ █▀▀▄ █▀▀▄ █▀▀ █▀▀▄ █▀▀▄ █▀▀█ 　 █▀▀ 
█▄▄█ █░░█ █▄▄▀ █▀▀ █░░█ █░░█ █▀▀ █░░█ █░░█ █░░█ 　 █░░ 
▀░░▀ █▀▀▀ ▀░▀▀ ▀▀▀ ▀░░▀ ▀▀▀░ ▀▀▀ ▀░░▀ ▀▀▀░ ▀▀▀▀ 　 ▀▀▀ ");

}

Dictionary<string, List<int>> BandasRegistradas = new Dictionary<string, List<int>>();
BandasRegistradas.Add("Linkin Park", new List<int>{10, 8, 6});
BandasRegistradas.Add("Green Day", new List<int>());

void boasVindas()
{
    Console.WriteLine("Seja Muito bem vindo ;)");
}

void opcoes()
{
    aula();
    boasVindas();
    Console.WriteLine("\nDigite 1 para registra banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para mostrar a media de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opçao: ");
    string escolha = Console.ReadLine()!;
    int escolhanum = int.Parse(escolha);
   
   switch(escolhanum)
   {
    case 1: ResgitarBanda();
        break;
    case 2: mostrarBandas();
        break;
    case 3: AvaliarBanda();
        break;
    case 4: Console.WriteLine("Voce escolheu a opçao " + escolhanum);
        break;
    case -1: Console.WriteLine("Adeus :)");
        break;
    default: Console.WriteLine("Não é uma opçao valida");
        break;
   }
}
void ResgitarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.WriteLine("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeDaBanda} foi resgitrada com sucesso");
    BandasRegistradas.Add(nomeDaBanda,new List<int>());
    Thread.Sleep(4000);
    Console.Clear();
    opcoes();
}

void mostrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas");
    foreach (string banda in BandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("pressione quaquer coisa para voltar para o menu");
    Console.ReadKey();
    Console.Clear();
    opcoes();
}

void ExibirTituloDaOpcao(string titulo){
    int QuantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(QuantidadeDeLetras,'*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n" );
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avalie uma banda");
    Console.Write("Digite o nome da banda que deseja valiar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (BandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que voce deseja dar a banda {nomeDaBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        BandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        opcoes();

    }  else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("digite uma tecla para voltar ao menu inicial");
        Console.ReadKey();
        Console.Clear();
        opcoes();
    }
}

opcoes();
