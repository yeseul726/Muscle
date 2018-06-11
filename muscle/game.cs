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
    public partial class game : Form
    {
        private int theGameTick;
        private int theTick;
        private Font theFont;
        private Brush theBrush;
        private Pen thePen;
        private Brush theBrush_rect;


        public game()
        {
            InitializeComponent();

            theGameTick = 0;
            theTick = 0;
            timer1.Start();

            theFont = new Font("나눔고딕", 10);
            theBrush = new SolidBrush(Color.White);
            thePen = new Pen(Color.Red);
            theBrush_rect = new SolidBrush(Color.Red);

            character.SizeMode = PictureBoxSizeMode.Zoom;
            character.Image = System.Drawing.Image.FromFile("men3.png");

            foodBtn_input_img();

        }

        private void foodBtn_input_img()
        {
            PictureBox[] food_btn = new PictureBox[3];
            food_btn[0] = food_btn1;
            food_btn[1] = food_btn2;
            food_btn[2] = food_btn3;

            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                int game_number = rand.Next(1, 4);
                food_btn[i].Load("fastfood" + game_number + ".png");
                food_btn[i].SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void game_Paint(object sender, PaintEventArgs e)
        {
            int time = 5 - (theTick - theGameTick) / (1000 / timer1.Interval); //5초짜리 타이머
            /*Rectangle rectangle = new Rectangle(10, 10, time * 10, 20);
            e.Graphics.FillRectangle(theBrush_rect, rectangle);*/
            
            if (time == -1) //5초 타이머가 다 끝나면
            {
                timer1.Stop(); //타이머를 멈춰주고
                foodBtn_input_img(); //각 PictureBox(게임 플레이 버튼)에 랜덤으로 새로운 이미지를 넣어준 다음 (랜덤으로 새로운 게임 불러오는 과정)
                theGameTick = 0; //타이머 초기화
                theTick = 0; //타이머 초기화
                timer1.Start(); //타이머 재시작 (이 과정이 계속 반복됨)
            }
        }

        private void pictureBox1_Click(object sender, PaintEventArgs e)
        {
            
        }
        /*private int ProgressMinimum = 10;
        private int ProgressMaximum = 100;
        private int ProgressValue = 40;

        // Show the progress.
        private void picProgress_Paint(object sender, PaintEventArgs e)
        {
            // Clear the background.
            e.Graphics.Clear(picProgress.BackColor);

            // Draw the progress bar.
            float fraction =
                (float)(ProgressValue - ProgressMinimum) /
                (ProgressMaximum - ProgressMinimum);
            int wid = (int)(fraction * picProgress.ClientSize.Width);
            e.Graphics.FillRectangle(
                Brushes.LightGreen, 0, 0, wid,
                picProgress.ClientSize.Height);
        }*/

        private void show_game(PictureBox button_name)
        {
            if(button_name.ImageLocation.Equals("fastfood1.png")) //햄버거. 팔굽혀펴기
            {
                pushup pushup = new pushup();
                pushup.Show();
            }
            else if(button_name.ImageLocation.Equals("fastfood2.png")) //감자튀김. 아령
            {
                dumbbell dumbbell = new dumbbell();
                dumbbell.Show();
            }
            else if(button_name.ImageLocation.Equals("fastfood3.png")) //아이스크림. 줄넘기
            {
                jump_rope jump_rope = new jump_rope();
                jump_rope.Show();
            }
            else {
                MessageBox.Show("오류");
            }
        }

        private void food_btn1_Click(object sender, EventArgs e)
        {
            show_game(food_btn1);
        }

        private void food_btn2_Click(object sender, EventArgs e)
        {
            show_game(food_btn2);
        }

        private void food_btn3_Click(object sender, EventArgs e)
        {
            show_game(food_btn3);
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
