using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//para debuguear solo ve a la izquierda del todo donde se ve
//el codigo mira que te saldran unos circulos cone so te vas a ayudar gracias a que cuando suceda un error te lo va a mostrar
namespace OppConcepts
{//hay que cambiar de internal a public
    public class Date
    {
        // Variables de instancia privadas para almacenar el año, mes y día
        private int _year;
        private int _month;
        private int _day;

        // Constructor de la clase Date
        public Date(int year, int month, int day)
        {
            // Asigna los valores de los parámetros a las variables de instancia
            _year = year;
            _day = CheckDay(day, month, year); // Llama al método para validar el día
            _month = CheackMonth(month); // Llama al método para validar el mes
        }

        // Método privado para validar el día
        private int CheckDay(int day, int month, int year)
        {
            // Array que contiene la cantidad de días por cada mes
            int[] daysPerMonths = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Verifica si el día es 29 de febrero en un año bisiesto
            if (month == 2 && day == 29)
            {
                if (IsLeapYear(year)) // Verifica si el año es bisiesto
                {
                    return day; // Retorna el día válido
                }
            }

            // Verifica si el día está dentro del rango válido para el mes
            if (day > 0 && day <= daysPerMonths[month])
            {
                return day; // Retorna el día válido
            }

            // Lanza una excepción si el día es inválido
            throw new InvalidDateException($"Día inválido: {day}");
        }

        // Método privado para verificar si un año es bisiesto
        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);

        }

        // Método privado para validar el mes
        private int CheackMonth(int month)
        {
            // Verifica si el mes está en el rango válido (entre 1 y 12)
            if (month >= 1 && month <= 12)
            {
                return month; // Retorna el mes válido
            }

            // Lanza una excepción si el mes es inválido
            throw new InvalidDateException($"Mes inválido: {month}");
        }

        // Método ToString para representar la fecha como una cadena
        //override = La palabra clave override se utiliza en C# para indicar que un método en una clase derivada
        //está reemplazando (o sobrescribiendo) un método de la clase base con el mismo nombre y firma
        public override string ToString()
        {
            return $"{_year}/{_month:00}/{_day:00}";
        }
    }
}