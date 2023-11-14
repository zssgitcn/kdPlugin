using kdPlugin.Config;
using kdPlugin.Utils;
using RestSharp;
using System.Net;
using System.Reflection;

namespace kdPlugin.Operation.Login
{
    /// <summary>登录相关方法类</summary>
    public static class Login
    {
        
        /// <summary>获取登录Cookie及将Cookie存储到全局变量中</summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>是否成功</returns>
        public static bool GetCookie(string username,string password,CheckBox box,string serverName)
        {
            var options = new RestClientOptions(GlobalConfig.MainUrl)
            {
                MaxTimeout = GlobalConfig.timeout,
                ThrowOnAnyError = true,
            };
            try {
                var client = new RestClient(options);
                var request = new RestRequest("/passport/dealPc.php", Method.Post);
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddParameter("username", username);
                request.AddParameter("password", password);
                RestResponse response = client.Execute(request);
                CookieCollection cookies = response.Cookies;
                if (cookies.Count <= 0)
                {
                    MessageBox.Show("连接服务器失败，请稍后再试！", "出错啦！");
                    return false;
                }
                else
                {
                    GlobalConfig.cookie = Convert.ToString(cookies["PHPSESSID"]);
                    string htmlInfo = Util.getHtml(new RestRequest("/login/login.php", Method.Post));
                    if (htmlInfo.IndexOf("index.php") >= 0)
                    {
                        if (box.Checked) 
                        {
                            htmlInfo = Util.getHtml(new RestRequest("function/Pets_Mod.php", Method.Post));
                            string name = Util.MidStrEx(htmlInfo, "<div class=\"upet\">\r\n", "<br/>");
                            Util.WriteUserConfig(string.Format("{0},{1},{2}[{3}]", username, password, name,serverName));
                        }
                        return true;
                    }
                    else 
                    {
                        MessageBox.Show("登录失败，请检查用户名密码后重试！", "登录失败");
                        return false;
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show("连接服务器超时，请稍后再试！", "连接超时");
                return false;
            }
        }
    }
}
