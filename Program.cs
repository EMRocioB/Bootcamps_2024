namespace TP3_Obligatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var estacion = new EstacionMeteorologica(5, 7);

            #region Instancias de Pasantes
            //Pasantes
            Pasante pasante1 = new Pasante("Gonzalez", "Ana", "001");
            Pasante pasante2 = new Pasante("Fernandez", "Juan", "002");
            Pasante pasante3 = new Pasante("Lopez", "Maria", "003");
            #endregion

            #region Instancias de Profesionales
            //Profesionales
            Profesional profesional1 = new Profesional("Martinez", "Pedro", "12345");
            Profesional profesional2 = new Profesional("Sanchez", "Lucia", "67890");
            Profesional profesional3 = new Profesional("Perez", "Carlos", "54321");
            #endregion

            #region Instancias de Temperaturas
            //registra temperaturas
            var registro1 = new RegistroTemperatura(25.3, pasante1, DateTime.Now);
            var registro2 = new RegistroTemperatura(27.8, profesional1, DateTime.Now);
            var registro3 = new RegistroTemperatura(12.2, pasante2, DateTime.Now);
            var registro4 = new RegistroTemperatura(1.1, profesional2, DateTime.Now);
            var registro5 = new RegistroTemperatura(35.4, pasante3, DateTime.Now);
            var registro6 = new RegistroTemperatura(4.0, profesional3, DateTime.Now);
            var registro7 = new RegistroTemperatura(10.3, pasante1, DateTime.Now);
            #endregion

            #region Instancias de estacionMeteorologica
            estacion.RegistrarTemperatura(registro1, 0, 0); //Semana 1, Día 1
            estacion.RegistrarTemperatura(registro2, 0, 1); //Semana 1, Día 2
            estacion.RegistrarTemperatura(registro3, 0, 2); //Semana 1, Día 3
            estacion.RegistrarTemperatura(registro4, 0, 3); //Semana 1, Día 4
            estacion.RegistrarTemperatura(registro5, 0, 4); //Semana 1, Día 5
            estacion.RegistrarTemperatura(registro6, 0, 5); //Semana 1, Día 6
            estacion.RegistrarTemperatura(registro7, 0, 6); //Semana 1, Día 7
            #endregion

            #region Imprime las Temperaturas de la 1ra semana
            //Mostra temperaturas de la semana 1
            Console.WriteLine($"Temperaturas de la semana 1:");
            for (int dia = 0; dia < 7; dia++)
            {
                var registro = estacion.VerTempDiaEsp(0, dia); //el registro del día específico
                if (registro != null)
                {
                    Console.WriteLine($"Día {dia + 1}: {registro.Temperatura}°C registrado por {(registro.Persona is Pasante ? "Pasante" : "Profesional")} {registro.Persona.Nombre}");
                }
                else
                {
                    Console.WriteLine($"Día {dia + 1}: No hay registro de temperatura.");
                }
            }
            #endregion

            var tempPromedio = CalculoTemperaturas.CalcularPromedio(estacion.GetRegistros());
            Console.WriteLine($"Temperatura promedio de la semana 1: {tempPromedio.ToString("F2")}");

            var tempMin = CalculoTemperaturas.TempMin(estacion.GetRegistros());
            Console.WriteLine($"Temperatura Minima: {tempMin.ToString()}");

            var tempMax = CalculoTemperaturas.TempMax(estacion.GetRegistros());
            Console.WriteLine($"Temperatura Maxima:  {tempMax.ToString()}");

            #region Asigna el turno de de 8hs intercalados en un dia
            //asigna un turno a un pasante y un profesional
            var turno1 = new Turno(pasante1, DateTime.Now, new TimeSpan(8, 0, 0), new TimeSpan(16, 0, 0));
            var turno2 = new Turno(profesional1, DateTime.Now, new TimeSpan(16, 0, 0), new TimeSpan(24, 0, 0));

            estacion.RegistrarTurno(turno1);
            estacion.RegistrarTurno(turno2);

            //mostrar turnos registrados
            Console.WriteLine("Turnos registrados:");
            foreach (var turno in estacion.MostrarTurnos())
            {
                var fechaTurno = turno.Fecha.ToShortDateString();
                var horaInicio = turno.HoraInicio.ToString();
                var horaFin = (turno.HoraFin.TotalHours >= 24) ? "00:00:00" : turno.HoraFin.ToString();

                Console.WriteLine($"Persona: {(turno.PersonaTurno is Pasante ? "Pasante" : "Profesional")} {turno.PersonaTurno.Nombre}, Fecha: {fechaTurno}, Inicio: {horaInicio}, Fin: {horaFin}");
            }
            #endregion
        }
    }

}
