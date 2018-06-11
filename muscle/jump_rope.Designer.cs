namespace muscle
{
    partial class jump_rope
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jump_rope));
            this.jump_rope_char = new System.Windows.Forms.ImageList(this.components);
            this.jump_char = new System.Windows.Forms.PictureBox();
            this.jump = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.game_result = new System.Windows.Forms.PictureBox();
            this.count_bg = new System.Windows.Forms.PictureBox();
            this.count_label = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jump_char)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_bg)).BeginInit();
            this.SuspendLayout();
            // 
            // jump_rope_char
            // 
            this.jump_rope_char.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.jump_rope_char.ImageSize = new System.Drawing.Size(16, 16);
            this.jump_rope_char.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // jump_char
            // 
            this.jump_char.BackColor = System.Drawing.Color.Transparent;
            this.jump_char.Location = new System.Drawing.Point(248, 68);
            this.jump_char.Name = "jump_char";
            this.jump_char.Size = new System.Drawing.Size(190, 300);
            this.jump_char.TabIndex = 0;
            this.jump_char.TabStop = false;
            // 
            // jump
            // 
            this.jump.BackColor = System.Drawing.Color.Transparent;
            this.jump.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("jump.BackgroundImage")));
            this.jump.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.jump.Location = new System.Drawing.Point(299, 385);
            this.jump.Name = "jump";
            this.jump.Size = new System.Drawing.Size(84, 38);
            this.jump.TabIndex = 1;
            this.jump.UseVisualStyleBackColor = false;
            this.jump.Click += new System.EventHandler(this.jump_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // game_result
            // 
            this.game_result.BackColor = System.Drawing.Color.Transparent;
            this.game_result.Location = new System.Drawing.Point(248, 165);
            this.game_result.Name = "game_result";
            this.game_result.Size = new System.Drawing.Size(190, 50);
            this.game_result.TabIndex = 2;
            this.game_result.TabStop = false;
            // 
            // count_bg
            // 
            this.count_bg.BackColor = System.Drawing.Color.Transparent;
            this.count_bg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("count_bg.BackgroundImage")));
            this.count_bg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.count_bg.Location = new System.Drawing.Point(281, 22);
            this.count_bg.Name = "count_bg";
            this.count_bg.Size = new System.Drawing.Size(127, 32);
            this.count_bg.TabIndex = 3;
            this.count_bg.TabStop = false;
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.BackColor = System.Drawing.Color.White;
            this.count_label.Font = new System.Drawing.Font("Munro Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_label.Location = new System.Drawing.Point(361, 29);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(22, 17);
            this.count_label.TabIndex = 4;
            this.count_label.Text = "50";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.Color.Transparent;
            this.result.Font = new System.Drawing.Font("소야곧은10", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(42, 138);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 33);
            this.result.TabIndex = 5;
            // 
            // jump_rope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.count_label);
            this.Controls.Add(this.count_bg);
            this.Controls.Add(this.game_result);
            this.Controls.Add(this.jump);
            this.Controls.Add(this.jump_char);
            this.DoubleBuffered = true;
            this.Name = "jump_rope";
            this.Text = "jump_rope";
            this.Load += new System.EventHandler(this.jump_rope_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.jump_rope_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.jump_char)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_bg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList jump_rope_char;
        private System.Windows.Forms.PictureBox jump_char;
        private System.Windows.Forms.Button jump;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox game_result;
        private System.Windows.Forms.PictureBox count_bg;
        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.Label result;
    }
}