using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTrivia
{
    class PreguntaDeporte
    {
        public PreguntaDeporte()
        {
            PreguntaServicio guarda = new PreguntaServicio();
            guarda.AddPregunta("¿Cuántas finales del mundo jugó la Selección Argentina de fútbol?", 30);
            guarda.AddPregunta("¿Cuál es el estilo de natación más rápido?", 31);
            guarda.AddPregunta("¿Cuántos jugadores componen un equipo de rugby?", 32);
            guarda.AddPregunta(" ¿En qué país se inventó el voleibol?", 33);
            guarda.AddPregunta("Qué selección acumula mayor cantidad de expulsados en  mundiales de fútbol?", 34);
            guarda.AddPregunta("¿Cuál es el estadio de fútbol con mayor capacidad en América?", 35);
            guarda.AddPregunta("¿Qué tipo de competición es el Giro de Italia?", 36);
            guarda.AddPregunta("¿Quién ganó el mundial de fútbol del año 2002?", 37);
            guarda.AddPregunta("Quién quedó número 1 del mundo de tenis en 2008?", 38);
            guarda.AddPregunta("Quién es el máximo goleador de la selección argentina de fútbol?", 39);
            //http://www.respuestaspreguntados.es/2014/07/deportes.html
            //Respuestas en este link
        }
    }
}
