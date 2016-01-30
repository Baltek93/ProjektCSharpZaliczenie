using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjektCsharp
{
    class ControlGuessingGame
    {

        public void CheckPicture(List<ContainerPictures> containerPictures, int ItemAmountPicture) //checked picture with gradient to logo example Politechnika WITCH MECH etc.
        {
            
            containerPictures[ItemAmountPicture].CheckSelectImage = true;
            containerPictures[ItemAmountPicture].Picture.Image =containerPictures[ItemAmountPicture].Path;

        }

        
        public List<ContainerPictures> RandomImageValue() // random iamge to game field
        {
            List<ContainerPictures> controlslist = new List<ContainerPictures>();
            Random random = new Random();
            int valueRandom, value=0;
            List<int> temp = new List<int>();
            for (int i = 1; i < 17; i++)
            {
                temp.Add(i);           
            }
           
            while (temp.Count != 0)
            {
                valueRandom = random.Next(0, temp.Count);
                controlslist.Add(new ContainerPictures(temp[valueRandom]));
                controlslist[value].RandomImageValue = temp[valueRandom];
                PathofDateList(controlslist, value);
                temp.RemoveAt(valueRandom);
                value++;
            }

           
            controlslist = controlslist.OrderBy(o => o.RandomImageValue).ToList(); // random value and sorting 
            return controlslist;
        }

        private static void PathofDateList(List<ContainerPictures> controlslist, int amount)
        {
            switch (amount)
            {
                case 1:
                case 2:
                    controlslist[amount].Path = Properties.Resources.architektura;
                    controlslist[amount].CheckImage = 0;
                    break;
                case 3:
                case 4:
                    controlslist[amount].Path = Properties.Resources.inzynieraladowa;
                    controlslist[amount].CheckImage = 1;
                    break;
                case 5:
                case 6:
                    controlslist[amount].Path =  Properties.Resources.inzynierasrodowiska;
                    controlslist[amount].CheckImage = 2;
                    break;
                case 7:
                case 8:
                    controlslist[amount].Path = Properties.Resources.matematykifizykiinformatyki;
                    controlslist[amount].CheckImage = 3;
                    break;
                case 9:
                case 10:
                    controlslist[amount].Path = Properties.Resources.mech;
                    controlslist[amount].CheckImage = 4;
                    break;
                case 11:
                case 12:
                    controlslist[amount].Path = Properties.Resources.wieik;
                    controlslist[amount].CheckImage = 5;
                    break;
                case 13:
                case 14:
                    controlslist[amount].Path = Properties.Resources.witch;
                    controlslist[amount].CheckImage = 6;
                    break;
                case 15:
                case 0:
                    controlslist[amount].Path = Properties.Resources.pk;
                    controlslist[amount].CheckImage = 7;
                    break;
            }
        }
    }
}
