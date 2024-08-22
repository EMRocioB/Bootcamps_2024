using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Obligatorio
{
    public class RegistroTemperatura
    {
        public double Temperatura { get; set; }
        public Persona Persona { get; set; }
        public DateTime Fecha { get; set; }

        public RegistroTemperatura(double temperatura, Persona persona, DateTime fecha)
        {
            Temperatura = temperatura;
            Persona = persona;
            Fecha = fecha;
        }
    }

}
