using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Obligatorio
{
    public class EstacionMeteorologica
    {
        private RegistroTemperatura[,] registros;
        private int semanas;
        private int diasXSemana;
        public List<Turno> turnos;//lista para almacenar turnos

        public EstacionMeteorologica(int semanas, int diasXSemana)
        {
            this.semanas = semanas;
            this.diasXSemana = diasXSemana;
            registros = new RegistroTemperatura[semanas, diasXSemana];
            turnos = new List<Turno>();//lista de turnos
        }

        public void RegistrarTemperatura(RegistroTemperatura registro, int semana, int dia)
        {
            RegistrarTemperatura(registro, semana, dia, registros);
        }

        public void RegistrarTemperatura(RegistroTemperatura registro, int semana, int dia, RegistroTemperatura[,] registros)
        {
            if (semana < semanas && dia < diasXSemana)
            {
                registros[semana, dia] = registro;//
            }
        }

        public double[] VerTemperaturas(int semana)
        {
            double[] temperaturas = new double[diasXSemana];

            for (int dia = 0; dia < diasXSemana; dia++)
            {
                if (registros[semana, dia] != null)
                {
                    temperaturas[dia] = registros[semana, dia].Temperatura;
                }
            }

            return temperaturas;
        }


        public RegistroTemperatura VerTempDiaEsp(int semana, int dia)
        {
            return registros[semana, dia];
        }

        //Metodo para obtener los registros
        public RegistroTemperatura[,] GetRegistros()
        {
            return registros;
        }

        public void RegistrarTurno(Turno turno)
        {
            turnos.Add(turno);
        }

        public List<Turno> MostrarTurnos()
        {
            return turnos;
        }

    }

}
