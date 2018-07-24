using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTrivia
{
     interface IJuegoServicio
    {
        void AddJugador(string nombre, string apellido, string password, int record);

        List<Jugador> GetUsuario();

        void EscojePregunta();


        void Agrega();


    }
}
