namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("<====== Placa do Veículo ======>");
            string placacad = Console.ReadLine();
            veiculos.Add(placacad);
            Console.WriteLine("Usuário cadastrado com sucesso.");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("<====== Placa do Veículo ======>");
            string placa = Console.ReadLine();
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("<====== Quantidade de Horas ======>");
                int horas = Int32.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora*horas; 
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R${valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Método Lógico de Verificação se há algum Registro na Lista.
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
               int i = 0; //Percorrer Lista de Veículos
                while (i < veiculos.Count) 
                {
                    Console.WriteLine($"O veículo {i+1} tem Placa: {veiculos[i]}");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
