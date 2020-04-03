using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FlappyBird
{
    public class Player
    {
        public void DrawPlayer(PictureBox ptb, int xaxis, int yaxis)
        {
            ptb.BackColor = Color.Red;
            ptb.Location = new Point(xaxis, yaxis);
            ptb.Size = new Size(30, 30);
        }
    }
}
