using OppConcepts;// Importa el espacio de nombres OppConcepts que contiene

try
{
    // Intenta ejecutar el siguiente bloque de código
    // Creación de una instancia de la clase Date con año 2022, día 5 y mes 15
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



}
catch (Exception ex)
{

    // Si se produce una excepción durante la ejecución del bloque try, captúrala y maneja el error aquí
    // Imprime el mensaje de la excepción en la consola
    Console.WriteLine(ex.Message);
}