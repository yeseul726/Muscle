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
    public partial class jump_rope : Form
    {
        int click_cnt = 0;
        int goal_num = 50;
        int get_fat;
        int get_muscle;

        private int theGameTick;
        private int theTick;
        private Font theFont;
        private Brush theBrush;
        private Pen thePen;
        private Brush theBrush_rect;

        string name = "";
        string id = "";
        string password = "";

        public jump_rope(string name, string id, string password)
        {
            InitializeComponent();

            theGameTick = 0;
            theTick = 0;
            timer1.Start();
            this.name = name;
            this.id = id;
            this.password = password;

            theFont = new Font("나눔고딕", 10);
            theBrush = new SolidBrush(Color.White);
            thePen = new Pen(Color.Red);
            theBrush_rect = new SolidBrush(Color.Red);

            /*count_label.BackColor = Color.Transparent;
            count_label.Parent = this;*/

            /*count_label.Parent = count_bg;
            count_label.BackColor = Color.Transparent;
            count_label.BringToFront();*/

            game_result.Hide();

            Random rand = new Random();
            get_muscle = rand.Next(50, 101); //50~100 사이 랜덤 근육량
            get_fat = rand.Next(50, 61); // 50~60 랜덤 지방량
        }


        private void jump_rope_Load(object sender, EventArgs e)
        {
            jump.FlatStyle = FlatStyle.Flat;
            jump.FlatAppearance.BorderSize = 0;
            jump.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            jump_char.Load("jumprope1.png"); 
            jump_char.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        
        private void jump_rope_Paint(object sender, PaintEventArgs e)
        {
            //timer 표시하자
            //theGameTick은 이상황에서 계속 0임, 안써줘됨
            int time = 10 - (theTick - theGameTick) / (500 / timer1.Interval); //100초 제한, 100, 99, 98
            //String stringTime = string.Format("Time : {0:D2}", time);
            //e.Graphics.DrawString(stringTime, theFont, theBrush, 0, 10);
            //e.Graphics.DrawRectangle(thePen, 0, 0, time, 10);
            Rectangle rectangle = new Rectangle(10, 10, time * 10, 20);
            e.Graphics.FillRectangle(theBrush_rect, rectangle);

            if (time == 0)
            {
                timer1.Stop(); //타이머를 먼저 멈추고 메세지 박스 띄어야함
                game_result.Load("gameover.png");
                game_result.SizeMode = PictureBoxSizeMode.StretchImage;
                game_result.Show();
                input_fat_result();
                jump.Enabled = false;
                result.Text = "지방량 " + get_fat + " 획득";
            }
        }

        private void jump_Click(object sender, EventArgs e)
        {
            click_cnt++;
            count_label.Text = (goal_num - click_cnt).ToString();
            if (click_cnt % 2 != 0)
            {
                jump_char.Load("jumprope2.png");
                jump_char.SizeMode = PictureBoxSizeMode.StretchImage;
            } else if (click_cnt % 2 == 0)
            {
                jump_char.Load("jumprope1.png");
                jump_char.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if(click_cnt == goal_num)
            {
                timer1.Stop();
                game_result.Load("gameclear.png");
                game_result.SizeMode = PictureBoxSizeMode.StretchImage;
                game_result.Show();
                //MessageBox.Show("성공!");
                input_muscle_result();
                jump.Enabled = false;
                result.Text = "근육량 " + get_muscle + " 획득";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //50m/s -> 1초 증가
            //100번 호출 -> 5000m/s -> 5초 증가
            theTick++;
            Invalidate(); //새로그려라
        }

        private void input_fat_result()
        {
            string fat = "";
            int member_fat = 0;

            // Sql 연결정보(서버:127.0.0.1, 포트:3535, 아이디:sa, 비밀번호 : password, db : member)
            string connectionString = "Data Source = 14.63.199.209,5433; Initial Catalog = Mirim2018; User ID = mirim2018; Password = alfla@)!*";
            // Sql 새연결정보 생성
            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;
            sqlComm.CommandText = "select fat from Mus_member where email=@id";
            sqlComm.Parameters.AddWithValue("@id", id);
            sqlConn.Open();
            using (SqlDataReader SqlRs = sqlComm.ExecuteReader())
            {
                while (SqlRs.Read())
                {
                    fat = SqlRs[0].ToString();
                    member_fat = Convert.ToInt32(fat);
                }
            }
            sqlConn.Close();

            try
            {
                //string connectionString = "Data Source = 14.63.199.209,5433; Initial Catalog = Mirim2018; User ID = mirim2018; Password = alfla@)!*";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd =
                        new SqlCommand("UPDATE Mus_member SET muscle=@muscle WHERE email=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@fat", member_fat + get_fat);

                        int rows = cmd.ExecuteNonQuery();

                        //rows number of record got inserted
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("안됨");
                //Log exception
                //Display Error message
            }
        }

        private void input_muscle_result()
        {
            string muscle = "";
            int member_muscle = 0;
            
            // Sql 연결정보(서버:127.0.0.1, 포트:3535, 아이디:sa, 비밀번호 : password, db : member)
            string connectionString = "Data Source = 14.63.199.209,5433; Initial Catalog = Mirim2018; User ID = mirim2018; Password = alfla@)!*";
            // Sql 새연결정보 생성
            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;
            sqlComm.CommandText = "select muscle from Mus_member where email=@id";
            sqlComm.Parameters.AddWithValue("@id", id);
            sqlConn.Open();
            using (SqlDataReader SqlRs = sqlComm.ExecuteReader())
            {
                while (SqlRs.Read())
                {
                    muscle = SqlRs[0].ToString();
                    member_muscle = Convert.ToInt32(muscle);
                }
            }
            sqlConn.Close();

            try
                {
                    //string connectionString = "Data Source = 14.63.199.209,5433; Initial Catalog = Mirim2018; User ID = mirim2018; Password = alfla@)!*";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd =
                            new SqlCommand("UPDATE Mus_member SET muscle=@muscle WHERE email=@id", conn))
                    {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@muscle", member_muscle + get_muscle);

                            int rows = cmd.ExecuteNonQuery();

                            //rows number of record got inserted
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("안됨");
                    //Log exception
                    //Display Error message
                }
        }
    }
}
