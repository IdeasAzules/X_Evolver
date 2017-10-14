using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_Evolvers
{
    class Program
    {
        static void Main(string[] args)
        {

            Print1_100 Number = new Print1_100();
            Print1_100 Number2 = new Print1_100();
            Print1_100 Nmber3 = new Print1_100();


            Number.printNumber();
            Number2.printNumber5();

            Console.WriteLine("\n \n");
            Console.WriteLine("Captura el multiplicador");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Captura el mensaje por el que vas a sustituir el número");
            string mensaje = Console.ReadLine();
            Nmber3.printAnyMultiple(n, mensaje);
            Console.ReadLine();


            Console.WriteLine("\n \n");
            Console.WriteLine("Captura el año de nacimeinto");
            int years = 0;
            try
            {

                years = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);


            }
            UserAge ageuser = new UserAge();
            Console.WriteLine("Tú tienes:" + ageuser.userAge(years) + " años");
            Console.ReadKey();


            int[] arr1 = new int[6];
            arr1[0] = 4;
            arr1[1] = 5;
            arr1[2] = 7;
            arr1[3] = 9;
            arr1[4] = 10;
            arr1[5] = 34;
            int[] arr2 = new int[6];
            arr2[0] = 1;
            arr2[1] = 3;
            arr2[2] = 6;
            arr2[3] = 8;
            arr2[4] = 32;
            arr2[5] = 33;
            Matrix array = new Matrix();
            //for (int k = 0; k < 13; k++)
            //{
            /*Console.WriteLine("Arreglo en Orden " + "[" +k+"]" +*/
            array.matrix(arr1, arr2);
            //}
            Console.ReadKey();
        }
    }
}
