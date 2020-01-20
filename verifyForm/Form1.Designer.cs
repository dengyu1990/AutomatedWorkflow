namespace verifyForm
{
    partial class Form1
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
            this.btnVerify = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSun = new System.Windows.Forms.CheckBox();
            this.chkSat = new System.Windows.Forms.CheckBox();
            this.chkFri = new System.Windows.Forms.CheckBox();
            this.chkThu = new System.Windows.Forms.CheckBox();
            this.chkWed = new System.Windows.Forms.CheckBox();
            this.chkTue = new System.Windows.Forms.CheckBox();
            this.chkMon = new System.Windows.Forms.CheckBox();
            this.lblM = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(305, 222);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(140, 48);
            this.btnVerify.TabIndex = 1;
            this.btnVerify.Text = "验证";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkSun);
            this.groupBox2.Controls.Add(this.chkSat);
            this.groupBox2.Controls.Add(this.chkFri);
            this.groupBox2.Controls.Add(this.chkThu);
            this.groupBox2.Controls.Add(this.chkWed);
            this.groupBox2.Controls.Add(this.chkTue);
            this.groupBox2.Controls.Add(this.chkMon);
            this.groupBox2.Controls.Add(this.lblM);
            this.groupBox2.Controls.Add(this.txtEnd);
            this.groupBox2.Controls.Add(this.txtStart);
            this.groupBox2.Location = new System.Drawing.Point(25, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 131);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "运行时段";
            // 
            // chkSun
            // 
            this.chkSun.AutoSize = true;
            this.chkSun.ForeColor = System.Drawing.Color.DarkGreen;
            this.chkSun.Location = new System.Drawing.Point(120, 80);
            this.chkSun.Name = "chkSun";
            this.chkSun.Size = new System.Drawing.Size(60, 16);
            this.chkSun.TabIndex = 10;
            this.chkSun.Text = "星期日";
            this.chkSun.UseVisualStyleBackColor = true;
            // 
            // chkSat
            // 
            this.chkSat.AutoSize = true;
            this.chkSat.ForeColor = System.Drawing.Color.DarkGreen;
            this.chkSat.Location = new System.Drawing.Point(40, 80);
            this.chkSat.Name = "chkSat";
            this.chkSat.Size = new System.Drawing.Size(60, 16);
            this.chkSat.TabIndex = 9;
            this.chkSat.Text = "星期六";
            this.chkSat.UseVisualStyleBackColor = true;
            // 
            // chkFri
            // 
            this.chkFri.AutoSize = true;
            this.chkFri.Location = new System.Drawing.Point(360, 40);
            this.chkFri.Name = "chkFri";
            this.chkFri.Size = new System.Drawing.Size(60, 16);
            this.chkFri.TabIndex = 8;
            this.chkFri.Text = "星期五";
            this.chkFri.UseVisualStyleBackColor = true;
            // 
            // chkThu
            // 
            this.chkThu.AutoSize = true;
            this.chkThu.ForeColor = System.Drawing.Color.Red;
            this.chkThu.Location = new System.Drawing.Point(280, 40);
            this.chkThu.Name = "chkThu";
            this.chkThu.Size = new System.Drawing.Size(60, 16);
            this.chkThu.TabIndex = 7;
            this.chkThu.Text = "星期四";
            this.chkThu.UseVisualStyleBackColor = true;
            // 
            // chkWed
            // 
            this.chkWed.AutoSize = true;
            this.chkWed.Location = new System.Drawing.Point(200, 40);
            this.chkWed.Name = "chkWed";
            this.chkWed.Size = new System.Drawing.Size(60, 16);
            this.chkWed.TabIndex = 6;
            this.chkWed.Text = "星期三";
            this.chkWed.UseVisualStyleBackColor = true;
            // 
            // chkTue
            // 
            this.chkTue.AutoSize = true;
            this.chkTue.Location = new System.Drawing.Point(120, 40);
            this.chkTue.Name = "chkTue";
            this.chkTue.Size = new System.Drawing.Size(60, 16);
            this.chkTue.TabIndex = 5;
            this.chkTue.Text = "星期二";
            this.chkTue.UseVisualStyleBackColor = true;
            // 
            // chkMon
            // 
            this.chkMon.AutoSize = true;
            this.chkMon.Location = new System.Drawing.Point(40, 40);
            this.chkMon.Name = "chkMon";
            this.chkMon.Size = new System.Drawing.Size(60, 16);
            this.chkMon.TabIndex = 4;
            this.chkMon.Text = "星期一";
            this.chkMon.UseVisualStyleBackColor = true;
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(299, 81);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(17, 12);
            this.lblM.TabIndex = 3;
            this.lblM.Text = "至";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(337, 78);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(45, 21);
            this.txtEnd.TabIndex = 2;
            this.txtEnd.Text = "17:00";
            this.txtEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(231, 78);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(45, 21);
            this.txtStart.TabIndex = 1;
            this.txtStart.Text = "08:00";
            this.txtStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(74, 268);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 12);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 403);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnVerify);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkSun;
        private System.Windows.Forms.CheckBox chkSat;
        private System.Windows.Forms.CheckBox chkFri;
        private System.Windows.Forms.CheckBox chkThu;
        private System.Windows.Forms.CheckBox chkWed;
        private System.Windows.Forms.CheckBox chkTue;
        private System.Windows.Forms.CheckBox chkMon;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label lblTime;
    }
}

