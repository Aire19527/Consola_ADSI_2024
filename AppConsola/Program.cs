
using AppConsola.Ejercicios.Barma.Logica;
using AppConsola.Logica;
using System;

namespace AppConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LogicBarma barma = new LogicBarma();
            barma.Barma();

            //POO pOO = new POO();
            ////pOO.AgregarInformacion();
            //pOO.VectorNumeros();

            //PersonasModel objPersona = new PersonasModel();
            //objPersona.Edad = 18;
            //objPersona.Nombre = "Roger";
            //objPersona.Sexo = "Masculino";

            //Console.WriteLine($"Nombre: {objPersona.Nombre}");
            //Console.WriteLine($"Edad: {objPersona.Edad}");
            //Console.WriteLine($"Sexo: {objPersona.Sexo}");


            //List<PersonasModel> personas = new List<PersonasModel>();
            //for( int i = 1; i <= 10; i++ )
            //{
            //    Random rnd = new Random();
            //    PersonasModel persona = new PersonasModel()
            //    {
            //        Edad = rnd.Next(10,50),
            //        Sexo="Masculino",
            //        Nombre="Persona "+i
            //    };
            //    personas.Add(persona);  
            //}

            //foreach( var persona in personas )
            //{
            //    Console.WriteLine($"Nombre: {persona.Nombre} Edad: {persona.Edad} Sexo: {persona.Sexo}");

            //}


            //GeneradorNumerosPrimos();
        }

        static void Ejercicio_Palabra_Mas_Larga()
        {
            Console.WriteLine("*** Señor usuario, por favor digita 2 palabras ***");
            Console.WriteLine("Escriba la palabra 1");
            string palabra_1 = Console.ReadLine();
            Console.WriteLine("Escriba la palabra 2");
            string palabra_2 = Console.ReadLine();

            int cantidad_1 = palabra_1.Length;
            int cantidad_2 = palabra_2.Length;

            if (cantidad_1 > cantidad_2)
            {
                int resta = cantidad_1 - cantidad_2;
                Console.WriteLine($"La palabra: {palabra_1} tiene  {resta}  más letras que  {palabra_2}");
            }
            else if (cantidad_2 > cantidad_1)
            {
                int resta_2 = cantidad_2 - cantidad_1;
                Console.WriteLine($"La palabra: {palabra_2} tiene  {resta_2}  más letras que  {palabra_1}");
            }
            else
            {
                Console.WriteLine("Las dos palabras tienene el mismo largo");
            }
        }


        static void Ejercicio_IMC()
        {
            Console.WriteLine("** Sistema de IMC **");
            Console.WriteLine("Por favor digita su peso:");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor digita su estatura:");
            double estatura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor digita su edad:");
            int edad = Convert.ToInt32(Console.ReadLine());

            double imc = peso / (estatura * estatura);

            if (edad < 45 && imc < 22)
            {
                Console.WriteLine("IMC bajo");
            }
            else if ((edad < 45 && imc >= 22) || (edad > 45 && imc < 22))
            {
                Console.WriteLine("IMC medio");
            }
            else if (edad > 45 && imc >= 22)
            {
                Console.WriteLine("IMC alto");
            }
        }


        static void WhileContrasenia()
        {
            //Crea un programa que pida al usuario una contraseña, de forma repetitiva
            //mientras que no introduzca “asdasd”. Cuando finalmente escriba la contraseña correcta,
            //se le dirá “Bienvenido” y terminará el programa.

            Console.WriteLine("Señor usuario, por favor introduzca la contraseña");
            int opt = 1;
            while (opt == 1)
            {
                string contrasenia = Console.ReadLine();
                if (contrasenia.ToLower() == "asdasd")
                {
                    Console.WriteLine("Bienvenido");
                    opt = 0;
                }
                else
                {
                    Console.WriteLine("por favor introduzca la contraseña correcta");
                }
            }

            Console.WriteLine("salió del bucle while");
        }


        static void EjercicioWhile2()
        {
            //un usuario quiere sumar 2 números, pero los números deben ser mayor a 10,
            //para poder realizar la suma.
            Console.WriteLine("Señor usuario, por favor digita 2 números.");
            Console.WriteLine("número 1");
            int numero_1 = Convert.ToInt32(Console.ReadLine());
            if (numero_1 < 10)
            {
                while (numero_1 < 10)
                {
                    Console.WriteLine("El número debe ser mayor a 10");
                    Console.WriteLine("digita el número 1");
                    numero_1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("número 2");
            int numero_2 = Convert.ToInt32(Console.ReadLine());
            if (numero_2 < 10)
            {
                while (numero_2 < 10)
                {
                    Console.WriteLine("El número debe ser mayor a 10");
                    Console.WriteLine("digita el número 2");
                    numero_2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                }
            }

            int suma = numero_1 + numero_2;
            Console.WriteLine($"La suma es: {suma}");
        }

        //ejercicio 1  que lea 5 notas, y sacar el promedio de las notas,
        //si el promedio es mayor o igual a 10, mostrar el mensaje de aprobado,
        //y si es menor a 10, reprobado.
        static void EjercicioFor()
        {
            int opt = 1;
            while (opt == 1)
            {
                Console.Clear();
                Console.WriteLine("** Sistema de notas **");
                Console.WriteLine("1. Ingresar notas");
                Console.WriteLine("2. Salir");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    int sumaNota = 0;
                    for (int i = 1; i <= 5; i++)
                    {
                        Console.WriteLine($"Ingrese por favor nota {i}");
                        int nota = Convert.ToInt32(Console.ReadLine());
                        sumaNota = sumaNota + nota;
                    }

                    double promedio = (sumaNota / 5);
                    if (promedio >= 10)
                        Console.WriteLine("Aprobado, con un promedio de: " + promedio);
                    else
                        Console.WriteLine("Reprobado, con un promedio de: " + promedio);

                    Console.WriteLine("Presione una tecla para continuar.");
                    Console.ReadKey();
                }
                else
                {
                    opt = 2;
                    Console.WriteLine("Saliendo del sistema");
                }
            }
        }

        static void EjercicioDoWhile()
        {
            bool esEntero = false;


            int count = 0;
            do
            {
                count++;
                Console.WriteLine($"{count} Es entero: " + esEntero);

                if (count == 10)
                {
                    esEntero = true;
                }

            } while (!esEntero);

        }

        static void GeneradorNumerosPrimos()
        {
            Console.WriteLine("");

            int opt = 1;
            while (opt == 1)
            {
                Console.Clear();
                Console.WriteLine("** Generador de números enteros **");
                Console.WriteLine("1. Ingresar números");
                Console.WriteLine("** Presione cualquier número para salir distinto de 1. **");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    Console.Write("Escriba un número: ");
                    int numero = Convert.ToInt32(Console.ReadLine());

                    if (numero > 1)
                    {
                        for (int n = 1; n <= numero; n++)
                        {
                            double raizCuadrada = Math.Sqrt(n);
                            double numeroEnteroDivisor = Math.Floor(raizCuadrada);
                            if (numeroEnteroDivisor != raizCuadrada)
                            {
                                if (numeroEnteroDivisor == 1)
                                {
                                    double result_1 = (n / 1);
                                    double division_1 = Math.Floor(result_1);

                                    double result_2 = (n / n);
                                    double division_2 = Math.Floor(result_2);

                                    if (result_1 == division_1 && result_2 == division_2)
                                        Console.WriteLine($"El número {n} es primo.");

                                }
                                else
                                {
                                    int count = 0;
                                    for (int i = 2; i <= numeroEnteroDivisor; i++)
                                    {
                                        double resultado = (double)n / i;
                                        double division = Math.Floor(resultado);
                                        if (division == resultado)
                                        {
                                            count++;
                                        }
                                    }

                                    if (count == 0)
                                        Console.WriteLine($"El número {n} es primo.");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Señor usuario, debe ingresar un número entero positivo.");
                    }

                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("** Saliendo del sistema **");
                    opt = 2;
                }
            }
        }

    }
}

