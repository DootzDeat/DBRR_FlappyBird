using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FlappyBird
{
    public class Tube
    {
        public void DrawTube(PictureBox ptbTop, PictureBox ptbBottom)
        {
            ptbTop.BackColor = Color.Aqua;
            ptbTop.Location = new Point(800, 0);
            ptbTop.Size = new Size(100, 200);

            ptbBottom.BackColor = Color.Aqua;
            ptbBottom.Location = new Point(800, 400);
            ptbBottom.Size = new Size(100, 200);
        }
    }
}
