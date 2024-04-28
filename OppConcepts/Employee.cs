using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts
{
    // Definición de la clase abstracta Employee que implementa la interfaz IPay
    public abstract class Employee : IPay
    {
        //creando propiedades con get y set (puede ser leidas y modificada) de instancia publica
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Document { get; set; }
        //del archivo Date estamos conectandolo con employeed
        //para usar todas sus variale y funciones ten en cuenta que no lo hereda
        public Date Birthdate { get; set; }

        public abstract decimal GetPayment();// Método abstracto para calcular el pago del empleado
       
        public override string ToString()// Método ToString para representar un empleado como una cadena
        {
            return $" Empleado..............: {Name} " +
                $"{Environment.NewLine} Cargo.................: {Role} " +
                $"{Environment.NewLine} Documento.............: {Document} " +
                $"{Environment.NewLine} Fecha de nacimiento...: {Birthdate}";
        }
    }
}