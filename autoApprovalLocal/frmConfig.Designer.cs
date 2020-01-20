namespace autoApprovalLocal
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.lstTitleWhite = new System.Windows.Forms.ListBox();
            this.lstNameWhite = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabCMain = new System.Windows.Forms.TabControl();
            this.tabPTitleBlack = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitleBlackKey = new System.Windows.Forms.TextBox();
            this.btnBlackTitleKeyAdd = new System.Windows.Forms.Button();
            this.btnBlackTitleKeyDel = new System.Windows.Forms.Button();
            this.lstTitleBlack = new System.Windows.Forms.ListBox();
            this.tabPNameBlack = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBlackName = new System.Windows.Forms.TextBox();
            this.btnBlackNameAdd = new System.Windows.Forms.Button();
            this.btnBlackNameDel = new System.Windows.Forms.Button();
            this.lstNameBlack = new System.Windows.Forms.ListBox();
            this.tabPSetting = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRNDMAX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.tabPTitleWhite = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitleWhiteKey = new System.Windows.Forms.TextBox();
            this.btnWhiteTitleKeyAdd = new System.Windows.Forms.Button();
            this.btnWhiteTitleKeyDel = new System.Windows.Forms.Button();
            this.tabPNameWhite = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWhiteName = new System.Windows.Forms.TextBox();
            this.btnWhiteNameAdd = new System.Windows.Forms.Button();
            this.btnWhiteNameDel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.frmMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabCMain.SuspendLayout();
            this.tabPTitleBlack.SuspendLayout();
            this.tabPNameBlack.SuspendLayout();
            this.tabPSetting.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPTitleWhite.SuspendLayout();
            this.tabPNameWhite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmMainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lstTitleWhite
            // 
            this.lstTitleWhite.FormattingEnabled = true;
            this.lstTitleWhite.ItemHeight = 12;
            this.lstTitleWhite.Location = new System.Drawing.Point(20, 17);
            this.lstTitleWhite.Name = "lstTitleWhite";
            this.lstTitleWhite.Size = new System.Drawing.Size(246, 304);
            this.lstTitleWhite.TabIndex = 0;
            // 
            // lstNameWhite
            // 
            this.lstNameWhite.FormattingEnabled = true;
            this.lstNameWhite.ItemHeight = 12;
            this.lstNameWhite.Location = new System.Drawing.Point(18, 17);
            this.lstNameWhite.Name = "lstNameWhite";
            this.lstNameWhite.Size = new System.Drawing.Size(248, 304);
            this.lstNameWhite.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(379, 419);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 35);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存修改";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(493, 419);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabCMain
            // 
            this.tabCMain.Controls.Add(this.tabPTitleBlack);
            this.tabCMain.Controls.Add(this.tabPNameBlack);
            this.tabCMain.Controls.Add(this.tabPSetting);
            this.tabCMain.Controls.Add(this.tabPTitleWhite);
            this.tabCMain.Controls.Add(this.tabPNameWhite);
            this.tabCMain.Location = new System.Drawing.Point(31, 29);
            this.tabCMain.Name = "tabCMain";
            this.tabCMain.SelectedIndex = 0;
            this.tabCMain.Size = new System.Drawing.Size(537, 366);
            this.tabCMain.TabIndex = 4;
            // 
            // tabPTitleBlack
            // 
            this.tabPTitleBlack.Controls.Add(this.label11);
            this.tabPTitleBlack.Controls.Add(this.label6);
            this.tabPTitleBlack.Controls.Add(this.txtTitleBlackKey);
            this.tabPTitleBlack.Controls.Add(this.btnBlackTitleKeyAdd);
            this.tabPTitleBlack.Controls.Add(this.btnBlackTitleKeyDel);
            this.tabPTitleBlack.Controls.Add(this.lstTitleBlack);
            this.tabPTitleBlack.Location = new System.Drawing.Point(4, 22);
            this.tabPTitleBlack.Name = "tabPTitleBlack";
            this.tabPTitleBlack.Padding = new System.Windows.Forms.Padding(3);
            this.tabPTitleBlack.Size = new System.Drawing.Size(529, 340);
            this.tabPTitleBlack.TabIndex = 4;
            this.tabPTitleBlack.Text = "标题黑名单";
            this.tabPTitleBlack.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(298, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "*支持多关键字同时匹配 中间空格隔开";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "关键字";
            // 
            // txtTitleBlackKey
            // 
            this.txtTitleBlackKey.Location = new System.Drawing.Point(329, 48);
            this.txtTitleBlackKey.MaxLength = 128;
            this.txtTitleBlackKey.Name = "txtTitleBlackKey";
            this.txtTitleBlackKey.Size = new System.Drawing.Size(178, 21);
            this.txtTitleBlackKey.TabIndex = 8;
            // 
            // btnBlackTitleKeyAdd
            // 
            this.btnBlackTitleKeyAdd.Location = new System.Drawing.Point(348, 124);
            this.btnBlackTitleKeyAdd.Name = "btnBlackTitleKeyAdd";
            this.btnBlackTitleKeyAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBlackTitleKeyAdd.TabIndex = 7;
            this.btnBlackTitleKeyAdd.Text = "<< 新增";
            this.btnBlackTitleKeyAdd.UseVisualStyleBackColor = true;
            this.btnBlackTitleKeyAdd.Click += new System.EventHandler(this.btnBlackTitleKeyAdd_Click);
            // 
            // btnBlackTitleKeyDel
            // 
            this.btnBlackTitleKeyDel.Location = new System.Drawing.Point(348, 211);
            this.btnBlackTitleKeyDel.Name = "btnBlackTitleKeyDel";
            this.btnBlackTitleKeyDel.Size = new System.Drawing.Size(75, 23);
            this.btnBlackTitleKeyDel.TabIndex = 6;
            this.btnBlackTitleKeyDel.Text = "删除 >>";
            this.btnBlackTitleKeyDel.UseVisualStyleBackColor = true;
            this.btnBlackTitleKeyDel.Click += new System.EventHandler(this.btnBlackTitleKeyDel_Click);
            // 
            // lstTitleBlack
            // 
            this.lstTitleBlack.FormattingEnabled = true;
            this.lstTitleBlack.ItemHeight = 12;
            this.lstTitleBlack.Location = new System.Drawing.Point(21, 18);
            this.lstTitleBlack.Name = "lstTitleBlack";
            this.lstTitleBlack.Size = new System.Drawing.Size(246, 304);
            this.lstTitleBlack.TabIndex = 5;
            // 
            // tabPNameBlack
            // 
            this.tabPNameBlack.Controls.Add(this.label5);
            this.tabPNameBlack.Controls.Add(this.txtBlackName);
            this.tabPNameBlack.Controls.Add(this.btnBlackNameAdd);
            this.tabPNameBlack.Controls.Add(this.btnBlackNameDel);
            this.tabPNameBlack.Controls.Add(this.lstNameBlack);
            this.tabPNameBlack.Location = new System.Drawing.Point(4, 22);
            this.tabPNameBlack.Name = "tabPNameBlack";
            this.tabPNameBlack.Padding = new System.Windows.Forms.Padding(3);
            this.tabPNameBlack.Size = new System.Drawing.Size(529, 340);
            this.tabPNameBlack.TabIndex = 3;
            this.tabPNameBlack.Text = "姓名黑名单";
            this.tabPNameBlack.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "姓名";
            // 
            // txtBlackName
            // 
            this.txtBlackName.Location = new System.Drawing.Point(357, 43);
            this.txtBlackName.Name = "txtBlackName";
            this.txtBlackName.Size = new System.Drawing.Size(128, 21);
            this.txtBlackName.TabIndex = 11;
            // 
            // btnBlackNameAdd
            // 
            this.btnBlackNameAdd.ForeColor = System.Drawing.Color.Black;
            this.btnBlackNameAdd.Location = new System.Drawing.Point(373, 124);
            this.btnBlackNameAdd.Name = "btnBlackNameAdd";
            this.btnBlackNameAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBlackNameAdd.TabIndex = 10;
            this.btnBlackNameAdd.Text = "<< 新增";
            this.btnBlackNameAdd.UseVisualStyleBackColor = true;
            this.btnBlackNameAdd.Click += new System.EventHandler(this.btnBlackNameAdd_Click);
            // 
            // btnBlackNameDel
            // 
            this.btnBlackNameDel.ForeColor = System.Drawing.Color.Black;
            this.btnBlackNameDel.Location = new System.Drawing.Point(373, 214);
            this.btnBlackNameDel.Name = "btnBlackNameDel";
            this.btnBlackNameDel.Size = new System.Drawing.Size(75, 23);
            this.btnBlackNameDel.TabIndex = 9;
            this.btnBlackNameDel.Text = "删除 >>";
            this.btnBlackNameDel.UseVisualStyleBackColor = true;
            this.btnBlackNameDel.Click += new System.EventHandler(this.btnBlackNameDel_Click);
            // 
            // lstNameBlack
            // 
            this.lstNameBlack.FormattingEnabled = true;
            this.lstNameBlack.ItemHeight = 12;
            this.lstNameBlack.Location = new System.Drawing.Point(44, 18);
            this.lstNameBlack.Name = "lstNameBlack";
            this.lstNameBlack.Size = new System.Drawing.Size(248, 304);
            this.lstNameBlack.TabIndex = 8;
            // 
            // tabPSetting
            // 
            this.tabPSetting.Controls.Add(this.groupBox3);
            this.tabPSetting.Controls.Add(this.groupBox2);
            this.tabPSetting.Controls.Add(this.groupBox1);
            this.tabPSetting.Location = new System.Drawing.Point(4, 22);
            this.tabPSetting.Name = "tabPSetting";
            this.tabPSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPSetting.Size = new System.Drawing.Size(529, 340);
            this.tabPSetting.TabIndex = 2;
            this.tabPSetting.Text = "自动触发配置";
            this.tabPSetting.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRNDMAX);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(267, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 126);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "设置随机范围的最大值";
            // 
            // txtRNDMAX
            // 
            this.txtRNDMAX.Location = new System.Drawing.Point(77, 55);
            this.txtRNDMAX.MaxLength = 3;
            this.txtRNDMAX.Name = "txtRNDMAX";
            this.txtRNDMAX.Size = new System.Drawing.Size(52, 21);
            this.txtRNDMAX.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "3秒  至";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "秒（5~120）";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
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
            this.groupBox2.Location = new System.Drawing.Point(22, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 131);
            this.groupBox2.TabIndex = 10;
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
            this.txtEnd.Text = "17:30";
            this.txtEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(231, 78);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(45, 21);
            this.txtStart.TabIndex = 1;
            this.txtStart.Text = "08:30";
            this.txtStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPWD);
            this.groupBox1.Location = new System.Drawing.Point(22, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 126);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "自动登录";
            // 
            // txtUM
            // 
            this.txtUM.Location = new System.Drawing.Point(74, 35);
            this.txtUM.MaxLength = 18;
            this.txtUM.Name = "txtUM";
            this.txtUM.Size = new System.Drawing.Size(126, 21);
            this.txtUM.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "帐 号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "密 码";
            // 
            // txtPWD
            // 
            this.txtPWD.Location = new System.Drawing.Point(74, 78);
            this.txtPWD.MaxLength = 18;
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.PasswordChar = '*';
            this.txtPWD.Size = new System.Drawing.Size(126, 21);
            this.txtPWD.TabIndex = 4;
            // 
            // tabPTitleWhite
            // 
            this.tabPTitleWhite.Controls.Add(this.label10);
            this.tabPTitleWhite.Controls.Add(this.label3);
            this.tabPTitleWhite.Controls.Add(this.txtTitleWhiteKey);
            this.tabPTitleWhite.Controls.Add(this.btnWhiteTitleKeyAdd);
            this.tabPTitleWhite.Controls.Add(this.btnWhiteTitleKeyDel);
            this.tabPTitleWhite.Controls.Add(this.lstTitleWhite);
            this.tabPTitleWhite.Location = new System.Drawing.Point(4, 22);
            this.tabPTitleWhite.Name = "tabPTitleWhite";
            this.tabPTitleWhite.Padding = new System.Windows.Forms.Padding(3);
            this.tabPTitleWhite.Size = new System.Drawing.Size(529, 340);
            this.tabPTitleWhite.TabIndex = 0;
            this.tabPTitleWhite.Text = "标题白名单";
            this.tabPTitleWhite.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(281, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "*支持多关键字同时匹配 中间空格隔开";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "关键字";
            // 
            // txtTitleWhiteKey
            // 
            this.txtTitleWhiteKey.Location = new System.Drawing.Point(328, 47);
            this.txtTitleWhiteKey.MaxLength = 128;
            this.txtTitleWhiteKey.Name = "txtTitleWhiteKey";
            this.txtTitleWhiteKey.Size = new System.Drawing.Size(178, 21);
            this.txtTitleWhiteKey.TabIndex = 3;
            // 
            // btnWhiteTitleKeyAdd
            // 
            this.btnWhiteTitleKeyAdd.Location = new System.Drawing.Point(347, 123);
            this.btnWhiteTitleKeyAdd.Name = "btnWhiteTitleKeyAdd";
            this.btnWhiteTitleKeyAdd.Size = new System.Drawing.Size(75, 23);
            this.btnWhiteTitleKeyAdd.TabIndex = 2;
            this.btnWhiteTitleKeyAdd.Text = "<< 新增";
            this.btnWhiteTitleKeyAdd.UseVisualStyleBackColor = true;
            this.btnWhiteTitleKeyAdd.Click += new System.EventHandler(this.btnWhiteTitleKeyAdd_Click);
            // 
            // btnWhiteTitleKeyDel
            // 
            this.btnWhiteTitleKeyDel.Location = new System.Drawing.Point(347, 210);
            this.btnWhiteTitleKeyDel.Name = "btnWhiteTitleKeyDel";
            this.btnWhiteTitleKeyDel.Size = new System.Drawing.Size(75, 23);
            this.btnWhiteTitleKeyDel.TabIndex = 1;
            this.btnWhiteTitleKeyDel.Text = "删除 >>";
            this.btnWhiteTitleKeyDel.UseVisualStyleBackColor = true;
            this.btnWhiteTitleKeyDel.Click += new System.EventHandler(this.btnWhiteTitleKeyDel_Click);
            // 
            // tabPNameWhite
            // 
            this.tabPNameWhite.Controls.Add(this.label1);
            this.tabPNameWhite.Controls.Add(this.txtWhiteName);
            this.tabPNameWhite.Controls.Add(this.btnWhiteNameAdd);
            this.tabPNameWhite.Controls.Add(this.btnWhiteNameDel);
            this.tabPNameWhite.Controls.Add(this.lstNameWhite);
            this.tabPNameWhite.Location = new System.Drawing.Point(4, 22);
            this.tabPNameWhite.Name = "tabPNameWhite";
            this.tabPNameWhite.Padding = new System.Windows.Forms.Padding(3);
            this.tabPNameWhite.Size = new System.Drawing.Size(529, 340);
            this.tabPNameWhite.TabIndex = 1;
            this.tabPNameWhite.Text = "姓名白名单";
            this.tabPNameWhite.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "姓名";
            // 
            // txtWhiteName
            // 
            this.txtWhiteName.Location = new System.Drawing.Point(331, 42);
            this.txtWhiteName.Name = "txtWhiteName";
            this.txtWhiteName.Size = new System.Drawing.Size(128, 21);
            this.txtWhiteName.TabIndex = 6;
            // 
            // btnWhiteNameAdd
            // 
            this.btnWhiteNameAdd.Location = new System.Drawing.Point(347, 123);
            this.btnWhiteNameAdd.Name = "btnWhiteNameAdd";
            this.btnWhiteNameAdd.Size = new System.Drawing.Size(75, 23);
            this.btnWhiteNameAdd.TabIndex = 5;
            this.btnWhiteNameAdd.Text = "<< 新增";
            this.btnWhiteNameAdd.UseVisualStyleBackColor = true;
            this.btnWhiteNameAdd.Click += new System.EventHandler(this.btnWhiteNameAdd_Click);
            // 
            // btnWhiteNameDel
            // 
            this.btnWhiteNameDel.Location = new System.Drawing.Point(347, 213);
            this.btnWhiteNameDel.Name = "btnWhiteNameDel";
            this.btnWhiteNameDel.Size = new System.Drawing.Size(75, 23);
            this.btnWhiteNameDel.TabIndex = 4;
            this.btnWhiteNameDel.Text = "删除 >>";
            this.btnWhiteNameDel.UseVisualStyleBackColor = true;
            this.btnWhiteNameDel.Click += new System.EventHandler(this.btnWhiteNameDel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(12, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(347, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "*黑名单有一个即不审批，在无黑名单前提下白名单有一个即放行";
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(31, 425);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(41, 23);
            this.btnOutput.TabIndex = 6;
            this.btnOutput.Text = "导出";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(78, 425);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(41, 23);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DarkGray;
            this.label12.Location = new System.Drawing.Point(218, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(239, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "*终止时间如果大于起始时间则默认全天执行";
            // 
            // frmMainBindingSource
            // 
            this.frmMainBindingSource.DataSource = typeof(autoApprovalLocal.frmMain);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(601, 487);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabCMain);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfig";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.tabCMain.ResumeLayout(false);
            this.tabPTitleBlack.ResumeLayout(false);
            this.tabPTitleBlack.PerformLayout();
            this.tabPNameBlack.ResumeLayout(false);
            this.tabPNameBlack.PerformLayout();
            this.tabPSetting.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPTitleWhite.ResumeLayout(false);
            this.tabPTitleWhite.PerformLayout();
            this.tabPNameWhite.ResumeLayout(false);
            this.tabPNameWhite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmMainBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource frmMainBindingSource;
        private System.Windows.Forms.ListBox lstTitleWhite;
        private System.Windows.Forms.ListBox lstNameWhite;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabCMain;
        private System.Windows.Forms.TabPage tabPTitleWhite;
        private System.Windows.Forms.TextBox txtTitleWhiteKey;
        private System.Windows.Forms.Button btnWhiteTitleKeyAdd;
        private System.Windows.Forms.Button btnWhiteTitleKeyDel;
        private System.Windows.Forms.TabPage tabPNameWhite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWhiteName;
        private System.Windows.Forms.Button btnWhiteNameAdd;
        private System.Windows.Forms.Button btnWhiteNameDel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPSetting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.TextBox txtUM;
        private System.Windows.Forms.TabPage tabPNameBlack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBlackName;
        private System.Windows.Forms.Button btnBlackNameAdd;
        private System.Windows.Forms.Button btnBlackNameDel;
        private System.Windows.Forms.ListBox lstNameBlack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRNDMAX;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.CheckBox chkSun;
        private System.Windows.Forms.CheckBox chkSat;
        private System.Windows.Forms.CheckBox chkFri;
        private System.Windows.Forms.CheckBox chkThu;
        private System.Windows.Forms.CheckBox chkWed;
        private System.Windows.Forms.CheckBox chkTue;
        private System.Windows.Forms.CheckBox chkMon;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TabPage tabPTitleBlack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTitleBlackKey;
        private System.Windows.Forms.Button btnBlackTitleKeyAdd;
        private System.Windows.Forms.Button btnBlackTitleKeyDel;
        private System.Windows.Forms.ListBox lstTitleBlack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label12;
    }
}