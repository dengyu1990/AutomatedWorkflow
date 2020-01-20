using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.DirectoryServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace autoApprovalLocal
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }
        //初始化加载配置数据
        private void frmConfig_Load(object sender, EventArgs e)
        {                      
            foreach (string key in frmMain.titlewhites)
            {
                lstTitleWhite.Items.Add(key);
            }

            foreach (string key in frmMain.titleblacks)
            {
                lstTitleBlack.Items.Add(key);
            }

            foreach (string name in frmMain.namewhites)
            {
                lstNameWhite.Items.Add(name);
            }

            foreach (string bname in frmMain.nameblacks)
            {
                lstNameBlack.Items.Add(bname);
            }

            txtUM.Text = Properties.Settings.Default.UM;
            //txtPWD.Text = frmMain.BCutEncrypt(Properties.Settings.Default.PWD);  //这条需要注释一下，稍后再打打开
            txtPWD.Text = "";
            txtRNDMAX.Text = Properties.Settings.Default.rndMax.ToString();
            string tmp = Properties.Settings.Default.dtRange.ToString();
            if (tmp == "")
                tmp = "True-True-True-True-True-True-True-00:01-23:59";
            string[] exs = tmp.Split('-');
            chkMon.Checked = Convert.ToBoolean(exs[0]);
            chkTue.Checked = Convert.ToBoolean(exs[1]);
            chkWed.Checked = Convert.ToBoolean(exs[2]);
            chkThu.Checked = Convert.ToBoolean(exs[3]);
            chkFri.Checked = Convert.ToBoolean(exs[4]);
            chkSat.Checked = Convert.ToBoolean(exs[5]);
            chkSun.Checked = Convert.ToBoolean(exs[6]);
            txtStart.Text = exs[7];
            txtEnd.Text = exs[8];
        }


        //标题白名单新增与删除
        private void btnWhiteTitleKeyAdd_Click(object sender, EventArgs e)
        {
            string strKWord = txtTitleWhiteKey.Text.Trim();
            if (strKWord != "" && !strKWord.Contains("  ") && !lstTitleWhite.Items.Contains(strKWord))
            {
                if (lstTitleWhite.Items.Contains(strKWord))
                {
                    MessageBox.Show("该关键字不能同时出现在黑白名单中！", "检测到互斥", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmMain.titlewhites.Add(strKWord);
                lstTitleWhite.Items.Add(strKWord);
            }
            txtTitleWhiteKey.Text = "";
        }

        private void btnWhiteTitleKeyDel_Click(object sender, EventArgs e)
        {
            if (lstTitleWhite.SelectedItems.Count > 0)
            {
                string strSelected = lstTitleWhite.SelectedItem.ToString();
                if (lstTitleWhite.Items.Contains(strSelected))
                {
                    frmMain.titlewhites.Remove(strSelected);
                    lstTitleWhite.Items.Remove(strSelected);
                }
            }
        }

        //标题黑名单新增与删除
        private void btnBlackTitleKeyAdd_Click(object sender, EventArgs e)
        {
            string strKWord = txtTitleBlackKey.Text.Trim();
            if (strKWord != "" && !strKWord.Contains("  ") && !lstTitleBlack.Items.Contains(strKWord))
            {
                if (lstTitleBlack.Items.Contains(strKWord))
                {
                    MessageBox.Show("该关键字不能同时出现在黑白名单中！", "检测到互斥", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmMain.titleblacks.Add(strKWord);
                lstTitleBlack.Items.Add(strKWord);
            }
            txtTitleBlackKey.Text = "";
        }

        private void btnBlackTitleKeyDel_Click(object sender, EventArgs e)
        {
            if (lstTitleBlack.SelectedItems.Count > 0)
            {
                string strSelected = lstTitleBlack.SelectedItem.ToString();
                if (lstTitleBlack.Items.Contains(strSelected))
                {
                    frmMain.titleblacks.Remove(strSelected);
                    lstTitleBlack.Items.Remove(strSelected);
                }
            }
        }

        //姓名白名单新增与删除
        private void btnWhiteNameAdd_Click(object sender, EventArgs e)
        {
            string strAD = txtWhiteName.Text.Trim();
            if (strAD != "" && !lstNameWhite.Items.Contains(strAD))
            {
                if (lstNameBlack.Items.Contains(strAD))
                {
                    MessageBox.Show("该姓名不能同时出现在黑白名单中！", "检测到互斥", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmMain.namewhites.Add(strAD);
                lstNameWhite.Items.Add(strAD);
            }
            txtWhiteName.Text = "";
        }

        private void btnWhiteNameDel_Click(object sender, EventArgs e)
        {
            if (lstNameWhite.SelectedItems.Count > 0)
            {
                string strSelected = lstNameWhite.SelectedItem.ToString();
                if (lstNameWhite.Items.Contains(strSelected))
                {
                    frmMain.namewhites.Remove(strSelected);
                    lstNameWhite.Items.Remove(strSelected);
                }
            }
        }
        //姓名黑名单新增与删除
        private void btnBlackNameAdd_Click(object sender, EventArgs e)
        {
            string bname = txtBlackName.Text.Trim();
            if (bname != "" && !lstNameBlack.Items.Contains(bname))
            {
                if (lstNameWhite.Items.Contains(bname))
                {
                    MessageBox.Show("该姓名不能同时出现在黑白名单中！", "检测到互斥", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmMain.nameblacks.Add(bname);
                lstNameBlack.Items.Add(bname);
            }
            txtBlackName.Text = "";
        }

        private void btnBlackNameDel_Click(object sender, EventArgs e)
        {
            if (lstNameBlack.SelectedItems.Count > 0)
            {
                string strSelected = lstNameBlack.SelectedItem.ToString();
                if (lstNameBlack.Items.Contains(strSelected))
                {
                    frmMain.nameblacks.Remove(strSelected);
                    lstNameBlack.Items.Remove(strSelected);
                }
            }
        }
       
        //保存配置修改
        private void btnSave_Click(object sender, EventArgs e)
        {
            int max;
            string str_pwd = txtPWD.Text.Trim();
            if (int.TryParse(txtRNDMAX.Text, out max))
            {
                if (max < 5 || max > 120)
                {
                    MessageBox.Show("最大随机值需设置在5到120之间", "超出设置范围", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                frmMain.rnd_max = max; //炒鸡全局变量哈
                Properties.Settings.Default.rndMax = frmMain.rnd_max;
            }
            else
            {
                MessageBox.Show("最大随机值须为5到120之间的整数", "设置错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Properties.Settings.Default.titlewhite = frmMain.titlewhites;
            Properties.Settings.Default.titleblack = frmMain.titleblacks;
            Properties.Settings.Default.namewhite = frmMain.namewhites;
            Properties.Settings.Default.nameblack = frmMain.nameblacks;
            Properties.Settings.Default.UM = txtUM.Text.Trim();
            if (str_pwd != "")
                Properties.Settings.Default.PWD = frmMain.BCutEncrypt(str_pwd);

            bool[] ori = new bool[7];
            ori[0] = chkMon.Checked;
            ori[1] = chkTue.Checked;
            ori[2] = chkWed.Checked;
            ori[3] = chkThu.Checked;
            ori[4] = chkFri.Checked;
            ori[5] = chkSat.Checked;
            ori[6] = chkSun.Checked;
            string store = string.Format("{0}-{1}-{2}-{3}-{4}-{5}-{6}-{7}-{8}", ori[0], ori[1], ori[2], ori[3], ori[4], ori[5], ori[6], txtStart.Text.Trim(), txtEnd.Text.Trim());
            if (IsDate(txtStart.Text.Trim()) && IsDate(txtEnd.Text.Trim()))
            {
                frmMain.dt_range = store;
                Properties.Settings.Default.dtRange = frmMain.dt_range;
            }
            else
            {
                MessageBox.Show("请输入标准日志，格式如06:19,23:00之类", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }                

            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("保存成功，已立即生效！", "自动审批", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private bool IsDate(string str)
        {
            return Regex.IsMatch(str, @"^((20|21|22|23|[0-1]?\d):[0-5]?\d)$");
        }

        //取消配置修改
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            frmMain.titlewhites = Properties.Settings.Default.titlewhite;
            frmMain.titleblacks = Properties.Settings.Default.titleblack;
            frmMain.namewhites = Properties.Settings.Default.namewhite;
            frmMain.nameblacks = Properties.Settings.Default.nameblack;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fs = new FileStream(@"D:\config.txt", FileMode.Append))
                {
                    string all = "-------标题白名单-------\r\n" + getData(frmMain.titlewhites) + "-------标题黑名单-------\r\n" + getData(frmMain.titleblacks) + "-------姓名白名单-------\r\n" + getData(frmMain.namewhites) + "-------姓名黑名单-------\r\n" + getData(frmMain.nameblacks);
                    var code = System.Text.Encoding.Default.GetBytes(all);
                    fs.Write(code, 0, code.Length);
                    fs.Flush();
                    fs.Close();
                }
                MessageBox.Show("配置导出成功，在D盘根路径下", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("配置导出失败:" + ex.ToString(), "未知异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public string getData(StringCollection data)
        {
            string strConfig = null;
            foreach (string str in data)
            {
                strConfig += str;
                strConfig += "\r\n";
            }
            return strConfig;
        }

        public void clearData(StringCollection[] cols)
        {
            foreach (StringCollection col in cols)
                col.Clear();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            
            string flag = null;
            try
            {
                string[] lines = File.ReadAllLines(@"D:\config.txt", Encoding.Default);
                StringCollection[] origins = new StringCollection[8] {
                    Properties.Settings.Default.titlewhite, Properties.Settings.Default.titleblack,
                    Properties.Settings.Default.namewhite, Properties.Settings.Default.nameblack,
                    frmMain.titlewhites, frmMain.titleblacks, frmMain.namewhites, frmMain.nameblacks
                };
                clearData(origins);
                foreach (string line in lines)
                {
                    if (line.Contains("-------"))
                    {
                        flag = line.Trim('-');
                        continue;
                    }
                    switch (flag)
                    {
                        case "标题白名单":
                            frmMain.titlewhites.Add(line);
                            break;
                        case "标题黑名单":
                            frmMain.titleblacks.Add(line);
                            break;
                        case "姓名白名单":
                            frmMain.namewhites.Add(line);
                            break;
                        case "姓名黑名单":
                            frmMain.nameblacks.Add(line);
                            break;
                    }
                    Properties.Settings.Default.titlewhite = frmMain.titlewhites;
                    Properties.Settings.Default.titleblack = frmMain.titleblacks;
                    Properties.Settings.Default.namewhite = frmMain.namewhites;
                    Properties.Settings.Default.nameblack = frmMain.nameblacks;
                    Properties.Settings.Default.Save();
                }
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("导入成功，已实时生效！", "自动审批", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch {
                MessageBox.Show("检测到D盘根目录下不存在config.txt的配置文件！");
                return;
            }

            
        }
    }
}
