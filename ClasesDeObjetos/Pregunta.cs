using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeObjetos
{
    public class Pregunta
    {
        // esta es la cadena de texto para las preguntas
        public string enunciadoDeLaPregunta;

        // arreglo de la respuesta
        public Respuesta[] respuestasDeLaPregunta;
        public int respuestaCorrecta;

        public Pregunta()
        {
            respuestasDeLaPregunta = new Respuesta[3];
        }
    }
}
