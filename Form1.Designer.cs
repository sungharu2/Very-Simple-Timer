namespace SimpleTimer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.main_Panel = new System.Windows.Forms.Panel();
            this.pbx_minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnl_Pause = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_PlayStop = new System.Windows.Forms.Panel();
            this.pbx_StartStop = new System.Windows.Forms.PictureBox();
            this.lb_Timer = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.main_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_Pause.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_PlayStop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_StartStop)).BeginInit();
            this.SuspendLayout();
            // 
            // main_Panel
            // 
            this.main_Panel.BackColor = System.Drawing.Color.White;
            this.main_Panel.Controls.Add(this.pbx_minimize);
            this.main_Panel.Controls.Add(this.pictureBox2);
            this.main_Panel.Controls.Add(this.pnl_Pause);
            this.main_Panel.Controls.Add(this.pnl_PlayStop);
            this.main_Panel.Controls.Add(this.lb_Timer);
            this.main_Panel.Location = new System.Drawing.Point(0, 0);
            this.main_Panel.Name = "main_Panel";
            this.main_Panel.Size = new System.Drawing.Size(300, 80);
            this.main_Panel.TabIndex = 0;
            this.main_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_Panel_Paint);
            this.main_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_MouseDown);
            this.main_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_MouseMove);
            this.main_Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_MouseUp);
            // 
            // pbx_minimize
            // 
            this.pbx_minimize.Image = global::SimpleTimer.Properties.Resources.minimize;
            this.pbx_minimize.Location = new System.Drawing.Point(285, 16);
            this.pbx_minimize.Name = "pbx_minimize";
            this.pbx_minimize.Size = new System.Drawing.Size(15, 15);
            this.pbx_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_minimize.TabIndex = 1;
            this.pbx_minimize.TabStop = false;
            this.pbx_minimize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbx_Minimize);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SimpleTimer.Properties.Resources.Close;
            this.pictureBox2.Location = new System.Drawing.Point(285, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbx_Close);
            // 
            // pnl_Pause
            // 
            this.pnl_Pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pnl_Pause.Controls.Add(this.pictureBox1);
            this.pnl_Pause.Location = new System.Drawing.Point(151, 60);
            this.pnl_Pause.Name = "pnl_Pause";
            this.pnl_Pause.Size = new System.Drawing.Size(147, 18);
            this.pnl_Pause.TabIndex = 2;
            this.pnl_Pause.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pause_Timer);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SimpleTimer.Properties.Resources.Pause;
            this.pictureBox1.Location = new System.Drawing.Point(67, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pause_Timer);
            // 
            // pnl_PlayStop
            // 
            this.pnl_PlayStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pnl_PlayStop.Controls.Add(this.pbx_StartStop);
            this.pnl_PlayStop.Location = new System.Drawing.Point(2, 60);
            this.pnl_PlayStop.Name = "pnl_PlayStop";
            this.pnl_PlayStop.Size = new System.Drawing.Size(147, 18);
            this.pnl_PlayStop.TabIndex = 2;
            this.pnl_PlayStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayOrStop_Timer);
            // 
            // pbx_StartStop
            // 
            this.pbx_StartStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbx_StartStop.Image = global::SimpleTimer.Properties.Resources.Start;
            this.pbx_StartStop.Location = new System.Drawing.Point(67, 0);
            this.pbx_StartStop.Name = "pbx_StartStop";
            this.pbx_StartStop.Size = new System.Drawing.Size(18, 18);
            this.pbx_StartStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_StartStop.TabIndex = 0;
            this.pbx_StartStop.TabStop = false;
            this.pbx_StartStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayOrStop_Timer);
            // 
            // lb_Timer
            // 
            this.lb_Timer.AutoSize = true;
            this.lb_Timer.Font = new System.Drawing.Font("메이플스토리", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Timer.Location = new System.Drawing.Point(3, 3);
            this.lb_Timer.Name = "lb_Timer";
            this.lb_Timer.Size = new System.Drawing.Size(291, 54);
            this.lb_Timer.TabIndex = 1;
            this.lb_Timer.Text = "00 : 00 : 00";
            this.lb_Timer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_Timer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_MouseDown);
            this.lb_Timer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_MouseMove);
            this.lb_Timer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_MouseUp);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 80);
            this.Controls.Add(this.main_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Simple Timer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.main_Panel.ResumeLayout(false);
            this.main_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_Pause.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_PlayStop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_StartStop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_Panel;
        private System.Windows.Forms.Panel pnl_Pause;
        private System.Windows.Forms.Panel pnl_PlayStop;
        private System.Windows.Forms.Label lb_Timer;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbx_StartStop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbx_minimize;
    }
}

