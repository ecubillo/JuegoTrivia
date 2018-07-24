using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTrivia
{
    class PreguntaGeografia
    {
        public PreguntaGeografia()
        {
            PreguntaServicio guarda = new PreguntaServicio();
            guarda.AddPregunta("¿Donde se encuentra la cueva de Rouffignac?", 0);
            guarda.AddPregunta("¿Cuál es la capital de Brasil?", 1);
            guarda.AddPregunta("¿Cuál es el segundo continente más grande del mundo?", 2);
            guarda.AddPregunta("¿Cuántos lagos comprende la región de los grandes lagos de Canadá y Estados Unidos?", 3);
            guarda.AddPregunta("¿Qué pueblo polinésico encuentras en Isla de Pascua?", 4);
            guarda.AddPregunta("¿Cuál es el cuerpo de agua más grande de la tierra?", 5);
            guarda.AddPregunta("¿Cuál es el tamaño aproximado de la línea del ecuador?", 6);
            guarda.AddPregunta("¿En qué país queda el grupo más grande de géiseres del hemisferio sur llamados El Tatio?", 7);
            guarda.AddPregunta("¿Cual se llama el desierto más grane del planeta?", 8);
            guarda.AddPregunta("¿Cuál océano se encuentra en la costa este de los Estados Unidos?", 9);
            guarda.AddPregunta("¿Cuál océano se encuentra en la costa este de los Estados Unidos ? ", 9);
            //https://aweita.larepublica.pe/magazine/4631-30-preguntas-de-geografia-que-todos-deberian-conocer-eres-capaz-de-resolver-este-test
            //Respuestas en este link
        }
    }
}
