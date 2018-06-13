namespace muscle
{
    partial class game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.character = new System.Windows.Forms.PictureBox();
            this.food_btn1 = new System.Windows.Forms.PictureBox();
            this.food_btn2 = new System.Windows.Forms.PictureBox();
            this.food_btn3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.store = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_btn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_btn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_btn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.store)).BeginInit();
            this.SuspendLayout();
            // 
            // character
            // 
            this.character.BackColor = System.Drawing.Color.Transparent;
            this.character.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.character.Location = new System.Drawing.Point(276, 168);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(164, 255);
            this.character.TabIndex = 0;
            this.character.TabStop = false;
            // 
            // food_btn1
            // 
            this.food_btn1.BackColor = System.Drawing.Color.White;
            this.food_btn1.Location = new System.Drawing.Point(242, 89);
            this.food_btn1.Name = "food_btn1";
            this.food_btn1.Size = new System.Drawing.Size(40, 40);
            this.food_btn1.TabIndex = 5;
            this.food_btn1.TabStop = false;
            this.food_btn1.Click += new System.EventHandler(this.food_btn1_Click);
            // 
            // food_btn2
            // 
            this.food_btn2.BackColor = System.Drawing.Color.White;
            this.food_btn2.Location = new System.Drawing.Point(338, 71);
            this.food_btn2.Name = "food_btn2";
            this.food_btn2.Size = new System.Drawing.Size(40, 40);
            this.food_btn2.TabIndex = 6;
            this.food_btn2.TabStop = false;
            this.food_btn2.Click += new System.EventHandler(this.food_btn2_Click);
            // 
            // food_btn3
            // 
            this.food_btn3.BackColor = System.Drawing.Color.White;
            this.food_btn3.Location = new System.Drawing.Point(433, 89);
            this.food_btn3.Name = "food_btn3";
            this.food_btn3.Size = new System.Drawing.Size(40, 40);
            this.food_btn3.TabIndex = 7;
            this.food_btn3.TabStop = false;
            this.food_btn3.Click += new System.EventHandler(this.food_btn3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(220, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 88);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(411, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 88);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(316, 55);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 88);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // store
            // 
            this.store.BackColor = System.Drawing.Color.Transparent;
            this.store.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("store.BackgroundImage")));
            this.store.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.store.Location = new System.Drawing.Point(665, 12);
            this.store.Name = "store";
            this.store.Size = new System.Drawing.Size(50, 50);
            this.store.TabIndex = 11;
            this.store.TabStop = false;
            this.store.Click += new System.EventHandler(this.store_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.store);
            this.Controls.Add(this.food_btn2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.food_btn3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.food_btn1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.character);
            this.DoubleBuffered = true;
            this.Name = "game";
            this.Text = "game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.game_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_btn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_btn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_btn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.store)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox character;
        private System.Windows.Forms.PictureBox food_btn1;
        private System.Windows.Forms.PictureBox food_btn2;
        private System.Windows.Forms.PictureBox food_btn3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox store;
    }
}