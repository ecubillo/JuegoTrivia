using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTrivia
{
   public class PreguntaHistoria
    {
     public PreguntaHistoria()
        {
            PreguntaServicio guarda = new PreguntaServicio();
            guarda.AddPregunta("¿En que año descubrió Colón América?", 10);
            guarda.AddPregunta("¿Cuándo se produjo principalmente el Siglo de Oro?", 11);
            guarda.AddPregunta("¿Quién fue el primer emperador romano?", 12);
            guarda.AddPregunta("¿Qué Rey encargó Las Meninas?", 13);
            guarda.AddPregunta("¿En que país nació Adolf Hitler?", 14);
            guarda.AddPregunta("¿Qué faraón era el marido de Nefertiti?", 15);
            guarda.AddPregunta("¿Cómo se llamó durante más de 50 años San Petersburgo ? ", 16);
            guarda.AddPregunta("¿En que isla murió Napoleón?", 17);
            guarda.AddPregunta( "¿En qué año cayó el Imperio Romano de Occidente?", 18);
            guarda.AddPregunta("¿En que guerra participó Juana de Arco ? ", 19);
            //http://www.antena3.com/liopardo/cuestionarios/20-preguntas-sobre-historia-que-todo-el-mundo-deberia-saber-responder_201611225a94de130cf2052ee3bdcc6b.html
            //Respuestas en este link
        }
    }
}
