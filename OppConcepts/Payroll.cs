using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts
{
    public class Payroll : IPay
    {
        public string Description { get; set; }
        public List<Employee> Employees { get; set; }  // Lista de empleados incluidos en la nómina
        public int Id { get; set; }
        public Date PayrollDate { get; set; }


        public decimal GetPayment()  // Método virtual para obtener el salario, se sobrescribirá en las clases derivadas.
        {
            decimal total = 0;
            foreach (Employee employee in Employees)
            {
                total += employee.GetPayment(); // Suma los pagos de cada empleado
            }

            return total;
        }
        public override string ToString()
        {
            // Utiliza un StringBuilder para construir la representación de la nómina
            //es una clase en C# que permite construir cadenas de caracteres de manera eficiente.
            //En lugar de crear y manipular múltiples instancias de string
            StringBuilder sb = new StringBuilder();

            sb.Append("=========NÓMINA=========");// Agrega el encabezado

            sb.Append(Environment.NewLine); //Agrega una nueva línea al StringBuilder. Environment.NewLine
            sb.Append(Environment.NewLine);

            sb.Append($"Factura N°: {Id}");//Agrega el número de factura de la nómina al 

            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);

            sb.Append($"Fecha: {PayrollDate}");

            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);

            sb.Append(Description);

            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);

            // Agrega la información de cada empleado a la representación de la nómina
            decimal total = 0;
            foreach (Employee employee in Employees)
            {
                sb.Append(employee.ToString());// Agrega la representación de cada empleado
                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);
                total += employee.GetPayment(); // Suma el pago del empleado al total
            }

            sb.Append("=============================");
            sb.Append(Environment.NewLine);
            //en C# el C2 se utiliza para formatear un valor numérico como una moneda con dos dígitos decimales
            sb.Append($"TOTAL:................: {total:C2}");// Muestra el total de la nómina


            return sb.ToString(); // Devuelve la representación de la nómina como una cadena
        }
    }
}
