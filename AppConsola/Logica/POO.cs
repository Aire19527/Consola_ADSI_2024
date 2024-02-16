using AppConsola.Helpers;
using AppConsola.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppConsola.Logica
{
    public class POO
    {
        public void AgregarInformacion()
        {
            //ctrl + L =>auto completado
            PersonaModel_Normal persona = new PersonaModel_Normal();
            Console.WriteLine("Escriba el nombre");
            persona.Nombre = Console.ReadLine();
            Console.WriteLine("Escriba el edad");
            persona.Edad = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("** Mostrar información **");
            Console.WriteLine($"Hola, mi nombre {persona.Nombre}, tengo {persona.Edad} años, y soy {persona.Sexo}");

        }

        public void PoblarPersonas()
        {
            List<PersonaModel_Normal> personas = new List<PersonaModel_Normal>();

            Random rnd = new Random();
            for (int i = 1; i <= 100; i++)
            {
                PersonaModel_Normal persona = new PersonaModel_Normal()
                {
                    Nombre = $"Persona {i}",
                    Edad = rnd.Next(10, 101),
                    Estatura = rnd.Next(10, 200),
                    Sexo = Helper.ValidarSexo(i)
                };
                personas.Add(persona);
                //Console.WriteLine($"Nombre: {persona.Nombre} - Edad: {persona.Edad} - Estatura: {persona.Estatura} - Sexo: {persona.Sexo}");
            }

            Console.WriteLine("Cantidad de personas: " + personas.Count);

            foreach (var persona in personas)
            {
                Console.WriteLine($"Nombre: {persona.Nombre} - Edad: {persona.Edad} - Estatura: {persona.Estatura} - Sexo: {persona.Sexo}");
            }
        }

        //Realizar un programa que defina un vector llamado “vector_numeros”
        //de 10 enteros, a continuación lo inicialice con valores aleatorios (del 1 al 10)
        //y posteriormente muestre en pantalla cada elemento del vector junto con su cuadrado
        //y su cubo.

        public void VectorNumeros()
        {
            List<int> vectorNumeros = new List<int>();
            Random rnd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int numero= rnd.Next(1,11);
                vectorNumeros.Add(numero);  
            }

            //ordenar de menor a mayor
            Console.WriteLine("Ordernade forma ascendente");
            foreach (var item in vectorNumeros.OrderBy(x => x))
            {
                int cuadrado = item * item;
                int cubo = item * item * item;
                Console.WriteLine($"Numero: {item} - Cuadrado:{cuadrado} - Cubo: {cubo}");
            }
            Console.WriteLine("");
            Console.WriteLine("Ordernade forma decendente"); 
            //ordenar de mayor a menor
            foreach (var item in vectorNumeros.OrderByDescending(x=>x))
            {
                int cuadrado = item * item;
                int cubo = item * item * item;
                Console.WriteLine($"Numero: {item} - Cuadrado:{cuadrado} - Cubo: {cubo}");
            }
            Console.WriteLine("");
            Console.WriteLine("Filtro");
            Console.WriteLine("");
            List<int> nuevosNumeros = vectorNumeros.Where(x => x == 5).ToList();
           if(nuevosNumeros.Any())
            {
                Console.WriteLine($"Hay {nuevosNumeros.Count} números en la lista con el número 5");
            }

        }


    }
}
