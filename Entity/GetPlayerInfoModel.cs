using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kdPlugin.Entity
{
    public class GetPlayerInfoModel
    {
        private Control name;
        private Control zhuchong;
        private Control shuijing;
        private Control jinbi;
        private Control yuanbao;
        private ComboBox skill;
        private Control vip;
        private TextBox log;

        public Control Name { get => name; set => name = value; }
        public Control Zhuchong { get => zhuchong; set => zhuchong = value; }
        public Control Shuijing { get => shuijing; set => shuijing = value; }
        public Control Jinbi { get => jinbi; set => jinbi = value; }
        public Control Yuanbao { get => yuanbao; set => yuanbao = value; }
        public ComboBox Skill { get => skill; set => skill = value; }
        public Control Vip { get => vip; set => vip = value; }
        public TextBox Log { get => log; set => log = value; }
    }
}
