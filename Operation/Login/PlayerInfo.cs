using kdPlugin.Config;
using kdPlugin.Entity;
using kdPlugin.Utils;
using RestSharp;

namespace kdPlugin.Operation.Login
{
    /// <summary>
    /// 获取玩家信息方法类
    /// </summary>
    public static class PlayerInfo
    {
        /// <summary>
        /// 获取玩家信息
        /// </summary>
        /// <param name="model">需要操作的界面控件控制器实体</param>
        public static void GetPlaterInfo(GetPlayerInfoModel model) {
            model.Skill.Items.Clear();
            try {
                //获取宠物信息
                string htmlInfo = Util.getHtml(new RestRequest("function/Pets_Mod.php", Method.Post));
                model.Name.Text = Util.MidStrEx(htmlInfo, "<div class=\"upet\">\r\n", "<br/>");
                model.Zhuchong.Text = Util.MidStrEx(htmlInfo, "<br/>宝贝：<font color=green>", "</font><br />");

                //获取技能信息
                GlobalConfig.mainPetId = Util.MidStrEx(htmlInfo, "var pid=", ";");
                string skillText = Util.MidStrEx(htmlInfo, "<div class=\"pet_c3_r r\" style=\"position:absolute; left:300px; top:50px\">", "</div>");
                skillText = skillText.Replace("<ul>","");
                skillText = skillText.Replace("</ul>","");
                skillText = skillText.Trim();
                string[] skillAry = skillText.Split("<li>");
                for (int i = 1;i <skillAry.Length;i++) 
                {
                    string skills = skillAry[i];
                    string skillId = Util.MidStrEx(skills, "sjJn('", "');");
                    string skillName = Util.MidStrEx(skills, "copyWord('", "');");
                    model.Skill.Items.Add(skillName + "," + skillId);
                    if (GlobalConfig.mainPetSkillId == skillId) 
                    {
                        model.Skill.SelectedItem = skillName + "," + skillId;
                    }
                }
                //获取货币信息
                model.Jinbi.Text = Util.MidStrEx(htmlInfo, "金币：", "<br />");
                model.Yuanbao.Text = Util.MidStrEx(htmlInfo, "元宝：", "<br />");
                model.Vip.Text = Util.MidStrEx(htmlInfo, "vip：", "<br />");
                htmlInfo = Util.getHtml(new RestRequest("function/Shopsm_Mod.php?op=cmp&style=1&sjstyle=2", Method.Post));
                model.Shuijing.Text = Util.MidStrEx(htmlInfo, "水晶:", "</div>");
                Util.WriteLog(model.Log, "获取用户信息成功。");
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}
