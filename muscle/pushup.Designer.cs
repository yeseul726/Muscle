namespace muscle
{
    partial class pushup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pushup));
            this.pushup_char = new System.Windows.Forms.PictureBox();
            this.game_result = new System.Windows.Forms.PictureBox();
            this.pushup_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pushup_char)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_result)).BeginInit();
            this.SuspendLayout();
            // 
            // pushup_char
            // 
            this.pushup_char.BackColor = System.Drawing.Color.Transparent;
            this.pushup_char.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pushup_char.Location = new System.Drawing.Point(187, 212);
            this.pushup_char.Name = "pushup_char";
            this.pushup_char.Size = new System.Drawing.Size(331, 139);
            this.pushup_char.TabIndex = 0;
            this.pushup_char.TabStop = false;
            // 
            // game_result
            // 
            this.game_result.BackColor = System.Drawing.Color.Transparent;
            this.game_result.Location = new System.Drawing.Point(262, 156);
            this.game_result.Name = "game_result";
            this.game_result.Size = new System.Drawing.Size(190, 50);
            this.game_result.TabIndex = 1;
            this.game_result.TabStop = false;
            // 
            // pushup_btn
            // 
            this.pushup_btn.BackColor = System.Drawing.Color.Transparent;
            this.pushup_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pushup_btn.BackgroundImage")));
            this.pushup_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pushup_btn.Location = new System.Drawing.Point(302, 369);
            this.pushup_btn.Name = "pushup_btn";
            this.pushup_btn.Size = new System.Drawing.Size(107, 40);
            this.pushup_btn.TabIndex = 2;
            this.pushup_btn.UseVisualStyleBackColor = false;
            this.pushup_btn.Click += new System.EventHandler(this.pushup_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pushup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.pushup_btn);
            this.Controls.Add(this.game_result);
            this.Controls.Add(this.pushup_char);
            this.DoubleBuffered = true;
            this.Name = "pushup";
            this.Text = "pushup";
            this.Load += new System.EventHandler(this.pushup_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.pushup_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pushup_char)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pushup_char;
        private System.Windows.Forms.PictureBox game_result;
        private System.Windows.Forms.Button pushup_btn;
        private System.Windows.Forms.Timer timer1;
    }
}