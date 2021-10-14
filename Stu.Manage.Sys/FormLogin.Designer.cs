namespace Stu.Manage.Sys
{
    partial class FormLogin
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
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPwd = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.linkLabelRes = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(371, 274);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(84, 28);
            this.buttonEnter.TabIndex = 0;
            this.buttonEnter.Text = "登录";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(486, 274);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 28);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(310, 120);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(62, 18);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "用户名";
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Location = new System.Drawing.Point(310, 204);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(53, 18);
            this.labelPwd.TabIndex = 3;
            this.labelPwd.Text = "密 码";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(371, 116);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(199, 28);
            this.textBoxUserName.TabIndex = 4;
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(371, 200);
            this.textBoxPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(199, 28);
            this.textBoxPwd.TabIndex = 5;
            // 
            // linkLabelRes
            // 
            this.linkLabelRes.AutoSize = true;
            this.linkLabelRes.Location = new System.Drawing.Point(310, 283);
            this.linkLabelRes.Name = "linkLabelRes";
            this.linkLabelRes.Size = new System.Drawing.Size(44, 18);
            this.linkLabelRes.TabIndex = 6;
            this.linkLabelRes.TabStop = true;
            this.linkLabelRes.Text = "注册";
            this.linkLabelRes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRes_LinkClicked);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.linkLabelRes);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEnter);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.LinkLabel linkLabelRes;
    }
}