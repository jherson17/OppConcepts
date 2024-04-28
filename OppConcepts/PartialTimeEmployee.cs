using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts
{
    //PartialTimeEmployee Hereda de Employee
    public class PartialTimeEmployee : Employee
    {
        //creando propiedades con get y set (puede ser leidas y modificada) de instancia publica
        public int Hours { get; set; }
        public decimal HourValue { get; set; }

        // Implementación del método abstracto GetPayment para calcular el pago de un empleado a tiempo parcial
        public override decimal GetPayment()
        {
            return Hours * HourValue; // Calcula el pago multiplicando las horas trabajadas por el valor de la hora
        }
        public override string ToString()
        {
            // Utiliza la implementación de ToString de la clase base (Employee) y agrega información adicional
            return base.ToString() +
                $"{Environment.NewLine} Horas trabajadas......: {Hours}" +
                $"{Environment.NewLine} Valor hora............: {HourValue:C2}" +
                $"{Environment.NewLine} -----------------------------------" +
                $"{Environment.NewLine} Pago..................: {GetPayment():C2}";
        }
    }
}