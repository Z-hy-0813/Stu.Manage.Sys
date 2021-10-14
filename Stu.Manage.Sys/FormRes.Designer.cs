namespace Stu.Manage.Sys
{
    partial class FormRes
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
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelPwd = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxip_addr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(306, 122);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(177, 25);
            this.textBoxPwd.TabIndex = 9;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(306, 52);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(177, 25);
            this.textBoxUserName.TabIndex = 8;
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Location = new System.Drawing.Point(252, 125);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(45, 15);
            this.labelPwd.TabIndex = 7;
            this.labelPwd.Text = "密 码";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(252, 55);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(52, 15);
            this.labelUserName.TabIndex = 6;
            this.labelUserName.Text = "用户名";
            // 
            // textBoxip_addr
            // 
            this.textBoxip_addr.Location = new System.Drawing.Point(306, 193);
            this.textBoxip_addr.Name = "textBoxip_addr";
            this.textBoxip_addr.Size = new System.Drawing.Size(177, 25);
            this.textBoxip_addr.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "限制IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxMac
            // 
            this.textBoxMac.Location = new System.Drawing.Point(306, 264);
            this.textBoxMac.Name = "textBoxMac";
            this.textBoxMac.Size = new System.Drawing.Size(177, 25);
            this.textBoxMac.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "限制MAC";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(408, 329);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(306, 329);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 14;
            this.buttonEnter.Text = "注册";
            this.buttonEnter.UseVisualStyleBackColor = true;
            // 
            // FormRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxMac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxip_addr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.labelUserName);
            this.Name = "FormRes";
            this.Text = "FormRes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxip_addr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEnter;
    }
}