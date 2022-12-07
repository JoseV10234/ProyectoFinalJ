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
        public int vidasActuales;
        public int puntajeActual;



        // metodo constructor del juego. TERMINAR UNA VEZ TENGA TODAS LAS PREGUNTAS
        public Juego()
        {
            vidasActuales = 3;
            puntajeActual = 0;

            bancoDePreguntas = new Dificultad[5];

            bancoDePreguntas[0] = new Dificultad();
            bancoDePreguntas[1] = new Dificultad();
            bancoDePreguntas[2] = new Dificultad();
            bancoDePreguntas[3] = new Dificultad();
            bancoDePreguntas[4] = new Dificultad();

            bancoDePreguntas[0].preguntas = new Pregunta[21];

            bancoDePreguntas[0].preguntas[0] = new Pregunta();
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[0].preguntas[1] = new Pregunta();
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[0].preguntas[2] = new Pregunta();
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[0].preguntas[3] = new Pregunta();
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[0].preguntas[4] = new Pregunta();
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[0].preguntas[5] = new Pregunta();
            bancoDePreguntas[0].preguntas[5].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[0].preguntas[5].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[5].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[5].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[0].preguntas[6] = new Pregunta();
            bancoDePreguntas[0].preguntas[6].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[0].preguntas[6].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[6].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[6].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[0].preguntas[7] = new Pregunta();
            bancoDePreguntas[0].preguntas[7].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[0].preguntas[7].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[7].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[7].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[0].preguntas[8] = new Pregunta();
            bancoDePreguntas[0].preguntas[8].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[0].preguntas[8].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[8].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[8].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[0].preguntas[9] = new Pregunta();
            bancoDePreguntas[0].preguntas[9].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[0].preguntas[9].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[9].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[9].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[0].preguntas[10] = new Pregunta();
            bancoDePreguntas[0].preguntas[10].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[0].preguntas[10].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[10].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[10].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[0].preguntas[11] = new Pregunta();
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[0].preguntas[12] = new Pregunta();
            bancoDePreguntas[0].preguntas[12].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[0].preguntas[12].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[12].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[12].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[0].preguntas[13] = new Pregunta();
            bancoDePreguntas[0].preguntas[13].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[0].preguntas[13].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[13].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[13].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[0].preguntas[14] = new Pregunta();
            bancoDePreguntas[0].preguntas[14].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[0].preguntas[14].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[14].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[14].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[0].preguntas[15] = new Pregunta();
            bancoDePreguntas[0].preguntas[15].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[0].preguntas[15].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[15].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[15].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[0].preguntas[16] = new Pregunta();
            bancoDePreguntas[0].preguntas[16].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[0].preguntas[16].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[16].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[16].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[0].preguntas[17] = new Pregunta();
            bancoDePreguntas[0].preguntas[17].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[0].preguntas[17].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[17].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[17].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[0].preguntas[18] = new Pregunta();
            bancoDePreguntas[0].preguntas[18].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[0].preguntas[18].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[18].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[18].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[0].preguntas[19] = new Pregunta();
            bancoDePreguntas[0].preguntas[19].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[0].preguntas[19].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[19].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[19].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[0].preguntas[20] = new Pregunta();
            bancoDePreguntas[0].preguntas[20].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[0].preguntas[20].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[20].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[20].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[1].preguntas = new Pregunta[21];

            bancoDePreguntas[1].preguntas[0] = new Pregunta();
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[1].preguntas[1] = new Pregunta();
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[1].preguntas[2] = new Pregunta();
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[1].preguntas[3] = new Pregunta();
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[1].preguntas[4] = new Pregunta();
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[1].preguntas[5] = new Pregunta();
            bancoDePreguntas[1].preguntas[5].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[1].preguntas[5].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[5].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[5].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[1].preguntas[6] = new Pregunta();
            bancoDePreguntas[1].preguntas[6].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[1].preguntas[6].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[6].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[6].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[1].preguntas[7] = new Pregunta();
            bancoDePreguntas[1].preguntas[7].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[1].preguntas[7].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[7].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[7].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[1].preguntas[8] = new Pregunta();
            bancoDePreguntas[1].preguntas[8].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[1].preguntas[8].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[8].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[8].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[1].preguntas[9] = new Pregunta();
            bancoDePreguntas[1].preguntas[9].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[1].preguntas[9].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[9].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[9].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[1].preguntas[10] = new Pregunta();
            bancoDePreguntas[1].preguntas[10].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[1].preguntas[10].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[10].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[10].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[1].preguntas[11] = new Pregunta();
            bancoDePreguntas[1].preguntas[11].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[1].preguntas[11].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[11].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[11].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[1].preguntas[12] = new Pregunta();
            bancoDePreguntas[1].preguntas[12].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[1].preguntas[12].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[12].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[12].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[1].preguntas[13] = new Pregunta();
            bancoDePreguntas[1].preguntas[13].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[1].preguntas[13].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[13].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[13].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[1].preguntas[14] = new Pregunta();
            bancoDePreguntas[1].preguntas[14].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[1].preguntas[14].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[14].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[14].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[1].preguntas[15] = new Pregunta();
            bancoDePreguntas[1].preguntas[15].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[1].preguntas[15].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[15].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[15].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[1].preguntas[16] = new Pregunta();
            bancoDePreguntas[1].preguntas[16].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[1].preguntas[16].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[16].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[16].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[1].preguntas[17] = new Pregunta();
            bancoDePreguntas[1].preguntas[17].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[1].preguntas[17].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[17].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[17].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[1].preguntas[18] = new Pregunta();
            bancoDePreguntas[1].preguntas[18].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[1].preguntas[18].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[18].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[18].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[1].preguntas[19] = new Pregunta();
            bancoDePreguntas[1].preguntas[19].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[1].preguntas[19].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[19].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[19].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[1].preguntas[20] = new Pregunta();
            bancoDePreguntas[1].preguntas[20].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[1].preguntas[20].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[20].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[20].respuestasDeLaPregunta[2] = new Respuesta();

            /*
            bancoDePreguntas[2].preguntas = new Pregunta[21];

            bancoDePreguntas[2].preguntas[0] = new Pregunta();
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[2].preguntas[1] = new Pregunta();
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[2].preguntas[2] = new Pregunta();
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[2].preguntas[3] = new Pregunta();
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[2].preguntas[4] = new Pregunta();
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[2].preguntas[5] = new Pregunta();
            bancoDePreguntas[2].preguntas[5].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[2].preguntas[5].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[5].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[5].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[2].preguntas[6] = new Pregunta();
            bancoDePreguntas[2].preguntas[6].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[2].preguntas[6].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[6].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[6].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[2].preguntas[7] = new Pregunta();
            bancoDePreguntas[2].preguntas[7].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[2].preguntas[7].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[7].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[7].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[2].preguntas[8] = new Pregunta();
            bancoDePreguntas[2].preguntas[8].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[2].preguntas[8].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[8].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[8].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[2].preguntas[9] = new Pregunta();
            bancoDePreguntas[2].preguntas[9].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[2].preguntas[9].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[9].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[9].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[2].preguntas[10] = new Pregunta();
            bancoDePreguntas[2].preguntas[10].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[2].preguntas[10].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[10].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[10].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[2].preguntas[11] = new Pregunta();
            bancoDePreguntas[2].preguntas[11].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[2].preguntas[11].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[11].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[11].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[2].preguntas[12] = new Pregunta();
            bancoDePreguntas[2].preguntas[12].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[2].preguntas[12].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[12].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[12].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[2].preguntas[13] = new Pregunta();
            bancoDePreguntas[2].preguntas[13].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[2].preguntas[13].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[13].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[13].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[2].preguntas[14] = new Pregunta();
            bancoDePreguntas[2].preguntas[14].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[2].preguntas[14].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[14].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[14].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[2].preguntas[15] = new Pregunta();
            bancoDePreguntas[2].preguntas[15].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[2].preguntas[15].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[15].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[15].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[2].preguntas[16] = new Pregunta();
            bancoDePreguntas[2].preguntas[16].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[2].preguntas[16].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[16].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[16].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[2].preguntas[17] = new Pregunta();
            bancoDePreguntas[2].preguntas[17].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[2].preguntas[17].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[17].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[17].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[2].preguntas[18] = new Pregunta();
            bancoDePreguntas[2].preguntas[18].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[2].preguntas[18].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[18].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[18].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[2].preguntas[19] = new Pregunta();
            bancoDePreguntas[2].preguntas[19].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[2].preguntas[19].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[19].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[19].respuestasDeLaPregunta[2] = new Respuesta();

            bancoDePreguntas[2].preguntas[20] = new Pregunta();
            bancoDePreguntas[2].preguntas[20].respuestasDeLaPregunta = new Respuesta[3];
            bancoDePreguntas[2].preguntas[20].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[20].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[20].respuestasDeLaPregunta[2] = new Respuesta(); 
            */



            CargarDatos();

            nivelDeDificultad = 0;
            rng = new Random();
            numeroDePregunta = rng.Next(0, 21); // me dara un numero del 0 al 20 sin incluir el 21.
                                                // CAMBIAR ESTO UNA VEZ TENGA TODAS LAS PREGUNTAS
        }

        public void AciertaPregunta()
        {
            puntajeActual += 1;
            
           
        }

        public void ProgresarJuego()
        {

            if (nivelDeDificultad == 0 && puntajeActual == 10)
            {
                nivelDeDificultad += 1;
                
            }

            if (nivelDeDificultad == 1 && puntajeActual == 20)
            {
                nivelDeDificultad += 1;
            }
           
            numeroDePregunta = rng.Next(0, 21); // CAMBIAR UNA VEZ TENGA TODAS LAS PREGUNTAS
        }

        public void FallarPregunta()
        {
            vidasActuales -= 1;
            numeroDePregunta = rng.Next(0, 21);
        }

        public void PerderJuego()
        {
            nivelDeDificultad = 0;
            numeroDePregunta = rng.Next(0, 21); // CAMBIAR UNA VEZ TENGA TODAS LAS PREGUNTAS
        }

        // Método que me entrega una pregunta del banco de pregunta en la dificultad actual
        

        public string ObtenerPregunta()
        {
            return bancoDePreguntas[nivelDeDificultad].preguntas[numeroDePregunta].enunciadoDeLaPregunta;
        }

        // Método que responde la pregunta actual en la dificultad actual.
        // Este metodo recibe un valor que es guardado en respuestaDelUsuario

        public void ResponderPregunta(int parametro)
        {

            respuestaDelUsuario = parametro;
        }


        // booleano que me evalua la respuesta que el usuario selecciona
        // Si la respuesta del usuario es igual a la respuesta correcta a como esta en el banco de preguntas, avanza
        // de lo contrario, se debe de perder una vida. TENGO QUE CAMBIAR

        public bool EvaluarRespuesta()
        {
            if (respuestaDelUsuario == bancoDePreguntas[nivelDeDificultad].preguntas[numeroDePregunta].respuestaCorrecta)
                return true;
            else
                return false;

        }

        // Método que me da la respuesta de la pregunta actual en la dificultad actual


        public string ObtenerRespuestasPosibles(int indice) // indice es de 0-2
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
            //Es el explorador de datos para buscar a las preguntas 

            // Muy faciles
            bancoDePreguntas[0].nombreDeLaDificultad = "Muy Fácil";
            bancoDePreguntas[0].preguntas[0].enunciadoDeLaPregunta = "        2+7=";
            bancoDePreguntas[0].preguntas[0].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "9";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-9";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "10";

            bancoDePreguntas[0].preguntas[1].enunciadoDeLaPregunta = "        6x3=";
            bancoDePreguntas[0].preguntas[1].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "20";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "16";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "18";

            bancoDePreguntas[0].preguntas[2].enunciadoDeLaPregunta = "        2^3=";
            bancoDePreguntas[0].preguntas[2].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "6";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "8";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "16";

            bancoDePreguntas[0].preguntas[3].enunciadoDeLaPregunta = "        24/3=";
            bancoDePreguntas[0].preguntas[3].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "6";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "8";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "9";

            bancoDePreguntas[0].preguntas[4].enunciadoDeLaPregunta = "        0x2=";
            bancoDePreguntas[0].preguntas[4].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "0";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "1";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "2";

            bancoDePreguntas[0].preguntas[5].enunciadoDeLaPregunta = "        300-10";
            bancoDePreguntas[0].preguntas[5].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[5].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "200";
            bancoDePreguntas[0].preguntas[5].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "390";
            bancoDePreguntas[0].preguntas[5].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "290";

            bancoDePreguntas[0].preguntas[6].enunciadoDeLaPregunta = "        297-316";
            bancoDePreguntas[0].preguntas[6].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[6].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-21";
            bancoDePreguntas[0].preguntas[6].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "21";
            bancoDePreguntas[0].preguntas[6].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-19";

            bancoDePreguntas[0].preguntas[7].enunciadoDeLaPregunta = "        654-94=";
            bancoDePreguntas[0].preguntas[7].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[7].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "560";
            bancoDePreguntas[0].preguntas[7].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "570";
            bancoDePreguntas[0].preguntas[7].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "550";

            bancoDePreguntas[0].preguntas[8].enunciadoDeLaPregunta = "        297+29=";
            bancoDePreguntas[0].preguntas[8].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[8].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "316";
            bancoDePreguntas[0].preguntas[8].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "326";
            bancoDePreguntas[0].preguntas[8].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "324";

            bancoDePreguntas[0].preguntas[9].enunciadoDeLaPregunta = "        954-66=";
            bancoDePreguntas[0].preguntas[9].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[9].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "888";
            bancoDePreguntas[0].preguntas[9].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "898";
            bancoDePreguntas[0].preguntas[9].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "908";

            bancoDePreguntas[0].preguntas[10].enunciadoDeLaPregunta = "        29-719=";
            bancoDePreguntas[0].preguntas[10].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[10].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-690";
            bancoDePreguntas[0].preguntas[10].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "690";
            bancoDePreguntas[0].preguntas[10].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "680";

            bancoDePreguntas[0].preguntas[11].enunciadoDeLaPregunta = "        137-60=";
            bancoDePreguntas[0].preguntas[11].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "87";
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "67";
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "77";

            bancoDePreguntas[0].preguntas[11].enunciadoDeLaPregunta = "        368+72=";
            bancoDePreguntas[0].preguntas[11].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "438";
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "440";
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "442";

            bancoDePreguntas[0].preguntas[11].enunciadoDeLaPregunta = "        368+72=";
            bancoDePreguntas[0].preguntas[11].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "438";
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "440";
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "442";

            bancoDePreguntas[0].preguntas[12].enunciadoDeLaPregunta = "        -11+-11=";
            bancoDePreguntas[0].preguntas[12].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[12].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "22";
            bancoDePreguntas[0].preguntas[12].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-22";
            bancoDePreguntas[0].preguntas[12].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "0";

            bancoDePreguntas[0].preguntas[13].enunciadoDeLaPregunta = "        -11+-11=";
            bancoDePreguntas[0].preguntas[13].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[13].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "22";
            bancoDePreguntas[0].preguntas[13].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-22";
            bancoDePreguntas[0].preguntas[13].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "0";

            bancoDePreguntas[0].preguntas[14].enunciadoDeLaPregunta = "        -17+-9=";
            bancoDePreguntas[0].preguntas[14].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[14].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-8";
            bancoDePreguntas[0].preguntas[14].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "26";
            bancoDePreguntas[0].preguntas[14].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-26";

            bancoDePreguntas[0].preguntas[15].enunciadoDeLaPregunta = "        -45--5=";
            bancoDePreguntas[0].preguntas[15].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[15].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "40";
            bancoDePreguntas[0].preguntas[15].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-40";
            bancoDePreguntas[0].preguntas[15].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-50";

            bancoDePreguntas[0].preguntas[16].enunciadoDeLaPregunta = "        -8--18=";
            bancoDePreguntas[0].preguntas[16].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[16].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "10";
            bancoDePreguntas[0].preguntas[16].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-10";
            bancoDePreguntas[0].preguntas[16].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-26";

            bancoDePreguntas[0].preguntas[17].enunciadoDeLaPregunta = "        1+-3=";
            bancoDePreguntas[0].preguntas[17].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[17].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "2";
            bancoDePreguntas[0].preguntas[17].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-2";
            bancoDePreguntas[0].preguntas[17].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-4";

            bancoDePreguntas[0].preguntas[18].enunciadoDeLaPregunta = "        ¿Cuál de estos es un número primo?";
            bancoDePreguntas[0].preguntas[18].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[18].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "2";
            bancoDePreguntas[0].preguntas[18].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "27";
            bancoDePreguntas[0].preguntas[18].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "667";

            bancoDePreguntas[0].preguntas[19].enunciadoDeLaPregunta = "        -25+2=";
            bancoDePreguntas[0].preguntas[19].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[19].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-23";
            bancoDePreguntas[0].preguntas[19].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-27";
            bancoDePreguntas[0].preguntas[19].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "27";

            bancoDePreguntas[0].preguntas[20].enunciadoDeLaPregunta = "        15--16=";
            bancoDePreguntas[0].preguntas[20].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[20].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-1";
            bancoDePreguntas[0].preguntas[20].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "31";
            bancoDePreguntas[0].preguntas[20].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "1";

            // faciles
            bancoDePreguntas[1].preguntas[0].enunciadoDeLaPregunta = "        816÷16=";
            bancoDePreguntas[1].preguntas[0].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "49";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "50";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "51";

            bancoDePreguntas[1].preguntas[1].enunciadoDeLaPregunta = "        ∛8 = ";
            bancoDePreguntas[1].preguntas[1].respuestaCorrecta = 1;
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-2";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "2";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "2,66";

            bancoDePreguntas[1].preguntas[2].enunciadoDeLaPregunta = "        -5 x -13 = ";
            bancoDePreguntas[1].preguntas[2].respuestaCorrecta = 1;
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "65";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "55";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-55";

            bancoDePreguntas[1].preguntas[3].enunciadoDeLaPregunta = "        -64 ÷ 16 = ";
            bancoDePreguntas[1].preguntas[3].respuestaCorrecta = 0;
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-4";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-6";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-5";

            bancoDePreguntas[1].preguntas[4].enunciadoDeLaPregunta = "        -2 x -17 = ";
            bancoDePreguntas[1].preguntas[4].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-34";
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "37";
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "34";

            bancoDePreguntas[1].preguntas[5].enunciadoDeLaPregunta = "        400 ÷ -20 = ";
            bancoDePreguntas[1].preguntas[5].respuestaCorrecta = 0;
            bancoDePreguntas[1].preguntas[5].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-20";
            bancoDePreguntas[1].preguntas[5].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-15";
            bancoDePreguntas[1].preguntas[5].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-40";

            bancoDePreguntas[1].preguntas[6].enunciadoDeLaPregunta = "294 ÷ 21 = ";
            bancoDePreguntas[1].preguntas[6].respuestaCorrecta = 0;
            bancoDePreguntas[1].preguntas[6].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "14";
            bancoDePreguntas[1].preguntas[6].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "15";
            bancoDePreguntas[1].preguntas[6].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "16";

            bancoDePreguntas[1].preguntas[7].enunciadoDeLaPregunta = "2 x -8 = ";
            bancoDePreguntas[1].preguntas[7].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[7].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "14";
            bancoDePreguntas[1].preguntas[7].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-14";
            bancoDePreguntas[1].preguntas[7].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-16";

            bancoDePreguntas[1].preguntas[8].enunciadoDeLaPregunta = "23 x 7 = ";
            bancoDePreguntas[1].preguntas[8].respuestaCorrecta = 1;
            bancoDePreguntas[1].preguntas[8].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "171";
            bancoDePreguntas[1].preguntas[8].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "161";
            bancoDePreguntas[1].preguntas[8].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "151";

            bancoDePreguntas[1].preguntas[9].enunciadoDeLaPregunta = "91 ÷ 13 = ";
            bancoDePreguntas[1].preguntas[9].respuestaCorrecta = 1;
            bancoDePreguntas[1].preguntas[9].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "6";
            bancoDePreguntas[1].preguntas[9].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "7";
            bancoDePreguntas[1].preguntas[9].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "8";

            bancoDePreguntas[1].preguntas[10].enunciadoDeLaPregunta = "1 x 6 ÷ 3 = ";
            bancoDePreguntas[1].preguntas[10].respuestaCorrecta = 0;
            bancoDePreguntas[1].preguntas[10].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "2";
            bancoDePreguntas[1].preguntas[10].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "3";
            bancoDePreguntas[1].preguntas[10].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "6";

            bancoDePreguntas[1].preguntas[11].enunciadoDeLaPregunta = "10^2 = ";
            bancoDePreguntas[1].preguntas[11].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[11].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "10";
            bancoDePreguntas[1].preguntas[11].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "20";
            bancoDePreguntas[1].preguntas[11].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "100";

            bancoDePreguntas[1].preguntas[12].enunciadoDeLaPregunta = "4^3 = ";
            bancoDePreguntas[1].preguntas[12].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[12].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "12";
            bancoDePreguntas[1].preguntas[12].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "32";
            bancoDePreguntas[1].preguntas[12].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "64";

            bancoDePreguntas[1].preguntas[13].enunciadoDeLaPregunta = "5^3 = ";
            bancoDePreguntas[1].preguntas[13].respuestaCorrecta = 0;
            bancoDePreguntas[1].preguntas[13].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "125";
            bancoDePreguntas[1].preguntas[13].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "15";
            bancoDePreguntas[1].preguntas[13].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "625";

            bancoDePreguntas[1].preguntas[14].enunciadoDeLaPregunta = "7^2 = ";
            bancoDePreguntas[1].preguntas[14].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[14].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "14";
            bancoDePreguntas[1].preguntas[14].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "36";
            bancoDePreguntas[1].preguntas[14].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "49";

            bancoDePreguntas[1].preguntas[15].enunciadoDeLaPregunta = "∛1 = ";
            bancoDePreguntas[1].preguntas[15].respuestaCorrecta = 0;
            bancoDePreguntas[1].preguntas[15].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "1";
            bancoDePreguntas[1].preguntas[15].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-1";
            bancoDePreguntas[1].preguntas[15].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "0";

            bancoDePreguntas[1].preguntas[16].enunciadoDeLaPregunta = "9^2 = ";
            bancoDePreguntas[1].preguntas[16].respuestaCorrecta = 1;
            bancoDePreguntas[1].preguntas[16].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "72";
            bancoDePreguntas[1].preguntas[16].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "81";
            bancoDePreguntas[1].preguntas[16].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "89";

            bancoDePreguntas[1].preguntas[17].enunciadoDeLaPregunta = "-63--6 = ";
            bancoDePreguntas[1].preguntas[17].respuestaCorrecta = 0;
            bancoDePreguntas[1].preguntas[17].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-57";
            bancoDePreguntas[1].preguntas[17].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-69";
            bancoDePreguntas[1].preguntas[17].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "67";

            bancoDePreguntas[1].preguntas[18].enunciadoDeLaPregunta = "-10 x-13 = ";
            bancoDePreguntas[1].preguntas[18].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[18].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "23";
            bancoDePreguntas[1].preguntas[18].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-130";
            bancoDePreguntas[1].preguntas[18].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "130";

            bancoDePreguntas[1].preguntas[19].enunciadoDeLaPregunta = "184 ÷ 8 = ";
            bancoDePreguntas[1].preguntas[19].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[19].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "21";
            bancoDePreguntas[1].preguntas[19].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "22";
            bancoDePreguntas[1].preguntas[19].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "23";

            bancoDePreguntas[1].preguntas[19].enunciadoDeLaPregunta = "1--6 = ";
            bancoDePreguntas[1].preguntas[19].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[19].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-5";
            bancoDePreguntas[1].preguntas[19].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "5";
            bancoDePreguntas[1].preguntas[19].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "7";

            bancoDePreguntas[1].preguntas[20].enunciadoDeLaPregunta = "12--16 = ";
            bancoDePreguntas[1].preguntas[20].respuestaCorrecta = 0;
            bancoDePreguntas[1].preguntas[20].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "28";
            bancoDePreguntas[1].preguntas[20].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "30";
            bancoDePreguntas[1].preguntas[20].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-4";

            /*
            //Medio

            bancoDePreguntas[2].preguntas[0].enunciadoDeLaPregunta = "5 x 6 ÷ 3 = ";
            bancoDePreguntas[2].preguntas[0].respuestaCorrecta = 0;
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "10";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "30";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "5";

            bancoDePreguntas[2].preguntas[1].enunciadoDeLaPregunta = "4^0 = ";
            bancoDePreguntas[2].preguntas[1].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "0";
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "1";
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "4";

            bancoDePreguntas[2].preguntas[2].enunciadoDeLaPregunta = "3 x 6 + 5 = ";
            bancoDePreguntas[2].preguntas[2].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "33";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "23";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "28";

            bancoDePreguntas[2].preguntas[3].enunciadoDeLaPregunta = "2-3x9 = ";
            bancoDePreguntas[2].preguntas[3].respuestaCorrecta = 2;
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "31";
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-9";
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-25";

            bancoDePreguntas[2].preguntas[4].enunciadoDeLaPregunta = "-7 x -9 -9 = ";
            bancoDePreguntas[2].preguntas[4].respuestaCorrecta = 2;
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "0";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-126";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "54";

            bancoDePreguntas[2].preguntas[5].enunciadoDeLaPregunta = "0,1 x -20 = ";
            bancoDePreguntas[2].preguntas[5].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[5].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-1";
            bancoDePreguntas[2].preguntas[5].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-2";
            bancoDePreguntas[2].preguntas[5].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-10";

            bancoDePreguntas[2].preguntas[6].enunciadoDeLaPregunta = "-315 + -7 = ";
            bancoDePreguntas[2].preguntas[6].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[6].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-44";
            bancoDePreguntas[2].preguntas[6].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "45";
            bancoDePreguntas[2].preguntas[6].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "46";

            bancoDePreguntas[2].preguntas[7].enunciadoDeLaPregunta = "-6 x -22 = ";
            bancoDePreguntas[2].preguntas[7].respuestaCorrecta = 2;
            bancoDePreguntas[2].preguntas[7].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "123";
            bancoDePreguntas[2].preguntas[7].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-88";
            bancoDePreguntas[2].preguntas[7].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "132";

            bancoDePreguntas[2].preguntas[8].enunciadoDeLaPregunta = "-405 + 27 = ";
            bancoDePreguntas[2].preguntas[8].respuestaCorrecta = 2;
            bancoDePreguntas[2].preguntas[8].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-14";
            bancoDePreguntas[2].preguntas[8].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-15";
            bancoDePreguntas[2].preguntas[8].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-16";

            bancoDePreguntas[2].preguntas[9].enunciadoDeLaPregunta = "102 x 12 = ";
            bancoDePreguntas[2].preguntas[9].respuestaCorrecta = 2;
            bancoDePreguntas[2].preguntas[9].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "1448";
            bancoDePreguntas[2].preguntas[9].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "1336";
            bancoDePreguntas[2].preguntas[9].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "1224";

            bancoDePreguntas[2].preguntas[10].enunciadoDeLaPregunta = "2(2v-3) = 30. v = ";
            bancoDePreguntas[2].preguntas[10].respuestaCorrecta = 2;
            bancoDePreguntas[2].preguntas[10].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "8";
            bancoDePreguntas[2].preguntas[10].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "8.5";
            bancoDePreguntas[2].preguntas[10].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "9";

            bancoDePreguntas[2].preguntas[11].enunciadoDeLaPregunta = "∛216= ";
            bancoDePreguntas[2].preguntas[11].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[11].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "5.4";
            bancoDePreguntas[2].preguntas[11].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "6";
            bancoDePreguntas[2].preguntas[11].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "7";

            bancoDePreguntas[2].preguntas[12].enunciadoDeLaPregunta = "∛216= ";
            bancoDePreguntas[2].preguntas[12].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[12].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "5.4";
            bancoDePreguntas[2].preguntas[12].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "6";
            bancoDePreguntas[2].preguntas[12].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "7";



            // Dificil

            // Muy dificil + endless

            bancoDePreguntas[4].preguntas[0].enunciadoDeLaPregunta = "12÷(1+3)−9×6=";
            bancoDePreguntas[4].preguntas[0].respuestaCorrecta = 2;
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-36";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "14";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-51";

            bancoDePreguntas[4].preguntas[1].enunciadoDeLaPregunta = "9×8+4−2÷(4−2)=";
            bancoDePreguntas[4].preguntas[1].respuestaCorrecta = 2;
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "53";
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "74";
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "75";

            bancoDePreguntas[4].preguntas[2].enunciadoDeLaPregunta = "9×7−(2+6)÷8=";
            bancoDePreguntas[4].preguntas[2].respuestaCorrecta = 0;
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "62";
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "54";
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "7";

            bancoDePreguntas[4].preguntas[3].enunciadoDeLaPregunta = "(7)^2 - 3 x 3 =";
            bancoDePreguntas[4].preguntas[3].respuestaCorrecta = 0;
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "40";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "48";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "138";

            bancoDePreguntas[4].preguntas[4].enunciadoDeLaPregunta = "(17-6÷2)+4x3 =";
            bancoDePreguntas[4].preguntas[4].respuestaCorrecta = 1;
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "40";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "26";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "138";

            bancoDePreguntas[4].preguntas[5].enunciadoDeLaPregunta = "-2(1x4-2÷2)+(6+2-3) =";
            bancoDePreguntas[4].preguntas[5].respuestaCorrecta = 1;
            bancoDePreguntas[4].preguntas[5].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "1";
            bancoDePreguntas[4].preguntas[5].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-1";
            bancoDePreguntas[4].preguntas[5].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "11";

            bancoDePreguntas[4].preguntas[6].enunciadoDeLaPregunta = "14+18÷2x18-7 =";
            bancoDePreguntas[4].preguntas[6].respuestaCorrecta = 0;
            bancoDePreguntas[4].preguntas[6].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "169";
            bancoDePreguntas[4].preguntas[6].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "281";
            bancoDePreguntas[4].preguntas[6].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "225";

            bancoDePreguntas[4].preguntas[7].enunciadoDeLaPregunta = "12-5x18÷9 =";
            bancoDePreguntas[4].preguntas[7].respuestaCorrecta = 0;
            bancoDePreguntas[4].preguntas[7].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "2";
            bancoDePreguntas[4].preguntas[7].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "10";
            bancoDePreguntas[4].preguntas[7].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "14";

            bancoDePreguntas[4].preguntas[8].enunciadoDeLaPregunta = "18x18÷9+15 =";
            bancoDePreguntas[4].preguntas[8].respuestaCorrecta = 1;
            bancoDePreguntas[4].preguntas[8].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "13.5";
            bancoDePreguntas[4].preguntas[8].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "51";
            bancoDePreguntas[4].preguntas[8].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "66";

            bancoDePreguntas[4].preguntas[9].enunciadoDeLaPregunta = "12+3x5-2 =";
            bancoDePreguntas[4].preguntas[9].respuestaCorrecta = 1;
            bancoDePreguntas[4].preguntas[9].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "12";
            bancoDePreguntas[4].preguntas[9].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "25";
            bancoDePreguntas[4].preguntas[9].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "73"; 
            */
        }

        // Metodo que retorna la dificultad actual
        public int ObtenerDificultadActual()
        {
            return nivelDeDificultad;
        }
    }


}
