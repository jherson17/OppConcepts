using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts.Geometry
{
    public abstract class Shape
    {//shape significa Forma

        // Propiedad para el color de la forma
        public string Color { get; set; }
        // Método abstracto para obtener el área de la forma

        //Una clase abstracta es una clase que no puede ser instanciada directamente,
        //sino que sirve como una plantilla para otras clases que la heredan.
        //Se utiliza la palabra clave abstract antes de la palabra clave class para declarar una clase como abstracta
        public abstract double GetArea();
        // Sobrescritura del método ToString para proporcionar una representación de cadena
        //override = La palabra clave override se utiliza en C# para indicar que un método en una clase derivada
        //está reemplazando (o sobrescribiendo) un método de la clase base con el mismo nombre y firma
        public override string ToString()
        {
            return $" La Figura es de color: {Color}";
        }
    }
}