
using System.Diagnostics;

namespace SistemaEstacionamento {
    public class Sistema()
    {

        public static Estacionamento Placas { get; set; } = new Estacionamento();

        public static void Main(String[] args) {


            Console.WriteLine("Seja bem vindo ao sistema de estacionamento");
            Console.Write("Digite o Preço Inicial: ");
            int.TryParse(Console.ReadLine(), out int precoInicial);

            while (precoInicial == 0) {

                Console.Write("Não é possível inicializar o sistema com Valor Inicial 0. Por favor digite novamente: ");
                int.TryParse(Console.ReadLine(), out precoInicial);
            }

            Console.Write("Agora digite o preço por hora: ");
            int.TryParse(Console.ReadLine(), out int precoHora);

            while (precoHora == 0) {
                
                Console.Write("Não é possível inicializar o sistema com Preço por Hora 0. Por favor digite novamente: ");
                int.TryParse(Console.ReadLine(), out precoHora);

            }

            Placas.AddPaymentInfo(precoInicial, precoHora);

            Menu();
            
        }

        public static void Menu() {

            Console.Clear();

            Console.WriteLine("Selecione a Opção desejada:");
            Console.WriteLine("1 - Adicionar Veículo");
            Console.WriteLine("2 - Remover Veículo");
            Console.WriteLine("3 - Listar Veículos");
            Console.WriteLine("4 - Encerrar Sistema");

            Enum.TryParse<AcaoEnum>(Console.ReadLine(), out AcaoEnum opcao);

            switch (opcao) {

                case AcaoEnum.Adicionar:
                    Placas.AdicionarVeiculo();
                    break;

                case AcaoEnum.Remover:
                    Placas.RemoverVeiculo();
                    break;

                case AcaoEnum.Listar:
                    Placas.ListarVeiculos();
                    break;

                case AcaoEnum.Finalizar:
                    Environment.Exit(0);
                    break;

                default:
                    OperacaoInvalida();
                    break;

            }

            Menu();

        }

        public static void OperacaoInvalida() {

            Console.WriteLine("Não foi possível processar essa solicitição");
            Console.Write("Pressione q=");
            Console.ReadLine();

        }


    }
}