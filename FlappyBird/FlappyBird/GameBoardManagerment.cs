using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace FlappyBird
{
    public delegate void PlayerMoving(PictureBox ptb, int xaxis, int yaxis);
    
    public class GameBoardManagerment
    {
        #region Properties
        private Panel gameBoard;
        private static int xaxis = 30;
        private static int yaxis = 0;

        PictureBox ptbPlayer = new PictureBox();
        Timer playerTime = new Timer();
        Timer tubeTime = new Timer();
        PictureBox ptbTubeTop = new PictureBox();
        PictureBox ptbTubeBottom = new PictureBox();
        Button button = new Button();
        Tube tube = new Tube();
        GamePlay gamePlay = new GamePlay();
        Player player = new Player();
        GamePlaySetting gamePlaySetting = new GamePlaySetting();
        public Panel GameBoard { get => gameBoard; set => gameBoard = value; }
        #endregion



        #region Initialize
        public GameBoardManagerment(Panel gameBoard)
        {
            this.gameBoard = gameBoard;
        }
      
        
        #endregion

        #region Methods
        public void DrawGameBoard()
        {
            

            player.DrawPlayer(ptbPlayer, xaxis, yaxis);
            gameBoard.Click += EventPlayerMove;
            playerTime.Enabled = true;
            playerTime.Tick += EventGameStart;
            tubeTime.Enabled = true;
            tubeTime.Tick += EventTubeMove;
            tube.DrawTube(ptbTubeTop, ptbTubeBottom);
            gameBoard.Controls.Add(ptbPlayer);
            gameBoard.Controls.Add(ptbTubeTop);
            gameBoard.Controls.Add(ptbTubeBottom);
            
            

            //gamePlaySetting.GameStartingButton(button);
            //GameBoard.Controls.Add(button);
            //button.Click += EventGameStart;        
        }
        
        public void EventPlayerMove (object sender, EventArgs e)
        {
            //playerTime.Enabled = false;
            gamePlay.PlayerMove(ptbPlayer, 50);
            //playerTime.Enabled = true;

        }

        public void EventTubeMove(object sender, EventArgs e)
        {
            if (ptbTubeTop.Right == 0)
            {
                int x;
                Random r = new Random();
                x = r.Next(50, 300);
                ptbTubeTop.Size = new Size(100, x);
                ptbTubeBottom.Location = new Point(800, 100+x);
                ptbTubeTop.Left = 800;
                ptbTubeBottom.Left = 800;
            }

            else {
                gamePlay.TubeMove(ptbTubeBottom, 20);
                gamePlay.TubeMove(ptbTubeTop, 20);
            } 
        }
        public void GameOver()
        {
            if (ptbPlayer.Bounds.IntersectsWith(ptbTubeTop.Bounds))
            {
                
                playerTime.Enabled = false;
                tubeTime.Enabled = false;
            }
            if (ptbPlayer.Bounds.IntersectsWith(ptbTubeBottom.Bounds))
            {

                playerTime.Enabled = false;
                tubeTime.Enabled = false;
                MessageBox.Show("Game Over");
            }
        }
        public void EventGameStart(object sender, EventArgs e)
        {   if(ptbPlayer.Top <= 300)
            {
                //MessageBox.Show("Thanh dep trai vo dich");
                gamePlay.Gravity(ptbPlayer, 10);
            }
            GameOver();
        }


        #endregion

    }
   

}
