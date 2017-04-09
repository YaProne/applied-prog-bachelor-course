using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs1
{
    public class line
    {
        public pont a;
        public void collection()
        {
            double k1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            a = new pont(k1, b1);
        }
    }
}
