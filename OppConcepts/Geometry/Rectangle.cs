using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts.Geometry
{
    public class Rectangle : Shape
    {
        // Propiedades para la base y la altura del rectángulo
        public double Base { get; set; }
        public double Height { get; set; }
        //implementacion del metodo abstracto Get area para calcular el area del rectangulo
        public override double GetArea()
        {
            return Base * Height;
        }

        // Sobrescritura del método ToString para proporcionar una representación de cadena personalizada
        //override = La palabra clave override se utiliza en C# para indicar que un método en una clase derivada
        //está reemplazando (o sobrescribiendo) un método de la clase base con el mismo nombre y firma. 
        public override string ToString()
        {
            // se refiere a invocar la implementación del mismo método en la clase base de
            // la clase actual. En este contexto específico, base.ToString()
            // invoca el método ToString() definido en la clase base Shape.
            return $"{base.ToString()}" +
                   $"\n La figura es un Rectángulo" +
                   $"\n El valor de la Base es: {Base}" +
                   $"\n El valor de la Altura es: {Height}" +
                   $"\n El valor del Área es: {GetArea()}";
        }

    }
}