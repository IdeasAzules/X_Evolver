using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_Evolvers
{
    public class UserAge
    {
        public void userAge(int years)
        {

            int age = 0;
            if (years < 0)
            {
                Console.WriteLine("Debe de capturar numeros positivos");
            }

            else

                if ((years < 1912) && (!(years >= 0 && years <= 9)))
            {
                Console.WriteLine("Edades fuera de la vida humana");
            }
            else
                if ((years > 1912))
            {
                age = 2017 - years;
                Console.WriteLine("Tú edad es:" + age);
            }
            //return age;
        }
    }
}

