using System.Globalization;

namespace correcao_exercicios_fixacao
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public string Situation()
        {
            if (NotaFinal() >= 60)
            {
                return "APROVADO";
            }
            else
            {
                double Pontos = 60.00 - NotaFinal();
                return "REPROVADO\nFALTARAM " 
                    + Pontos.ToString("F2", CultureInfo.InvariantCulture) 
                    + " PONTOS";
            }
        }

        public override string ToString()
        {
            return "NOTA FINAL = "
                + NotaFinal().ToString("F2", CultureInfo.InvariantCulture)
                + "\n"
                + Situation();
        }
    }
}
