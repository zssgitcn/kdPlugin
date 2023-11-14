using kdPlugin.Config;
using kdPlugin.Entity;
using Microsoft.VisualBasic.Devices;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Control;

namespace kdPlugin.Utils
{
    /// <summary>
    /// 公共工具类
    /// </summary>
    public static class Util
    {
        /// <summary>
        /// 获取界面控件控制器
        /// </summary>
        /// <param name="form">需要获取控件控制器的页面</param>
        /// <param name="controlName">控件标识</param>
        /// <returns>控件控制器</returns>
        public static Control GetFormControl(Form form, string controlName)
        {
            ControlCollection cs = form.Controls;
            Control control = null;
            foreach (Control c in cs)
            {
                if (c.Name == controlName)
                {
                    control = c;
                    break;
                }
            }
            return control;
        }
        /// <summary>
        /// 取指定字符串之间的内容
        /// </summary>
        /// <param name="sourse">被检索的字符串</param>
        /// <param name="startstr">开始位置字符串</param>
        /// <param name="endstr">结束位置字符串</param>
        /// <returns>获取到的内容</returns>
        public static string MidStrEx(string sourse, string startstr, string endstr)
          {
              string result = string.Empty;
              int startindex, endindex;
              try
              {
                  startindex = sourse.IndexOf(startstr);
                  if (startindex == -1)
                      return result;
                 string tmpstr = sourse.Substring(startindex + startstr.Length);
                 endindex = tmpstr.IndexOf(endstr);           
                 if (endindex == -1)
                     return result;
                 result = tmpstr.Remove(endindex);
             }
             catch (Exception ex)
             {
                result = "";
             }
             return result;
         }
        /// <summary>
        /// 获取网页内容
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns>网页内容</returns>
        public static string getHtml(RestRequest request) 
        {
            var options = new RestClientOptions(GlobalConfig.MainUrl)
            {
                MaxTimeout = GlobalConfig.timeout,
                ThrowOnAnyError = true,
            };
            var client = new RestClient(options);
            request.AddHeader("Cookie", GlobalConfig.cookie);
            var response = client.Execute(request);
            return response.Content;
        }
        /// <summary>
        /// 辅助界面信息框输出内容
        /// </summary>
        /// <param name="log">信息框控制器</param>
        /// <param name="content">需要输出的内容</param>
        public static void WriteLog(TextBox log,string content) 
        {
            DateTime dateTime = DateTime.Now;
            log.AppendText(string.Format("[{1}] {0}\r\n", content,dateTime.ToString("yyyy年MM月dd日 HH时mm分ss秒")));
        }
        /// <summary>
        /// 写入用户账号记录
        /// </summary>
        /// <param name="content">需要写入的账号、区服信息</param>
        public static void WriteUserConfig(string content) 
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "config.bat";
            if (!File.Exists(path)) 
            {
                File.Create(path);
            }
            StreamReader sr = File.OpenText(path);
            bool needWrite = true;
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                if (s == content) {
                    needWrite = false;
                    break;
                }
            }
            sr.Close();
            if (needWrite) 
            {
                StreamWriter sw = File.AppendText(path);
                sw.WriteLine(content);
                sw.Close();
            }
        }
        /// <summary>
        /// 读取用户账号记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void ReadUserConfig()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "config.bat";
            if (File.Exists(path))
            {
                Dictionary<string, string[]> map = new Dictionary<string, string[]>();
                StreamReader sr = File.OpenText(path);
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    string[] ary = s.Split(",");
                    map.Add(ary[2], ary);
                }
                GlobalConfig.configFile = map;
                sr.Close();
            }
        }
    }
}
