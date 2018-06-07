using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muscle
{
    public partial class pushup : Form
    {
        int click_cnt = 0;
        int goal_num = 30;

        private int theGameTick;
        private int theTick;
        private Font theFont;
        private Brush theBrush;
        private Pen thePen;
        private Brush theBrush_rect;

        public pushup()
        {
            InitializeComponent();

            theGameTick = 0;
            theTick = 0;
            timer1.Start();

            theFont = new Font("나눔고딕", 10);
            theBrush = new SolidBrush(Color.White);
            thePen = new Pen(Color.Red);
            theBrush_rect = new SolidBrush(Color.Red);

            game_result.Hide();
        }

        private void pushup_Load(object sender, EventArgs e)
        {
            pushup_btn.FlatStyle = FlatStyle.Flat;
            pushup_btn.FlatAppearance.BorderSize = 0;
            pushup_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            pushup_char.Load("pushup1.png");
            pushup_char.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pushup_Paint(object sender, PaintEventArgs e)
        {
            //timer 표시하자
            //theGameTick은 이상황에서 계속 0임, 안써줘됨
            int time = 10 - (theTick - theGameTick) / (1000 / timer1.Interval); //100초 제한, 100, 99, 98
            //String stringTime = string.Format("Time : {0:D2}", time);
            //e.Graphics.DrawString(stringTime, theFont, theBrush, 0, 10);
            //e.Graphics.DrawRectangle(thePen, 0, 0, time, 10);
            Rectangle rectangle = new Rectangle(10, 10, time * 10, 20);
            e.Graphics.FillRectangle(theBrush_rect, rectangle);

            if (time == -1)
            {
                timer1.Stop(); //타이머를 먼저 멈추고 메세지 박스 띄어야함
                game_result.Load("gameover.png");
                game_result.SizeMode = PictureBoxSizeMode.StretchImage;
                game_result.Show();
                pushup_btn.Enabled = false;
            }
        }

        private void pushup_btn_Click(object sender, EventArgs e)
        {
            click_cnt++;
            if (click_cnt % 2 != 0)
            {
                pushup_char.Load("pushup2.png");
                pushup_char.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (click_cnt % 2 == 0)
            {
                pushup_char.Load("pushup1.png");
                pushup_char.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (click_cnt == goal_num)
            {
                timer1.Stop();
                game_result.Load("gameclear.png");
                game_result.SizeMode = PictureBoxSizeMode.StretchImage;
                game_result.Show();
                //MessageBox.Show("성공!");
                pushup_btn.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //50m/s -> 1초 증가
            //100번 호출 -> 5000m/s -> 5초 증가
            theTick++;
            Invalidate(); //새로그려라
        }
    }
}
