namespace 课程设计Csharp
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_register = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_mainexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(12, 71);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(108, 63);
            this.button_register.TabIndex = 0;
            this.button_register.Text = "注册";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(147, 71);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(108, 63);
            this.button_login.TabIndex = 1;
            this.button_login.Text = "登陆";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(291, 200);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(108, 63);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "退出";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // button_mainexit
            // 
            this.button_mainexit.Location = new System.Drawing.Point(92, 194);
            this.button_mainexit.Name = "button_mainexit";
            this.button_mainexit.Size = new System.Drawing.Size(75, 23);
            this.button_mainexit.TabIndex = 3;
            this.button_mainexit.Text = "退出";
            this.button_mainexit.UseVisualStyleBackColor = true;
            this.button_mainexit.Click += new System.EventHandler(this.button_mainexit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_mainexit);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.button_register);
            this.Name = "Main";
            this.Text = "通讯录管理系统";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_mainexit;
    }
}

