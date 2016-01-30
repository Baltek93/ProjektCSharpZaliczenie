using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektCsharp
{
    class ContainerPictures //class container to picture and pictureBoxs
    {
        private PictureBox picture;
        public PictureBox Picture { get; set; }
        private Byte checkImage;
        public Byte CheckImage { get; set; }
        private int randomImageValue;
        public int RandomImageValue
        {
            get; set;
        }

        private Boolean checkSelectkImage;
        private readonly Bitmap path;


        public Boolean CheckSelectImage { get; set; }
        public Bitmap Path { get; set; }
        public ContainerPictures(int RandomImageValue)
        {
            this.checkSelectkImage = false;
            this.randomImageValue = RandomImageValue;
            this.path = null;
        }
        public ContainerPictures()
        {
            this.checkSelectkImage = false;
            this.randomImageValue = 0;
            this.path = null;

        }
    }
}
