namespace XZMStudy
{
    partial class FormLogin
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
            this.panelLogin = new Infragistics.Win.Misc.UltraPanel();
            this.labelUserName = new Infragistics.Win.Misc.UltraLabel();
            this.labelPassword = new Infragistics.Win.Misc.UltraLabel();
            this.ultraTextEditor1 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.textPassword = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.panelLogin.ClientArea.SuspendLayout();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            // 
            // panelLogin.ClientArea
            // 
            this.panelLogin.ClientArea.Controls.Add(this.textPassword);
            this.panelLogin.ClientArea.Controls.Add(this.ultraTextEditor1);
            this.panelLogin.ClientArea.Controls.Add(this.labelPassword);
            this.panelLogin.ClientArea.Controls.Add(this.labelUserName);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(800, 450);
            this.panelLogin.TabIndex = 0;
            // 
            // labelUserName
            // 
            this.labelUserName.Location = new System.Drawing.Point(237, 167);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(66, 23);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "用户名";
            // 
            // labelPassword
            // 
            this.labelPassword.Location = new System.Drawing.Point(237, 216);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(66, 23);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "密码";
            // 
            // ultraTextEditor1
            // 
            this.ultraTextEditor1.Location = new System.Drawing.Point(309, 163);
            this.ultraTextEditor1.Name = "ultraTextEditor1";
            this.ultraTextEditor1.Size = new System.Drawing.Size(167, 21);
            this.ultraTextEditor1.TabIndex = 2;
            // 
            // textPassword
            // 
            this.textPassword.AutoSize = false;
            this.textPassword.Location = new System.Drawing.Point(309, 212);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(167, 21);
            this.textPassword.TabIndex = 3;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLogin);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelLogin.ClientArea.ResumeLayout(false);
            this.panelLogin.ClientArea.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraPanel panelLogin;
        private Infragistics.Win.Misc.UltraLabel labelPassword;
        private Infragistics.Win.Misc.UltraLabel labelUserName;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor textPassword;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor1;
    }
}

