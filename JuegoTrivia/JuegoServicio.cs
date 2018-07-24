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

        public JuegoServicio()
        {
            Usuario.Add(new Jugador("Esteban", "Cubillo", "ECM23", 0));
            Usuario.Add(new Jugador("Adrian", "Barboza", "AB123", 0));
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
            PreguntaServicio ejecuta = new PreguntaServicio();
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
                        ejecuta.Search(var1);
                        System.Console.WriteLine(ejecuta.Search(var1));
                        break;
                    case 2:
                        Random random2 = new Random();
                        int var2 = 0;
                        var2 = random2.Next(10, 20);
                        ejecuta.Search(var2);
                        System.Console.WriteLine(ejecuta.Search(var2));
                        break;
                    case 3:
                        Random random3 = new Random();
                        int var3 = 0;
                        var3 = random3.Next(20, 30);
                        ejecuta.Search(var3);
                        System.Console.WriteLine(ejecuta.Search(var3));
                        break;
                    case 4:
                        Random random4 = new Random();
                        int var4 = 0;
                        var4 = random4.Next(30, 40);
                        ejecuta.Search(var4);
                        System.Console.WriteLine(ejecuta.Search(var4));
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

        
    }
}
