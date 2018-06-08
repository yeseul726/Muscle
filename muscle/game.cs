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

        public game()
        {
            InitializeComponent();

            character.SizeMode = PictureBoxSizeMode.Zoom;
            character.Image = System.Drawing.Image.FromFile("men3.png");
        }
        private void pictureBox1_Click(object sender, PaintEventArgs e)
        {

        }
        private int ProgressMinimum = 10;
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
        }

        private void game_Load(object sender, PaintEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            jump_rope jump_rope = new jump_rope();
            jump_rope.Show();
        }

        private void game_Load(object sender, EventArgs e)
        {

        }

        private void dumbbell_Click(object sender, EventArgs e)
        {
            dumbbell dumbbell = new dumbbell();
            dumbbell.Show();
        }

        private void pushup_Click(object sender, EventArgs e)
        {
            pushup pushup = new pushup();
            pushup.Show();
        }
    }
}
