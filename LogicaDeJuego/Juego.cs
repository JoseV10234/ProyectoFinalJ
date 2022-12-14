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



        // metodo constructor del juego. 
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

            bancoDePreguntas[0].preguntas[5] = new Pregunta();
            bancoDePreguntas[0].preguntas[5].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[5].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[5].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[5].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[5].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[6] = new Pregunta();
            bancoDePreguntas[0].preguntas[6].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[6].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[6].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[6].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[6].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[7] = new Pregunta();
            bancoDePreguntas[0].preguntas[7].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[7].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[7].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[7].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[7].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[8] = new Pregunta();
            bancoDePreguntas[0].preguntas[8].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[8].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[8].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[8].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[8].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[9] = new Pregunta();
            bancoDePreguntas[0].preguntas[9].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[9].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[9].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[9].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[9].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[10] = new Pregunta();
            bancoDePreguntas[0].preguntas[10].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[10].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[10].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[10].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[10].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[11] = new Pregunta();
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[12] = new Pregunta();
            bancoDePreguntas[0].preguntas[12].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[12].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[12].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[12].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[12].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[13] = new Pregunta();
            bancoDePreguntas[0].preguntas[13].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[13].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[13].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[13].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[13].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[14] = new Pregunta();
            bancoDePreguntas[0].preguntas[14].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[14].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[14].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[14].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[14].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[15] = new Pregunta();
            bancoDePreguntas[0].preguntas[15].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[15].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[15].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[15].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[15].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[16] = new Pregunta();
            bancoDePreguntas[0].preguntas[16].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[16].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[16].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[16].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[16].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[17] = new Pregunta();
            bancoDePreguntas[0].preguntas[17].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[17].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[17].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[17].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[17].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[18] = new Pregunta();
            bancoDePreguntas[0].preguntas[18].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[18].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[18].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[18].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[18].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[19] = new Pregunta();
            bancoDePreguntas[0].preguntas[19].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[19].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[19].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[19].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[19].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[20] = new Pregunta();
            bancoDePreguntas[0].preguntas[20].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[20].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[20].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[20].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[20].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas = new Pregunta[21];

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

            bancoDePreguntas[1].preguntas[5] = new Pregunta();
            bancoDePreguntas[1].preguntas[5].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[5].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[5].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[5].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[5].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[6] = new Pregunta();
            bancoDePreguntas[1].preguntas[6].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[6].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[6].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[6].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[6].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[7] = new Pregunta();
            bancoDePreguntas[1].preguntas[7].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[7].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[7].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[7].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[7].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[8] = new Pregunta();
            bancoDePreguntas[1].preguntas[8].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[8].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[8].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[8].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[8].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[9] = new Pregunta();
            bancoDePreguntas[1].preguntas[9].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[9].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[9].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[9].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[9].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[10] = new Pregunta();
            bancoDePreguntas[1].preguntas[10].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[10].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[10].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[10].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[10].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[11] = new Pregunta();
            bancoDePreguntas[1].preguntas[11].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[11].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[11].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[11].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[11].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[12] = new Pregunta();
            bancoDePreguntas[1].preguntas[12].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[12].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[12].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[12].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[12].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[13] = new Pregunta();
            bancoDePreguntas[1].preguntas[13].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[13].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[13].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[13].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[13].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[14] = new Pregunta();
            bancoDePreguntas[1].preguntas[14].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[14].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[14].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[14].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[14].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[15] = new Pregunta();
            bancoDePreguntas[1].preguntas[15].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[15].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[15].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[15].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[15].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[16] = new Pregunta();
            bancoDePreguntas[1].preguntas[16].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[16].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[16].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[16].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[16].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[17] = new Pregunta();
            bancoDePreguntas[1].preguntas[17].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[17].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[17].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[17].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[17].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[18] = new Pregunta();
            bancoDePreguntas[1].preguntas[18].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[18].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[18].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[18].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[18].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[19] = new Pregunta();
            bancoDePreguntas[1].preguntas[19].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[19].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[19].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[19].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[19].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[20] = new Pregunta();
            bancoDePreguntas[1].preguntas[20].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[20].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[20].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[20].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[20].respuestasDeLaPregunta[3] = new Respuesta();


            bancoDePreguntas[2].preguntas = new Pregunta[21];

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

            bancoDePreguntas[2].preguntas[5] = new Pregunta();
            bancoDePreguntas[2].preguntas[5].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[5].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[5].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[5].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[5].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[6] = new Pregunta();
            bancoDePreguntas[2].preguntas[6].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[6].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[6].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[6].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[6].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[7] = new Pregunta();
            bancoDePreguntas[2].preguntas[7].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[7].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[7].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[7].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[7].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[8] = new Pregunta();
            bancoDePreguntas[2].preguntas[8].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[8].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[8].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[8].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[8].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[9] = new Pregunta();
            bancoDePreguntas[2].preguntas[9].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[9].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[9].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[9].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[9].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[10] = new Pregunta();
            bancoDePreguntas[2].preguntas[10].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[10].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[10].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[10].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[10].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[11] = new Pregunta();
            bancoDePreguntas[2].preguntas[11].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[11].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[11].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[11].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[11].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[12] = new Pregunta();
            bancoDePreguntas[2].preguntas[12].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[12].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[12].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[12].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[12].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[13] = new Pregunta();
            bancoDePreguntas[2].preguntas[13].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[13].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[13].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[13].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[13].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[14] = new Pregunta();
            bancoDePreguntas[2].preguntas[14].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[14].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[14].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[14].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[14].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[15] = new Pregunta();
            bancoDePreguntas[2].preguntas[15].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[15].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[15].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[15].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[15].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[16] = new Pregunta();
            bancoDePreguntas[2].preguntas[16].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[16].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[16].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[16].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[16].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[17] = new Pregunta();
            bancoDePreguntas[2].preguntas[17].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[17].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[17].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[17].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[17].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[18] = new Pregunta();
            bancoDePreguntas[2].preguntas[18].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[18].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[18].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[18].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[18].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[19] = new Pregunta();
            bancoDePreguntas[2].preguntas[19].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[19].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[19].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[19].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[19].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[20] = new Pregunta();
            bancoDePreguntas[2].preguntas[20].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[20].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[20].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[20].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[20].respuestasDeLaPregunta[3] = new Respuesta();

            
            bancoDePreguntas[3].preguntas = new Pregunta[21];

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

            bancoDePreguntas[3].preguntas[5] = new Pregunta();
            bancoDePreguntas[3].preguntas[5].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[5].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[5].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[5].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[5].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[6] = new Pregunta();
            bancoDePreguntas[3].preguntas[6].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[6].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[6].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[6].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[6].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[7] = new Pregunta();
            bancoDePreguntas[3].preguntas[7].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[7].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[7].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[7].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[7].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[8] = new Pregunta();
            bancoDePreguntas[3].preguntas[8].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[8].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[8].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[8].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[8].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[9] = new Pregunta();
            bancoDePreguntas[3].preguntas[9].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[9].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[9].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[9].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[9].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[10] = new Pregunta();
            bancoDePreguntas[3].preguntas[10].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[10].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[10].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[10].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[10].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[11] = new Pregunta();
            bancoDePreguntas[3].preguntas[11].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[11].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[11].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[11].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[11].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[12] = new Pregunta();
            bancoDePreguntas[3].preguntas[12].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[12].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[12].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[12].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[12].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[13] = new Pregunta();
            bancoDePreguntas[3].preguntas[13].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[13].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[13].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[13].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[13].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[14] = new Pregunta();
            bancoDePreguntas[3].preguntas[14].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[14].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[14].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[14].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[14].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[15] = new Pregunta();
            bancoDePreguntas[3].preguntas[15].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[15].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[15].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[15].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[15].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[16] = new Pregunta();
            bancoDePreguntas[3].preguntas[16].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[16].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[16].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[16].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[16].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[17] = new Pregunta();
            bancoDePreguntas[3].preguntas[17].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[17].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[17].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[17].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[17].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[18] = new Pregunta();
            bancoDePreguntas[3].preguntas[18].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[18].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[18].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[18].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[18].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[19] = new Pregunta();
            bancoDePreguntas[3].preguntas[19].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[19].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[19].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[19].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[19].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[20] = new Pregunta();
            bancoDePreguntas[3].preguntas[20].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[20].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[20].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[20].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[20].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[4].preguntas = new Pregunta[21];

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

            bancoDePreguntas[4].preguntas[5] = new Pregunta();
            bancoDePreguntas[4].preguntas[5].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[5].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[5].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[5].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[5].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[4].preguntas[6] = new Pregunta();
            bancoDePreguntas[4].preguntas[6].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[6].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[6].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[6].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[6].respuestasDeLaPregunta[3] = new Respuesta();
        
            bancoDePreguntas[4].preguntas[7] = new Pregunta();
            bancoDePreguntas[4].preguntas[7].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[7].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[7].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[7].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[7].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[4].preguntas[8] = new Pregunta();
            bancoDePreguntas[4].preguntas[8].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[8].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[8].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[8].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[8].respuestasDeLaPregunta[3] = new Respuesta();
        
            bancoDePreguntas[4].preguntas[9] = new Pregunta();
            bancoDePreguntas[4].preguntas[9].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[9].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[9].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[9].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[9].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[4].preguntas[10] = new Pregunta();
            bancoDePreguntas[4].preguntas[10].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[10].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[10].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[10].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[10].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[4].preguntas[11] = new Pregunta();
            bancoDePreguntas[4].preguntas[11].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[11].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[11].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[11].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[11].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[4].preguntas[12] = new Pregunta();
            bancoDePreguntas[4].preguntas[12].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[12].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[12].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[12].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[12].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[4].preguntas[13] = new Pregunta();
            bancoDePreguntas[4].preguntas[13].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[13].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[13].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[13].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[13].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[4].preguntas[14] = new Pregunta();
            bancoDePreguntas[4].preguntas[14].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[14].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[14].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[14].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[14].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[4].preguntas[15] = new Pregunta();
            bancoDePreguntas[4].preguntas[15].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[15].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[15].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[15].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[15].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[4].preguntas[16] = new Pregunta();
            bancoDePreguntas[4].preguntas[16].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[16].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[16].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[16].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[16].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[4].preguntas[17] = new Pregunta();
            bancoDePreguntas[4].preguntas[17].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[17].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[17].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[17].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[17].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[4].preguntas[18] = new Pregunta();
            bancoDePreguntas[4].preguntas[18].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[18].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[18].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[18].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[18].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[4].preguntas[19] = new Pregunta();
            bancoDePreguntas[4].preguntas[19].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[19].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[19].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[19].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[19].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[4].preguntas[20] = new Pregunta();
            bancoDePreguntas[4].preguntas[20].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[20].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[20].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[20].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[20].respuestasDeLaPregunta[3] = new Respuesta();



            CargarDatos();

            nivelDeDificultad = 0;
            rng = new Random();
            numeroDePregunta = rng.Next(0, 21); // me dara un numero del 0 al 20 sin incluir el 21.
                                                
        }

        public void AciertaPregunta() // funcion para cambiar puntaje al acertar la pregunta
        {
            puntajeActual += 1;
            
           
        }

        public void ProgresarJuego()
        {

            if (nivelDeDificultad == 0 && puntajeActual == 10)
            {
                nivelDeDificultad += 1;
                if (vidasActuales < 3)
                {
                    vidasActuales += 1;
                    Console.WriteLine("Vida extra!");
                
                }
            }

            if (nivelDeDificultad == 1 && puntajeActual == 20)
            {
                nivelDeDificultad += 1;
                if (vidasActuales < 3)
                {
                    vidasActuales += 1;
                    Console.WriteLine("Vida extra!");

                }

            }

            if (nivelDeDificultad == 2 && puntajeActual == 30)
            {
                nivelDeDificultad += 1;
                if (vidasActuales < 3)
                {
                    vidasActuales += 1;
                    Console.WriteLine("Vida extra!");

                }
            }

            if (nivelDeDificultad == 3 && puntajeActual == 40)
            {
                nivelDeDificultad += 1;
                if (vidasActuales < 3)
                {
                    vidasActuales += 1;
                    Console.WriteLine("Vida extra!");

                }
            }

            numeroDePregunta = rng.Next(0, 21); 
        }

        public void FallarPregunta()
        {
            vidasActuales -= 1;
            numeroDePregunta = rng.Next(0, 21);
        }

        public void PerderJuego()
        {
            nivelDeDificultad = 0;
            numeroDePregunta = rng.Next(0, 21); 
            
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
            //Es el explorador de datos para buscar a las preguntas 

            // Muy faciles
            bancoDePreguntas[0].nombreDeLaDificultad = "Muy Fácil";
            bancoDePreguntas[0].preguntas[0].enunciadoDeLaPregunta = "        2+7=";
            bancoDePreguntas[0].preguntas[0].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "9";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-9";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "10";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "-10";

            bancoDePreguntas[0].preguntas[1].enunciadoDeLaPregunta = "        6x3=";
            bancoDePreguntas[0].preguntas[1].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "20";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "16";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "18";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "14";

            bancoDePreguntas[0].preguntas[2].enunciadoDeLaPregunta = "        2^3=";
            bancoDePreguntas[0].preguntas[2].respuestaCorrecta = 3;
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "6";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "10";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "16";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "8";

            bancoDePreguntas[0].preguntas[3].enunciadoDeLaPregunta = "        24/3=";
            bancoDePreguntas[0].preguntas[3].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "6";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "8";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "9";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "7";

            bancoDePreguntas[0].preguntas[4].enunciadoDeLaPregunta = "        0x2=";
            bancoDePreguntas[0].preguntas[4].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "0";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "1";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "2";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "4";

            bancoDePreguntas[0].preguntas[5].enunciadoDeLaPregunta = "        300-10";
            bancoDePreguntas[0].preguntas[5].respuestaCorrecta = 3;
            bancoDePreguntas[0].preguntas[5].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "200";
            bancoDePreguntas[0].preguntas[5].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "190";
            bancoDePreguntas[0].preguntas[5].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "390";
            bancoDePreguntas[0].preguntas[5].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "290";

            bancoDePreguntas[0].preguntas[6].enunciadoDeLaPregunta = "        297-316";
            bancoDePreguntas[0].preguntas[6].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[6].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-21";
            bancoDePreguntas[0].preguntas[6].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "21";
            bancoDePreguntas[0].preguntas[6].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-19";
            bancoDePreguntas[0].preguntas[6].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "19";

            bancoDePreguntas[0].preguntas[7].enunciadoDeLaPregunta = "        654-94=";
            bancoDePreguntas[0].preguntas[7].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[7].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "560";
            bancoDePreguntas[0].preguntas[7].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "570";
            bancoDePreguntas[0].preguntas[7].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "550";
            bancoDePreguntas[0].preguntas[7].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "580";

            bancoDePreguntas[0].preguntas[8].enunciadoDeLaPregunta = "        297+29=";
            bancoDePreguntas[0].preguntas[8].respuestaCorrecta = 3;
            bancoDePreguntas[0].preguntas[8].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "316";
            bancoDePreguntas[0].preguntas[8].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "328";
            bancoDePreguntas[0].preguntas[8].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "324";
            bancoDePreguntas[0].preguntas[8].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "326";

            bancoDePreguntas[0].preguntas[9].enunciadoDeLaPregunta = "        954-66=";
            bancoDePreguntas[0].preguntas[9].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[9].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "888";
            bancoDePreguntas[0].preguntas[9].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "898";
            bancoDePreguntas[0].preguntas[9].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "908";
            bancoDePreguntas[0].preguntas[9].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "918";

            bancoDePreguntas[0].preguntas[10].enunciadoDeLaPregunta = "        29-719=";
            bancoDePreguntas[0].preguntas[10].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[10].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-690";
            bancoDePreguntas[0].preguntas[10].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "690";
            bancoDePreguntas[0].preguntas[10].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "680";
            bancoDePreguntas[0].preguntas[10].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "-680";

            bancoDePreguntas[0].preguntas[11].enunciadoDeLaPregunta = "        137-60=";
            bancoDePreguntas[0].preguntas[11].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "87";
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "67";
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "77";
            bancoDePreguntas[0].preguntas[11].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "57";


            bancoDePreguntas[0].preguntas[12].enunciadoDeLaPregunta = "        -109+-171=";
            bancoDePreguntas[0].preguntas[12].respuestaCorrecta = 3;
            bancoDePreguntas[0].preguntas[12].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-280";
            bancoDePreguntas[0].preguntas[12].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-62";
            bancoDePreguntas[0].preguntas[12].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "280";
            bancoDePreguntas[0].preguntas[12].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "62";

            bancoDePreguntas[0].preguntas[13].enunciadoDeLaPregunta = "        -11+-11=";
            bancoDePreguntas[0].preguntas[13].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[13].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "22";
            bancoDePreguntas[0].preguntas[13].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-22";
            bancoDePreguntas[0].preguntas[13].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "0";
            bancoDePreguntas[0].preguntas[13].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "11";

            bancoDePreguntas[0].preguntas[14].enunciadoDeLaPregunta = "        -17+-9=";
            bancoDePreguntas[0].preguntas[14].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[14].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-8";
            bancoDePreguntas[0].preguntas[14].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "26";
            bancoDePreguntas[0].preguntas[14].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-26";
            bancoDePreguntas[0].preguntas[14].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "8";

            bancoDePreguntas[0].preguntas[15].enunciadoDeLaPregunta = "        -45--5=";
            bancoDePreguntas[0].preguntas[15].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[15].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "40";
            bancoDePreguntas[0].preguntas[15].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-40";
            bancoDePreguntas[0].preguntas[15].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-50";
            bancoDePreguntas[0].preguntas[15].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "50";


            bancoDePreguntas[0].preguntas[16].enunciadoDeLaPregunta = "        -8--18=";
            bancoDePreguntas[0].preguntas[16].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[16].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "10";
            bancoDePreguntas[0].preguntas[16].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-10";
            bancoDePreguntas[0].preguntas[16].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-26";
            bancoDePreguntas[0].preguntas[16].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "26";

            bancoDePreguntas[0].preguntas[17].enunciadoDeLaPregunta = "        1+-3=";
            bancoDePreguntas[0].preguntas[17].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[17].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "2";
            bancoDePreguntas[0].preguntas[17].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-2";
            bancoDePreguntas[0].preguntas[17].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-4";
            bancoDePreguntas[0].preguntas[17].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "4";

            bancoDePreguntas[0].preguntas[18].enunciadoDeLaPregunta = "        ¿Cuál de estos es un número primo?";
            bancoDePreguntas[0].preguntas[18].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[18].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "2";
            bancoDePreguntas[0].preguntas[18].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "27";
            bancoDePreguntas[0].preguntas[18].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "667";
            bancoDePreguntas[0].preguntas[18].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "4";

            bancoDePreguntas[0].preguntas[19].enunciadoDeLaPregunta = "        -25+2=";
            bancoDePreguntas[0].preguntas[19].respuestaCorrecta = 3;
            bancoDePreguntas[0].preguntas[19].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "23";
            bancoDePreguntas[0].preguntas[19].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-27";
            bancoDePreguntas[0].preguntas[19].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "27";
            bancoDePreguntas[0].preguntas[19].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "-23";

            bancoDePreguntas[0].preguntas[20].enunciadoDeLaPregunta = "        15--16=";
            bancoDePreguntas[0].preguntas[20].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[20].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-1";
            bancoDePreguntas[0].preguntas[20].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "31";
            bancoDePreguntas[0].preguntas[20].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "1";
            bancoDePreguntas[0].preguntas[20].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "-31";

            // faciles
            bancoDePreguntas[1].preguntas[0].enunciadoDeLaPregunta = "        816÷16=";
            bancoDePreguntas[1].preguntas[0].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "49";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "50";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "51";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "52";

            bancoDePreguntas[1].preguntas[1].enunciadoDeLaPregunta = "        Raíz cúbica de 8 = ";
            bancoDePreguntas[1].preguntas[1].respuestaCorrecta = 1;
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-2";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "2";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "2,66";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "2,55";

            bancoDePreguntas[1].preguntas[2].enunciadoDeLaPregunta = "        -5 x -13 = ";
            bancoDePreguntas[1].preguntas[2].respuestaCorrecta = 3;
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "65";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "55";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-55";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "-65";

            bancoDePreguntas[1].preguntas[3].enunciadoDeLaPregunta = "        -64 ÷ 16 = ";
            bancoDePreguntas[1].preguntas[3].respuestaCorrecta = 0;
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-4";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-6";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-5";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "-7";

            bancoDePreguntas[1].preguntas[4].enunciadoDeLaPregunta = "        -2 x -17 = ";
            bancoDePreguntas[1].preguntas[4].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-34";
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "37";
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "34";
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "-37";

            bancoDePreguntas[1].preguntas[5].enunciadoDeLaPregunta = "        400 ÷ -20 = ";
            bancoDePreguntas[1].preguntas[5].respuestaCorrecta = 3;
            bancoDePreguntas[1].preguntas[5].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "20";
            bancoDePreguntas[1].preguntas[5].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-15";
            bancoDePreguntas[1].preguntas[5].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-40";
            bancoDePreguntas[1].preguntas[5].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "-20";

            bancoDePreguntas[1].preguntas[6].enunciadoDeLaPregunta = "        294 ÷ 21 = ";
            bancoDePreguntas[1].preguntas[6].respuestaCorrecta = 0;
            bancoDePreguntas[1].preguntas[6].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "14";
            bancoDePreguntas[1].preguntas[6].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "15";
            bancoDePreguntas[1].preguntas[6].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "16";
            bancoDePreguntas[1].preguntas[6].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "17";

            bancoDePreguntas[1].preguntas[7].enunciadoDeLaPregunta = "        2 x -8 = ";
            bancoDePreguntas[1].preguntas[7].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[7].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "14";
            bancoDePreguntas[1].preguntas[7].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-14";
            bancoDePreguntas[1].preguntas[7].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-16";
            bancoDePreguntas[1].preguntas[7].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "16";

            bancoDePreguntas[1].preguntas[8].enunciadoDeLaPregunta = "        23 x 7 = ";
            bancoDePreguntas[1].preguntas[8].respuestaCorrecta = 1;
            bancoDePreguntas[1].preguntas[8].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "171";
            bancoDePreguntas[1].preguntas[8].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "161";
            bancoDePreguntas[1].preguntas[8].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "151";
            bancoDePreguntas[1].preguntas[8].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "141";


            bancoDePreguntas[1].preguntas[9].enunciadoDeLaPregunta = "        91 ÷ 13 = ";
            bancoDePreguntas[1].preguntas[9].respuestaCorrecta = 1;
            bancoDePreguntas[1].preguntas[9].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "6";
            bancoDePreguntas[1].preguntas[9].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "7";
            bancoDePreguntas[1].preguntas[9].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "8";
            bancoDePreguntas[1].preguntas[9].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "9";

            bancoDePreguntas[1].preguntas[10].enunciadoDeLaPregunta = "        1 x 6 ÷ 3 = ";
            bancoDePreguntas[1].preguntas[10].respuestaCorrecta = 3;
            bancoDePreguntas[1].preguntas[10].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "4";
            bancoDePreguntas[1].preguntas[10].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "3";
            bancoDePreguntas[1].preguntas[10].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "6";
            bancoDePreguntas[1].preguntas[10].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "2";

            bancoDePreguntas[1].preguntas[11].enunciadoDeLaPregunta = "        10^2 = ";
            bancoDePreguntas[1].preguntas[11].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[11].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "10";
            bancoDePreguntas[1].preguntas[11].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "20";
            bancoDePreguntas[1].preguntas[11].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "100";
            bancoDePreguntas[1].preguntas[11].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "200";

            bancoDePreguntas[1].preguntas[12].enunciadoDeLaPregunta = "        4^3 = ";
            bancoDePreguntas[1].preguntas[12].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[12].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "12";
            bancoDePreguntas[1].preguntas[12].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "32";
            bancoDePreguntas[1].preguntas[12].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "64";
            bancoDePreguntas[1].preguntas[12].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "72";

            bancoDePreguntas[1].preguntas[13].enunciadoDeLaPregunta = "        5^3 = ";
            bancoDePreguntas[1].preguntas[13].respuestaCorrecta = 0;
            bancoDePreguntas[1].preguntas[13].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "125";
            bancoDePreguntas[1].preguntas[13].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "15";
            bancoDePreguntas[1].preguntas[13].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "625";
            bancoDePreguntas[1].preguntas[13].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "50";

            bancoDePreguntas[1].preguntas[14].enunciadoDeLaPregunta = "        7^2 = ";
            bancoDePreguntas[1].preguntas[14].respuestaCorrecta = 3;
            bancoDePreguntas[1].preguntas[14].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "14";
            bancoDePreguntas[1].preguntas[14].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "36";
            bancoDePreguntas[1].preguntas[14].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "28";
            bancoDePreguntas[1].preguntas[14].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "49";

            bancoDePreguntas[1].preguntas[15].enunciadoDeLaPregunta = "        ∛1 = ";
            bancoDePreguntas[1].preguntas[15].respuestaCorrecta = 0;
            bancoDePreguntas[1].preguntas[15].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "1";
            bancoDePreguntas[1].preguntas[15].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-1";
            bancoDePreguntas[1].preguntas[15].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "0";
            bancoDePreguntas[1].preguntas[15].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "3";

            bancoDePreguntas[1].preguntas[16].enunciadoDeLaPregunta = "        9^2 = ";
            bancoDePreguntas[1].preguntas[16].respuestaCorrecta = 1;
            bancoDePreguntas[1].preguntas[16].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "72";
            bancoDePreguntas[1].preguntas[16].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "81";
            bancoDePreguntas[1].preguntas[16].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "89";
            bancoDePreguntas[1].preguntas[16].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "18";

            bancoDePreguntas[1].preguntas[17].enunciadoDeLaPregunta = "        -63--6 = ";
            bancoDePreguntas[1].preguntas[17].respuestaCorrecta = 0;
            bancoDePreguntas[1].preguntas[17].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-57";
            bancoDePreguntas[1].preguntas[17].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-69";
            bancoDePreguntas[1].preguntas[17].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "67";
            bancoDePreguntas[1].preguntas[17].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "-72";

            bancoDePreguntas[1].preguntas[18].enunciadoDeLaPregunta = "        -10 x-13 = ";
            bancoDePreguntas[1].preguntas[18].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[18].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "23";
            bancoDePreguntas[1].preguntas[18].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-130";
            bancoDePreguntas[1].preguntas[18].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "130";
            bancoDePreguntas[1].preguntas[18].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "260";

            bancoDePreguntas[1].preguntas[19].enunciadoDeLaPregunta = "        184 ÷ 8 = ";
            bancoDePreguntas[1].preguntas[19].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[19].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "21";
            bancoDePreguntas[1].preguntas[19].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "22";
            bancoDePreguntas[1].preguntas[19].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "23";
            bancoDePreguntas[1].preguntas[19].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "24";


            bancoDePreguntas[1].preguntas[20].enunciadoDeLaPregunta = "        12--16 = ";
            bancoDePreguntas[1].preguntas[20].respuestaCorrecta = 0;
            bancoDePreguntas[1].preguntas[20].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "28";
            bancoDePreguntas[1].preguntas[20].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "30";
            bancoDePreguntas[1].preguntas[20].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-4";
            bancoDePreguntas[1].preguntas[20].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "-8";


            //Medio

            bancoDePreguntas[2].preguntas[0].enunciadoDeLaPregunta = "        5 x 6 ÷ 3 = ";
            bancoDePreguntas[2].preguntas[0].respuestaCorrecta = 0;
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "10";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "30";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "5";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "15";

            bancoDePreguntas[2].preguntas[1].enunciadoDeLaPregunta = "        4^0 = ";
            bancoDePreguntas[2].preguntas[1].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "0";
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "1";
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "4";
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "-1";

            bancoDePreguntas[2].preguntas[2].enunciadoDeLaPregunta = "        3 x 6 + 5 = ";
            bancoDePreguntas[2].preguntas[2].respuestaCorrecta = 3;
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "33";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "13";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "28";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "23";

            bancoDePreguntas[2].preguntas[3].enunciadoDeLaPregunta = "        2-3x9 = ";
            bancoDePreguntas[2].preguntas[3].respuestaCorrecta = 2;
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "31";
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-9";
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-25";
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "15";

            bancoDePreguntas[2].preguntas[4].enunciadoDeLaPregunta = "        -7 x -9 -9 = ";
            bancoDePreguntas[2].preguntas[4].respuestaCorrecta = 3;
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "0";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-126";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "52";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "54";

            bancoDePreguntas[2].preguntas[5].enunciadoDeLaPregunta = "        0,1 x -20 = ";
            bancoDePreguntas[2].preguntas[5].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[5].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-1";
            bancoDePreguntas[2].preguntas[5].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-2";
            bancoDePreguntas[2].preguntas[5].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-10";
            bancoDePreguntas[2].preguntas[5].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "5";

            bancoDePreguntas[2].preguntas[6].enunciadoDeLaPregunta = "        -315 ÷ -7 = ";
            bancoDePreguntas[2].preguntas[6].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[6].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-44";
            bancoDePreguntas[2].preguntas[6].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "45";
            bancoDePreguntas[2].preguntas[6].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "46";
            bancoDePreguntas[2].preguntas[6].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "-47";

            bancoDePreguntas[2].preguntas[7].enunciadoDeLaPregunta = "        -6 x -22 = ";
            bancoDePreguntas[2].preguntas[7].respuestaCorrecta = 2;
            bancoDePreguntas[2].preguntas[7].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "123";
            bancoDePreguntas[2].preguntas[7].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-88";
            bancoDePreguntas[2].preguntas[7].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "132";
            bancoDePreguntas[2].preguntas[7].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "135";

            bancoDePreguntas[2].preguntas[8].enunciadoDeLaPregunta = "        -405 ÷ 27 = ";
            bancoDePreguntas[2].preguntas[8].respuestaCorrecta = 2;
            bancoDePreguntas[2].preguntas[8].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-14";
            bancoDePreguntas[2].preguntas[8].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-15";
            bancoDePreguntas[2].preguntas[8].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-16";
            bancoDePreguntas[2].preguntas[8].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "15";

            bancoDePreguntas[2].preguntas[9].enunciadoDeLaPregunta = "        102 x 12 = ";
            bancoDePreguntas[2].preguntas[9].respuestaCorrecta = 2;
            bancoDePreguntas[2].preguntas[9].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "1448";
            bancoDePreguntas[2].preguntas[9].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "1336";
            bancoDePreguntas[2].preguntas[9].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "1224";
            bancoDePreguntas[2].preguntas[9].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "5";

            bancoDePreguntas[2].preguntas[10].enunciadoDeLaPregunta = "        2(2v-3) = 30. v = ? ";
            bancoDePreguntas[2].preguntas[10].respuestaCorrecta = 2;
            bancoDePreguntas[2].preguntas[10].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "8";
            bancoDePreguntas[2].preguntas[10].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "8.5";
            bancoDePreguntas[2].preguntas[10].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "9";
            bancoDePreguntas[2].preguntas[10].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "10";

            bancoDePreguntas[2].preguntas[11].enunciadoDeLaPregunta = "       Raíz cúbica de 216= ";
            bancoDePreguntas[2].preguntas[11].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[11].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "5.4";
            bancoDePreguntas[2].preguntas[11].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "6";
            bancoDePreguntas[2].preguntas[11].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "7";
            bancoDePreguntas[2].preguntas[11].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "5";

            bancoDePreguntas[2].preguntas[12].enunciadoDeLaPregunta = "        600 ÷ -20 = ";
            bancoDePreguntas[2].preguntas[12].respuestaCorrecta = 0;
            bancoDePreguntas[2].preguntas[12].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-30";
            bancoDePreguntas[2].preguntas[12].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-20";
            bancoDePreguntas[2].preguntas[12].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-300";
            bancoDePreguntas[2].preguntas[12].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "-33";

            bancoDePreguntas[2].preguntas[13].enunciadoDeLaPregunta = "        11 x 11 - 8 + 2= ";
            bancoDePreguntas[2].preguntas[13].respuestaCorrecta = 3;
            bancoDePreguntas[2].preguntas[13].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "101";
            bancoDePreguntas[2].preguntas[13].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "35";
            bancoDePreguntas[2].preguntas[13].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "127";
            bancoDePreguntas[2].preguntas[13].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "115";

            bancoDePreguntas[2].preguntas[14].enunciadoDeLaPregunta = "        Al tirar dos dados, ¿cuál es la posibilidad de sacar un par de 6's? ";
            bancoDePreguntas[2].preguntas[14].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[14].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "1/12";
            bancoDePreguntas[2].preguntas[14].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "1/36";
            bancoDePreguntas[2].preguntas[14].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "1/64";
            bancoDePreguntas[2].preguntas[14].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "5/16";

            bancoDePreguntas[2].preguntas[15].enunciadoDeLaPregunta = "        2^9 = ";
            bancoDePreguntas[2].preguntas[15].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[15].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "256";
            bancoDePreguntas[2].preguntas[15].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "512";
            bancoDePreguntas[2].preguntas[15].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "1024";
            bancoDePreguntas[2].preguntas[15].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "2048";

            bancoDePreguntas[2].preguntas[16].enunciadoDeLaPregunta = "        7(3--4) = ";
            bancoDePreguntas[2].preguntas[16].respuestaCorrecta = 3;
            bancoDePreguntas[2].preguntas[16].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-7";
            bancoDePreguntas[2].preguntas[16].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "1";
            bancoDePreguntas[2].preguntas[16].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "14";
            bancoDePreguntas[2].preguntas[16].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "49";

            bancoDePreguntas[2].preguntas[17].enunciadoDeLaPregunta = "        (2+-9) x 2[(5^2)-35+10] = ";
            bancoDePreguntas[2].preguntas[17].respuestaCorrecta = 0;
            bancoDePreguntas[2].preguntas[17].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "0";
            bancoDePreguntas[2].preguntas[17].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "90";
            bancoDePreguntas[2].preguntas[17].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "140";
            bancoDePreguntas[2].preguntas[17].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "5";

            bancoDePreguntas[2].preguntas[18].enunciadoDeLaPregunta = "        (678-221)(2--1)(3-6+3)  = ";
            bancoDePreguntas[2].preguntas[18].respuestaCorrecta = 0;
            bancoDePreguntas[2].preguntas[18].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "0";
            bancoDePreguntas[2].preguntas[18].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "43289";
            bancoDePreguntas[2].preguntas[18].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "23678";
            bancoDePreguntas[2].preguntas[18].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "52112";

            bancoDePreguntas[2].preguntas[19].enunciadoDeLaPregunta = "        -2(80÷5)+2  = ";
            bancoDePreguntas[2].preguntas[19].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[19].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "16";
            bancoDePreguntas[2].preguntas[19].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "30";
            bancoDePreguntas[2].preguntas[19].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "34";
            bancoDePreguntas[2].preguntas[19].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "36";

            bancoDePreguntas[2].preguntas[20].enunciadoDeLaPregunta = "        2(780÷2÷3)--300  = ";
            bancoDePreguntas[2].preguntas[20].respuestaCorrecta = 3;
            bancoDePreguntas[2].preguntas[20].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-130";
            bancoDePreguntas[2].preguntas[20].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "260";
            bancoDePreguntas[2].preguntas[20].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "340";
            bancoDePreguntas[2].preguntas[20].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "560";
            
            
            // Dificil

            bancoDePreguntas[3].preguntas[0].enunciadoDeLaPregunta = "        3(2 x -7) + 8 =";
            bancoDePreguntas[3].preguntas[0].respuestaCorrecta = 0;
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-3";
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-11";
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "50";
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "-50";

            bancoDePreguntas[3].preguntas[1].enunciadoDeLaPregunta = "        4! =";
            bancoDePreguntas[3].preguntas[1].respuestaCorrecta = 1;
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "12";
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "24";
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "36";
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "48";

            bancoDePreguntas[3].preguntas[2].enunciadoDeLaPregunta = "        6! =";
            bancoDePreguntas[3].preguntas[2].respuestaCorrecta = 1;
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "134";
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "720";
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "864";
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "976";

            bancoDePreguntas[3].preguntas[3].enunciadoDeLaPregunta = "        10! =";
            bancoDePreguntas[3].preguntas[3].respuestaCorrecta = 2;
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "40320";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "362880";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "3628800";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "36288000";

            bancoDePreguntas[3].preguntas[4].enunciadoDeLaPregunta = "        Un producto de $5000 tiene un 17% de descuento. Su precio final es";
            bancoDePreguntas[3].preguntas[4].respuestaCorrecta = 1;
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "4050";
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "4150";
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "4250";
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "4400";

            bancoDePreguntas[3].preguntas[5].enunciadoDeLaPregunta = "        Un producto de $8700 tiene un 20% de descuento. Su precio final es";
            bancoDePreguntas[3].preguntas[5].respuestaCorrecta = 0;
            bancoDePreguntas[3].preguntas[5].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "6960";
            bancoDePreguntas[3].preguntas[5].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "7000";
            bancoDePreguntas[3].preguntas[5].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "7120";
            bancoDePreguntas[3].preguntas[5].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "7200";

            bancoDePreguntas[3].preguntas[6].enunciadoDeLaPregunta = "        El mínimo común múltiplo de 5 y 7 es ";
            bancoDePreguntas[3].preguntas[6].respuestaCorrecta = 3;
            bancoDePreguntas[3].preguntas[6].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "12";
            bancoDePreguntas[3].preguntas[6].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "17";
            bancoDePreguntas[3].preguntas[6].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "5";
            bancoDePreguntas[3].preguntas[6].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "35";

            bancoDePreguntas[3].preguntas[7].enunciadoDeLaPregunta = "        ¿Cuál es el próximo número en la sequencia? 4, 9, 16, 25, ... ";
            bancoDePreguntas[3].preguntas[7].respuestaCorrecta = 1;
            bancoDePreguntas[3].preguntas[7].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "32";
            bancoDePreguntas[3].preguntas[7].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "36";
            bancoDePreguntas[3].preguntas[7].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "40";
            bancoDePreguntas[3].preguntas[7].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "44";

            bancoDePreguntas[3].preguntas[8].enunciadoDeLaPregunta = "        ¿Cuál es el próximo número en la sequencia? 9, 27, 45, 63, ... ";
            bancoDePreguntas[3].preguntas[8].respuestaCorrecta = 1;
            bancoDePreguntas[3].preguntas[8].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "72";
            bancoDePreguntas[3].preguntas[8].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "81";
            bancoDePreguntas[3].preguntas[8].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "90";
            bancoDePreguntas[3].preguntas[8].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "101";

            bancoDePreguntas[3].preguntas[9].enunciadoDeLaPregunta = "        En teoría, ¿cuáles son las posibilidades de que al tirar una moneda 3 veces, salgan 3 veces corona? ";
            bancoDePreguntas[3].preguntas[9].respuestaCorrecta = 0;
            bancoDePreguntas[3].preguntas[9].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "1/8";
            bancoDePreguntas[3].preguntas[9].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "1/6";
            bancoDePreguntas[3].preguntas[9].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "1/12";
            bancoDePreguntas[3].preguntas[9].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "101";

            bancoDePreguntas[3].preguntas[10].enunciadoDeLaPregunta = "        En teoría, ¿cuáles son las posibilidades de que al tirar una moneda 3 veces, salgan 3 veces corona? ";
            bancoDePreguntas[3].preguntas[10].respuestaCorrecta = 3;
            bancoDePreguntas[3].preguntas[10].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "1/4";
            bancoDePreguntas[3].preguntas[10].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "1/6";
            bancoDePreguntas[3].preguntas[10].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "1/12";
            bancoDePreguntas[3].preguntas[10].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "1/8";

            bancoDePreguntas[3].preguntas[11].enunciadoDeLaPregunta = "        3 x 8 x 8 x 2 ÷ 3 x 5 ÷ 8 ÷ 4=";
            bancoDePreguntas[3].preguntas[11].respuestaCorrecta = 3;
            bancoDePreguntas[3].preguntas[11].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "192";
            bancoDePreguntas[3].preguntas[11].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "40";
            bancoDePreguntas[3].preguntas[11].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "80";
            bancoDePreguntas[3].preguntas[11].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "20";

            bancoDePreguntas[3].preguntas[12].enunciadoDeLaPregunta = "        (17 - 6 ÷ 2) + 4 x 3 =";
            bancoDePreguntas[3].preguntas[12].respuestaCorrecta = 0;
            bancoDePreguntas[3].preguntas[12].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "26";
            bancoDePreguntas[3].preguntas[12].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "30";
            bancoDePreguntas[3].preguntas[12].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "24";
            bancoDePreguntas[3].preguntas[12].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "18";

            bancoDePreguntas[3].preguntas[13].enunciadoDeLaPregunta = "        -2(1 x 4 - 2 ÷ 2) + (6 + 2 - 3) =";
            bancoDePreguntas[3].preguntas[13].respuestaCorrecta = 0;
            bancoDePreguntas[3].preguntas[13].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "26";
            bancoDePreguntas[3].preguntas[13].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "30";
            bancoDePreguntas[3].preguntas[13].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "24";
            bancoDePreguntas[3].preguntas[13].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "18";

            bancoDePreguntas[3].preguntas[14].enunciadoDeLaPregunta = "        ¿Cuál es el próximo número en la sequencia? 5, 7, 11, 13, 17... ";
            bancoDePreguntas[3].preguntas[14].respuestaCorrecta = 0;
            bancoDePreguntas[3].preguntas[14].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "19";
            bancoDePreguntas[3].preguntas[14].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "21";
            bancoDePreguntas[3].preguntas[14].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "22";
            bancoDePreguntas[3].preguntas[14].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "23";

            bancoDePreguntas[3].preguntas[15].enunciadoDeLaPregunta = "        El mínimo común múltiplo de  9 y 27 es";
            bancoDePreguntas[3].preguntas[15].respuestaCorrecta = 2;
            bancoDePreguntas[3].preguntas[15].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "3";
            bancoDePreguntas[3].preguntas[15].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "9";
            bancoDePreguntas[3].preguntas[15].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "27";
            bancoDePreguntas[3].preguntas[15].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "81";

            bancoDePreguntas[3].preguntas[16].enunciadoDeLaPregunta = "        7 (-2(6^2)) ÷ 14 = ";
            bancoDePreguntas[3].preguntas[16].respuestaCorrecta = 2;
            bancoDePreguntas[3].preguntas[16].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "9";
            bancoDePreguntas[3].preguntas[16].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "28";
            bancoDePreguntas[3].preguntas[16].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "36";
            bancoDePreguntas[3].preguntas[16].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "50";

            bancoDePreguntas[3].preguntas[17].enunciadoDeLaPregunta = "        (6x8÷12)^2) ÷ (6+-5) = ";
            bancoDePreguntas[3].preguntas[17].respuestaCorrecta = 0;
            bancoDePreguntas[3].preguntas[17].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "4";
            bancoDePreguntas[3].preguntas[17].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "12";
            bancoDePreguntas[3].preguntas[17].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "26";
            bancoDePreguntas[3].preguntas[17].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "30";

            bancoDePreguntas[3].preguntas[18].enunciadoDeLaPregunta = "        Un producto de $15000 tiene un 37% de descuento. Su precio final es: ";
            bancoDePreguntas[3].preguntas[18].respuestaCorrecta = 1;
            bancoDePreguntas[3].preguntas[18].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "10150";
            bancoDePreguntas[3].preguntas[18].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "9450";
            bancoDePreguntas[3].preguntas[18].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "9150";
            bancoDePreguntas[3].preguntas[18].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "8950";

            bancoDePreguntas[3].preguntas[19].enunciadoDeLaPregunta = "        Un producto de $20000 tiene un 68% de descuento. Su precio final es: ";
            bancoDePreguntas[3].preguntas[19].respuestaCorrecta = 0;
            bancoDePreguntas[3].preguntas[19].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "6400";
            bancoDePreguntas[3].preguntas[19].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "6600";
            bancoDePreguntas[3].preguntas[19].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "7200";
            bancoDePreguntas[3].preguntas[19].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "5800";

            bancoDePreguntas[3].preguntas[20].enunciadoDeLaPregunta = "        8! = ";
            bancoDePreguntas[3].preguntas[20].respuestaCorrecta = 0;
            bancoDePreguntas[3].preguntas[20].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "40320";
            bancoDePreguntas[3].preguntas[20].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "5040";
            bancoDePreguntas[3].preguntas[20].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "20160";
            bancoDePreguntas[3].preguntas[20].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "26780";

            
            // Muy dificil

            bancoDePreguntas[4].preguntas[0].enunciadoDeLaPregunta = "        12÷(1+3)−9×6=";
            bancoDePreguntas[4].preguntas[0].respuestaCorrecta = 2;
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-36";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "14";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-51";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "-77";

            bancoDePreguntas[4].preguntas[1].enunciadoDeLaPregunta = "        9×8+4−2÷(4−2)=";
            bancoDePreguntas[4].preguntas[1].respuestaCorrecta = 2;
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "53";
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "74";
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "75";
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "79";

            bancoDePreguntas[4].preguntas[2].enunciadoDeLaPregunta = "        9×7−(2+6)÷8=";
            bancoDePreguntas[4].preguntas[2].respuestaCorrecta = 0;
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "62";
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "54";
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "7";
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "8";

            bancoDePreguntas[4].preguntas[3].enunciadoDeLaPregunta = "        (7)^2 - 3 x 3 =";
            bancoDePreguntas[4].preguntas[3].respuestaCorrecta = 0;
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "40";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "48";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "138";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "80";

            bancoDePreguntas[4].preguntas[4].enunciadoDeLaPregunta = "        (17-6÷2)+4x3 =";
            bancoDePreguntas[4].preguntas[4].respuestaCorrecta = 1;
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "40";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "26";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "138";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "78";

            bancoDePreguntas[4].preguntas[5].enunciadoDeLaPregunta = "        -2(1x4-2÷2)+(6+2-3) =";
            bancoDePreguntas[4].preguntas[5].respuestaCorrecta = 1;
            bancoDePreguntas[4].preguntas[5].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "1";
            bancoDePreguntas[4].preguntas[5].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-1";
            bancoDePreguntas[4].preguntas[5].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "11";
            bancoDePreguntas[4].preguntas[5].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "22";

            bancoDePreguntas[4].preguntas[6].enunciadoDeLaPregunta = "        14+18÷2x18-7 =";
            bancoDePreguntas[4].preguntas[6].respuestaCorrecta = 0;
            bancoDePreguntas[4].preguntas[6].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "169";
            bancoDePreguntas[4].preguntas[6].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "281";
            bancoDePreguntas[4].preguntas[6].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "225";
            bancoDePreguntas[4].preguntas[6].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "164";

            bancoDePreguntas[4].preguntas[7].enunciadoDeLaPregunta = "        12-5x18÷9 =";
            bancoDePreguntas[4].preguntas[7].respuestaCorrecta = 0;
            bancoDePreguntas[4].preguntas[7].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "2";
            bancoDePreguntas[4].preguntas[7].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "10";
            bancoDePreguntas[4].preguntas[7].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "14";
            bancoDePreguntas[4].preguntas[7].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "18";

            bancoDePreguntas[4].preguntas[8].enunciadoDeLaPregunta = "        18x18÷9+15 =";
            bancoDePreguntas[4].preguntas[8].respuestaCorrecta = 1;
            bancoDePreguntas[4].preguntas[8].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "13.5";
            bancoDePreguntas[4].preguntas[8].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "51";
            bancoDePreguntas[4].preguntas[8].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "66";
            bancoDePreguntas[4].preguntas[8].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "75";

            bancoDePreguntas[4].preguntas[9].enunciadoDeLaPregunta = "        12+3x5-2 =";
            bancoDePreguntas[4].preguntas[9].respuestaCorrecta = 1;
            bancoDePreguntas[4].preguntas[9].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "12";
            bancoDePreguntas[4].preguntas[9].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "25";
            bancoDePreguntas[4].preguntas[9].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "73";
            bancoDePreguntas[4].preguntas[9].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "64";

            bancoDePreguntas[4].preguntas[10].enunciadoDeLaPregunta = "        El mínimo común múltiplo de 6 y 8 es";
            bancoDePreguntas[4].preguntas[10].respuestaCorrecta = 0;
            bancoDePreguntas[4].preguntas[10].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "24";
            bancoDePreguntas[4].preguntas[10].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "32";
            bancoDePreguntas[4].preguntas[10].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "48";
            bancoDePreguntas[4].preguntas[10].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "64";

            bancoDePreguntas[4].preguntas[11].enunciadoDeLaPregunta = "        (3x(5^2)÷15)-(5-(2^2)) =";
            bancoDePreguntas[4].preguntas[11].respuestaCorrecta = 3;
            bancoDePreguntas[4].preguntas[11].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "6";
            bancoDePreguntas[4].preguntas[11].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "10";
            bancoDePreguntas[4].preguntas[11].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "8";
            bancoDePreguntas[4].preguntas[11].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "4";

            bancoDePreguntas[4].preguntas[12].enunciadoDeLaPregunta = "        El máximo comun divisor de 8 y 17 es =";
            bancoDePreguntas[4].preguntas[12].respuestaCorrecta = 3;
            bancoDePreguntas[4].preguntas[12].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "2";
            bancoDePreguntas[4].preguntas[12].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "4";
            bancoDePreguntas[4].preguntas[12].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "17";
            bancoDePreguntas[4].preguntas[12].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "No tiene";

            bancoDePreguntas[4].preguntas[13].enunciadoDeLaPregunta = "        ((22÷2-2x5)^2) + ((4 - 6 ÷ 6)^2) =";
            bancoDePreguntas[4].preguntas[13].respuestaCorrecta = 2;
            bancoDePreguntas[4].preguntas[13].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "8";
            bancoDePreguntas[4].preguntas[13].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "16";
            bancoDePreguntas[4].preguntas[13].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "10";
            bancoDePreguntas[4].preguntas[13].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "12";

            bancoDePreguntas[4].preguntas[14].enunciadoDeLaPregunta = "        ((1^4)x(2^2)+(3^3)) - (2^5) ÷ 4 =";
            bancoDePreguntas[4].preguntas[14].respuestaCorrecta = 1;
            bancoDePreguntas[4].preguntas[14].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "18";
            bancoDePreguntas[4].preguntas[14].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "23";
            bancoDePreguntas[4].preguntas[14].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "30";
            bancoDePreguntas[4].preguntas[14].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "44";

            bancoDePreguntas[4].preguntas[15].enunciadoDeLaPregunta = "        25 ÷ (8 - 3)^2 + - 7 =";
            bancoDePreguntas[4].preguntas[15].respuestaCorrecta = 3;
            bancoDePreguntas[4].preguntas[15].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "16";
            bancoDePreguntas[4].preguntas[15].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-7";
            bancoDePreguntas[4].preguntas[15].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "24";
            bancoDePreguntas[4].preguntas[15].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "-6";

            bancoDePreguntas[4].preguntas[16].enunciadoDeLaPregunta = "        (3)^4 - 11 x 11 =";
            bancoDePreguntas[4].preguntas[16].respuestaCorrecta = 0;
            bancoDePreguntas[4].preguntas[16].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-40";
            bancoDePreguntas[4].preguntas[16].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "70";
            bancoDePreguntas[4].preguntas[16].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "144";
            bancoDePreguntas[4].preguntas[16].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "-26";

            bancoDePreguntas[4].preguntas[17].enunciadoDeLaPregunta = "        (20)^2 x 0.5 x -0.2 =";
            bancoDePreguntas[4].preguntas[17].respuestaCorrecta = 3;
            bancoDePreguntas[4].preguntas[17].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "40";
            bancoDePreguntas[4].preguntas[17].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "100";
            bancoDePreguntas[4].preguntas[17].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-80";
            bancoDePreguntas[4].preguntas[17].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "-40";

            bancoDePreguntas[4].preguntas[18].enunciadoDeLaPregunta = "        19 - (4 x 80) ÷ 16  =";
            bancoDePreguntas[4].preguntas[18].respuestaCorrecta = 3;
            bancoDePreguntas[4].preguntas[18].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "54";
            bancoDePreguntas[4].preguntas[18].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "88";
            bancoDePreguntas[4].preguntas[18].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "32";
            bancoDePreguntas[4].preguntas[18].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "-1";

            bancoDePreguntas[4].preguntas[19].enunciadoDeLaPregunta = "        -3(6x5) ÷ (5x7 - 80)   =";
            bancoDePreguntas[4].preguntas[19].respuestaCorrecta = 3;
            bancoDePreguntas[4].preguntas[19].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "-15";
            bancoDePreguntas[4].preguntas[19].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "30";
            bancoDePreguntas[4].preguntas[19].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "-90";
            bancoDePreguntas[4].preguntas[19].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "45";

            bancoDePreguntas[4].preguntas[20].enunciadoDeLaPregunta = "        Raíz cúbica de -27  =";
            bancoDePreguntas[4].preguntas[20].respuestaCorrecta = 3;
            bancoDePreguntas[4].preguntas[20].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "4.5";
            bancoDePreguntas[4].preguntas[20].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "-9";
            bancoDePreguntas[4].preguntas[20].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "14";
            bancoDePreguntas[4].preguntas[20].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "-3";

        }

        // Metodo que retorna la dificultad actual
        public int ObtenerDificultadActual() //  dato publico para poder publicar en cual nivel de dificultad estoy
        {
            return nivelDeDificultad;
        }
    }


}
