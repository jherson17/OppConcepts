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

    }
}