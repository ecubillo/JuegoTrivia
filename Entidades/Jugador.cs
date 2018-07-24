using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTrivia
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Password { get; set; }
        public int Record { get; set; }

        public Jugador(string nombre, string apellido, string password, int record)
        {
            Nombre = nombre;
            Apellido = apellido;
            Password = Password;
            Record = record;
        }

        public override string ToString()
        {
            return Nombre + "" + Apellido + "su record es de: " + Record;
        }
    }
}
