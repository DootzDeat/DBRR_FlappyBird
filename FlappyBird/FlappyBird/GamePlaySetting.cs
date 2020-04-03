using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FlappyBird
{
    public class GamePlaySetting
    {
        #region Properties
        private Panel gamePlaySetting;
        #endregion
        GamePlay gamePlay = new GamePlay();
        #region Initialize
        public GamePlaySetting()
        {

        }
        public GamePlaySetting(Panel gamePlaySetting)
        {
            this.gamePlaySetting = gamePlaySetting;
        }
        #endregion

        #region Methods
        public void GameStartingButton(Button button)
        {
            button.Name = "GameStart";
            button.Text = "GameStart";
            button.Location = new Point(300, 300);
            button.Size = new Size(90, 30);

        }
        
        #endregion

    }

}
