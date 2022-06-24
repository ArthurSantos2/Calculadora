namespace Calculator
{
    public class Operations
    {
        public static double CalcularSoma(string primeiroNumero, string segundoNumero)
        {
            double resultado;
            resultado = Convert.ToDouble(primeiroNumero) + Convert.ToDouble(segundoNumero);
            return resultado;
        }

        public static double CalcularSubtracao(string primeiroNumero, string segundoNumero)
        {
            double resultado;
            resultado = Convert.ToDouble(primeiroNumero) - Convert.ToDouble(segundoNumero);
            return resultado;
        }

        public static double CalcularMultiplicacao(string primeiroNumero, string segundoNumero)
        {
            double resultado;
            resultado = Convert.ToDouble(primeiroNumero) * Convert.ToDouble(segundoNumero);
            return resultado;
        }

        public static double CalcularDivisao(string primeiroNumero, string segundoNumero)
        {
            double resultado;
            resultado = Convert.ToDouble(primeiroNumero) / Convert.ToDouble(segundoNumero);
            return resultado;
        }

        public static double CalcularPercentual(string primeiroNumero, string segundoNumero)
        {
            double resultado;
            resultado = (Convert.ToDouble(primeiroNumero)/100) * (Convert.ToDouble(segundoNumero));
            return resultado;
        }

        public static double CalcularPotencia(string primeiroNumero, string segundoNumero)
        {
            double resultado = 1;
            double Potenciador = Convert.ToDouble(segundoNumero);
            for(int i = 0; i < Potenciador; i++)
            {
                resultado = resultado * Potenciador;
            }
            return resultado;
        }

        public static double CalcularSeno(string angulo)
        {
            double resultado = Math.Sin(Convert.ToDouble(angulo));
            return resultado;
        }

        public static double CalcularCosseno(string angulo)
        {
            double resultado = Math.Cos(Convert.ToDouble(angulo));
            return resultado;
        }

        public static double CalcularTangente(string angulo)
        {
            double resultado = Math.Tan(Convert.ToDouble(angulo));
            return resultado;
        }

    }
}