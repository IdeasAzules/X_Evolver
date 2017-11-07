using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_Evolvers
{
    public class Matrix
    {
        public void matrix(int[] arr1, int[] arr2)
        {

            List<int> merge = new List<int>();  //list declaration
            merge.AddRange(arr2);           //to use AddRange method for each array
            merge.AddRange(arr1);
            int[] z = merge.ToArray();//make the list a fix
            try
            {
                Console.Write("Convinación ordenado de los dos vectores:\n");
                for (int i = 0; i < 13; i++)
                {
                    //Sort the list and print the values.
                    Array.Sort(z);
                    Console.Write(" " + z[i] + " ");
                }
            }
            catch (Exception)
            {
               
                //Console.Write("Dato no valido");
            }




        }
    }
}

