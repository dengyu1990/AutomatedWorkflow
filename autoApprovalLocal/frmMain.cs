using System;
using System.Collections.Specialized;
using System.Text;
using System.Windows.Forms;

namespace autoApprovalLocal
{
    
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            web.ScriptErrorsSuppressed = true;
            web.Navigate("http://i.icefish.cn/login");
        }
        public static int dan_nums = 0;
        public static int exc_time = 10;
        public static int rnd_max = 5;
        public static string dt_range = "True-True-True-True-True-True-True-08:30-17:30"; //默认值
        public static StringCollection titlewhites = new StringCollection();
        public static StringCollection titleblacks = new StringCollection();
        public static StringCollection namewhites = new StringCollection();
        public static StringCollection nameblacks = new StringCollection();
       
        Random rnd = new Random();
        DateTime start_time = DateTime.Now;
        string str_start = DateTime.Now.ToLongDateString() + DateTime.Now.ToShortTimeString();

        private void frmMain_Load(object sender, EventArgs e)
        {
            titlewhites = Properties.Settings.Default.titlewhite;
            titleblacks = Properties.Settings.Default.titleblack;
            namewhites = Properties.Settings.Default.namewhite;
            nameblacks = Properties.Settings.Default.nameblack;
            rnd_max = Properties.Settings.Default.rndMax;
            dt_range = Properties.Settings.Default.dtRange;
        }
          
        private void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url != web.Url || web.ReadyState != WebBrowserReadyState.Complete)
                return;               
            string url = web.Url.AbsoluteUri;
            lblState.Text = url;
            if (url.IndexOf("http://i.icefish.cn/login") == 0)
            {
                string um = Properties.Settings.Default.UM;
                string pwd = BCutEncrypt(Properties.Settings.Default.PWD);
                if (um == "")
                {
                    MessageBox.Show("检测到首次启动，请在配置中（自动登录帐号）填入冰鱼帐号及密码哈~");
                    frmConfig frmC = new frmConfig();
                    frmC.ShowDialog();
                    return;
                }
                HtmlElement UM = web.Document.GetElementById("j_username");
                UM.SetAttribute("value", um);
                HtmlElement PWD = web.Document.GetElementById("j_password");
                PWD.SetAttribute("value", pwd);
                HtmlElementCollection btnS = web.Document.GetElementsByTagName("INPUT").GetElementsByName("Submit");
                btnS[0].InvokeMember("click");

                web.Navigate("http://i.icefish.cn/tasklist.aspx");
            }
            else if (url.IndexOf("http://i.icefish.cn/tasklist.aspx") == 0)  //19更新点：newFM.do
            { 
                try
                {
                    HtmlElementCollection tasks = web.Document.GetElementById("tbody1").GetElementsByTagName("tr");
                    HtmlElementCollection links = web.Document.GetElementById("tbody1").GetElementsByTagName("A");
                    analysiscExc(tasks, links);
                }
                catch
                {
                    try
                    {
                        HtmlElementCollection tasks = web.Document.GetElementById("tbody3").GetElementsByTagName("tr");
                        HtmlElementCollection links = web.Document.GetElementById("tbody3").GetElementsByTagName("A");
                        analysiscExc(tasks, links);
                    }
                    catch
                    {
                        return;
                    }
                    return;
                }
            }
            else if (url.IndexOf("http://i.icefish.cn/tasklist.aspx?TID=") == 0)
            {
                string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string name = web.Document.GetElementById("tasktransactor").GetAttribute("value");
                string um = web.Document.GetElementsByTagName("INPUT").GetElementsByName("SendLeader")[0].GetAttribute("value").Substring(8).Split(',')[0].ToLower();
                string tel = web.Document.GetElementById("tel").GetAttribute("value");
                string task = web.Document.GetElementById("taskname").GetAttribute("value");
                string dep = web.Document.GetElementById("taskdeptname").GetAttribute("value");
                dan_nums++;
                txtLog.AppendText(string.Format("[{0}] {1}  {2}  {3}（{4}） {5}  {6}\r\n", dan_nums, time, dep, name, um, task, tel));      
                txtLog.ScrollToCaret();

                HtmlElement leaderidea1 = web.Document.GetElementById("leaderidea1");
                leaderidea1.SetAttribute("value", "同意");
                HtmlElementCollection buttonList = web.Document.GetElementsByTagName("INPUT").GetElementsByName("btnSave");
                if (buttonList.Count == 0)  //针对被征求意见类型的单
                    buttonList = web.Document.GetElementsByTagName("INPUT").GetElementsByName("btnApprove");
                buttonList[0].InvokeMember("click");
            }
        }

        public void analysiscExc(HtmlElementCollection tasks, HtmlElementCollection links)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                
                bool exc = false;
                string task = tasks[i].InnerText;             
                string[] str = task.Split(' ');
                if (namewhites.Contains(str[3]) || namewhites.Contains(str[4]))
                    exc = true;
                foreach (string mc in titlewhites)
                {
                    if (mc.Contains(" "))
                    {
                        exc = FuzzyMatch(task, mc);
                    }
                    else
                    {
                        if (task.Contains(mc))
                            exc = true;
                    }                       
                }
                foreach (string xc in titleblacks)
                {
                    if (xc.Contains(" "))
                    {
                        exc = !FuzzyMatch(task, xc);
                    }
                    else
                    {
                        if (task.Contains(xc))
                            exc = false;
                    }
                }
                if (nameblacks.Contains(str[3]) || nameblacks.Contains(str[4]))
                    exc = false;
                //时间控制时间(每天必扫)
                if (DateTime.Now.ToShortTimeString() == "6:58")
                    exc = true;
                if (exc)
                    web.Navigate(links[i].GetAttribute("href"));
            }
        }

        public bool FuzzyMatch(string str, string mc)
        {
            string[] keys = mc.Split(' ');
            foreach (string key in keys)
            {
                if (!str.Contains(key))
                    return false;
            }
            return true;
        }

        private void tmrExecute_Tick(object sender, EventArgs e)
        {
            if (isInRange(dt_range.Split('-')) && isInTime(dt_range.Split('-')))
            {
                //时区判断通过则开始哈
                if (exc_time == 0)
                {
                    exc_time = rnd.Next(3, rnd_max);
                    web.Navigate("http://i.icefish.cn/tasklist.aspx");
                }
                lblMsg.Text = string.Format("当前已批：{0}单     已经运行：{1}     上次启动：{2}", dan_nums, runTotalTime(), str_start);
                lblState.Text = string.Format("等待执行中...{0}秒", exc_time--);
            }
            else {
                lblMsg.Text = "休息时间 (*^__^*) ";
                lblState.Text = "*请在配置中查看设定的工作时间"; 
            }
            
        }

        public string runTotalTime()
        {
            TimeSpan ts = DateTime.Now - start_time;
            int day = (int)ts.Days;
            int hour = (int)ts.Hours;
            int min = (int)ts.Minutes;
            int sec = (int)ts.Seconds;
            if (day > 0)
                return day + "天" + hour + "小时" + min + "分钟" + sec + "秒";
            else if(hour >0)
                return hour + "小时" + min + "分钟" + sec + "秒";
            else if(min>0)
                return min + "分钟" + sec + "秒";
            else
                return sec + "秒";
        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            tmrExecute.Enabled = false;
            frmConfig frmC = new frmConfig(); //
            frmC.ShowDialog();
            if (frmC.DialogResult == DialogResult.OK)
                tmrExecute.Enabled = true;
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            notifyIconM.Visible = true;
        }

        private void notifyIconM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
                this.Activate();
                this.ShowInTaskbar = true;
                notifyIconM.Visible = false;
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
                this.Activate();
                this.ShowInTaskbar = true;
                notifyIconM.Visible = false;
            }
        }
        
        public static string BCutEncrypt(string str)
        {
            char emblem = 'm';
            StringBuilder buffer = new StringBuilder();
            char[] chars = str.ToCharArray();
            foreach (char ch in chars)
            {
                char temp = (char)(ch ^ emblem);
                buffer.Append(temp);
            }
            return buffer.ToString();
            //这里需要加一行注释
        }
        private bool isInRange(string[] exs)
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
        private bool isInTime(string[] exs)
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
