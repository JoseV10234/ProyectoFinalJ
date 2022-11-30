using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesDeObjetos;


namespace LogicaDeJuego
{
    public class Juego
    {
        // propiedades o variables
        private Dificultad[] bancoDePreguntas;
        private int nivelDeDificultad;
        private int numeroDePregunta;
        private Random rng;
        private int respuestaDelUsuario;

        // metodo constructor
        public Juego()
        {
            bancoDePreguntas = new Dificultad[5];

            bancoDePreguntas[0] = new Dificultad();
            bancoDePreguntas[1] = new Dificultad();
            bancoDePreguntas[2] = new Dificultad();
            bancoDePreguntas[3] = new Dificultad();
            bancoDePreguntas[4] = new Dificultad();

            bancoDePreguntas[0].preguntas = new Pregunta[5];

            bancoDePreguntas[0].preguntas[0] = new Pregunta();
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[1] = new Pregunta();
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[2] = new Pregunta();
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[3] = new Pregunta();
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[4] = new Pregunta();
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[0] = new Pregunta();
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[1] = new Pregunta();
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[2] = new Pregunta();
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[3] = new Pregunta();
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[4] = new Pregunta();
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[0] = new Pregunta();
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[1] = new Pregunta();
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[2] = new Pregunta();
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[3] = new Pregunta();
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[4] = new Pregunta();
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[0] = new Pregunta();
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[1] = new Pregunta();
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[2] = new Pregunta();
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[3] = new Pregunta();
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[4] = new Pregunta();
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[3] = new Respuesta();


            bancoDePreguntas[4].preguntas[0] = new Pregunta();
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[4].preguntas[1] = new Pregunta();
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[4].preguntas[2] = new Pregunta();
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[4].preguntas[3] = new Pregunta();
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[4].preguntas[4] = new Pregunta();
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[3] = new Respuesta();

            CargarDatos();

            nivelDeDificultad = 0;
            rng = new Random();
            numeroDePregunta = rng.Next(0, 21); // CAMBIAR ESTO UNA VEZ TENGA TODAS LAS PREGUNTAS
        }
        public void ProgresarJuego()
        {
            nivelDeDificultad += 1;
            numeroDePregunta = rng.Next(0, 5); // CAMBIAR UNA VEZ TENGA TODAS LAS PREGUNTAS
        }

        public void PerderJuego()
        {
            nivelDeDificultad = 0;
            numeroDePregunta = rng.Next(0, 5); // CAMBIAR UNA VEZ TENGA TODAS LAS PREGUNTAS
        }

        // Método que me entrega una pregunta del banco de pregunta en la dificultada
        // actual
        public string ObtenerPregunta()
        {
            return bancoDePreguntas[nivelDeDificultad].preguntas[numeroDePregunta].enunciadoDeLaPregunta;
        }

        // Método que responde la pregunta actual en la dificultad actual.
        // Recibe un un valor que guarda en respuestaDelUsuario

        public void ResponderPregunta(int parametro)
        {

            respuestaDelUsuario = parametro;
        }


        // Método que me indica si el jugador acerto o falla la pregunta 
        // Si acertó, el método devuelve el valor TRUE
        // Caso contrario, devuelve false.
        public bool EvaluarRespuesta()
        {
            if (respuestaDelUsuario == bancoDePreguntas[nivelDeDificultad].preguntas[numeroDePregunta].respuestaCorrecta)
                return true;
            else
                return false;

        }

        // Método que me da la respuesta de la pregunta actual en la dificultad actual
        //public Respuesta[] ObtenerRespuestasPosibles()
        //{
        //    Respuesta[] respuestasPosiblesTemporal = bancoDePreguntas[nivelDeDificultad].preguntas[numeroDePregunta].respuestasDeLaPregunta;
        //    return respuestasPosiblesTemporal;
        //}

        public string ObtenerRespuestasPosibles(int indice) // indice es de 0-3
        {
            return
                bancoDePreguntas[nivelDeDificultad].
                    preguntas[numeroDePregunta].
                        respuestasDeLaPregunta[indice].
                            EnunciadoDeLaRespuesta;
        }

        public int DarRespuestaCorrecta(int indice)
        {
            return bancoDePreguntas[nivelDeDificultad].preguntas[numeroDePregunta].respuestaCorrecta;
        }

