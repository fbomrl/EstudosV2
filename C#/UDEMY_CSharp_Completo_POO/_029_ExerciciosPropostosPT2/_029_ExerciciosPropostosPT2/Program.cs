using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_ExerciciosPropostosPT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            void Menu()
            {
                Console.WriteLine("EXERCICIOS SOBRE ESTRUTURA CONDICIONAL (IF-ELSE)");
                Console.WriteLine("Selecionar uma das opções abaixo: ");
                Console.WriteLine("001 - Exercicio 1: ");
                Console.WriteLine("002 - Exercicio 2: ");
                Console.WriteLine("003 - Exercicio 3: ");
                Console.WriteLine("004 - Exercicio 4: ");
                Console.WriteLine("005 - Exercicio 5: ");
                Console.WriteLine("006 - Exercicio 6: ");
                Console.WriteLine("007 - Exercicio 7: ");
                Console.WriteLine("008 - Exercicio 8: ");
                Console.WriteLine("000 - Sair ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Exercicio01();
                        break;
                    case 2:

                        Exercicio02();
                        break;
                    case 3:

                        Exercicio03();
                        break;
                    case 4:

                        Exercicio04();
                        break;
                    case 5:

                        Exercicio05();
                        break;
                    case 6:

                        Exercicio06();
                        break;
                    case 7:

                        Exercicio07();
                        break;
                    case 8:

                        Exercicio08();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                }
            }

            void Exercicio01()
            {
                Console.Clear();
                Console.WriteLine("Exercicio 1: ");
                Console.WriteLine("Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não");
                Console.WriteLine();
                Console.WriteLine("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine("NÃO NEGATIVO");
                }
                else
                {
                    Console.WriteLine("NEGATIVO");
                }

                Console.ReadKey();
                Console.Clear();
                Menu();

            }
            void Exercicio02()
            {
                Console.Clear();
                Console.WriteLine("Exercicio 2: ");
                Console.WriteLine("Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar");
                Console.WriteLine();
                Console.WriteLine("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero / 2 == 0)
                {
                    Console.WriteLine("PAR");
                }
                else
                {
                    Console.WriteLine("IMPAR");
                }

                Console.ReadKey();
                Console.Clear();
                Menu();

            }
            void Exercicio03()
            {
                Console.Clear();
                Console.WriteLine("Exercicio 3: ");
                Console.WriteLine("Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem Sao Multiplos ou Nao sao Multiplos, indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.");
                Console.WriteLine();
                Console.WriteLine("Digite 2 valores, na mesma linha separados por espaço ");
                string[] valores = Console.ReadLine().Split(' ');
                int valor1 = int.Parse(valores[0]);
                int valor2 = int.Parse(valores[1]);

                if (valor1 % valor2 == 0)
                {
                    Console.WriteLine("São Multiplos");
                }
                else
                {
                    Console.WriteLine("Não são Multiplos");
                }

                Console.ReadKey();
                Console.Clear();
                Menu();

            }
            void Exercicio04()
            {
                Console.Clear();
                Console.WriteLine("Exercicio 4: ");
                Console.WriteLine("Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas");
                Console.WriteLine();
                Console.WriteLine("Hora Inicial: (1/24)");
                int horaInicial = int.Parse(Console.ReadLine());
                Console.WriteLine("Hora Final: (1/24)");
                int horaFinal = int.Parse(Console.ReadLine());

                int duracaoJogo = 0;

                if (horaInicial > 24 || horaInicial < 0 || horaFinal > 24 || horaFinal < 0)
                {
                    Console.WriteLine("Favor digitar horário correto...");
                    Console.ReadKey();
                    Console.Clear();
                    Exercicio04();
                }
                if (horaInicial > horaFinal)
                {
                    horaInicial = 24 - horaInicial;
                    duracaoJogo = horaFinal + horaInicial;
                    Console.WriteLine($"O JOGO DUROU {duracaoJogo} HORA(S)");
                }
                else if (horaInicial < horaFinal)
                {
                    duracaoJogo = horaFinal - horaInicial;
                    Console.WriteLine($"O JOGO DUROU {duracaoJogo} HORA(S)");
                }
                else if (horaInicial == 0 && horaFinal == 0)
                {
                    duracaoJogo = 24;
                    Console.WriteLine($"O JOGO DUROU {duracaoJogo} HORA(S)");
                }

                Console.ReadKey();
                Console.Clear();
                Menu();

            }
            void Exercicio05()
            {
                Console.Clear();
                Console.WriteLine("Exercicio 5: ");
                Console.WriteLine("Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.");
                Console.WriteLine();

                Console.WriteLine("CODIGO ----- ESPECIFICAÇÃO ----- PREÇO");
                Console.WriteLine("  1    ----    HotDog     ---- R$ 4,00");
                Console.WriteLine("  2    ----    X-Salada   ---- R$ 4,50");
                Console.WriteLine("  3    ----    X-Bacon    ---- R$ 5,00");
                Console.WriteLine("  4    ----    Torrada S. ---- R$ 2,00");
                Console.WriteLine("  5    ----    Refrigerante--- R$ 1,50");
                Console.WriteLine();
                Console.WriteLine("Digite o código do produto desejado: ");
                int cod = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade que deseja: ");
                int qntd = int.Parse(Console.ReadLine());

                double preco = 0;

                if (cod == 1)
                {
                    preco = 4.00;
                }
                else if (cod == 2)
                {
                    preco = 4.50;
                }
                else if (cod == 3)
                {
                    preco = 5.00;
                }
                else if (cod == 4)
                {
                    preco = 2.00;
                }
                else if (cod == 2)
                {
                    preco = 1.50;
                }
                double precoTotal = qntd * preco;
                Console.WriteLine("Total: R$" + precoTotal);

                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            void Exercicio06()
            {
                Console.Clear();
                Console.WriteLine("Exercicio 6: ");
                Console.WriteLine("Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos([0, 25], (25, 50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”");
                Console.WriteLine();
                Console.WriteLine("Digite um valor: ");
                double valor = double.Parse(Console.ReadLine());
                if (valor <= 0 || 25 >= valor)
                {
                    Console.WriteLine("Intervalo [0,25]");
                }
                else if (valor > 25 && valor <= 50)
                {
                    Console.WriteLine("Intervalo [25,50]");
                }
                else if (valor > 50 && valor <= 75)
                {
                    Console.WriteLine("Intervalo [50,75]");
                }
                else if (valor > 75 && valor <= 100)
                {
                    Console.WriteLine("Intervalo [75,100]");
                }
                else
                {
                    Console.WriteLine("Fora do Intervalo");
                }

                Console.ReadKey();
                Console.Clear();
                Menu();

            }
            void Exercicio07()
            {
                Console.Clear();
                Console.WriteLine("Exercicio 7: ");
                Console.WriteLine("Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano.A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0).");
                Console.WriteLine("Se o ponto estiver na origem, escreva a mensagem “Origem”.");
                Console.WriteLine("Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação");
                Console.WriteLine();
                Console.WriteLine("           Y");
                Console.WriteLine("        | ");
                Console.WriteLine("        | ");
                Console.WriteLine("_____Q2_|_Q1_____  X");
                Console.WriteLine("     Q3 | Q4");
                Console.WriteLine("        | ");
                Console.WriteLine("        |");
                Console.WriteLine();
                Console.WriteLine("Valor X: ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Valor Y: ");
                double y = double.Parse(Console.ReadLine());

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Q1");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Q2");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Q3");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Q4");
                }
                else
                {
                    Console.WriteLine("Origem");
                }

                Console.ReadKey();
                Console.Clear();
                Menu();

            }
            void Exercicio08()
            {
                Console.Clear();
                Console.WriteLine("Exercicio 8: ");
                Console.WriteLine("Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem qualquer desvio.A moeda deste país é o Rombus, cujo símbolo é o R$");
                Console.WriteLine("Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo");
                Console.WriteLine();
                Console.WriteLine("RENDA                          IMPOSTO DE RENDA");
                Console.WriteLine("de R$ 0,00 a R$ 2000,00            Isento ");
                Console.WriteLine("de R$ 2000,01 a R$ 3000,00           8% ");
                Console.WriteLine("de R$ 3000,01 a R$ 4500,00          18% ");
                Console.WriteLine("acima de R$ 4500,00                 28% ");
                Console.WriteLine();
                Console.WriteLine("Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda.No exemplo fornecido(abaixo), a taxa é de 8 % sobre R$ 1000.00 + 18 % sobre R$ 2.00, o que resulta em R$ 80.36 no total.O valor deve ser impresso com duas casas decimais");
                Console.WriteLine();
                Console.WriteLine("Digite o salário: R$");
                double valor = double.Parse(Console.ReadLine());
                double valor2;
                double valor3;
                double valorFinal;
                double imposto1;
                double imposto2;
                double imposto3;

                if (valor < 0)
                {
                    Console.WriteLine("Favor informar um valor válido.");
                }
                else if (valor >= 0 && valor <= 2000)
                {
                    Console.WriteLine("Isento.");
                }
                else if (valor >= 2000.01 && valor <= 3000)
                {
                    valor = valor - 2000.00;
                    valorFinal = valor * 8 / 100;

                    Console.WriteLine("R$ " + valorFinal.ToString("F2"));
                }
                else if (valor >= 3000.01 && valor <= 4500)
                {

                    valor = valor - 2000.00;
                    valor2 = valor - 1000.00;

                    imposto1 = valor * 8 / 100;
                    imposto2 = valor2 * 18 / 100;

                    valorFinal = imposto1 + imposto2;

                    Console.WriteLine("R$ " + valorFinal.ToString("F2"));
                }
                else if (valor >= 4500.01)
                {
                    valor = valor - 2000.00;
                    valor2 = valor - 999.99;
                    valor3 = valor - 1499.99;

                    imposto1 = valor * 8 / 100;
                    imposto2 = valor2 * 18 / 100;
                    imposto3 = valor3 * 28 / 100;

                    valorFinal = imposto1 + imposto2;

                    Console.WriteLine("R$ " + valorFinal.ToString("F2"));
                }

                Console.ReadKey();
                Console.Clear();
                Menu();

            }
        }
    }
}