using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TemperaturileZilnice
{
    public class INREGISTRATORDETEMPERATURI
    {

        public List<INREGISTRARETEMPERATURI> INREGISTRARI = new List<INREGISTRARETEMPERATURI>();

        public INREGISTRATORDETEMPERATURI()
        { 
            
        }

        public void PRINTAREDATE(TextBox TB)
        {
            string S = " ";

            S = INREGISTRARI[0].TMP.TEMP.ToString();
            S += " ";
            S += INREGISTRARI[0].TMP.TIPGRADE.ToString();
            S += " ";
            S += INREGISTRARI[0].D.AN.ToString();
            S += " ";
            S += INREGISTRARI[0].D.LUNA.ToString();
            S += " ";
            S += INREGISTRARI[0].D.ZI.ToString();
            S += " ";
            S += INREGISTRARI[0].T.ORE.ToString();
            S += " ";
            S += INREGISTRARI[0].T.MINUTE.ToString();
            S += " ";
            S += INREGISTRARI[0].T.SECUNDE.ToString();
            S += " ";
            S += INREGISTRARI[0].T.MILISECUNDE.ToString();
            S += " ";

            TB.Text = S;

        



        }
    }
}
