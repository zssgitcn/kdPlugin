namespace kdPlugin.Config
{
    public static class GlobalConfig
    {

        //游戏主地址
        public static string MainUrl { get; set; } = "";
        //是否记录调试日志
        public static bool RecordLog { get; set; }  = true;
        //游戏登录标识
        public static string cookie = "";
        //超时时间
        public static int timeout = 30 * 1000;
        //主宠id
        public static string mainPetId = "";
        //主宠技能id
        public static string mainPetSkillId = "1";
        //配置文件内容
        public static Dictionary<string, string[]> configFile;
    }
}
