using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Validador
    {
        public bool esEntero(String a)
        {
            int b;
            return int.TryParse(a,out b);
        }

        public bool esDecimal(String a)
        {
            double b;
            return double.TryParse(a,out b);
        }


        public bool esEdad(String a)
        {
            if (esEntero(a))
            {
                if(int.Parse(a)<110&& int.Parse(a) > 0)
                {
                    return true;
                }
                else{
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
