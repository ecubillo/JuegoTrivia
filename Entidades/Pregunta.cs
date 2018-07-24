using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTrivia
{
   public class Pregunta
    {
        //public string Categoria { get; set; }
        public string TipoPregunta { get; set; }
        public int PreguntaID { get; set; }

        public Pregunta( string tipoPregunta, int preguntaID)
        {
            TipoPregunta = tipoPregunta;
            PreguntaID = preguntaID;
        }

        public override string ToString()
        {
            return TipoPregunta;
        }
    }
}
