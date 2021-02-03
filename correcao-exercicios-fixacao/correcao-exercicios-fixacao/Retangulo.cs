﻿using System;
using System.Globalization;

namespace correcao_exercicios_fixacao
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura + Altura) * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        public override string ToString()
        {
            return "Area: " 
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\nPerimetro: " 
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\nDiagonal: "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
