using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTrivia
{
    class PreguntasEntretenimiento
    {
       public PreguntasEntretenimiento()
        {
            PreguntaServicio guarda = new PreguntaServicio();
            guarda.AddPregunta("¿Qué premiada serie de televisión tiene como protagonista a un publicista? ",20);
            guarda.AddPregunta("¿Cómo se llamaba el personaje que interpretaba John Travolta en Grease?",21);
            guarda.AddPregunta(" ¿En qué año se estrenó la película de Disney Pinocho?", 22);
            guarda.AddPregunta(" ¿Quién es la mascota de SEGA?" ,23);
            guarda.AddPregunta("¿Cómo se llama el protagonista de la saga Indiana Jones?", 24);
            guarda.AddPregunta("¿Qué personaje del videojuego Mortal Kombat tiene poderes de hielo?", 25);
            guarda.AddPregunta("¿Cómo se llama el pájaro símbolo de los Juegos del Hambre?|", 26);
            guarda.AddPregunta("¿Qué personaje de Disney perdió su zapato de cristal ?", 27);
            guarda.AddPregunta("¿Cuántos colores tiene un cubo de Rubik clásico?", 28);
            guarda.AddPregunta("¿Cuál es la discográfica destintiva de la música soul ?", 29);
            //http://ganaenpreguntados.blogspot.com/2014/05/entretenimiento.html
            //Respuestas en este link
        }


    }
}
