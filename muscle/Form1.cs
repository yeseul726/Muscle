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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }      
        //로그인
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("서비스 준비 중 입니다.");
            game game = new game();
            game.Show();
        }

        //회원가입
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 join = new Form2();
            join.Show();
        }
    }
}
