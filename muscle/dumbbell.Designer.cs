namespace muscle
{
    partial class dumbbell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dumbbell));
            this.dumbbell_char = new System.Windows.Forms.PictureBox();
            this.lift = new System.Windows.Forms.Button();
            this.game_result = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dumbbell_char)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_result)).BeginInit();
            this.SuspendLayout();
            // 
            // dumbbell_char
            // 
            this.dumbbell_char.BackColor = System.Drawing.Color.Transparent;
            this.dumbbell_char.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dumbbell_char.Location = new System.Drawing.Point(232, 98);
            this.dumbbell_char.Name = "dumbbell_char";
            this.dumbbell_char.Size = new System.Drawing.Size(220, 241);
            this.dumbbell_char.TabIndex = 0;
            this.dumbbell_char.TabStop = false;
            // 
            // lift
            // 
            this.lift.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lift.BackgroundImage")));
            this.lift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lift.Location = new System.Drawing.Point(299, 370);
            this.lift.Name = "lift";
            this.lift.Size = new System.Drawing.Size(81, 40);
            this.lift.TabIndex = 1;
            this.lift.UseVisualStyleBackColor = true;
            this.lift.Click += new System.EventHandler(this.lift_Click);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dumbbell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.game_result);
            this.Controls.Add(this.lift);
            this.Controls.Add(this.dumbbell_char);
            this.DoubleBuffered = true;
            this.Name = "dumbbell";
            this.Text = "dumbbell";
            this.Load += new System.EventHandler(this.dumbbell_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.dumbbell_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dumbbell_char)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dumbbell_char;
        private System.Windows.Forms.Button lift;
        private System.Windows.Forms.PictureBox game_result;
        private System.Windows.Forms.Timer timer1;
    }
}