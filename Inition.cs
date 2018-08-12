using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inition
{
    class Inition
    {
        public int ScrH()
        {
            return Screen.PrimaryScreen.Bounds.Height;
        }

        public int ScrW()
        {
            return Screen.PrimaryScreen.Bounds.Width;
        }

        public int ScreenScale(int size)
        {
            return size * (ScrW() / 640);
        }
    }
}
