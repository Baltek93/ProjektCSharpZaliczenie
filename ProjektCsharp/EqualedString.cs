using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektCsharp
{
    class EqualedString
    {
        public static void EquledString(TextBox[] tx)
        {
            for (int i = 0; i <= 5; i++)
            {
                tx[i].BackColor = System.Drawing.Color.Red;
            }
            if(tx[0].Text.Equals("2"))
            {
                tx[0].BackColor = System.Drawing.Color.Blue;
            }
          

            if (tx[1].Text.Equals("3*x^2"))
            {
                tx[1].BackColor = System.Drawing.Color.Blue;
            }
         
            if (tx[2].Text.Equals("cosx"))
            {
                tx[2].BackColor = System.Drawing.Color.Blue;
            }
            if (tx[3].Text.Equals("e^x"))
            {
                tx[3].BackColor = System.Drawing.Color.Blue;
            }
            if (tx[4].Text.Equals("1/x"))
            {
                tx[4].BackColor = System.Drawing.Color.Blue;
            }
            if (tx[5].Text.Equals("-sinx"))
            {
                tx[5].BackColor = System.Drawing.Color.Blue;
            }
          
        }
        
    }
}
