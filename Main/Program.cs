using JuegoTrivia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var juego = new JuegoServicio();
            juego.EscojePregunta();
            Console.WriteLine("");
            juego.Agrega();


            ////// System.Console.WriteLine("id pregunta");
            ////// int.TryParse(System.Console.ReadLine(), out int id);
            ////// System.Console.WriteLine(juego.Search(id));

            //////System.Console.ReadKey();
        }
    }
}
