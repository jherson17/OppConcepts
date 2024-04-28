using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts
{
       //FullTimeEmployee Hereda de Employee
    public class FullTimeEmployee : Employee
    {
        //creando propiedades con get y set (puede ser leidas y modificada) de instancia publica
        public decimal Salary { get; set; }

        // Implementación del método abstracto GetPayment para calcular el pago de un empleado a tiempo completo
        public override decimal GetPayment()
        {
            return Salary;// Devuelve el salario mensual del empleado
        }
        // Método ToString para representar un empleado a tiempo completo como una cadena
        public override string ToString()
        {
            // Utiliza la implementación de ToString de la clase base (Employee) y agrega información adicional
            return base.ToString() +
                 $"{Environment.NewLine} Salario...............: {Salary:C2}" +
                 $"{Environment.NewLine} -----------------------------------" +
                 $"{Environment.NewLine} Pago..................: {GetPayment():C2}";
        }
    }
}