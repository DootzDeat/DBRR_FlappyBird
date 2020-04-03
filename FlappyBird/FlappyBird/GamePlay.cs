using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
namespace FlappyBird
{   
    public class GamePlay 
    {
        public event EventHandler OnPlayerMove;
        
        public void PlayerMove(PictureBox ptbPlayer, int speed)
        {   
            ptbPlayer.Top -= speed;
            //Thread.Sleep(50);
            //PlayerMove(ptbPlayer, speed);
        }
        public void Gravity (PictureBox gravity, int speed)
        {
            gravity.Top += speed;
            Thread.Sleep(50);
        }

        public void TubeMove(PictureBox ptbTube, int speed)
        {   
            ptbTube.Left -= speed;
            //Thread.Sleep(50);
            //TubeMove(ptbTube, speed);∟
        }
    }
}
