using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektCsharp
{
    class Quiz  //create class a story date about question and anwers 
    {
        private
        String question;
        string[] anwers;

        public String Question { get; set; }
        public String[] Anwers { get; set; }

        public Quiz()
        {

            Anwers = new String[4];

        }

    }
}
