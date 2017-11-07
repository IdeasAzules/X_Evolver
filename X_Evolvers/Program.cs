using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_Evolvers
{
    class program
    {
        static void Main(string []args)
        {
            Console.WriteLine("Elige una opción\n"+
                "\n1.- Imprime los numeros del 1 al 100"+
                "\n2.- Recibe un año de nacimiento como un parámetro y devuelve la edad del usuario"+
                "\n3.- Recibe dos matrices"+
                "\n4.-Salir\n");

            string s1 = null;

            s1 = Console.ReadLine();

            switch(s1)
            {
                case "1":

                    Console.WriteLine("\n\n\n**********Imprime los numeros del 1 al 100**********\n");
                            Print1_100 obj = new Print1_100();
                            obj.printer();

                    Console.WriteLine("\n\n\n**********Para los múltiplos de 3 impresiones \'Fizz\' en lugar del número \nY Para los múltiplos de 5 impresiones \'Buzz\' en lugar del número**********\n");
                            Print1_100 obj1 = new Print1_100();
                            obj1.printNumber();

                    Console.WriteLine("\n\n\n**********Para múltiplos de tres y cinco impresiones \'FizzBuzz\'**********\n");
                            Print1_100 obj2 = new Print1_100();
                            obj2.printNumber5();
                    Console.WriteLine("\n\n\n**********Codificarlo considerando la extensibilidad (lo que significa que puede agregar fácilmente más multiplicadores).**********\n");
                            Print1_100 obj3 = new Print1_100();
                    Console.WriteLine("\n \n");
                    Console.WriteLine("Captura el multiplicador");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Captura el mensaje por el que vas a sustituir el número");
                    string mensaje = Console.ReadLine();
                    obj3.printAnyMultiple(n, mensaje);
                    Console.ReadLine();

                    break;
                case "2":
                    Console.WriteLine("\n\n\n**********Recibe un año de nacimiento como un parámetro y devuelve la edad del usuario**********\n");
                    UserAge obj4 = new UserAge();
                    Console.WriteLine("\n \n");
                    Console.WriteLine("Captura el año");
                    int an= int.Parse(Console.ReadLine());
                    obj4.userAge(an);
                            break;
                case "3":

                    Console.WriteLine("\n\n\n**********Codifique una función que reciba 2 matrices ordenadas como parámetro y fusiónelas en una matriz ordenada**********\n");
                    Matrix obj5 = new Matrix();
                    int valor=0;
                    
                    Console.WriteLine("\n \n");
                    Console.WriteLine("Captura el tamaño del vector (debe de ser 6 datos)");
                    int m;
                    m = int.Parse(Console.ReadLine());
                    
                    int [] a = new int[6];
                    Console.WriteLine("Captura los datos del vector");
                    for (int i=0; i<m; i++)
                    {
                        Console.Write("[" + i + "]=");
                        a[i] = valor= int.Parse(Console.ReadLine()); 
                        
                    }

                    //a[0] = 4;
                    //a[1] = 5;
                    //a[2] = 7;
                    //a[3] = 9;
                    //a[4] = 10;
                    //a[5] = 34;
                    
                    int[] b = new int[6];
                    int valor1;
                    Console.WriteLine("Captura el tamaño del vector (debe de ser 6 datos)");
                    int s;
                    s = int.Parse(Console.ReadLine());
                    Console.WriteLine("Captura los datos del vector");
                    for (int j = 0; j < s; j++)
                    {
                        Console.Write("[" + j + "]=");
                        b[j] = valor1 = int.Parse(Console.ReadLine());

                    }
                    //b[0] = 1;
                    //b[1] = 3;
                    //b[2] = 6;
                    //b[3] = 8;
                    //b[4] = 32;
                    //b[5] = 33;
                    obj5.matrix(a, b);
                    Console.ReadKey();
                    break;
                case "4":
                    Console.ReadKey();
                    break; 
                default:
                    Console.WriteLine("No se a seleccionado una opcion");
                    break;
            }
            Console.Read();
        }
    }
}
