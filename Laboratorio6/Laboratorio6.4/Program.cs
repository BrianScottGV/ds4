﻿
internal class Laboratorio64
{
    static void checkAge(int age)
    {
        if (age < 10)
        {
            throw new ArithmeticException("Acceso negado - no cumple con el criterio de edad");
        }
        else
        {
            Console.WriteLine("Acceso Concedido");
        }
    }

    static void Main(string[] args)
    {
        checkAge(15);
    }

}
