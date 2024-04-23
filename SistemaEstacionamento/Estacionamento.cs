using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionamento {
    public class Estacionamento : List<string>{

        public static int Caixa { get; private set; }
        public static int PrecoInicial { get; private set; }
        public static int PrecoHora { get; private set; }

        public void AdicionarVeiculo() {

            Console.WriteLine("Digite a placa do veículo que deseja adicionar: ");
            string? placaVeiculo = Console.ReadLine();

            Add(placaVeiculo);
        }


        public void RemoverVeiculo() {

            Console.Write("Digite a placa do veículo que deseja remover: ");
            string? placaVeiculo = Console.ReadLine();

            Console.Write("Digite a quantidade de horas: ");
            int.TryParse(Console.ReadLine(), out int periodoEstacionado);

            int pagamento;

            if ( periodoEstacionado < 1) {

                pagamento = PrecoInicial;

            } else {

                pagamento = PrecoInicial + (PrecoHora * periodoEstacionado);

            }

            Console.WriteLine($"Valor a ser cobrado: {pagamento}");
            Console.WriteLine("Pressione qualquer tecla para realizar o pagamento");
            Console.ReadLine();

            Caixa += pagamento;

            Console.WriteLine($"Novo Valor em Caixa: {Caixa}");
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadLine();

            Remove(placaVeiculo);

        }

        public void ListarVeiculos() {

            if ( Count == 0 ) {

                Console.WriteLine("Você ainda não adicionou veículos.");
                Console.WriteLine("Pressione uma tecla para voltar ao menu ");
                Console.ReadLine();
                return;

            }

            for (int i = 1; i <= Count; i++) {

                Console.WriteLine($"[ {i} ] - {this[i - 1]}");

            }

            Console.Write("Pressione uma tecla pra continuar");
            Console.ReadLine();

        }

        public void AddPaymentInfo(int precoInicial, int precoHora) {

            PrecoInicial = precoInicial;
            PrecoHora = precoHora;

        }

    }
}
