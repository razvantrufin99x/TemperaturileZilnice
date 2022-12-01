using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemperaturileZilnice
{
    public class TIMP
    {
        public int ORE;
        public int MINUTE;
        public int SECUNDE;
        public int MILISECUNDE;

        public TIMP(int ore, int minute, int secunde, int milisecunde)
        {
            ORE = ore;
            MINUTE = minute;
            SECUNDE = secunde;
            MILISECUNDE = milisecunde;
        }
    }
}
