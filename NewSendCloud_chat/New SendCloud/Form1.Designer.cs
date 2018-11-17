namespace New_SendCloud
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sendCloudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서버ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.시작ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.클라이언트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서버연결ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.환경설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.simpleMemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleMemo사용ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.txtip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(417, 344);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(96, 25);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "전송";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(12, 344);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(399, 25);
            this.txtSend.TabIndex = 1;
            this.txtSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSend_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendCloudToolStripMenuItem,
            this.simpleMemoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sendCloudToolStripMenuItem
            // 
            this.sendCloudToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.서버ToolStripMenuItem,
            this.클라이언트ToolStripMenuItem,
            this.환경설정ToolStripMenuItem,
            this.닫기ToolStripMenuItem,
            this.toolStripTextBox1});
            this.sendCloudToolStripMenuItem.Name = "sendCloudToolStripMenuItem";
            this.sendCloudToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.sendCloudToolStripMenuItem.Text = "SendCloud";
            // 
            // 서버ToolStripMenuItem
            // 
            this.서버ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.시작ToolStripMenuItem});
            this.서버ToolStripMenuItem.Name = "서버ToolStripMenuItem";
            this.서버ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.서버ToolStripMenuItem.Text = "서버";
            // 
            // 시작ToolStripMenuItem
            // 
            this.시작ToolStripMenuItem.Name = "시작ToolStripMenuItem";
            this.시작ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.시작ToolStripMenuItem.Text = "서버 시작";
            this.시작ToolStripMenuItem.Click += new System.EventHandler(this.시작ToolStripMenuItem_Click);
            // 
            // 클라이언트ToolStripMenuItem
            // 
            this.클라이언트ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.서버연결ToolStripMenuItem});
            this.클라이언트ToolStripMenuItem.Name = "클라이언트ToolStripMenuItem";
            this.클라이언트ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.클라이언트ToolStripMenuItem.Text = "클라이언트";
            // 
            // 서버연결ToolStripMenuItem
            // 
            this.서버연결ToolStripMenuItem.Name = "서버연결ToolStripMenuItem";
            this.서버연결ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.서버연결ToolStripMenuItem.Text = "서버 연결";
            this.서버연결ToolStripMenuItem.Click += new System.EventHandler(this.서버연결ToolStripMenuItem_Click);
            // 
            // 환경설정ToolStripMenuItem
            // 
            this.환경설정ToolStripMenuItem.Name = "환경설정ToolStripMenuItem";
            this.환경설정ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.환경설정ToolStripMenuItem.Text = "환경 설정";
            this.환경설정ToolStripMenuItem.Click += new System.EventHandler(this.환경설정ToolStripMenuItem_Click);
            // 
            // 닫기ToolStripMenuItem
            // 
            this.닫기ToolStripMenuItem.Name = "닫기ToolStripMenuItem";
            this.닫기ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.닫기ToolStripMenuItem.Text = "닫기";
            this.닫기ToolStripMenuItem.Click += new System.EventHandler(this.닫기ToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.ToolTipText = "암호화키값입력";
            // 
            // simpleMemoToolStripMenuItem
            // 
            this.simpleMemoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleMemo사용ToolStripMenuItem});
            this.simpleMemoToolStripMenuItem.Name = "simpleMemoToolStripMenuItem";
            this.simpleMemoToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.simpleMemoToolStripMenuItem.Text = "SimpleMemo";
            // 
            // simpleMemo사용ToolStripMenuItem
            // 
            this.simpleMemo사용ToolStripMenuItem.Name = "simpleMemo사용ToolStripMenuItem";
            this.simpleMemo사용ToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.simpleMemo사용ToolStripMenuItem.Text = "SimpleMemo 사용";
            this.simpleMemo사용ToolStripMenuItem.Click += new System.EventHandler(this.simpleMemo사용ToolStripMenuItem_Click);
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(12, 64);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChat.Size = new System.Drawing.Size(501, 261);
            this.txtChat.TabIndex = 4;
            // 
            // txtip
            // 
            this.txtip.Location = new System.Drawing.Point(80, 33);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(433, 25);
            this.txtip.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP주소 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtip);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "New SendCloud";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sendCloudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서버ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 시작ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 클라이언트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서버연결ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 닫기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 환경설정ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStripMenuItem simpleMemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleMemo사용ToolStripMenuItem;
    }
}

