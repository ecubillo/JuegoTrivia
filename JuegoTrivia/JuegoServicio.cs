using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTrivia
{
  public  class JuegoServicio : IJuegoServicio
    {


        List<Jugador> Usuario = new List<Jugador>();
        List<Pregunta> Pregunta = new List<Pregunta>();

        public JuegoServicio()
        {
            Usuario.Add(new Jugador("Esteban", "Cubillo", "ECM23", 0));
            Usuario.Add(new Jugador("Adrian", "Barboza", "AB123", 0));

            Pregunta.Add(new Pregunta("¿Donde se encuentra la cueva de Rouffignac?", 0));
            Pregunta.Add(new Pregunta("¿Cuál es la capital de Brasil?", 1));
            Pregunta.Add(new Pregunta("¿Cuál es el segundo continente más grande del mundo?", 2));
            Pregunta.Add(new Pregunta("¿Cuántos lagos comprende la región de los grandes lagos de Canadá y Estados Unidos?", 3));
            Pregunta.Add(new Pregunta("¿Qué pueblo polinésico encuentras en Isla de Pascua?", 4));
            Pregunta.Add(new Pregunta("¿Cuál es el cuerpo de agua más grande de la tierra?", 5));
            Pregunta.Add(new Pregunta("¿Cuál es el tamaño aproximado de la línea del ecuador?", 6));
            Pregunta.Add(new Pregunta("¿En qué país queda el grupo más grande de géiseres del hemisferio sur llamados El Tatio?", 7));
            Pregunta.Add(new Pregunta("¿Cual se llama el desierto más grane del planeta?", 8));
            Pregunta.Add(new Pregunta("¿Cuál océano se encuentra en la costa este de los Estados Unidos?", 9));
            //https://aweita.larepublica.pe/magazine/4631-30-preguntas-de-geografia-que-todos-deberian-conocer-eres-capaz-de-resolver-este-test
            //Respuestas en este link
            Pregunta.Add(new Pregunta("¿En que año descubrió Colón América?", 10));
            Pregunta.Add(new Pregunta("¿Cuándo se produjo principalmente el Siglo de Oro?", 11));
            Pregunta.Add(new Pregunta("¿Quién fue el primer emperador romano?", 12));
            Pregunta.Add(new Pregunta("¿Qué Rey encargó Las Meninas?", 13));
            Pregunta.Add(new Pregunta("¿En que país nació Adolf Hitler?", 14));
            Pregunta.Add(new Pregunta("¿Qué faraón era el marido de Nefertiti?", 15));
            Pregunta.Add(new Pregunta("¿Cómo se llamó durante más de 50 años San Petersburgo?", 16));
            Pregunta.Add(new Pregunta("¿En que isla murió Napoleón?", 17));
            Pregunta.Add(new Pregunta("¿En qué año cayó el Imperio Romano de Occidente?", 18));
            Pregunta.Add(new Pregunta("¿En que guerra participó Juana de Arco?", 19));
            //http://www.antena3.com/liopardo/cuestionarios/20-preguntas-sobre-historia-que-todo-el-mundo-deberia-saber-responder_201611225a94de130cf2052ee3bdcc6b.html
            //Respuestas en este link
            Pregunta.Add(new Pregunta("A", 20));
            Pregunta.Add(new Pregunta("B", 21));
            Pregunta.Add(new Pregunta("C", 22));
            Pregunta.Add(new Pregunta("D", 23));
            Pregunta.Add(new Pregunta("F", 24));
            Pregunta.Add(new Pregunta("G", 25));
            Pregunta.Add(new Pregunta("H", 26));
            Pregunta.Add(new Pregunta("I", 27));
            Pregunta.Add(new Pregunta("J", 28));
            Pregunta.Add(new Pregunta("K", 29));

            Pregunta.Add(new Pregunta("L", 30));
            Pregunta.Add(new Pregunta("M", 39));

        }

        public void Agrega()
        {

            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su nueva contraseña");
            string password = Console.ReadLine();
            Console.WriteLine("Confirme su contraseña");
            string password2 = Console.ReadLine();
            while (!password.Equals(password2))
            {
                Console.WriteLine("Error, las contraseñas no coinciden \n Favor ingresar de nuevo la info");
                password2 = Console.ReadLine();
            }
            Console.WriteLine("Usuario agregado exitosamente");

            Usuario.Add(new Jugador(nombre, apellido, password, 0));
            Console.WriteLine(nombre +""+ apellido);

        }

        public void EscojePregunta()
        {
            for(int cont = 0; cont < 8; cont++)
            {
                Console.WriteLine("          Bienvenido al Juego          ");
                Random random0 = new Random();
                int opcion = random0.Next(1, 5);
                switch (opcion)
                {
                    case 1:
                        Random random1 = new Random();
                        int var1 = 0;
                        var1 = random1.Next(0, 10);
                        Search(var1);
                        System.Console.WriteLine(Search(var1));
                        break;
                    case 2:
                        Random random2 = new Random();
                        int var2 = 0;
                        var2 = random2.Next(10, 20);
                        Search(var2);
                        System.Console.WriteLine(Search(var2));
                        break;
                    case 3:
                        Random random3 = new Random();
                        int var3 = 0;
                        var3 = random3.Next(20, 30);
                        Search(var3);
                        System.Console.WriteLine(Search(var3));
                        break;
                    case 4:
                        Random random4 = new Random();
                        int var4 = 0;
                        var4 = random4.Next(30, 40);
                        Search(var4);
                        System.Console.WriteLine(Search(var4));
                        break;
                }
            }
        }

        public void AddJugador(string nombre, string apellido, string password, int record)
        {
            Usuario.Add(new Jugador(nombre, apellido, password, record));
        }

        public List<Jugador> GetUsuario()
        {
            List<Jugador> result = Usuario;
            
            return result;
        }

        public string Search(int id)
        {
            string s = "";
            foreach(var pregunta in Pregunta)
            {
                if (pregunta.PreguntaID == id)
                {
                    s= s + String.Format("La pregunta es: {0}", pregunta.TipoPregunta);

                }
               
            }
            return s;
        }
    }
}
