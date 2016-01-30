using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjektCsharp
{
    class ReadFileTxt
    {


        private List<Quiz> quizs;
        public List<Quiz> Quizs
        {
            get;
            set;
        }
        public List<Quiz>  ReadFile()
        {
            List<Quiz> quiz = new List<Quiz>();
            
            int  valueLines=0, indexList=0;

            string path = "../../asset/pytania.txt";

            StreamReader sr = new StreamReader(path,Encoding.GetEncoding("ISO-8859-2")); // coding polish characters 
            string s;
            do
            {
                valueLines++;
                s = sr.ReadLine();
               
                switch (valueLines)
                {
                    case 1:
                        quiz.Add(new Quiz());
                        quiz[indexList].Question = s;
                        break;
                    case 2:
                        quiz[indexList].Anwers[0] = s;
                        break;
                    case 3:
                        quiz[indexList].Anwers[1] = s;
                        break;
                            case 4:
                        quiz[indexList].Anwers[2] = s;
                        break;
                    case 5:
                        quiz[indexList].Anwers[3] = s;
                        break;

                    default:
                        valueLines = 0;
                        indexList++;
                        break;
                }

  

            } while (s!=null);
            sr.Close();
            return quiz;
        }
        
    }
}
