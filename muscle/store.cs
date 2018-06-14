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
    public partial class store : Form
    {
        int fat = 0;
        int muscle = 0;

        String food_name = "";
        List<List<string>> item_store = new List<List<string>>();
        List<string> item_name = new List<string>();
        List<string> dumbbel = new List<string>();
        List<Label> item = new List<Label>();

        string name = "";
        string id = "";
        string password = "";

        int cnt = 0;

        int width = 240;
        int height = 120;

        int member_dumbbel_su = 0;

        public store(string name, string id, string password)
        {
            InitializeComponent();

            this.name = name;
            this.id = id;
            this.password = password;

            member_info(id);//회원이 가지고 있는 아령 수, 지방량, 근육량 가져오기

            item_info();

            System.Windows.Forms.Label label1;

            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    label1 = new System.Windows.Forms.Label();
                    label1.Location = new System.Drawing.Point(110+width*j, 100+height*i);
                    label1.Name = "food_name" + i.ToString();
                    label1.Size = new System.Drawing.Size(90, 15);
                    label1.TabIndex = i;
                    label1.Text = item_name[cnt++];

                    this.Controls.Add(label1);
                }
            }

            System.Windows.Forms.Label label2;
            cnt = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    label2 = new System.Windows.Forms.Label();
                    label2.Location = new System.Drawing.Point(110 + width * j, 123 + height * i);
                    label2.Name = "food_explain" + i.ToString();
                    label2.Size = new System.Drawing.Size(90, 15);
                    label2.TabIndex = i;
                    label2.Text = dumbbel[cnt++]+"개";

                    this.Controls.Add(label2);
                }
            }
        }

        private void howtoshop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("게임을 통해 획득한 아령으로 다이어트 식품을 구입하세요!\n\n" +
                "게임의 보상보다 더 많은 근육량을 단번에 얻을 수 있어요.\n\n" +
                "하지만 음식을 먹었으니 그만큼 살도 찌겠죠? :)\n");
        }

        private void abocado_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("아보카도");
            food_name = "아보카도";
            buy_food(food_name);
        }

        private void egg_Click(object sender, EventArgs e)
        {
            food_name = "계란";
            buy_food(food_name);
        }

        private void brocolly_Click(object sender, EventArgs e)
        {
            food_name = "브로콜리";
            buy_food(food_name);
        }

        private void carrot_Click(object sender, EventArgs e)
        {
            food_name = "당근";
            buy_food(food_name);
        }

        private void tomato_Click(object sender, EventArgs e)
        {
            food_name = "토마토";
            buy_food(food_name);
        }

        private void milk_Click(object sender, EventArgs e)
        {
            food_name = "저지방 우유";
            buy_food(food_name);
        }

        private void tofu_Click(object sender, EventArgs e)
        {
            food_name = "두부";
            buy_food(food_name);
        }

        private void chicken_breast_Click(object sender, EventArgs e)
        {
            food_name = "닭가슴살";
            buy_food(food_name);
        }

        private void diet_drink_Click(object sender, EventArgs e)
        {
            food_name = "다이어트 음료";
            buy_food(food_name);
        }

        public void member_info(string id)
        {
            string connectionString = "Data Source = 14.63.199.209,5433; Initial Catalog = Mirim2018; User ID = mirim2018; Password = alfla@)!*";
            // Sql 새연결정보 생성
            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;
            sqlComm.CommandText = "select dumbbell, fat, muscle from Mus_member where email = @id";

            sqlComm.Parameters.AddWithValue("@id", id);

            sqlConn.Open();
            using (SqlDataReader SqlRs = sqlComm.ExecuteReader())
            {

                while (SqlRs.Read())
                {
                    dumbbell_num.Text = SqlRs[0].ToString();
                    member_dumbbel_su = Convert.ToInt32(SqlRs[0]);
                    fat = Convert.ToInt32(SqlRs[1]);
                    muscle = Convert.ToInt32(SqlRs[2]);
                }
            }
            sqlConn.Close();
        }

        public void buy_food(string food_name)
        {

            string connectionString = "Data Source = 14.63.199.209,5433; Initial Catalog = Mirim2018; User ID = mirim2018; Password = alfla@)!*";
            // Sql 새연결정보 생성
            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;
            sqlComm.CommandText = "select dumbbel, effect, fat, muscle from Mus_item where name = @food_name";

            sqlComm.Parameters.AddWithValue("@food_name", food_name);

            sqlConn.Open();
            using (SqlDataReader SqlRs = sqlComm.ExecuteReader())
            {

                while (SqlRs.Read())
                {
                    //MessageBox.Show(SqlRs[0].ToString()); // 아령
                    //MessageBox.Show(SqlRs[1].ToString()); // 효과 문구
                    //MessageBox.Show(SqlRs[2].ToString()); // 지방량
                    //MessageBox.Show(SqlRs[3].ToString()); // 근육량

                    if (member_dumbbel_su >= Convert.ToInt32(SqlRs[0]))// 살 수 있음
                    {
                        MessageBox.Show("섭취 완료!\n\n[" + SqlRs[1].ToString()+"]");
                        // 섭취했으니 업데이트
                        member_dumbbel_su -= Convert.ToInt32(SqlRs[0]);
                        fat += Convert.ToInt32(SqlRs[2]);
                        muscle += Convert.ToInt32(SqlRs[3]);

                        SqlRs.Close();

                        sqlComm.CommandText = "update Mus_member set dumbbell = @dumbbell, fat = @fat, muscle = @muscle where email = @id";
                        sqlComm.Parameters.AddWithValue("@dumbbell", member_dumbbel_su);
                        sqlComm.Parameters.AddWithValue("@fat", fat);
                        sqlComm.Parameters.AddWithValue("@muscle", muscle);
                        sqlComm.Parameters.AddWithValue("@id", id);

                        int rows = sqlComm.ExecuteNonQuery();

                        member_info(id);

                        break;
                    }
                    else // 아령이 부족해요
                    {
                        MessageBox.Show("이런~ 아령이 부족해요");
                    }

                }
            }
            sqlConn.Close();
        }

        public void item_info()
        {
            string connectionString = "Data Source = 14.63.199.209,5433; Initial Catalog = Mirim2018; User ID = mirim2018; Password = alfla@)!*";
            // Sql 새연결정보 생성
            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;
            sqlComm.CommandText = "select name, dumbbel from Mus_item";

            sqlConn.Open();
            using (SqlDataReader SqlRs = sqlComm.ExecuteReader())
            {

                while (SqlRs.Read())
                {
                    item_name.Add(SqlRs[0].ToString());
                    dumbbel.Add(SqlRs[1].ToString());
                }
                item_store.Add(item_name);
                item_store.Add(dumbbel);
            }
            sqlConn.Close();
        }

        private void store_Load(object sender, EventArgs e)
        {

        }
        
    }
}
