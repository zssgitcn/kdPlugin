using kdPlugin.Config;
using kdPlugin.Operation.Login;
using RestSharp;
using System.Diagnostics;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace kdPlugin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            bool isLogin = Login.GetCookie(username.Text, password.Text);
            if (isLogin)
            {
                PlayerInfo.GetPlaterInfo(this);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}