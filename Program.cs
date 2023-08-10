//Crie uma classe Calculadora com dois atributos, valor1 e valor2.
//Crie 4 métodos de operação básica matemática desses dois valores.
//Crie uma classe de teste com um menu para a pessoa selecionar qual operação deseja realizar.
//Mostre o resultado na tela e pergunte se deseja realizar novo calculo.
//Utilize o máximo do conteúdo aprendido até aqui.

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool calculate = true;
            while (calculate)
            {
                int option = SelectOption();
                Calculadora calc = DefineValues(option);
                int result = DoTheMath(calc, option);
                Console.WriteLine(result);

                Console.WriteLine("Deseja realizar outra operação?");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("2 - Não");
                bool continueOperationParse = int.TryParse(Console.ReadLine(), out int continueOperation);

                if (continueOperation == 2) {
                    calculate = false;
                }
                }

            static int SelectOption()
            {
                Console.WriteLine("Qual operação deseja realizar?");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Divisão");
                Console.WriteLine("4 - Multiplicação");

                bool optionParse = int.TryParse(Console.ReadLine(), out int option);

                if (optionParse)
                {
                    return option;
                }
                else
                {
                    return -1;
                }
            }

            static Calculadora DefineValues(int option)
            {
                Console.WriteLine("Digite o primeiro valor");
                bool firstValueParse = int.TryParse(Console.ReadLine(),out int firstValue);
                Console.WriteLine("Digite o segundo valor");
                bool secondValueParse = int.TryParse(Console.ReadLine(), out int secondValue);

                Calculadora calculadora = new(firstValue, secondValue);
                return calculadora;
            }

            static int DoTheMath(Calculadora calculadora, int option)
            {
                int aftermath = 0;
                switch (option)
                {
                    case 1:
                        aftermath = calculadora.sum();
                        break;
                    case 2:
                        aftermath = calculadora.sub();
                        break;
                    case 3:
                        aftermath = calculadora.divide();
                        break;
                    case 4:
                        aftermath = calculadora.multiply();
                        break;
                    default:
                        Console.WriteLine("Número inválido");
                        break;
                }

                return aftermath;
            }
        }
    }
}