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
        public double Radious { get; set; }

        // Implementación del método abstracto para calcular el área del círculo
        public override double GetArea()
        {
           // constante estática en la clase Math de.NET Framework que representa el valor de pi(π)
            return Math.PI * Math.Pow(Radious, 2);
            //es un método estático en la clase Math que se utiliza para elevar un número a una potencia determinada
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
                   $"\n El valor del Radio es: {Radious}" +
                   $"\n El valor del Área es: {GetArea()}";
        }
    }
}