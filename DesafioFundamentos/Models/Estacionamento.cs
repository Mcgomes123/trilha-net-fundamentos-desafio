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
            // TODO: Implementado
            Console.Clear();
            Console.WriteLine("----------");
            Console.WriteLine("Entrada de veículo");
            Console.WriteLine("----------\n");            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            var placa = Console.ReadLine();
            if(veiculos.Any(x => x. ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("----------");
                Console.WriteLine("Desculpe! Este veículo já está cadastrado!");
                Console.WriteLine("----------");
            }
            else
            {
                veiculos.Add(placa.Trim());
                Console.WriteLine("Veículo cadastrado com sucesso!\n");
            }
        }

        public void RemoverVeiculo()
        {
            int horas;
            Console.Clear();
            Console.WriteLine("----------");
            Console.WriteLine("Saída de veículos");
            Console.WriteLine("----------\n");     
            Console.WriteLine("Digite a placa do veículo para remover:");           

            // Implementado
            var placa = Console.ReadLine();

            // Verifica se o veículo existe         
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Implemantado
                horas = int.Parse(Console.ReadLine());
                decimal valorTotal = 0; 
                valorTotal = (precoInicial + precoPorHora) * horas;
                veiculos.Remove(placa.Trim());
                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Implementado
            if (veiculos.Any())
            {
                Console.WriteLine("----------");
                Console.WriteLine("Os veículos estacionados são:");
                Console.WriteLine("----------\n");
                    int contadorForeach = 0;
                    foreach (string placa in veiculos)
                    {
                        Console.WriteLine(placa);
                        contadorForeach++;
                    }
                    Console.WriteLine("----------");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
