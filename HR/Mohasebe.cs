using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
Karmand karmand = new Karmand();
Rais rais = new Rais();
namespace HR
{
    class Mohasebe
    {
        public static double Salary (Karmand karmand)
        {
            double salary = 0;
            if (karmand is Rais)
            {
                Rais rais = (Rais)karmand;
                salary = rais.Sath * 6000000;
            }
            else
            {
                salary = 5000000;
            }
            return salary;
        }
    }
}
