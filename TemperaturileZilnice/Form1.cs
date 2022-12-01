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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public INREGISTRATORDETEMPERATURI RECORDS = new INREGISTRATORDETEMPERATURI();

        private void Form1_Load(object sender, EventArgs e)
        {
            RECORDS.INREGISTRARI.Add(new INREGISTRARETEMPERATURI(new TEMPERATURA(5,"CELSIUS"), new DATA(2020, 11, 16), new TIMP(16,17,0,0)));

            /*   RECORDS.INREGISTRARI.Add(
               new INREGISTRARETEMPERATURI(
                   new TEMPERATURA(5, "CELSIUS"), 
                   new DATA(2020, 11, 16), 
                   new TIMP(16, 17, 0, 0)
                   )
                   );
           */
            RECORDS.PRINTAREDATE(textBox1);
            
        }
    }
}
