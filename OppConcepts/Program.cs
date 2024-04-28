using OppConcepts;// Importa el espacio de nombres OppConcepts que contiene
using OppConcepts.Geometry;
try
{
    Console.WriteLine("=======Empleados=========");
    Console.WriteLine("=========================");
    Console.WriteLine("=========================");
    Console.WriteLine("\n");
    // Intenta ejecutar el siguiente bloque de código

    //creacion de una instancia de la clase 
    Date date = new Date(2022, 5, 15);

    //creacion de una instancia de la clase fulltime 
    FullTimeEmployee emp2 = new FullTimeEmployee
    {
        Birthdate = date,
        Document = "222",
        Id = 2,
        Name = "Ana",
        Role = "CMO",
        Salary = 3500000
    };

    // Imprime la informacion del empleado
    Console.WriteLine( emp2 );

    // Imprime la informacion un empleado
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