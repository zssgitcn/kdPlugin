using kdPlugin.Config;
using kdPlugin.Entity;
using kdPlugin.Operation.Login;
using kdPlugin.Utils;
using System.Diagnostics;
using System.IO;

namespace kdPlugin
{
    public partial class MainForm : Form
    {
        GetPlayerInfoModel model = new GetPlayerInfoModel();
        public MainForm()
        {
            InitializeComponent();
            model.Name = this.name;
            model.Shuijing = this.shuijing;
            model.Yuanbao = this.yuanbao;
            model.Jinbi = this.jinbi;
            model.Zhuchong = this.zhuchong;
            model.Skill = this.skill;
            model.Vip = this.vip;
            model.Log = this.log;
            Util.ReadUserConfig();
            foreach (KeyValuePair<string, string[]> res in GlobalConfig.configFile)
            {
                this.readConfig.Items.Add(res.Key);
            }
        }
        /// <summary>
        /// 登录按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            //设置MainUrl
            MainUrl mainUrl = new MainUrl();
            string serverName = "server1";
            string serverText = "1区";
            //获取选中的区服
            Control.ControlCollection serverList = this.serverBox.Controls;
            foreach (RadioButton c in serverList)
            {
                if (c.Checked)
                {
                    serverName = c.Name;
                    serverText = c.Text;
                    break;
                }
            }
            //设置配置中的区服地址
            string mUrl = mainUrl.GetValue(serverName);
            if (mUrl == null)
            {
                MessageBox.Show("获取服务器地址失败，请稍后再试！", "出错啦");
                return;
            }
            GlobalConfig.MainUrl = mUrl;
            //登录获取Cookie
            bool isLogin = Login.GetCookie(username.Text, password.Text, this.remember, serverText);
            if (isLogin)
            {
                Util.WriteLog(this.log, "登录成功。");
                PlayerInfo.GetPlaterInfo(model);
            }
        }
        /// <summary>
        /// 复制按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copy_Click(object sender, EventArgs e)
        {
            if (name.Text != "")
            {
                Clipboard.SetDataObject(name.Text);
            }
        }
        /// <summary>
        /// 刷新按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refreshPlayInfo_Click(object sender, EventArgs e)
        {
            PlayerInfo.GetPlaterInfo(model);
        }
        /// <summary>
        /// 主宠技能变更时设置全局属性变更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skill_SelectedValueChanged(object sender, EventArgs e)
        {
            object obj = this.skill.SelectedItem;
            string skillId = "";
            if (obj != null)
            {
                string? selected = Convert.ToString(obj);
                if (!string.IsNullOrEmpty(selected))
                {
                    skillId = selected.Split(",")[1];
                }
            }
            else
            {
                skillId = "1";
            }
            GlobalConfig.mainPetSkillId = skillId;
        }

        private void readConfig_SelectedValueChanged(object sender, EventArgs e)
        {
            string key = this.readConfig.Text;
            string[] user = GlobalConfig.configFile[key];
            if (user != null)
            {
                this.username.Text = user[0]; 
                this.password.Text = user[1];
            }
        }
    }
}