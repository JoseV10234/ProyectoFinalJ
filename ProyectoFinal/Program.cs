using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using ClasesDeObjetos;
using LogicaDeJuego;

namespace ProyectoFinal
{

    internal class Program


    {
        static public void MostrarInstrucciones()
        {
            Console.WriteLine("Instrucciones del juego");
            Console.WriteLine("El juego empieza con 3 puntos de vida. Al empezar, se mostrará una operación matemática.");
            Console.WriteLine("Tendrás una cantidad limitada de tiempo para responder la pregunta. Después de cada 2 aciertos, el tiempo se reducirá.");
            Console.WriteLine("Después de acertar 10 preguntas, la dificultad incrementará y el tiempo máximo se reiniciará.");
            Console.WriteLine("Presiona ENTER para volver al menú principal");
            Console.ReadLine();

        }

        static public void MostrarPortada()
        {
            Console.Clear();
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░████░░███░░███░░░░░░░░░░░░█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░██░█████░███░░█░░░░░░░░░░░██░░░░░░██░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░█░█░░░██░░░█░░░░░░░░████████░░░█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░███░░░███░░██░░░░███░░░█░░░░░░░██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░███░░░███░░██░░████░██░█░░░░░░░██░█████░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░██░░░███░░██░░██░░░░████░░░░░░█████░░██░░░░░░░░░░░░░░░░░░░░░░░░\r\n░██░░░░██░░██░░██░░░████░░░░░░░░███░░░██░░░██░░░░░░░░░░░░░░░░░░░░\r\n░█░░░░██░░░█░░██░░████░██░░░░█████░░░░██████░░░░░░░░░░░░░░░░░░░░░\r\n░█░░░██░░░█████████░░█████████░█░░░░░░░██░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░██░░░░░░░░░░░░░░░░░░░░░█░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░████░░░░░░░░░░░░░░░░░░░█░░░███░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░████░░████░░░░░░░░░░░░░░░░░███░██████░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░███░░█░█░░█░░░░░░░█████░░░░███░░░███░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░██░░░░███░░█░░░░░░██░░░███░██░░░░████░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n██░░░░░██░░░█░░░░██░░░░░████░░░░░░█░░███░░░░░░░░░░░░░░░░░░░░░░░░░\r\n██░░░░█████░█░░█████░░███████░░░░███░░░████░░░░░░░░░░░░░░░░░░░░░░\r\n░█████░░░░██████░░░████░░░████████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n");

        }

        static public void MostrarOpciones()
        {
            Console.WriteLine("1 - Iniciar Juego");
            Console.WriteLine("2 - Instrucciones");
            Console.WriteLine("3 - Creditos");
            Console.WriteLine("4 - Salir");
            Console.Write("Digite su seleccion: ");
        }

        static public void MostrarCreditos()
        {
            Console.WriteLine("Creado por Jose A. Vargas C.");
            Console.ReadLine();
        }

        static public void IniciarJuego()
        {
            int respuestaDelJugador;
            Juego juegoActual = new Juego();
            Console.WriteLine("Usted esta en el nivel {0}", juegoActual.ObtenerDificultadActual());

            int limite = 5;

            for (int b = 0; b < limite; b++)
            {
                Console.WriteLine(juegoActual.ObtenerPregunta());
                Console.WriteLine("0 - " + juegoActual.ObtenerRespuestasPosibles(0));
                Console.WriteLine("1 - " + juegoActual.ObtenerRespuestasPosibles(1));
                Console.WriteLine("2 - " + juegoActual.ObtenerRespuestasPosibles(2));

                respuestaDelJugador = CapturarNumero();

                juegoActual.ResponderPregunta(respuestaDelJugador);

                if (juegoActual.EvaluarRespuesta() == true)
                {
                    Console.WriteLine("Correcto");
                    juegoActual.ProgresarJuego();

                }
                else
                {
                    Console.WriteLine("No has acertado!");
                    // Console.WriteLine("El juego ha terminado"); Aqui creo que hay que cambiar que vidas -1 y si llega a 0 

                    juegoActual.PerderJuego();

                    Console.ReadLine();

                    // romper el ciclo for
                    break;
                }
                Console.ReadLine();
            }

        }

        static public int CapturarNumero()
        {
            try
            {
                string textoEscritoPorElUsuario;
                textoEscritoPorElUsuario = Console.ReadLine();
                return int.Parse(textoEscritoPorElUsuario);
            }

            catch
            {
                Console.WriteLine("Error al escribit el número.");
                Console.WriteLine("Solo se aceptan números.");
                Console.ReadLine();
                return -1;
            }
        }

        static void Main(string[] args)
        {
            int seleccionDelUsuario = 0;

            // ESTA ES LA GAMELOOP
            while (seleccionDelUsuario != 4)
            {
                MostrarPortada();
                MostrarOpciones(); 

                seleccionDelUsuario = CapturarNumero(); 

                if (seleccionDelUsuario == 1)
                {
                    Console.WriteLine("¡El juego va a empezar!");
                    Console.WriteLine("En 3...");
                    Console.WriteLine("2");
                    Console.WriteLine("1");
                    Console.ReadLine();
                    IniciarJuego();
                }

                else if (seleccionDelUsuario == 2)
                {
                    MostrarInstrucciones();
                }

                else if (seleccionDelUsuario == 3)
                {
                    MostrarCreditos();
                }

                else if (seleccionDelUsuario == 4)
                {
                    Console.WriteLine("Has escogido salir. ¡Nos vemos!");
                    Console.ReadLine();
                }

               

               


               


                

                

                
            }
        }
    }
}

