namespace autoApprovalLocal
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.web = new System.Windows.Forms.WebBrowser();
            this.tmrExecute = new System.Windows.Forms.Timer(this.components);
            this.btnConfig = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnMini = new System.Windows.Forms.Button();
            this.notifyIconM = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblState = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.NotifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // web
            // 
            this.web.Location = new System.Drawing.Point(3, 3);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.ScrollBarsEnabled = false;
            this.web.Size = new System.Drawing.Size(994, 556);
            this.web.TabIndex = 0;
            this.web.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.web_DocumentCompleted);
            // 
            // tmrExecute
            // 
            this.tmrExecute.Interval = 1000;
            this.tmrExecute.Tick += new System.EventHandler(this.tmrExecute_Tick);
            // 
            // btnConfig
            // 
            this.btnConfig.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfig.ForeColor = System.Drawing.Color.Sienna;
            this.btnConfig.Location = new System.Drawing.Point(710, 578);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(93, 43);
            this.btnConfig.TabIndex = 1;
            this.btnConfig.Text = "配置";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg.ForeColor = System.Drawing.Color.Black;
            this.lblMsg.Location = new System.Drawing.Point(54, 584);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(147, 14);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "（请先点击配置按钮）";
            // 
            // btnMini
            // 
            this.btnMini.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMini.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnMini.Location = new System.Drawing.Point(831, 578);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(93, 43);
            this.btnMini.TabIndex = 3;
            this.btnMini.Text = "静默执行";
            this.btnMini.UseVisualStyleBackColor = true;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // notifyIconM
            // 
            this.notifyIconM.ContextMenuStrip = this.NotifyMenu;
            this.notifyIconM.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconM.Icon")));
            this.notifyIconM.Text = "Automatic Approval System";
            this.notifyIconM.Visible = true;
            this.notifyIconM.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconM_MouseDoubleClick);
            // 
            // NotifyMenu
            // 
            this.NotifyMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.NotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.退出ToolStripMenuItem});
            this.NotifyMenu.Name = "NotifyMenu";
            this.NotifyMenu.Size = new System.Drawing.Size(125, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem1.Text = "显示窗口";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.ForeColor = System.Drawing.Color.DimGray;
            this.lblState.Location = new System.Drawing.Point(12, 614);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(107, 12);
            this.lblState.TabIndex = 5;
            this.lblState.Text = "状态栏初始化中...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(932, 614);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Build 2020";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(3, 629);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(994, 171);
            this.txtLog.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 728);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.web);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.NotifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.Timer tmrExecute;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.NotifyIcon notifyIconM;
        private System.Windows.Forms.ContextMenuStrip NotifyMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLog;
    }
}