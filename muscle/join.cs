using muscle.Models;
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
    public partial class join : Form
    {
        String name = "";
        String id = "";
        String password = "";
        String password_check = "";
        SortedList<string, string> member_info = new SortedList<string, string>();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = input_name.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            id = input_id.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            password = input_pw.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            password_check = input_pw_ck.Text;  
            if(!(password.Equals(password_check)))
            {
                pw_ck_result.Text = "비밀번호가 일치하지 않습니다.";
            }
            else
            {
                pw_ck_result.Text = "";
            }
        }


        public join()
        {
            InitializeComponent();
        }

        /*private void signUp_Click(object sender, EventArgs e) // 가입 하기
        {
            int idCheck = 0;

            // 먼저 있는 회원인지 체크하고
            // Sql 연결정보(서버:127.0.0.1, 포트:3535, 아이디:sa, 비밀번호 : password, db : member)
            string connectionString = "Data Source = 14.63.199.209,5433; Initial Catalog = Mirim2018; User ID = mirim2018; Password = alfla@)!*";
            // Sql 새연결정보 생성
            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;
            sqlComm.CommandText = "select email from Mus_member";
            sqlConn.Open();
            using (SqlDataReader SqlRs = sqlComm.ExecuteReader())
            {
                Console.WriteLine("email");
                while (SqlRs.Read())
                {
                    //MessageBox.Show(string.Format("{0}", SqlRs[0].ToString()));
                    if (SqlRs[0].ToString().Equals(id)){ // DB에서 읽어온 값이랑 사용자가 입력한 값이랑 동일하면
                        idCheck++;
                    }
                }
            }
            sqlConn.Close();


            if (idCheck == 0) // 신규 회원 (id가 중복되지 X)
            {
                try
                {
                    //string connectionString = "Data Source = 14.63.199.209,5433; Initial Catalog = Mirim2018; User ID = mirim2018; Password = alfla@)!*";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd =
                            new SqlCommand("INSERT INTO Mus_member VALUES(@name, @email, @password,1,1, 1000, 200)", conn)) //idx는 기본키
                        {
                            //cmd.Parameters.AddWithValue("@idx", null);
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@email", id);
                            cmd.Parameters.AddWithValue("@password", password);

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

                this.Close();
            }
            else
            {
                MessageBox.Show("이미 있는 회원 ID 입니다");
            }
        }*/

        /*private void reset_Click(object sender, EventArgs e) // 다시 입력
        {

        }*/

        private void join_btn_Click(object sender, EventArgs e)
        {
            int idCheck = 0;

            if (name.Equals("") || id.Equals("") || password.Equals("") || password_check.Equals(""))
            {
                MessageBox.Show("모든 항목을 입력해주세요.");
                input_name.Focus();
            }
            else //모든 항목을 입력했다면 회원가입 절차 실행
            {
                if (password.Equals(password_check)) //비밀번호, 비밀번호 재입력이 같아야 회원가입 절차 실행
                {
                    // 먼저 있는 회원인지 체크하고
                    // Sql 연결정보(서버:127.0.0.1, 포트:3535, 아이디:sa, 비밀번호 : password, db : member)
                    string connectionString = "Data Source = 14.63.199.209,5433; Initial Catalog = Mirim2018; User ID = mirim2018; Password = alfla@)!*";
                    // Sql 새연결정보 생성
                    SqlConnection sqlConn = new SqlConnection(connectionString);
                    SqlCommand sqlComm = new SqlCommand();
                    sqlComm.Connection = sqlConn;
                    sqlComm.CommandText = "select email from Mus_member";
                    sqlConn.Open();
                    using (SqlDataReader SqlRs = sqlComm.ExecuteReader())
                    {
                        Console.WriteLine("email");
                        while (SqlRs.Read())
                        {
                            //MessageBox.Show(string.Format("{0}", SqlRs[0].ToString()));
                            if (SqlRs[0].ToString().Equals(id))
                            { // DB에서 읽어온 값이랑 사용자가 입력한 값이랑 동일하면
                                idCheck++;
                            }
                        }
                    }
                    sqlConn.Close();


                    if (idCheck == 0) // 신규 회원 (id가 중복되지 X)
                    {
                        try
                        {
                            //string connectionString = "Data Source = 14.63.199.209,5433; Initial Catalog = Mirim2018; User ID = mirim2018; Password = alfla@)!*";
                            using (SqlConnection conn = new SqlConnection(connectionString))
                            {
                                conn.Open();
                                using (SqlCommand cmd =
                                    new SqlCommand("INSERT INTO Mus_member VALUES(@name, @email, @password,1,1, 1000, 200)", conn)) //idx는 기본키
                                {
                                    //cmd.Parameters.AddWithValue("@idx", null);
                                    cmd.Parameters.AddWithValue("@name", name);
                                    cmd.Parameters.AddWithValue("@email", id);
                                    cmd.Parameters.AddWithValue("@password", password);

                                    int rows = cmd.ExecuteNonQuery();

                                    //rows number of record got inserted
                                }
                                MessageBox.Show("회원가입 성공");
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("안됨");
                            //Log exception
                            //Display Error message
                        }

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("이미 있는 회원 ID 입니다");
                    }
                }
                else
                {
                    pw_ck_result.Text = "비밀번호가 일치하지 않습니다.";
                    input_pw_ck.Focus();
                }
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            input_name.Text = "";
            input_id.Text = "";
            input_pw.Text = "";
            input_pw_ck.Text = "";
            input_name.Focus();
        }
    }
}
