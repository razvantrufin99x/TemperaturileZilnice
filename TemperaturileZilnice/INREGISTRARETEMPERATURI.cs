using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemperaturileZilnice
{
    public class INREGISTRARETEMPERATURI
    {
        public TEMPERATURA TMP;
        public DATA D;
        public TIMP T;

        public INREGISTRARETEMPERATURI(TEMPERATURA tmp, DATA d, TIMP t)
        {
            TMP = tmp;
            D = d;
            T = t;
        }
    }
}
