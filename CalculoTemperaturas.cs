using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Obligatorio
{
    public static class CalculoTemperaturas
    {
        public static double CalcularPromedio(RegistroTemperatura[,] registros)
        {
            double suma = 0;
            int contador = 0;

            foreach (var registro in registros)
            {
                if (registro != null)
                {
                    suma += registro.Temperatura;
                    contador++;
                }
            }

            return contador > 0 ? suma / contador : double.NaN;
        }

        public static double TempMin(RegistroTemperatura[,] registros)
        {
            double minTemp = double.MaxValue;

            foreach (var registro in registros)
            {
                if (registro != null && registro.Temperatura < minTemp)
                {
                    minTemp = registro.Temperatura;
                }
            }

            return minTemp;
        }

        public static double TempMax(RegistroTemperatura[,] registros)
        {
            double maxTemp = double.MinValue;

            foreach (var registro in registros)
            {
                if (registro != null && registro.Temperatura > maxTemp)
                {
                    maxTemp = registro.Temperatura;
                }
            }

            return maxTemp;
        }

    }

}
