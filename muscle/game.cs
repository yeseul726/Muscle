using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        string name = "";
        string id = "";
        string password = "";
        int fat = 0;
        int muscle = 0;
        int fat_limit = 0;


        public game(string name, string id, string password)
        {
            InitializeComponent();

            //this.Invalidate();

            this.name = name;
            this.id = id;
            this.password = password;


            //MessageBox.Show(name + ", "+id + ", "+password);

            theGameTick = 0;
            theTick = 0;
            timer1.Start();

            theFont = new Font("나눔고딕", 10);
            theBrush = new SolidBrush(Color.White);
            thePen = new Pen(Color.Red);
            theBrush_rect = new SolidBrush(Color.Red);

            foodBtn_input_img();

            // 먼저 있는 회원인지 체크하고
            // Sql 연결정보(서버:127.0.0.1, 포트:3535, 아이디:sa, 비밀번호 : password, db : member)
            string connectionString = "Data Source = 14.63.199.209,5433; Initial Catalog = Mirim2018; User ID = mirim2018; Password = alfla@)!*";
            // Sql 새연결정보 생성
            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;
            sqlComm.CommandText = "select fat, muscle from Mus_member where email = @id";

            sqlComm.Parameters.AddWithValue("@id", id);

            sqlConn.Open();
            using (SqlDataReader SqlRs = sqlComm.ExecuteReader())
            {
                
                while (SqlRs.Read())
                {
                    //MessageBox.Show(string.Format("{0}", SqlRs[0].ToString()));
                    //MessageBox.Show(SqlRs[0].ToString());
                    //MessageBox.Show(SqlRs[1].ToString());
                    
                    fat = Int32.Parse(SqlRs[0].ToString());
                    muscle = Int32.Parse(SqlRs[1].ToString());
                    fat_limit = muscle / fat;
                    //MessageBox.Show(fat_limit.ToString());

                }
            }
            sqlConn.Close();

            //근육량, 지방량 표시

            var gcd = GCD(muscle, fat);
            string Ratio = string.Format("{0}:{1}", muscle / gcd, fat / gcd);

            //근육량:지방량 비율로 나타내기
            //MessageBox.Show(Ratio);
            ratio.Text = Ratio;

            //Amount_muscle.Text = muscle.ToString();
            //.Text = fat.ToString();

            if (fat_limit < 0)
            {
                character.SizeMode = PictureBoxSizeMode.Zoom;
                character.Image = System.Drawing.Image.FromFile("men1.png");
            }
            else if(fat_limit >= 0 && fat_limit < 1)
            {
                character.SizeMode = PictureBoxSizeMode.Zoom;
                character.Image = System.Drawing.Image.FromFile("men2.png");
            }
            else if (fat_limit >= 1 && fat_limit < 2)
            {
                character.SizeMode = PictureBoxSizeMode.Zoom;
                character.Image = System.Drawing.Image.FromFile("men3.png");
            }
            else
            {
                character.SizeMode = PictureBoxSizeMode.Zoom;
                character.Image = System.Drawing.Image.FromFile("men4.png");
            }


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
      

        private void show_game(PictureBox button_name)
        {
            if(button_name.ImageLocation.Equals("fastfood1.png")) //햄버거. 팔굽혀펴기
            {
                //this.Hide();
                pushup pushup = new pushup(name, id, password);
                pushup.Show();
                //this.Close();
            }
            else if(button_name.ImageLocation.Equals("fastfood2.png")) //감자튀김. 아령
            {
                //this.Hide();
                dumbbell dumbbell = new dumbbell(name, id, password);
                dumbbell.Show();
                //this.Close();
            }
            else if(button_name.ImageLocation.Equals("fastfood3.png")) //아이스크림. 줄넘기
            {
                //this.Hide();
                jump_rope jump_rope = new jump_rope(name, id, password);
                jump_rope.Show();
                //this.Close();
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

        private void store_Click(object sender, EventArgs e)
        {
            store store = new store(name, id, password);
            store.Show();
        }

        public int GCD(int a, int b)

        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }
            if (a == 0)
                return b;
            else
                return a;
        }

    }
}
