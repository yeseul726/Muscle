namespace muscle
{
    partial class join
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(join));
            this.label4 = new System.Windows.Forms.Label();
            this.input_name = new System.Windows.Forms.TextBox();
            this.input_id = new System.Windows.Forms.TextBox();
            this.input_pw = new System.Windows.Forms.TextBox();
            this.input_pw_ck = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.join_btn = new System.Windows.Forms.PictureBox();
            this.reset_btn = new System.Windows.Forms.PictureBox();
            this.pw_ck_result = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.join_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reset_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(306, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "회원가입";
            // 
            // input_name
            // 
            this.input_name.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.input_name.Location = new System.Drawing.Point(145, 60);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(197, 26);
            this.input_name.TabIndex = 0;
            this.input_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // input_id
            // 
            this.input_id.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.input_id.Location = new System.Drawing.Point(145, 102);
            this.input_id.Name = "input_id";
            this.input_id.Size = new System.Drawing.Size(197, 26);
            this.input_id.TabIndex = 1;
            this.input_id.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // input_pw
            // 
            this.input_pw.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.input_pw.Location = new System.Drawing.Point(145, 143);
            this.input_pw.Name = "input_pw";
            this.input_pw.Size = new System.Drawing.Size(197, 26);
            this.input_pw.TabIndex = 2;
            this.input_pw.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // input_pw_ck
            // 
            this.input_pw_ck.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.input_pw_ck.Location = new System.Drawing.Point(145, 185);
            this.input_pw_ck.Name = "input_pw_ck";
            this.input_pw_ck.Size = new System.Drawing.Size(197, 26);
            this.input_pw_ck.TabIndex = 3;
            this.input_pw_ck.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "비밀번호";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "비밀번호 확인";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pw_ck_result);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.input_pw_ck);
            this.groupBox1.Controls.Add(this.input_pw);
            this.groupBox1.Controls.Add(this.input_id);
            this.groupBox1.Controls.Add(this.input_name);
            this.groupBox1.Location = new System.Drawing.Point(167, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 263);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // join_btn
            // 
            this.join_btn.BackColor = System.Drawing.Color.Transparent;
            this.join_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("join_btn.BackgroundImage")));
            this.join_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.join_btn.Location = new System.Drawing.Point(257, 337);
            this.join_btn.Name = "join_btn";
            this.join_btn.Size = new System.Drawing.Size(88, 34);
            this.join_btn.TabIndex = 16;
            this.join_btn.TabStop = false;
            this.join_btn.Click += new System.EventHandler(this.join_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.Transparent;
            this.reset_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reset_btn.BackgroundImage")));
            this.reset_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reset_btn.Location = new System.Drawing.Point(375, 337);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(88, 34);
            this.reset_btn.TabIndex = 17;
            this.reset_btn.TabStop = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // pw_ck_result
            // 
            this.pw_ck_result.AutoSize = true;
            this.pw_ck_result.Location = new System.Drawing.Point(145, 218);
            this.pw_ck_result.Name = "pw_ck_result";
            this.pw_ck_result.Size = new System.Drawing.Size(0, 12);
            this.pw_ck_result.TabIndex = 12;
            // 
            // join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.join_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "join";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.join_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reset_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.TextBox input_id;
        private System.Windows.Forms.TextBox input_pw;
        private System.Windows.Forms.TextBox input_pw_ck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox join_btn;
        private System.Windows.Forms.PictureBox reset_btn;
        private System.Windows.Forms.Label pw_ck_result;
    }
}