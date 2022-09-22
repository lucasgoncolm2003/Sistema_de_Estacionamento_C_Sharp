using DesafioFundamentos.Models;
// Encoding de UTF8 para Acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;
decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("<====== Sistema de Estacionamento ======>\n" +
                  "<====== Preço Inicial ======>");
precoInicial = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("<====== Preço por Hora ======>");
precoPorHora = Convert.ToDecimal(Console.ReadLine());
// Objeto da classe Estacionamento
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);
string opcao = string.Empty;
bool exibirMenu = true;
// Looping de Exibição de Menu enquanto exibirMenu for Verdadeiro
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 ===> Cadastrar veículo");
    Console.WriteLine("2 ===> Remover veículo");
    Console.WriteLine("3 ===> Listar veículos");
    Console.WriteLine("4 ===> Encerrar");
    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;
            // Quebra Looping do While

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}
Console.WriteLine("O programa se encerrou");
