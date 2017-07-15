using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucao_5
{
    class Program
    {
        public static decimal ObtenhaMontante(decimal capitalInicial, decimal taxaJuros, decimal prazo)
        {
            decimal Montante = (decimal)((double)capitalInicial * Math.Pow((double)taxaJuros + 1.0, (double)prazo));
            return Montante;
        }

        public static decimal ObtenhaJuroTotal(decimal montante, decimal capitalInicial)
        {
            return montante - capitalInicial;
        }

        static void Main(string[] args)
        {
            string escolha;
            string entrada;
            decimal capitalInicial;
            decimal taxaJuros;
            decimal prazo;

            decimal Solucao2 = ObtenhaMontante((decimal)10000.0, (decimal)(3.0 / 100.0), (decimal)3.0);

            Console.WriteLine("\nSolucao 5.2");
            Console.Write("Montante de um emprestimo de 10000,00 reais a uma taxa de 3% ao mes, por 3 meses: ");
            Console.Write(Solucao2);
            Console.WriteLine(" R$.");

            decimal Solucao4 = ObtenhaJuroTotal(Solucao2, (decimal)10000.0);

            Console.WriteLine("\nSolucao 5.4");
            Console.Write("O total de juros no caso acima e: ");
            Console.Write(Solucao4);
            Console.WriteLine(" R$.");

            Console.WriteLine("\nAviso: Para valores nao inteiros utilize a virgula (,) e evite usar ponto (.).");

            do
            {
                Console.WriteLine("\nEntre 1 para calcular um montante e total de juros ou sair para finalizar.");
                Console.Write("Entrada: ");
                escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                        {
                            Console.Write("\nInforme o Capital Inicial: ");

                            do
                            {
                                entrada = Console.ReadLine();
                                if (!Decimal.TryParse(entrada, NumberStyles.Float, new CultureInfo("pt-BR"), out capitalInicial))
                                {
                                    Console.Write("\nEntrada invalida. Informe o Capital Inicial novamente: ");
                                }
                            } while (!Decimal.TryParse(entrada, NumberStyles.Float, new CultureInfo("pt-BR"), out capitalInicial));

                            Console.Write("\nInforme a taxa juros (%): ");

                            do
                            {
                                entrada = Console.ReadLine();
                                if (!Decimal.TryParse(entrada, NumberStyles.Float, new CultureInfo("pt-BR"), out taxaJuros))
                                {
                                    Console.Write("\nEntrada invalida. Informe a taxa de juros novamente: ");
                                }
                            } while (!Decimal.TryParse(entrada, NumberStyles.Float, new CultureInfo("pt-BR"), out taxaJuros));
                            taxaJuros = taxaJuros / 100;

                            Console.Write("\nInforme o prazo para pagamento: ");

                            do
                            {
                                entrada = Console.ReadLine();
                                if (!Decimal.TryParse(entrada, NumberStyles.Float, new CultureInfo("pt-BR"), out prazo))
                                {
                                    Console.WriteLine("\nEntrada invalida. Informe o prazo novamente: ");
                                }
                            } while (!Decimal.TryParse(entrada, NumberStyles.Float, new CultureInfo("pt-BR"), out prazo));

                            decimal montante = ObtenhaMontante(capitalInicial, taxaJuros, prazo);
                            Console.Write("\nO montante neste caso e: ");
                            Console.Write(montante);
                            Console.WriteLine(" R$.");

                            decimal juros = ObtenhaJuroTotal(montante, capitalInicial);
                            Console.Write("\nO total de juros e: ");
                            Console.Write(juros);
                            Console.WriteLine(" R$.");
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            } while (escolha != "sair");

        }
    }
}
