namespace kdPlugin
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            loginButton = new Button();
            username = new TextBox();
            password = new TextBox();
            tab = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            refreshPlayInfo = new Button();
            copy = new Label();
            label11 = new Label();
            vip = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label5 = new Label();
            skill = new ComboBox();
            jinbi = new Label();
            yuanbao = new Label();
            shuijing = new Label();
            zhuchong = new Label();
            name = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            remember = new CheckBox();
            readConfig = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            serverBox = new Panel();
            ServerTest = new RadioButton();
            Server1 = new RadioButton();
            label2 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            丢弃ToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel3 = new Panel();
            groupBox3 = new GroupBox();
            log = new TextBox();
            tab.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            serverBox.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(312, 206);
            loginButton.Margin = new Padding(2, 3, 2, 3);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(84, 39);
            loginButton.TabIndex = 0;
            loginButton.Text = "登录";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // username
            // 
            username.BorderStyle = BorderStyle.FixedSingle;
            username.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(149, 75);
            username.Margin = new Padding(2, 3, 2, 3);
            username.Name = "username";
            username.PlaceholderText = "请输入账号";
            username.Size = new Size(247, 33);
            username.TabIndex = 1;
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.FixedSingle;
            password.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(149, 115);
            password.Margin = new Padding(2, 3, 2, 3);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "请输入密码";
            password.Size = new Size(247, 33);
            password.TabIndex = 2;
            // 
            // tab
            // 
            tab.Controls.Add(tabPage1);
            tab.Controls.Add(tabPage2);
            tab.Controls.Add(tabPage3);
            tab.Controls.Add(tabPage4);
            tab.Controls.Add(tabPage5);
            tab.Controls.Add(tabPage6);
            tab.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tab.Location = new Point(3, 3);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(498, 653);
            tab.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(490, 620);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "账号";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(refreshPlayInfo);
            groupBox2.Controls.Add(copy);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(vip);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(skill);
            groupBox2.Controls.Add(jinbi);
            groupBox2.Controls.Add(yuanbao);
            groupBox2.Controls.Add(shuijing);
            groupBox2.Controls.Add(zhuchong);
            groupBox2.Controls.Add(name);
            groupBox2.Location = new Point(6, 298);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(478, 316);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "玩家信息";
            // 
            // refreshPlayInfo
            // 
            refreshPlayInfo.BackgroundImage = (Image)resources.GetObject("refreshPlayInfo.BackgroundImage");
            refreshPlayInfo.BackgroundImageLayout = ImageLayout.Stretch;
            refreshPlayInfo.Location = new Point(440, 15);
            refreshPlayInfo.Name = "refreshPlayInfo";
            refreshPlayInfo.Size = new Size(32, 32);
            refreshPlayInfo.TabIndex = 24;
            refreshPlayInfo.UseVisualStyleBackColor = true;
            refreshPlayInfo.Click += refreshPlayInfo_Click;
            // 
            // copy
            // 
            copy.AutoSize = true;
            copy.Cursor = Cursors.Hand;
            copy.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            copy.ForeColor = SystemColors.Highlight;
            copy.Location = new Point(385, 36);
            copy.Name = "copy";
            copy.Size = new Size(52, 27);
            copy.TabIndex = 23;
            copy.Text = "复制";
            copy.Click += copy_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(57, 216);
            label11.Name = "label11";
            label11.Size = new Size(104, 27);
            label11.TabIndex = 22;
            label11.Text = "VIP积分：";
            // 
            // vip
            // 
            vip.AutoSize = true;
            vip.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            vip.Location = new Point(169, 216);
            vip.Name = "vip";
            vip.Size = new Size(0, 27);
            vip.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(71, 144);
            label6.Name = "label6";
            label6.Size = new Size(90, 27);
            label6.TabIndex = 20;
            label6.Text = "金   币：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(71, 108);
            label7.Name = "label7";
            label7.Size = new Size(90, 27);
            label7.TabIndex = 19;
            label7.Text = "元   宝：";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(71, 72);
            label8.Name = "label8";
            label8.Size = new Size(90, 27);
            label8.TabIndex = 18;
            label8.Text = "水   晶：";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(71, 180);
            label9.Name = "label9";
            label9.Size = new Size(90, 27);
            label9.TabIndex = 17;
            label9.Text = "主   宠：";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(71, 36);
            label10.Name = "label10";
            label10.Size = new Size(92, 27);
            label10.TabIndex = 16;
            label10.Text = "用户名：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(51, 264);
            label5.Name = "label5";
            label5.Size = new Size(112, 27);
            label5.TabIndex = 15;
            label5.Text = "使用技能：";
            // 
            // skill
            // 
            skill.DropDownStyle = ComboBoxStyle.DropDownList;
            skill.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            skill.FormattingEnabled = true;
            skill.Location = new Point(169, 261);
            skill.Name = "skill";
            skill.Size = new Size(247, 35);
            skill.TabIndex = 14;
            skill.SelectedValueChanged += skill_SelectedValueChanged;
            // 
            // jinbi
            // 
            jinbi.AutoSize = true;
            jinbi.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            jinbi.Location = new Point(169, 144);
            jinbi.Name = "jinbi";
            jinbi.Size = new Size(0, 27);
            jinbi.TabIndex = 13;
            // 
            // yuanbao
            // 
            yuanbao.AutoSize = true;
            yuanbao.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            yuanbao.Location = new Point(169, 108);
            yuanbao.Name = "yuanbao";
            yuanbao.Size = new Size(0, 27);
            yuanbao.TabIndex = 11;
            // 
            // shuijing
            // 
            shuijing.AutoSize = true;
            shuijing.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            shuijing.Location = new Point(169, 72);
            shuijing.Name = "shuijing";
            shuijing.Size = new Size(0, 27);
            shuijing.TabIndex = 9;
            // 
            // zhuchong
            // 
            zhuchong.AutoSize = true;
            zhuchong.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            zhuchong.Location = new Point(169, 180);
            zhuchong.Name = "zhuchong";
            zhuchong.Size = new Size(0, 27);
            zhuchong.TabIndex = 7;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(169, 36);
            name.Name = "name";
            name.Size = new Size(0, 27);
            name.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(remember);
            groupBox1.Controls.Add(readConfig);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(loginButton);
            groupBox1.Controls.Add(serverBox);
            groupBox1.Controls.Add(password);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(username);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 265);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "登录";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 35);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(112, 27);
            label4.TabIndex = 10;
            label4.Text = "读取配置：";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // remember
            // 
            remember.AutoSize = true;
            remember.Checked = true;
            remember.CheckState = CheckState.Checked;
            remember.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            remember.Location = new Point(149, 209);
            remember.Name = "remember";
            remember.Size = new Size(114, 31);
            remember.TabIndex = 9;
            remember.Text = "记住账号";
            remember.UseVisualStyleBackColor = true;
            // 
            // readConfig
            // 
            readConfig.DropDownStyle = ComboBoxStyle.DropDownList;
            readConfig.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            readConfig.FormattingEnabled = true;
            readConfig.Location = new Point(149, 32);
            readConfig.Name = "readConfig";
            readConfig.Size = new Size(247, 35);
            readConfig.TabIndex = 8;
            readConfig.SelectedValueChanged += readConfig_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(71, 76);
            label1.Name = "label1";
            label1.Size = new Size(72, 27);
            label1.TabIndex = 3;
            label1.Text = "账号：";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(71, 153);
            label3.Name = "label3";
            label3.Size = new Size(72, 27);
            label3.TabIndex = 7;
            label3.Text = "区服：";
            // 
            // serverBox
            // 
            serverBox.BorderStyle = BorderStyle.FixedSingle;
            serverBox.Controls.Add(ServerTest);
            serverBox.Controls.Add(Server1);
            serverBox.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            serverBox.Location = new Point(149, 151);
            serverBox.Name = "serverBox";
            serverBox.Size = new Size(247, 33);
            serverBox.TabIndex = 6;
            // 
            // ServerTest
            // 
            ServerTest.AutoSize = true;
            ServerTest.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ServerTest.Location = new Point(69, 2);
            ServerTest.Name = "ServerTest";
            ServerTest.Size = new Size(82, 27);
            ServerTest.TabIndex = 6;
            ServerTest.Text = "测试区";
            ServerTest.UseVisualStyleBackColor = true;
            // 
            // Server1
            // 
            Server1.AutoSize = true;
            Server1.Checked = true;
            Server1.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Server1.Location = new Point(4, 2);
            Server1.Name = "Server1";
            Server1.Size = new Size(58, 27);
            Server1.TabIndex = 5;
            Server1.TabStop = true;
            Server1.Text = "1区";
            Server1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(71, 117);
            label2.Name = "label2";
            label2.Size = new Size(72, 27);
            label2.TabIndex = 4;
            label2.Text = "密码：";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(490, 620);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "基本功能";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(490, 620);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "战斗";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(490, 620);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "特殊功能";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(490, 620);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "交易区";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(490, 620);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "使用说明";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, 丢弃ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1027, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(53, 24);
            toolStripMenuItem1.Text = "界面";
            // 
            // 丢弃ToolStripMenuItem
            // 
            丢弃ToolStripMenuItem.Name = "丢弃ToolStripMenuItem";
            丢弃ToolStripMenuItem.Size = new Size(53, 24);
            丢弃ToolStripMenuItem.Text = "丢弃";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tab);
            panel1.Location = new Point(518, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 657);
            panel1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(groupBox3);
            panel3.Location = new Point(5, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 657);
            panel3.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(log);
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(492, 649);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "日志信息";
            // 
            // log
            // 
            log.BackColor = SystemColors.ButtonHighlight;
            log.Location = new Point(6, 28);
            log.Multiline = true;
            log.Name = "log";
            log.ReadOnly = true;
            log.Size = new Size(490, 615);
            log.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 690);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2, 3, 2, 3);
            Name = "MainForm";
            Text = "口袋助手";
            tab.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            serverBox.ResumeLayout(false);
            serverBox.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private TextBox username;
        private TextBox password;
        private TabControl tab;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem 丢弃ToolStripMenuItem;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private GroupBox groupBox1;
        private ComboBox readConfig;
        private GroupBox groupBox2;
        private Label label4;
        private Label label5;
        public Label name;
        public Label jinbi;
        public Label yuanbao;
        public Label shuijing;
        public Label zhuchong;
        public ComboBox skill;
        public Label label6;
        public Label label7;
        public Label label8;
        public Label label9;
        public Label label10;
        public Label label11;
        public Label vip;
        private Label copy;
        private Panel panel3;
        private GroupBox groupBox3;
        public TextBox log;
        private TextBox textBox1;
        public RadioButton ServerTest;
        public RadioButton Server1;
        public Panel serverBox;
        public Button refreshPlayInfo;
        public CheckBox remember;
    }
}