        public void CargarDatos()
        {
            //Esta funcion funciona como FileExplorer de Windows. 
            //Por ejemplo: bancoDePreguntas 0/Pregunta 0/enunciadoDeLaPregunta/ 'Pregunta'.

            // Muy faciles
            bancoDePreguntas[0].nombreDeLaDificultad = "Muy Fácil";
            bancoDePreguntas[0].preguntas[0].enunciadoDeLaPregunta = "2+7=";
            bancoDePreguntas[0].preguntas[0].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "9";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-9";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "10";

            bancoDePreguntas[0].preguntas[1].enunciadoDeLaPregunta = "6x3=";
            bancoDePreguntas[0].preguntas[1].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "20";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "16";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "18";

            bancoDePreguntas[0].preguntas[2].enunciadoDeLaPregunta = "2^3=";
            bancoDePreguntas[0].preguntas[2].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "6";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "8";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "16";

            bancoDePreguntas[0].preguntas[3].enunciadoDeLaPregunta = "24/3=";
            bancoDePreguntas[0].preguntas[3].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "6";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "8";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "9";

            bancoDePreguntas[0].preguntas[4].enunciadoDeLaPregunta = "0x2=";
            bancoDePreguntas[0].preguntas[4].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "0";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "1";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "2";

            bancoDePreguntas[0].preguntas[5].enunciadoDeLaPregunta = "300-10";
            bancoDePreguntas[0].preguntas[5].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[5].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "200";
            bancoDePreguntas[0].preguntas[5].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "390";
            bancoDePreguntas[0].preguntas[5].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "290";

            bancoDePreguntas[0].preguntas[6].enunciadoDeLaPregunta = "297-316";
            bancoDePreguntas[0].preguntas[6].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[6].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-21";
            bancoDePreguntas[0].preguntas[6].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "21";
            bancoDePreguntas[0].preguntas[6].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-19";

            bancoDePreguntas[0].preguntas[7].enunciadoDeLaPregunta = "654-94=";
            bancoDePreguntas[0].preguntas[7].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[7].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "560";
            bancoDePreguntas[0].preguntas[7].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "570";
            bancoDePreguntas[0].preguntas[7].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "550";

            bancoDePreguntas[0].preguntas[8].enunciadoDeLaPregunta = "297+29=";
            bancoDePreguntas[0].preguntas[8].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[8].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "316";
            bancoDePreguntas[0].preguntas[8].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "326";
            bancoDePreguntas[0].preguntas[8].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "324";

            bancoDePreguntas[0].preguntas[9].enunciadoDeLaPregunta = "954-66=";
            bancoDePreguntas[0].preguntas[9].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[9].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "888";
            bancoDePreguntas[0].preguntas[9].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "898";
            bancoDePreguntas[0].preguntas[9].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "908";

            bancoDePreguntas[0].preguntas[10].enunciadoDeLaPregunta = "29-719=";
            bancoDePreguntas[0].preguntas[10].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[10].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-690";
            bancoDePreguntas[0].preguntas[10].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "690";
            bancoDePreguntas[0].preguntas[10].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "680";

            bancoDePreguntas[0].preguntas[11].enunciadoDeLaPregunta = "137-60=";
            bancoDePreguntas[0].preguntas[11].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "87";
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "67";
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "77";

            bancoDePreguntas[0].preguntas[11].enunciadoDeLaPregunta = "368+72=";
            bancoDePreguntas[0].preguntas[11].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "438";
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "440";
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "442";

            bancoDePreguntas[0].preguntas[11].enunciadoDeLaPregunta = "368+72=";
            bancoDePreguntas[0].preguntas[11].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "438";
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "440";
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "442";

            bancoDePreguntas[0].preguntas[12].enunciadoDeLaPregunta = "-11+-11=";
            bancoDePreguntas[0].preguntas[12].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[12].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "22";
            bancoDePreguntas[0].preguntas[12].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-22";
            bancoDePreguntas[0].preguntas[12].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "0";

            bancoDePreguntas[0].preguntas[13].enunciadoDeLaPregunta = "-11+-11=";
            bancoDePreguntas[0].preguntas[13].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[13].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "22";
            bancoDePreguntas[0].preguntas[13].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-22";
            bancoDePreguntas[0].preguntas[13].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "0";

            bancoDePreguntas[0].preguntas[14].enunciadoDeLaPregunta = "-17+-9=";
            bancoDePreguntas[0].preguntas[14].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[14].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-8";
            bancoDePreguntas[0].preguntas[14].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "26";
            bancoDePreguntas[0].preguntas[14].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-26";

            bancoDePreguntas[0].preguntas[15].enunciadoDeLaPregunta = "-17+-9=";
            bancoDePreguntas[0].preguntas[15].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[15].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-8";
            bancoDePreguntas[0].preguntas[15].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "26";
            bancoDePreguntas[0].preguntas[15].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-26";

            bancoDePreguntas[0].preguntas[16].enunciadoDeLaPregunta = "-8--18=";
            bancoDePreguntas[0].preguntas[16].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[16].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "10";
            bancoDePreguntas[0].preguntas[16].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-10";
            bancoDePreguntas[0].preguntas[16].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-26";

            bancoDePreguntas[0].preguntas[17].enunciadoDeLaPregunta = "1+-3=";
            bancoDePreguntas[0].preguntas[17].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[17].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "2";
            bancoDePreguntas[0].preguntas[17].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-4";
            bancoDePreguntas[0].preguntas[17].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "4";

            bancoDePreguntas[0].preguntas[18].enunciadoDeLaPregunta = "¿Cuál de estos es un número primo?";
            bancoDePreguntas[0].preguntas[18].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[18].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "2";
            bancoDePreguntas[0].preguntas[18].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "27";
            bancoDePreguntas[0].preguntas[18].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "667";

            bancoDePreguntas[0].preguntas[19].enunciadoDeLaPregunta = "-25+2=";
            bancoDePreguntas[0].preguntas[19].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[19].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-23";
            bancoDePreguntas[0].preguntas[19].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-27";
            bancoDePreguntas[0].preguntas[19].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "27";

            bancoDePreguntas[0].preguntas[20].enunciadoDeLaPregunta = "15--16=";
            bancoDePreguntas[0].preguntas[20].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[20].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-1";
            bancoDePreguntas[0].preguntas[20].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "31";
            bancoDePreguntas[0].preguntas[20].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "1";
        }

        public int ObtenerDificultadActual()
        {
            return nivelDeDificultad;
        }
    }


}
