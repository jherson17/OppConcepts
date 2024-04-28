﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts.Geometry
{
    //Square Hereda de Shape
    public class Square : Shape
    {
        // Propiedad para el lado del cuadrado
        public double Side { get; set; }
        // Implementación del método abstracto para calcular el área
        public override double GetArea()
        {
            return Side * Side;
        }
        // Sobrescritura del método ToString para proporcionar una representación de cadena personalizada
        //override = La palabra clave override se utiliza en C# para indicar que un método en una clase derivada
        //está reemplazando (o sobrescribiendo) un método de la clase base con el mismo nombre y firma
        public override string ToString()
        {
            // se refiere a invocar la implementación del mismo método en la clase base de
            // la clase actual. En este contexto específico, base.ToString()
            // invoca el método ToString() definido en la clase base Shape
            return $"{base.ToString()}" +
                   $"\n La figura es un Cuadrado" +
                   $"\n El valor de los lades es: {Side}" +
                   $"\n El valor del Área es: {GetArea()}";
        }
    }
}