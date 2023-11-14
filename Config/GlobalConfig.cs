namespace kdPlugin.Config
{
    public static class GlobalConfig
    {
        //正式服务器地址
        public static string MainUrl { get; set; } = "http://42.51.28.64:8088/";
        //测试服务器地址
        //private string MainUrl {get;set;} = "http://123.60.219.255:8088/";
        //是否记录调试日志
        public static bool RecordLog { get; set; }  = true;

        public static string cookie = "";
    }
}
