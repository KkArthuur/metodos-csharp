/*
Refatore o arquivo Calc.cs, deixe tudo dentro de função, 

Sugestão:
- Crie uma função Menu(){  } , que quando executada chama a função Opção() { }
na última linha do código chame a função Menu();

*/

/*static void ExecutarCalculadora()
{
    Thread.Sleep(2000);
    double n1;
    double n2;
    double resultado = 0;
    string opcao;
    bool continuar = true;
    while (continuar == true)
    {
        static string Menu()
        {
            Console.Clear();
            Console.WriteLine("=== CALCULADORA ===");
            Console.WriteLine("+ Soma");
            Console.WriteLine("- Subtração");
            Console.WriteLine("* Multiplicação");
            Console.WriteLine("/ Divisão");
            Console.Write("Escolha uma opção: ");
            string operacao = Console.ReadLine()!;
            return operacao;

        }
        opcao = Menu();



        Console.Write("Digite o primeiro número: ");
        n1 = double.Parse(Console.ReadLine()!);

        Console.Write("Digite o segundo número: ");
        n2 = double.Parse(Console.ReadLine()!);

        static void Calcular(string opcao, double n1, double n2, double resultado)
        {
            if (opcao == "+")
            {
                resultado = n1 + n2;
                Console.WriteLine($"Resultado da soma: {resultado}");
            }
            else if (opcao == "-")
            {
                resultado = n1 - n2;
                Console.WriteLine($"Resultado da subtração: {resultado}");
            }
            else if (opcao == "*")
            {
                resultado = n1 * n2;
                Console.WriteLine($"Resultado da multiplicação: {resultado}");
            }
            else if (opcao == "/")
            {
                resultado = n1 / n2;
                Console.WriteLine($"Resultado da divisão: {resultado}");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
        Calcular(opcao, n1, n2, resultado);
        static bool Continuar()
        {
            Console.WriteLine();
            Console.Write("Deseja fazer outro cálculo? (s/n): ");
            string opcao = Console.ReadLine()!;
            if (opcao == "s" || opcao == "S")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        continuar = Continuar();
    }
}
ExecutarCalculadora();
Thread.Sleep(1000);
Console.Clear();
Console.Write("Fim de programa!!");
*/
