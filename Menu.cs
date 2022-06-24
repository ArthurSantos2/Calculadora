namespace Calculator
{
    public class Menu
    {

        public static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo a calculadora multifunção");
            Console.WriteLine("Decida abaixo qual tipo de calculo quer fazer:");
            Console.WriteLine("");
            Console.WriteLine("Tecle 1 para calculos simples(soma, subtração, divisão e multiplicação)");
            Console.WriteLine("Tecle 2 para calculos aprimorados(percentual, potenciação)");
            Console.WriteLine("Tecle 3 para calculos de diferentes(sen, cos, tang)");
            Console.WriteLine("Tecle 5 para fechar a calculadora");
            
            string resposta = Console.ReadLine();
            
            if(string.IsNullOrEmpty(resposta))
            {   
                Console.Clear();
                Console.WriteLine("Você está sendo redirecionadx ao menu principal por ter enviado uma resposta inválida");
                Console.WriteLine("Escreva como está configurado");
                Thread.Sleep(5000);
                Menu.MenuPrincipal();
            }

            switch(resposta)
            {
                case "1": MenuSimples(); break;
                case "2": MenuAprimorado(); break;
                case "3": MenuDiferente(); break;
                case "5": System.Environment.Exit(0); break;
                default: MenuPrincipal(); break;
            }
           
        }

        public static void MenuSimples()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo aos cálculos simples");
            Console.WriteLine("Decida abaixo qual tipo de calculo quer fazer digitando a opção:");
            Console.WriteLine("Somar: 1");
            Console.WriteLine("Subtrair: 2");
            Console.WriteLine("Multiplicar: 3");
            Console.WriteLine("Dividir: 4");
            Console.WriteLine("Tecle 5 para fechar a calculadora");
            Console.WriteLine("Tecle 6 para voltar ao menu principal");
            
            string resposta = Console.ReadLine();
            
             if(string.IsNullOrEmpty(resposta))
            {   
                Console.Clear();
                Console.WriteLine("Escreva como está configurado");
                Thread.Sleep(5000);
                Menu.MenuSimples();
            }

           
            switch(resposta)
            {
                case "1": MenuCalculos.Somar(); break;
                case "2": MenuCalculos.Subtrair(); break;
                case "3": MenuCalculos.Multiplicar(); break;
                case "4": MenuCalculos.Dividir(); break;
                case "5": System.Environment.Exit(0); break;
                case "6": Menu.MenuPrincipal(); break;
                default: MenuSimples(); break;
            }

        }

        public static void MenuAprimorado()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo aos cálculos aprimorados");
            Console.WriteLine("Decida abaixo qual tipo de calculo quer fazer digitando a opção:");
            Console.WriteLine("Percentual: 1");
            Console.WriteLine("Potência: 2");
            Console.WriteLine("Tecle 5 para fechar a calculadora");
            Console.WriteLine("Tecle 6 para voltar ao menu principal");
            
            string resposta = Console.ReadLine();
            
             if(string.IsNullOrEmpty(resposta))
            {   
                Console.Clear();
                Console.WriteLine("Escreva como está configurado");
                Thread.Sleep(5000);
                Menu.MenuAprimorado();
            }

           
            switch(resposta)
            {
                case "1": MenuCalculos.Percentual(); break;
                case "2": MenuCalculos.Potencia(); break;
                case "5": System.Environment.Exit(0); break;
                case "6": Menu.MenuPrincipal(); break;
                default: MenuAprimorado(); break;
            }
        }

        public static void MenuDiferente()
        {
             Console.Clear();
            Console.WriteLine("Bem vindo aos cálculos diferentes");
            Console.WriteLine("Decida abaixo qual tipo de calculo quer fazer digitando a opção:");
            Console.WriteLine("Seno: 1");
            Console.WriteLine("Cosseno: 2");
            Console.WriteLine("Tangente: 2");
            Console.WriteLine("Tecle 5 para fechar a calculadora");
            Console.WriteLine("Tecle 6 para voltar ao menu principal");
            
            string resposta = Console.ReadLine();
            
             if(string.IsNullOrEmpty(resposta))
            {   
                Console.Clear();
                Console.WriteLine("Escreva como está configurado");
                Thread.Sleep(5000);
                Menu.MenuDiferente();
            }

           
            switch(resposta)
            {
                case "1": MenuCalculos.Seno(); break;
                case "2": MenuCalculos.Cosseno(); break;
                case "3": MenuCalculos.Tangente(); break;
                case "5": System.Environment.Exit(0); break;
                case "6": Menu.MenuPrincipal(); break;
                default: MenuDiferente(); break;
            }
        }





    }   
}