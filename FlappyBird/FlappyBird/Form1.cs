using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            #region Properties
            GameBoardManagerment gameBoard;
            GamePlaySetting gameSetting;
            #endregion
            InitializeComponent();

            gameBoard = new GameBoardManagerment(panel1);
            gameBoard.DrawGameBoard();

            //gameSetting = new GamePlaySetting(panel2);
            //gameSetting.GameStarting();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
