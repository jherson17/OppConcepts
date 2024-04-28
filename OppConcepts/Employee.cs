using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts
{
    public class Employee
    {
        //creando propiedades con get y set (puede ser leidas y modificada) de instancia publica
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Document { get; set; }
        //del archivo Date estamos conectandolo con employeed
        //para usar todas sus variale y funciones ten en cuenta que no lo hereda
        public Date Birthdate { get; set; }

        //constructor sin parametros
        public Employee()
        {

        }
        //constructor con parametros
        //son métodos especiales que se utilizan para inicializar
        //objetos cuando se crean instancias de una clase
        public Employee(int id, string name, string role, string document, Date birthdate)
        {
            Id = id;
            Name = name;
            Role = role;
            Document = document;
            Birthdate = birthdate;
        }
        //devolver cierta informacion
        public override string ToString()
        {
            return $"Empleado: {Name} | Cargo: {Role} | Documento: {Document} | Fecha de nacimiento: {Birthdate}";
        }
    }
}