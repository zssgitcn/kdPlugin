using kdPlugin.Config;
using kdPlugin.Utils.GetFormControls;
using RestSharp;

namespace kdPlugin.Operation.Login
{
    /// <summary>
    /// 获取玩家信息方法类
    /// </summary>
    public static class PlayerInfo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="form"></param>
        public static void GetPlaterInfo(Form form) {
            Control name = GetFormControls.GetFormControl(form, "name");
            Control zhuchong = GetFormControls.GetFormControl(form, "zhuchong");
            Control shuijing = GetFormControls.GetFormControl(form, "shuijing");
            Control yuanbao = GetFormControls.GetFormControl(form, "yuanbao");
            Control jinbi = GetFormControls.GetFormControl(form, "jinbi");
            var options = new RestClientOptions(GlobalConfig.MainUrl)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/function/Pets_Mod.php", Method.Post);
            request.AddHeader("Cookie", GlobalConfig.cookie);
            var response = client.Execute(request);
            string petInfo = response.Content;
            int i = 0;
        }
    }
}
