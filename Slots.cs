using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kazik
{
    public partial class Slots : Form
    {
        public Slots()
        {
            InitializeComponent();
        }

        private Random rnd = new Random();

        int intLeftImgNum = 0;
        private void timerLeftSlot_Tick(object sender, EventArgs e)
        {
            intLeftImgNum = rnd.Next(0,4);
            pictureBoxLeftSlot.Image = imageListLeftSlot.Images[intLeftImgNum];
            if (intLeftImgNum == imageListLeftSlot.Images.Count - 1)
            {
                intLeftImgNum = 0;
            }
            else
            {
                intLeftImgNum++;
            }

        }

        int intMiddleImgNum = 0;
        private void timerMiddleSlot_Tick(object sender, EventArgs e)
        {
            intMiddleImgNum = rnd.Next(0,3);
            pictureBoxMiddleSlot.Image = imageListMiddleSlot.Images[intMiddleImgNum];
            if (intMiddleImgNum == imageListMiddleSlot.Images.Count - 1)
            {
                intMiddleImgNum = 0;
            }
            else
            {
                intMiddleImgNum++;
            }
        }

        int intRightImgNum = 0;
        private void timerRightSlot_Tick(object sender, EventArgs e)
        {
            intRightImgNum = rnd.Next(0,3);
            pictureBoxRightSlot.Image = imageListRightSlot.Images[intRightImgNum];
            if (intRightImgNum == imageListRightSlot.Images.Count - 1)
            {
                intRightImgNum = 0;
            }
            else
            {
                intRightImgNum++;
            }
        }

        private void Slots_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timerLeftSlot.Stop();
                timerMiddleSlot.Stop();
                timerRightSlot.Stop();
            }
        }
    }
}
