using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace verifyForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string strRange = "False-True-True-True-True-False-True-19:00-23:00";
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] exs = strRange.Split('-');

            chkMon.Checked = Convert.ToBoolean(exs[0]);
            chkTue.Checked = Convert.ToBoolean(exs[1]);
            chkWed.Checked = Convert.ToBoolean(exs[2]);
            chkThu.Checked = Convert.ToBoolean(exs[3]);
            chkFri.Checked = Convert.ToBoolean(exs[4]);
            chkSat.Checked = Convert.ToBoolean(exs[5]);
            chkSun.Checked = Convert.ToBoolean(exs[6]);

            txtStart.Text = exs[7];
            txtEnd.Text = exs[8];

            lblTime.Text = DateTime.Now.ToString();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            /*
            bool[] ori = new bool[7];
            ori[0] = chkMon.Checked;
            ori[1] = chkTue.Checked;
            ori[2] = chkWed.Checked;
            ori[3] = chkThu.Checked;
            ori[4] = chkFri.Checked;
            ori[5] = chkSat.Checked;
            ori[6] = chkSun.Checked;
            
            string store = string.Format("{0}-{1}-{2}-{3}-{4}-{5}-{6}-{7}-{8}", ori[0], ori[1], ori[2], ori[3], ori[4], ori[5], ori[6], txtStart.Text.Trim(), txtEnd.Text.Trim());
            */

            if (IsDate(txtStart.Text.Trim()) && IsDate(txtEnd.Text.Trim()))
            {
                //MessageBox.Show(store+"\n"+"是否在匹配范围内？");
                //这里加上判断当前时间是否在预设时间内的
                MessageBox.Show("当前配置：" + strRange + "日期判断：" + isInRange(strRange.Split('-')).ToString() + "时间判断："+ isInTime(strRange.Split('-')).ToString());
            }
            else
            {
                MessageBox.Show("请输入标准日志，格式如06:19,23:00之类", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static bool IsDate(string str)
        {
            return Regex.IsMatch(str, @"^((20|21|22|23|[0-1]?\d):[0-5]?\d)$");
        }

        public static bool isInRange(string[] exs)
        {
            switch (DateTime.Now.DayOfWeek.ToString())
            {
                case "Monday":
                    Console.WriteLine("Monday");
                    return Convert.ToBoolean(exs[0]);
                case "Tuesday":
                    Console.WriteLine("Tuesday");
                    return Convert.ToBoolean(exs[1]);
                case "Wednesday":
                    Console.WriteLine("Wednesday");
                    return Convert.ToBoolean(exs[2]);
                case "Thursday":
                    Console.WriteLine("Thursday");
                    return Convert.ToBoolean(exs[3]);
                case "Friday":
                    Console.WriteLine("Friday");
                    return Convert.ToBoolean(exs[4]);
                case "Saturday":
                    Console.WriteLine("Saturday");
                    return Convert.ToBoolean(exs[5]);
                case "Sunday":
                    Console.WriteLine("Sunday");
                    return Convert.ToBoolean(exs[6]);
            }
            return true;
        }
        public static bool isInTime(string[] exs)
        {
            TimeSpan workStart = DateTime.Parse(exs[7]).TimeOfDay;
            TimeSpan workEnd = DateTime.Parse(exs[8]).TimeOfDay;
            TimeSpan now = DateTime.Now.TimeOfDay;
            if ((now > workStart && now < workEnd) || workStart > workEnd)
            {
                return true;
            }
            return false;
        }
    }
}
