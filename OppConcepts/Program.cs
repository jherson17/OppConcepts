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

    Employee emp3 = new CommissionEmployee
    {
        Birthdate = new Date(1994, 5, 11),
        Document = "444",
        Id = 4,
        Name = "Juan",
        Role = "Vendedor",
        CommisionPercentage = 0.2,
        TotalSalesValue = 90000000,
    };

    Employee emp4 = new ComissionBaseEmployee
    {
        Birthdate = new Date(1996, 5, 8),
        Document = "555",
        Id = 5,
        Name = "Erika",
        Role = "MTO",
        CommisionPercentage = 0.2,
        TotalSalesValue = 4000000,
        Salary = 1000000
    };

    // Crea una instancia de la clase Payroll para representar una nómina
    Payroll payroll = new Payroll
    {
        Description = "Pago Nómina Febrero",
        Id = 123,
        PayrollDate = new Date(2024, 2, 26),
        Employees = new List<Employee> { emp1, emp2, emp3, emp4 } // Establece la lista de empleados incluidos en la nómina
    };
    Console.WriteLine(payroll); // Imprime la información de la nómina en la consola

    Console.WriteLine("\n");


    Console.WriteLine("========Figuras==========");
    Console.WriteLine("=========================");
    Console.WriteLine("=========================");
    Console.WriteLine("\n");

    // Crea instancias de diferentes figuras geométricas: cuadrado, rectángulo y círculo
    Square square = new Square
    {
        Color = "Blue",
        Side = 5
    };

    Rectangle rectangle = new Rectangle
    {
        Color = "Red",
        Base = 4,
        Height = 8,
    };

    Circle circle = new Circle
    {
        Color = "Green",
        Radius = 7
    };

    List<Shape> shapes = new List<Shape>
    {
        square,
        rectangle,
        circle
    };


    Console.WriteLine("=========================");
    foreach (Shape shape in shapes)
    {

        Console.WriteLine(shape); // Imprime la representación de cadena de la figura en la consola

        if (shape is IDrawable)
        {
            // Obtiene el método "Draw" de la interfaz IDrawable utilizando reflexión
            MethodInfo method = typeof(IDrawable).GetMethod("Draw");
            // Invoca el método "Draw" en la figura y lo imprime en la consola
            Console.WriteLine(method.Invoke(shape, null));
        }

        switch (shape.Color)
        {// Establece el color de la consola basado en el color de la figuras
            case "Red": Console.ForegroundColor = ConsoleColor.Red; break;
            case "Green": Console.ForegroundColor = ConsoleColor.Green; break;
            case "Blue": Console.ForegroundColor = ConsoleColor.Blue; break;
        }

        Console.WriteLine(shape.Draw());// Dibuja la figura en la consola

        Console.ForegroundColor = ConsoleColor.White; // Restaura el color de la consola a blanco

        Console.WriteLine("=========================");
        Console.WriteLine("\n");
    }


}
catch (Exception ex)
{

    // Si se produce una excepción durante la ejecución del bloque try, captúrala y maneja el error aquí
    // Imprime el mensaje de la excepción en la consola
    Console.WriteLine(ex.Message);
}