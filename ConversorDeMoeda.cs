
namespace Segundo
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;
        public static double ValorReal(double valorUs, double cotacao)
        {
            double resultado = valorUs * cotacao;
            resultado = resultado + valorUs * Iof / 100;
            return resultado;
        }

    }
}
