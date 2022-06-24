using System.Globalization;

namespace Calculator
{
    public class MenuCalculos
    {
        public static void EvitarErroSimples(string? valor)
        {
            if(string.IsNullOrEmpty(valor))
            {
                Console.WriteLine("A resposta foi inválida, retornando para o menu simples!");
                Thread.Sleep(3000);
                Menu.MenuSimples();
            }
            double n;
            bool verificador = double.TryParse(valor, out n);

            if(verificador == false)
            {
                Console.WriteLine("A resposta foi inválida, retornando para o menu simples!");
                Thread.Sleep(3000);
                Menu.MenuSimples();
            }
        }

        public static void EvitarErroAprimorado(string? valor)
        {
            if(string.IsNullOrEmpty(valor))
            {
                Console.WriteLine("A resposta foi inválida, retornando para o menu simples!");
                Thread.Sleep(3000);
                Menu.MenuAprimorado();
            }

            double n;
            bool verificador = double.TryParse(valor, out n);

            if(verificador == false)
            {
                Console.WriteLine("A resposta foi inválida, retornando para o menu simples!");
                Thread.Sleep(3000);
                Menu.MenuAprimorado();
            }
        
        }

        public static void EvitarErroDiferente(string? valor)
        {
            if(string.IsNullOrEmpty(valor))
            {
                Console.WriteLine("A resposta foi inválida, retornando para o menu simples!");
                Thread.Sleep(3000);
                Menu.MenuDiferente();
            }

            double n;
            bool verificador = double.TryParse(valor, out n);

            if(verificador == false)
            {
                Console.WriteLine("A resposta foi inválida, retornando para o menu simples!");
                Thread.Sleep(3000);
                Menu.MenuDiferente();
            }
        
        }


        public static void Somar()
        {
            Console.WriteLine("Digite o primeiro número");
            var numero1 = Console.ReadLine();
            EvitarErroSimples(numero1);
            Console.WriteLine("Digite o primeiro número");
            var numero2 = Console.ReadLine();
            EvitarErroSimples(numero2);

            Console.WriteLine($"O valor da soma é: {Operations.CalcularSoma(numero1, numero2)}");

            Console.WriteLine("Retornando ao menu principal...");
            Thread.Sleep(10000);
            Menu.MenuPrincipal();
        }

        public static void Subtrair()
        {
            Console.WriteLine("Digite o número a ser subtraido");
            var numero1 = Console.ReadLine();
            EvitarErroSimples(numero1);
            Console.WriteLine("Digite o que diminuirá");
            var numero2 = Console.ReadLine();
            EvitarErroSimples(numero2);

            Console.WriteLine($"O valor da subtração é: {Operations.CalcularSubtracao(numero1, numero2)}");

            Console.WriteLine("Retornando ao menu principal...");
            Thread.Sleep(10000);
            Menu.MenuPrincipal();
        }

        public static void Multiplicar()
        {
            Console.WriteLine("Digite o número a ser multiplicado");
            var numero1 = Console.ReadLine();
            EvitarErroSimples(numero1);
            Console.WriteLine("Digite o número multiplicador");
            var numero2 = Console.ReadLine();
            EvitarErroSimples(numero2);

            Console.WriteLine($"O valor da multiplicação é: {Operations.CalcularMultiplicacao(numero1, numero2)}");

            Console.WriteLine("Retornando ao menu principal...");
            Thread.Sleep(10000);
            Menu.MenuPrincipal();
        }

        public static void Dividir()
        {
            Console.WriteLine("Digite o número a ser dividido");
            var numero1 = Console.ReadLine();
            EvitarErroSimples(numero1);
            Console.WriteLine("Digite o divisor");
            var numero2 = Console.ReadLine();
            EvitarErroSimples(numero2);

            Console.WriteLine($"O valor da divisão é: {Operations.CalcularDivisao(numero1, numero2)}");

            Console.WriteLine("Retornando ao menu principal...");
            Thread.Sleep(10000);
            Menu.MenuPrincipal();
        }

        public static void Percentual()
        {
            Console.WriteLine("Digite quantos porcento quer(apenas números)");
            var numero1 = Console.ReadLine();
            EvitarErroAprimorado(numero1);
            Console.WriteLine("Digite o número");
            var numero2 = Console.ReadLine();
            EvitarErroAprimorado(numero2);

            Console.WriteLine($"O valor do percentual é: {Operations.CalcularPercentual(numero1, numero2)}");

            Console.WriteLine("Retornando ao menu principal...");
            Thread.Sleep(10000);
            Menu.MenuPrincipal();
        }

        public static void Potencia()
        {
            Console.WriteLine("Digite o número a ser potenciado");
            var numero1 = Console.ReadLine();
            EvitarErroAprimorado(numero1);
            Console.WriteLine("Digite o potenciador");
            var numero2 = Console.ReadLine();
            EvitarErroAprimorado(numero2);

            Console.WriteLine($"A potencia do valor escolhido é: {Operations.CalcularPotencia(numero1, numero2)}");

            Console.WriteLine("Retornando ao menu principal...");
            Thread.Sleep(10000);
            Menu.MenuPrincipal();
        }

         public static void Seno()
        {
            Console.WriteLine("Digite o ângulo");
            var angulo = Console.ReadLine();
            EvitarErroAprimorado(angulo);
           

            Console.WriteLine($"O seno do ângulo escolhido é: {Operations.CalcularSeno(angulo)}");

            Console.WriteLine("Retornando ao menu principal...");
            Thread.Sleep(10000);
            Menu.MenuPrincipal();
        }

         public static void Cosseno()
        {
            Console.WriteLine("Digite o ângulo");
            var angulo = Console.ReadLine();
            EvitarErroAprimorado(angulo);
           

            Console.WriteLine($"O seno do ângulo escolhido é: {Operations.CalcularCosseno(angulo)}");

            Console.WriteLine("Retornando ao menu principal...");
            Thread.Sleep(10000);
            Menu.MenuPrincipal();
        }

        public static void Tangente()
        {
            Console.WriteLine("Digite o ângulo");
            var angulo = Console.ReadLine();
            EvitarErroAprimorado(angulo);
           

            Console.WriteLine($"O seno do ângulo escolhido é: {Operations.CalcularTangente(angulo)}");

            Console.WriteLine("Retornando ao menu principal...");
            Thread.Sleep(10000);
            Menu.MenuPrincipal();
        }

    }
}