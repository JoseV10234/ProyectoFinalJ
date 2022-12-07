using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using ClasesDeObjetos;
using LogicaDeJuego;

namespace ProyectoFinal
{

    internal class Program


    {
        static public void MostrarInstrucciones() // Definimos un public void que guarda lo que debo de hacer al llamar la
                                                  // funcion mostrar instrucciones()
        {
            Console.WriteLine("Instrucciones del juego");
            Console.WriteLine("El juego empieza con 3 puntos de vida. Al empezar, se mostrará una operación matemática.");
            Console.WriteLine("Tendrás una cantidad limitada de tiempo para responder la pregunta. Después de cada 2 aciertos, el tiempo se reducirá.");
            Console.WriteLine("Después de acertar 10 preguntas, la dificultad incrementará y el tiempo máximo se reiniciará.");
            Console.WriteLine("Presiona ENTER para volver al menú principal");
            Console.ReadLine();

        }

        static public void MostrarPortada() // definimos un public void que guarda lo que debo de hacer al llamar la
                                            // funcion mostrarportada()
        {
           Console.Clear();
           Console.WriteLine("      ___           ___           ___           ___                                 \r\n     /\\__\\         /\\  \\         /\\  \\         /\\__\\                                \r\n    /::|  |       /::\\  \\        \\:\\  \\       /:/  /                                \r\n   /:|:|  |      /:/\\:\\  \\        \\:\\  \\     /:/__/                                 \r\n  /:/|:|__|__   /::\\~\\:\\  \\       /::\\  \\   /::\\  \\ ___                             \r\n /:/ |::::\\__\\ /:/\\:\\ \\:\\__\\     /:/\\:\\__\\ /:/\\:\\  /\\__\\                            \r\n \\/__/~~/:/  / \\/__\\:\\/:/  /    /:/  \\/__/ \\/__\\:\\/:/  /                            \r\n       /:/  /       \\::/  /    /:/  /           \\::/  /                             \r\n      /:/  /        /:/  /     \\/__/            /:/  /                              \r\n     /:/  /        /:/  /                      /:/  /                               \r\n     \\/__/         \\/__/                       \\/__/                                \r\n      ___           ___           ___           ___           ___           ___     \r\n     /\\  \\         /\\  \\         /\\  \\         /\\  \\         /\\  \\         /\\__\\    \r\n    /::\\  \\        \\:\\  \\        \\:\\  \\       /::\\  \\       /::\\  \\       /:/  /    \r\n   /:/\\:\\  \\        \\:\\  \\        \\:\\  \\     /:/\\:\\  \\     /:/\\:\\  \\     /:/__/     \r\n  /::\\~\\:\\  \\       /::\\  \\       /::\\  \\   /::\\~\\:\\  \\   /:/  \\:\\  \\   /::\\__\\____ \r\n /:/\\:\\ \\:\\__\\     /:/\\:\\__\\     /:/\\:\\__\\ /:/\\:\\ \\:\\__\\ /:/__/ \\:\\__\\ /:/\\:::::\\__\\\r\n \\/__\\:\\/:/  /    /:/  \\/__/    /:/  \\/__/ \\/__\\:\\/:/  / \\:\\  \\  \\/__/ \\/_|:|~~|~   \r\n      \\::/  /    /:/  /        /:/  /           \\::/  /   \\:\\  \\          |:|  |    \r\n      /:/  /     \\/__/         \\/__/            /:/  /     \\:\\  \\         |:|  |    \r\n     /:/  /                                    /:/  /       \\:\\__\\        |:|  |    \r\n     \\/__/                                     \\/__/         \\/__/         \\|__|    ");
          
        }

        static public void MostrarOpciones() // definimos un public void que guarda lo que debo de hacer al llamar
                                             // la funcion de mostraropciones() para el jugador
        {
            Console.WriteLine("1 - Iniciar Juego");
            Console.WriteLine("2 - Instrucciones");
            Console.WriteLine("3 - Creditos");
            Console.WriteLine("4 - Salir");
            Console.Write("Digite su seleccion: ");
        }

        static public void MostrarCreditos() // enseñamos los créditos al jugador
        {
            Console.WriteLine("Creado por Jose A. Vargas C.");
            Console.WriteLine("Creado para el curso de Programación y Tecnología.");
            Console.WriteLine("Universidad Véritas");
            Console.WriteLine("Arte por: https://patorjk.com/software/taag/ y https://www.asciiart.eu/ ");
            Console.ReadLine();
        }

