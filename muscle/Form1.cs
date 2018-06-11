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
    public partial class Form1 : Form
    {
        string name = "";
        string id = "";
        string password = "";

        int loginCheck = 0;

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            id = textBox1.Text;
        }


        public Form1()
        {
            InitializeComponent();
        }

        //로그인
        private void button1_Click(object sender, EventArgs e) // 로그인 버튼
        {
            // 먼저 있는 회원인지 체크하고
            // Sql 연결정보(서버:127.0.0.1, 포트:3535, 아이디:sa, 비밀번호 : password, db : member)
            string connectionString = "Data Source = 14.63.199.209,5433; Initial Catalog = Mirim2018; User ID = mirim2018; Password = alfla@)!*";
            // Sql 새연결정보 생성
            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;
            sqlComm.CommandText = "select name, email, password from Mus_member";
            sqlConn.Open();
            using (SqlDataReader SqlRs = sqlComm.ExecuteReader())
            {
                while (SqlRs.Read())
                {
                    MessageBox.Show(string.Format("{0}, {1}, {2}", SqlRs[0].ToString(), SqlRs[1].ToString(), SqlRs[2].ToString()));
                    MessageBox.Show(password);
                    if (SqlRs[1].ToString().Equals(id))
                    { // id가 같고
                        if (SqlRs[2].ToString().Equals(password)) // password도 같으면
                        {
                            MessageBox.Show(SqlRs[0].ToString() + "님 환영합니다");

                            name = SqlRs[0].ToString();
                            id = SqlRs[1].ToString();
                            password = SqlRs[2].ToString();
                            loginCheck++;
                            break;

                        }
                        else //id만 맞고 password가 틀리면
                        {
                            MessageBox.Show("비밀번호를 다시 확인해 주세요");
                            break;
                        }
                    }
                    else // id부터 틀리면
                    {
                        MessageBox.Show("아이디를 다시 확인해 주세요.");
                        break;
                    }

                }
                if (loginCheck != 0)
                {
                    //game으로 들어가기
                    game game = new game(name, id, password);
                    game.Show();
                }

            }
            sqlConn.Close();

            /*
            game game = new game();
            game.Show();
            */
        }

        //회원가입
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 join = new Form2();
            join.Show();
        }

        
    }
}
