using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts.Geometry
{
    public class Circle : Shape
    {
        // Propiedad para el radio del círculo
        public double Radius { get; set; }

        // Implementación del método abstracto para calcular el área del círculo
        public override double GetArea()
        {
           // constante estática en la clase Math de.NET Framework que representa el valor de pi(π)
            return Math.PI * Math.Pow(Radius, 2);
            //es un método estático en la clase Math que se utiliza para elevar un número a una potencia determinada
        }

        public override string Draw()
        {
            // Calcular el diámetro del círculo
            double diameter = Radius * 2;

            // Crear un string para almacenar el círculo
            string circleString = "";

            // Iterar sobre cada fila
            for (double row = 0; row <= diameter; row++)
            {
                // Iterar sobre cada columna
                for (double column = 0; column <= diameter; column++)
                {
                    // Calcular la distancia del punto actual al centro del círculo
                    double distanceToCenter = Math.Sqrt(Math.Pow(column - Radius, 2) + Math.Pow(row - Radius, 2));

                    // Si la distancia al centro es menor o igual al radio, agregar un asterisco al string, de lo contrario agregar un espacio en blanco
                    if (distanceToCenter <= Radius)
                    {
                        circleString += "* ";
                    }
                    else
                    {
                        circleString += "  ";
                    }
                }
                // Agregar un salto de línea después de cada fila
                circleString += "\n";
            }

            // Devolver el string que representa el círculo
            return circleString;
        }

        //override = La palabra clave override se utiliza en C# para indicar que un método en una clase derivada
        //está reemplazando (o sobrescribiendo) un método de la clase base con el mismo nombre y firma
        public override string ToString()
        {
            // se refiere a invocar la implementación del mismo método en la clase base de
            // la clase actual. En este contexto específico, base.ToString()
            // invoca el método ToString() definido en la clase base Shape.
            return $"{base.ToString()}" +
                   $"\n La figura es un Circulo" +
                   $"\n El valor del Radio es: {Radius}" +
                   $"\n El valor del Área es: {GetArea()}";
        }
    }
}