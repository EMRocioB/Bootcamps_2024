using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Obligatorio
{
    public class Turno
    {
        public Persona PersonaTurno { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }

        //Constructor
        public Turno(Persona personaTurno, DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin)
        {
            PersonaTurno = personaTurno;
            Fecha = fecha;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
        }
    }
}
