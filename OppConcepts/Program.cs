using OppConcepts;// Importa el espacio de nombres OppConcepts que contiene
using OppConcepts.Geometry;
using System.Reflection;
try
{
    Console.WriteLine("=======Empleados=========");
    Console.WriteLine("=========================");
    Console.WriteLine("=========================");
    Console.WriteLine("\n");

    //creacion de una instancia de la clase 
    Date date = new Date(2022, 5, 15);

    // Crea una instancia de la clase FullTimeEmployee para representar un empleado a tiempo completo (emp1)
    Employee emp1 = new FullTimeEmployee
    {
        Birthdate = date,
        Document = "222",
        Id = 2,
        Name = "Ana",
        Role = "CMO",
        Salary = 3500000
    };
    // Crea una instancia de la clase PartialTimeEmployee para representar un empleado a tiempo parcial (emp2)
    Employee emp2 = new PartialTimeEmployee
    {
        Birthdate = new Date(1995, 5, 13),
        Document = "333",
        Id = 3,
        Name = "Jhon",
        Role = "COO",
        Hours = 40,
        HourValue = 95000.5M
    };

    // Crea una instancia de la clase Payroll para representar una nómina
    Payroll payroll = new Payroll
    {
        Description = "Pago Nómina Febrero",
        Id = 123,
        PayrollDate = new Date(2024, 2, 26),
        Employees = new List<Employee> { emp1, emp2 } // Establece la lista de empleados incluidos en la nómina
    };
    Console.WriteLine(payroll); // Imprime la información de la nómina en la consola

    Console.WriteLine("\n");



    // Creación de una instancia de la clase 
    Square square = new Square
    {
        Color = "Blue",
        Side = 5
    };
    // Creación de una instancia de la clase 
    Rectangle rectangle = new Rectangle
    {
        Color = "Red",
        Base = 4,
        Height = 8,
    };
    // Creación de una instancia de la clase 
    Circle circle = new Circle
    {
        Color = "Green",
        Radious = 7
    };
    // Creación de una instancia de la clase 
    List<Shape> shapes = new List<Shape>
    {
        square,
        rectangle,
        circle
    };

    // las asigna a una lista de formas (List<Shape> shapes) y luego las imprime en la consola.
    //Como la lista shapes contiene instancias de clases que heredan de Shape, la variable shape puede contener cualquier objeto que sea una subclase de Shape
    Console.WriteLine("=========================");
    //foreach = Proporciona una forma simple y conveniente de recorrer todos los elementos de una colección sin necesidad de preocuparse por el índice o la cantidad de elementos en la colección.
    foreach (Shape shape in shapes)
    {
        //y llama cada derivada de toString de los heredado ToString (se llama polimosfirmo(herencia))
        Console.WriteLine(shape);
        Console.WriteLine("=========================");
        Console.WriteLine("\n");
    }
    //foreach (tipo elemento in colección)
    //{
        // Cuerpo del bucle: código que se ejecuta para cada elemento en la colección
    //}



}
catch (Exception ex)
{

    // Si se produce una excepción durante la ejecución del bloque try, captúrala y maneja el error aquí
    // Imprime el mensaje de la excepción en la consola
    Console.WriteLine(ex.Message);
}