        static public void MostrarArte()
        {
            Console.WriteLine("           __________\r\n      ____/,    _____)\r\n      \\  //    /   /\r\n      _\\/_     \\  (\r\n     /    \\  ___\\_|_\r\n____/    \\_\\/       \\\r\n      (\\___/\\\\       \\\r\n       |     \\_______/\r\n       |     //      \\\r\n   /   |     \\_______/\r\n___\\   |   _//     \\\r\n    \\__|  //\\______/\r\n       |__\\______/  ____\r\n    _____|____|____|____|\r\n   /          __________ \\\r\n  /          /            \\\r\n  \\_________/_____________/");
        } // dibujo extra


        static public void IniciarJuego() // con esto iniciamos el juego de trivia
        {
            int respuestaDelJugador;
            Juego juegoActual = new Juego();
            Console.WriteLine("     Usted esta en el nivel {0}", juegoActual.ObtenerDificultadActual());

            int limite = 50; // Variable que me dice cuál va a ser el límite de niveles disponibles en el juego. EDITAR

            for (int b = 0; b < limite; b++) // esto nos repite el proceso de juego hasta el número definido por el límite
            {
                Console.WriteLine("Vidas actuales {0}", juegoActual.vidasActuales);
                Console.WriteLine("Puntaje actual {0}", juegoActual.puntajeActual);
                Console.WriteLine(juegoActual.ObtenerPregunta());
                Console.WriteLine("     0. " + juegoActual.ObtenerRespuestasPosibles(0));
                Console.WriteLine("     1. " + juegoActual.ObtenerRespuestasPosibles(1));
                Console.WriteLine("     2. " + juegoActual.ObtenerRespuestasPosibles(2));

                respuestaDelJugador = CapturarNumero();

                juegoActual.ResponderPregunta(respuestaDelJugador);

                if (juegoActual.EvaluarRespuesta() == true)
                {
                    Console.WriteLine("Correcto");
                    juegoActual.AciertaPregunta();
                    juegoActual.ProgresarJuego();
                   
                     // juegoActual.ProgresarJuego(); // CAMBIAR UNA VEZ TENGA NUEVA FUNCION Y PUNTUACION
                    
                    
                  

                    
                   
                }

                

                else
                {
                    Console.WriteLine("No has acertado!");
                    // Console.WriteLine("El juego ha terminado"); Aqui creo que hay que cambiar que vidas -1 y si llega a 0 

                    juegoActual.FallarPregunta();

                    if (juegoActual.vidasActuales == 0)
                    {
                        juegoActual.PerderJuego();
                        Console.WriteLine("GAME OVER");
                        Console.ReadLine();
                        break; // rompemos el ciclo for
                    }

                  

                }
                Console.ReadLine();
            }

        }

        static public int CapturarNumero() // funcion para transformar el texo a números y dar un -1 si sucede un error
        {
            try
            {
                string textoEscritoPorElUsuario;
                textoEscritoPorElUsuario = Console.ReadLine();
                return int.Parse(textoEscritoPorElUsuario);
            }

            catch // devuelve el -1 si el valor no es igual a uno de los disponibles
            {
                Console.WriteLine("Error al escribit el número."); 
                Console.WriteLine("Solo se aceptan números.");
                Console.ReadLine();
                return -1;
            }
        }

        // AQUI EMPIEZA MAIN

        static void Main(string[] args)
        {
            int seleccionDelUsuario = 0;

            // ESTA ES LA GAMELOOP
            while (seleccionDelUsuario != 4)
            {
                MostrarPortada(); // despliega la portada al jugador
                MostrarArte(); // arte extra
                MostrarOpciones(); // muestra la lista de opciones al jugador
                

                seleccionDelUsuario = CapturarNumero(); // se encarga de atrapar la decision del usuario

                if (seleccionDelUsuario == 1) // si la eleccion es 1
                {
                    Console.WriteLine("¡El juego va a empezar!");
                    Console.WriteLine("En 3...");
                    Console.WriteLine("2");
                    Console.WriteLine("1");
                    Console.ReadLine();
                    IniciarJuego();
                }

                else if (seleccionDelUsuario == 2) // si la eleccion es 2, mustro instrucciones
                {
                    MostrarInstrucciones();
                }

                else if (seleccionDelUsuario == 3) // si la eleccion es 3, muestro creditos
                {
                    MostrarCreditos();
                }

                else if (seleccionDelUsuario == 4) // si escribo 4, salgo del juego
                {
                    Console.WriteLine("Has escogido salir. ¡Nos vemos!");
                    Console.ReadLine();
                }

               

               


               


                

                

                
            }
        }
    }
}

