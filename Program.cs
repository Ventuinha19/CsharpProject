﻿// Screen Sound
string MensagemBoasVindas = "Boas vindas ao Screen Sound";
List<String> Bandas = new List<string>();


void ExibirLogo()
{
  Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
  Console.WriteLine(MensagemBoasVindas);
}
void ExibirOpcoesDoMenu()
{
  ExibirLogo();
  Console.WriteLine("\nDigite 1 para registrar uma banda");
  Console.WriteLine("Digite 2 para mostrar todas as bandas");
  Console.WriteLine("Digite 3 para avaliar uma banda");
  Console.WriteLine("Digite 4 para exibir a média de uma banda");
  Console.WriteLine("Digite -1 para sair");

  Console.Write("\nDigite sua opção:");
  string opcaoEscolhida = Console.ReadLine()!;
  int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

  switch (opcaoEscolhidaNumerica)
  {
    case 1:
      registarBanda();
      break;
    case 2:
      mostrarBandasRegistradas();
      break;
    case 3:
      Console.WriteLine("Você Escolheu a opção" + opcaoEscolhidaNumerica);
      break;
    case 4:
      Console.WriteLine("Você Escolheu a opção" + opcaoEscolhidaNumerica);
      break;
    case -1:
      Console.WriteLine("Você Escolheu a opção" + opcaoEscolhidaNumerica);
      break;
    default:
      Console.WriteLine("Opção invalida!");
      break;
  };
  void registarBanda()
  {
    Console.Clear();
    Console.WriteLine("************************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("************************\n");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    String nomeDaBanda = Console.ReadLine()!;
    Bandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(3000);
    Console.Clear();
    ExibirOpcoesDoMenu();

  }
  void mostrarBandasRegistradas()
  {
    Console.Clear();
    Console.WriteLine("************************");
    Console.WriteLine("Exibindo as bandas registradas");
    Console.WriteLine("************************\n");
    /*for (int i = 0; i < Bandas.Count; i++)
    {
      Console.WriteLine($"Bandas: {Bandas[i]}");
    }*/

    foreach (string banda in Bandas)
    {
      Console.WriteLine($"Bandas: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
  };

};

ExibirOpcoesDoMenu();









