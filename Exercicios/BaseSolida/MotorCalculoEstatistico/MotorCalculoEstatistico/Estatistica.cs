using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorCalculoEstatistico
{
    public static class Estatistica
    {
        private static void LancarErroListaInvalida()
        {
            throw new ArgumentException("Lista inválida.");
        }
        public static double CalcularMedia(double a, double b)
        {
            return CalcularMedia(new double[] { a, b });
        }
        public static double CalcularMedia(double a, double b, double c)
        {
            return CalcularMedia(new double[] { a, b, c });
        }
        public static double CalcularMedia(List<double> valores)
        {
            return CalcularMedia(valores.ToArray());
        }

        public static double CalcularMedia(IEnumerable<double> valores)
        {
            var lista = valores.ToList();
            if (valores == null || lista.Count <= 0)
            {
                LancarErroListaInvalida();
            }
            return lista.Average();
        }

        public static double CalcularMedia(double[] valores, bool ignorarNegativos)
        {
            if (ignorarNegativos)
            {
                return CalcularMedia(valores.Where(num => num >= 0).ToArray());
            }
            else 
            {
                return CalcularMedia(valores);
            }
        }
    }
}
