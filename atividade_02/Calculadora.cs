namespace atividade_02
{
    internal class Calculadora
    {
        public double Somar(double x, double y)
        {
            return x + y;
        }
        public double Subtrair(double x, double y)
        {
            return x - y;
        }
        public double Multiplicar(double x, double y)
        {
            return x * y;
        }
        public double Dividir(double x, double y)
        {
            return x / y;
        }
        public double Potencia(double x, double y)
        {
            double resultado = x;
            if (y == 0)
            {
                resultado = 1;
            }
            else if (y < 0)
            {
                y *= -1;
                for (int i = 0; i < y - 1; i++)
                {
                    resultado *= x;
                }
                resultado = 1/resultado;
            }
            else
            {
                for (int i = 0; i < y - 1; i++)
                {
                    resultado *= x;
                }
            }
            return resultado;
        }
    }
}
