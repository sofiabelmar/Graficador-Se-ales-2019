using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NAudio.Wave;

namespace GraficadorDeSeñales
{
    class SeñalAudio : Señal
    {
        public string RutaArchivo { get; set; }

        public SeñalAudio (string rutaArchivo)
        {
            RutaArchivo = rutaArchivo;
            Muestras = new List<Muestra>();

            AudioFileReader reader = new AudioFileReader(rutaArchivo);

            TiempoInicial = 0.0;
            TiempoFinal = reader.TotalTime.TotalSeconds;
            FrecuenciaMuestreo = reader.WaveFormat.SampleRate;

            var bufferLectura = new float[reader.WaveFormat.Channels];
        }
        public override double evaluar(double tiempo)
        {
            throw new NotImplementedException();
        }
    }
}
