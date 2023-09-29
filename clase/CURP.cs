using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.clase
{
    internal class CURP
    {
        public void DeterminarSexo(string curp, string year)
        {
            DateOnly fecha = DateOnly.ParseExact(year, "yy/MM/dd", CultureInfo.InvariantCulture);
        }
    }
}
