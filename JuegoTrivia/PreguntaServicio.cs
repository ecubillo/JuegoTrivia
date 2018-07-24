
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTrivia
{
    class PreguntaServicio : IPreguntaServicio
    {

       List<Pregunta> usedQuestion = new List<Pregunta>();
        List<Pregunta> Pregunta = new List<Pregunta>();


        public void AddPregunta(string tipoPregunta, int preguntaID)
        {
            Pregunta.Add(new Pregunta( tipoPregunta, preguntaID));
        }

        public string Search(int id)
        {
            string s = "";
            foreach (var pregunta in Pregunta)
            {
                if (pregunta.PreguntaID == id)
                {
                    s = s + String.Format("La pregunta es: {0}", pregunta.TipoPregunta);

                }

            }
            return s;
        }

        public void GetCategoria()
        {
           
        }

        public List<Pregunta> GetPreguntaUsada()
        {
            throw new NotImplementedException();
        }

        public void GetUsada(int id)
        {
            throw new NotImplementedException();
        }
    }
}

