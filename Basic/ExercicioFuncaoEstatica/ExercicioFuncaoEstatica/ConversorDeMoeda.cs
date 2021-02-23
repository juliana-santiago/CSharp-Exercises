namespace ExercicioFuncaoEstatica
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double Conversao(double dolar, double quantia)
        {
            return dolar * quantia + (dolar * quantia * Iof / 100.00);
        }
    }
}
