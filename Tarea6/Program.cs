using System;
using System.Collections.Generic;
using System.Diagnostics;

public static class Validador
{
    public static int LeerEntero(string mensaje, int min, int max)
    {
        int valor;
        while (true)
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out valor) && valor >= min && valor <= max)
            {
                return valor;
            }
            Console.WriteLine($"Dato invalido. Escribe un numero entre {min} y {max}");
        }
    }

    public static string LeerTexto(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            string texto = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                return texto;
            }
            Console.WriteLine("El texto no puede estar vacio");
        }
    }
}

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine();
            Console.WriteLine("===== TAREA 6: CODIGO SEGURO - EQUIPO 2 =====");
            Console.WriteLine("Integrantes: Mauricio Gabriel Terrazas Gomez, Johana Candida Granado Huarcaya");
            Console.WriteLine("1. Notas corregidas");
            Console.WriteLine("2. PIN y pendientes");
            Console.WriteLine("3. List vs LinkedList");
            Console.WriteLine("0. Salir");
            opcion = Validador.LeerEntero("Elige una opcion: ", 0, 3);

            switch (opcion)
            {
                case 1: Ejercicio1(); break;
                case 2: Ejercicio2(); break;
                case 3: Ejercicio3(); break;
                case 0: Console.WriteLine("Hasta luego"); break;
                default: Console.WriteLine("Opcion no valida"); break;
            }
        } while (opcion != 0);
    }

    // ========== MAURICIO ==========
    static void Ejercicio1()
    {
        int[] notas = new int[3];
        int suma = 0;

        for (int i = 0; i < 3; i++)
        {
            notas[i] = Validador.LeerEntero($"Nota {i + 1}: ", 0, 100);
            suma += notas[i];
        }

        double promedio = (double)suma / notas.Length;
        Console.WriteLine("Promedio: " + promedio.ToString("0.00"));
    }

    // ========== JOHANA ==========
    static void Ejercicio2()
    {
        string pin = Validador.LeerTexto("PIN: ");
        Console.WriteLine("Tu PIN " + new string('*', pin.Length) + " fue guardado");

        int cantidad = Validador.LeerEntero("Cuantos pendientes (0-3): ", 0, 3);

        Stack<string> pendientes = new Stack<string>();

        for (int i = 0; i < cantidad; i++)
        {
            string pendiente = Validador.LeerTexto($"Pendiente {i + 1}: ");
            pendientes.Push(pendiente);
        }

        if (pendientes.Count > 0)
            Console.WriteLine("Siguiente pendiente: " + pendientes.Pop());
        else
            Console.WriteLine("No hay pendientes");
    }

    // ========== JOHANA ==========
    static void Ejercicio3()
    {
        int cantidad = 50000;
        Stopwatch reloj;

        reloj = Stopwatch.StartNew();
        List<int> lista = new List<int>();
        for (int i = 0; i < cantidad; i++) lista.Insert(0, i);
        reloj.Stop();
        Console.WriteLine("List, insertar al inicio: " + reloj.ElapsedMilliseconds + " ms");

        reloj = Stopwatch.StartNew();
        LinkedList<int> enlazada = new LinkedList<int>();
        for (int i = 0; i < cantidad; i++) enlazada.AddFirst(i);
        reloj.Stop();
        Console.WriteLine("LinkedList, insertar al inicio: " + reloj.ElapsedMilliseconds + " ms");

        reloj = Stopwatch.StartNew();
        List<int> listaFinal = new List<int>();
        for (int i = 0; i < cantidad; i++) listaFinal.Add(i);
        reloj.Stop();
        Console.WriteLine("List, insertar al final: " + reloj.ElapsedMilliseconds + " ms");

        reloj = Stopwatch.StartNew();
        LinkedList<int> enlazadaFinal = new LinkedList<int>();
        for (int i = 0; i < cantidad; i++) enlazadaFinal.AddLast(i);
        reloj.Stop();
        Console.WriteLine("LinkedList, insertar al final: " + reloj.ElapsedMilliseconds + " ms");
    }
}