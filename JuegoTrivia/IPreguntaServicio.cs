using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTrivia
{
    interface IPreguntaServicio
    {
        void AddPregunta( string TipoPregunta, int PreguntaID);

        List<Pregunta> GetPreguntaUsada();

        void GetUsada(int id);

        string Search(int id);

        void GetCategoria();
    }
}
