using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts
{
    public class FullTimeEmployee : Employee
    {
        //creando propiedades con get y set (puede ser leidas y modificada) de instancia publica
        public decimal Salary { get; set; }
    }
}