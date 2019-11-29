using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перегрузка_операторов_танки_
{
    class Resalt
    {
       public int counter = 0;

       public string Result()
        {
            if (counter > 0)
                return "В ТАНКОВОМ БОЮ ПОБЕДИЛА КОМАНДА ТАНКОВ Т34\n";
            else
                return "В ТАНКОВОМ БОЮ ПОБЕДИЛА КОМАНДА ТАНКОВ Pantera\n";
        }
    }
}
