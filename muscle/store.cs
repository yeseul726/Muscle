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
    public partial class store : Form
    {
        public store(string name, string id, string password)
        {
            InitializeComponent();
        }

        private void howtoshop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("게임을 통해 획득한 아령으로 다이어트 식품을 구입하세요!\n\n" +
                "게임의 보상보다 더 많은 근육량을 단번에 얻을 수 있어요.\n\n" +
                "하지만 음식을 먹었으니 그만큼 살도 찌겠죠? :)\n");
        }
    }
}
