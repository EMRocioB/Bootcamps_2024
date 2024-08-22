using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Obligatorio
{
    public abstract class Persona
    {
        public string Apellido { get; set; }

        public string Nombre { get; set; }

        //constructor que acepta parametros
        protected Persona(string apellido, string nombre)
        {
            Apellido = apellido;
            Nombre = nombre;
        }
    }

    public class Profesional : Persona
    {
        public string Matricula { get; set; }

        //constructor que incluye el nombre del profesional
        public Profesional(string apellido, string nombre, string matricula)
            : base(apellido, nombre) //llama al constructor de la clase base
        {
            Matricula = matricula;
        }
    }

    public class Pasante : Persona
    {
        public string Legajo { get; set; }

        //constructor que incluye el nombre del pasante
        public Pasante(string apellido, string nombre, string legajo)
            : base(apellido, nombre)
        {
            Legajo = legajo;
        }
    }

}
