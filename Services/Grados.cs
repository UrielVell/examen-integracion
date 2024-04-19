using System;

namespace grados
{
    public class Grados : iGrados
    {
        public float CelciusFharenheit(int celcius){
            float grados = 1.8f;
            return (celcius*grados)+32;
        }

        public float FharenheitCelcius(int fharenheit){
            float grados = 0.5556f;
            return (fharenheit-32)*grados;
        }
    }
}