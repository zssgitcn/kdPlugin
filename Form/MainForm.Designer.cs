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
            loginButton = new Button();
            username = new TextBox();
            password = new TextBox();
            tab = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            jinbi = new Label();
            yuanbao = new Label();
            shuijing = new Label();
            zhuchong = new Label();
            name = new Label();
            groupBox1 = new GroupBox();
            remember = new CheckBox();
            readConfig = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            server1 = new RadioButton();
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
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            tab.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
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
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(comboBox1);
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
            groupBox2.Enter += groupBox2_Enter;
            // 
            // jinbi
            // 
            jinbi.AutoSize = true;
            jinbi.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            jinbi.Location = new Point(41, 178);
            jinbi.Name = "jinbi";
            jinbi.Size = new Size(90, 27);
            jinbi.TabIndex = 13;
            jinbi.Text = "金   币：";
            // 
            // yuanbao
            // 
            yuanbao.AutoSize = true;
            yuanbao.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            yuanbao.Location = new Point(41, 136);
            yuanbao.Name = "yuanbao";
            yuanbao.Size = new Size(90, 27);
            yuanbao.TabIndex = 11;
            yuanbao.Text = "元   宝：";
            // 
            // shuijing
            // 
            shuijing.AutoSize = true;
            shuijing.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            shuijing.Location = new Point(41, 94);
            shuijing.Name = "shuijing";
            shuijing.Size = new Size(90, 27);
            shuijing.TabIndex = 9;
            shuijing.Text = "水   晶：";
            // 
            // zhuchong
            // 
            zhuchong.AutoSize = true;
            zhuchong.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            zhuchong.Location = new Point(41, 220);
            zhuchong.Name = "zhuchong";
            zhuchong.Size = new Size(90, 27);
            zhuchong.TabIndex = 7;
            zhuchong.Text = "主   宠：";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(41, 52);
            name.Name = "name";
            name.Size = new Size(92, 27);
            name.TabIndex = 5;
            name.Text = "用户名：";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(remember);
            groupBox1.Controls.Add(readConfig);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(loginButton);
            groupBox1.Controls.Add(panel2);
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
            // remember
            // 
            remember.AutoSize = true;
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
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(server1);
            panel2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(149, 151);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 33);
            panel2.TabIndex = 6;
            // 
            // server1
            // 
            server1.AutoSize = true;
            server1.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            server1.Location = new Point(4, 3);
            server1.Name = "server1";
            server1.Size = new Size(58, 27);
            server1.TabIndex = 5;
            server1.TabStop = true;
            server1.Text = "1区";
            server1.UseVisualStyleBackColor = true;
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
            tabPage2.Size = new Size(369, 506);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "基本功能";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(369, 506);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "战斗";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(369, 506);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "特殊功能";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(369, 506);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "交易区";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(369, 506);
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
            menuStrip1.Size = new Size(1036, 28);
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
            panel1.Location = new Point(12, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 657);
            panel1.TabIndex = 5;
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
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(139, 252);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(247, 35);
            comboBox1.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 255);
            label5.Name = "label5";
            label5.Size = new Size(112, 27);
            label5.TabIndex = 15;
            label5.Text = "使用技能：";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 697);
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
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
        private RadioButton server1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private GroupBox groupBox1;
        private ComboBox readConfig;
        private CheckBox remember;
        private GroupBox groupBox2;
        private Label name;
        private Label jinbi;
        private Label yuanbao;
        private Label shuijing;
        private Label zhuchong;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
    }
}