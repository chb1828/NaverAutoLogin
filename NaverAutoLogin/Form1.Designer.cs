namespace NaverAutoLogin
{
    partial class brandNameLabel
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
            this.label1 = new System.Windows.Forms.Label();
            this.mCroStart = new System.Windows.Forms.Button();
            this.login_idC = new System.Windows.Forms.TextBox();
            this.login_pwdC = new System.Windows.Forms.TextBox();
            this.login_id = new System.Windows.Forms.Label();
            this.login_pwd = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.exitBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serverT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "로그인";
            this.label1.UseWaitCursor = true;
            // 
            // mCroStart
            // 
            this.mCroStart.Location = new System.Drawing.Point(230, 157);
            this.mCroStart.Name = "mCroStart";
            this.mCroStart.Size = new System.Drawing.Size(93, 42);
            this.mCroStart.TabIndex = 2;
            this.mCroStart.Text = "시작";
            this.mCroStart.UseVisualStyleBackColor = true;
            this.mCroStart.UseWaitCursor = true;
            this.mCroStart.Click += new System.EventHandler(this.mCroStart_Click);
            // 
            // login_idC
            // 
            this.login_idC.Location = new System.Drawing.Point(70, 86);
            this.login_idC.Name = "login_idC";
            this.login_idC.Size = new System.Drawing.Size(230, 21);
            this.login_idC.TabIndex = 3;
            this.login_idC.UseWaitCursor = true;
            this.login_idC.Validating += new System.ComponentModel.CancelEventHandler(this.login_idC_Validating);
            // 
            // login_pwdC
            // 
            this.login_pwdC.Location = new System.Drawing.Point(70, 113);
            this.login_pwdC.Name = "login_pwdC";
            this.login_pwdC.PasswordChar = '*';
            this.login_pwdC.Size = new System.Drawing.Size(230, 21);
            this.login_pwdC.TabIndex = 4;
            this.login_pwdC.UseWaitCursor = true;
            this.login_pwdC.Validating += new System.ComponentModel.CancelEventHandler(this.login_pwdC_Validating);
            // 
            // login_id
            // 
            this.login_id.AutoSize = true;
            this.login_id.Location = new System.Drawing.Point(23, 89);
            this.login_id.Name = "login_id";
            this.login_id.Size = new System.Drawing.Size(41, 12);
            this.login_id.TabIndex = 5;
            this.login_id.Text = "아이디";
            this.login_id.UseWaitCursor = true;
            // 
            // login_pwd
            // 
            this.login_pwd.AutoSize = true;
            this.login_pwd.Location = new System.Drawing.Point(11, 116);
            this.login_pwd.Name = "login_pwd";
            this.login_pwd.Size = new System.Drawing.Size(53, 12);
            this.login_pwd.TabIndex = 6;
            this.login_pwd.Text = "비밀번호";
            this.login_pwd.UseWaitCursor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(25, 157);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(93, 42);
            this.exitBtn.TabIndex = 17;
            this.exitBtn.Text = "종료";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.UseWaitCursor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "서버시간 : ";
            this.label4.UseWaitCursor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serverT
            // 
            this.serverT.AutoSize = true;
            this.serverT.Location = new System.Drawing.Point(109, 51);
            this.serverT.Name = "serverT";
            this.serverT.Size = new System.Drawing.Size(0, 12);
            this.serverT.TabIndex = 23;
            this.serverT.UseWaitCursor = true;
            // 
            // brandNameLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 211);
            this.Controls.Add(this.serverT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.login_pwd);
            this.Controls.Add(this.login_id);
            this.Controls.Add(this.login_pwdC);
            this.Controls.Add(this.login_idC);
            this.Controls.Add(this.mCroStart);
            this.Controls.Add(this.label1);
            this.Name = "brandNameLabel";
            this.Text = "네이버 자동 로그인";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mCroStart;
        private System.Windows.Forms.TextBox login_idC;
        private System.Windows.Forms.TextBox login_pwdC;
        private System.Windows.Forms.Label login_id;
        private System.Windows.Forms.Label login_pwd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label serverT;
        private System.Windows.Forms.Timer timer1;
    }
}

