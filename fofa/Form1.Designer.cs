
namespace fofa
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_key = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_proxy = new System.Windows.Forms.TextBox();
            this.cb_remember = new System.Windows.Forms.CheckBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_result = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.host = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.domain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.server = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_keyword = new System.Windows.Forms.ListBox();
            this.btn_cancelall = new System.Windows.Forms.Button();
            this.btn_adds = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_keyword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_size = new System.Windows.Forms.TextBox();
            this.tb_page = new System.Windows.Forms.TextBox();
            this.cb_searchAllData = new System.Windows.Forms.CheckBox();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.domainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号邮箱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "API  Key";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(71, 14);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(166, 21);
            this.tb_email.TabIndex = 2;
            // 
            // tb_key
            // 
            this.tb_key.Location = new System.Drawing.Point(71, 45);
            this.tb_key.Name = "tb_key";
            this.tb_key.Size = new System.Drawing.Size(166, 21);
            this.tb_key.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "代理";
            // 
            // tb_proxy
            // 
            this.tb_proxy.Location = new System.Drawing.Point(297, 13);
            this.tb_proxy.Name = "tb_proxy";
            this.tb_proxy.Size = new System.Drawing.Size(196, 21);
            this.tb_proxy.TabIndex = 5;
            // 
            // cb_remember
            // 
            this.cb_remember.AutoSize = true;
            this.cb_remember.Location = new System.Drawing.Point(508, 50);
            this.cb_remember.Name = "cb_remember";
            this.cb_remember.Size = new System.Drawing.Size(48, 16);
            this.cb_remember.TabIndex = 6;
            this.cb_remember.Text = "记住";
            this.cb_remember.UseVisualStyleBackColor = true;
            this.cb_remember.CheckedChanged += new System.EventHandler(this.cb_remember_CheckedChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(695, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(110, 44);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "搜索";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(862, 19);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(97, 44);
            this.btn_export.TabIndex = 9;
            this.btn_export.Text = "导出";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_result);
            this.groupBox1.Controls.Add(this.lb_keyword);
            this.groupBox1.Controls.Add(this.btn_cancelall);
            this.groupBox1.Controls.Add(this.btn_adds);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.tb_keyword);
            this.groupBox1.Location = new System.Drawing.Point(6, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1021, 486);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // lv_result
            // 
            this.lv_result.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.host,
            this.ip,
            this.port,
            this.domain,
            this.title,
            this.server});
            this.lv_result.FullRowSelect = true;
            this.lv_result.GridLines = true;
            this.lv_result.HideSelection = false;
            this.lv_result.Location = new System.Drawing.Point(209, 18);
            this.lv_result.Name = "lv_result";
            this.lv_result.Size = new System.Drawing.Size(809, 460);
            this.lv_result.TabIndex = 5;
            this.lv_result.UseCompatibleStateImageBehavior = false;
            this.lv_result.View = System.Windows.Forms.View.Details;
            this.lv_result.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lv_result_ColumnClick);
            this.lv_result.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_result_MouseClick);
            this.lv_result.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_result_MouseDoubleClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 40;
            // 
            // host
            // 
            this.host.Text = "Host";
            this.host.Width = 150;
            // 
            // ip
            // 
            this.ip.Text = "IP";
            this.ip.Width = 150;
            // 
            // port
            // 
            this.port.Text = "Port";
            // 
            // domain
            // 
            this.domain.Text = "Domain";
            this.domain.Width = 150;
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.Width = 150;
            // 
            // server
            // 
            this.server.Text = "Server";
            this.server.Width = 100;
            // 
            // lb_keyword
            // 
            this.lb_keyword.FormattingEnabled = true;
            this.lb_keyword.ItemHeight = 12;
            this.lb_keyword.Location = new System.Drawing.Point(10, 66);
            this.lb_keyword.Name = "lb_keyword";
            this.lb_keyword.Size = new System.Drawing.Size(188, 412);
            this.lb_keyword.TabIndex = 4;
            this.lb_keyword.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_keyword_MouseDoubleClick);
            // 
            // btn_cancelall
            // 
            this.btn_cancelall.Location = new System.Drawing.Point(107, 42);
            this.btn_cancelall.Name = "btn_cancelall";
            this.btn_cancelall.Size = new System.Drawing.Size(91, 22);
            this.btn_cancelall.TabIndex = 3;
            this.btn_cancelall.Text = "全部取消";
            this.btn_cancelall.UseVisualStyleBackColor = true;
            this.btn_cancelall.Click += new System.EventHandler(this.btn_cancelall_Click);
            // 
            // btn_adds
            // 
            this.btn_adds.Location = new System.Drawing.Point(9, 42);
            this.btn_adds.Name = "btn_adds";
            this.btn_adds.Size = new System.Drawing.Size(91, 22);
            this.btn_adds.TabIndex = 2;
            this.btn_adds.Text = "批量添加";
            this.btn_adds.UseVisualStyleBackColor = true;
            this.btn_adds.Click += new System.EventHandler(this.btn_adds_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(176, 17);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(23, 21);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_keyword
            // 
            this.tb_keyword.Location = new System.Drawing.Point(10, 17);
            this.tb_keyword.Name = "tb_keyword";
            this.tb_keyword.Size = new System.Drawing.Size(156, 21);
            this.tb_keyword.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "条数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "页数";
            // 
            // tb_size
            // 
            this.tb_size.Location = new System.Drawing.Point(297, 46);
            this.tb_size.Name = "tb_size";
            this.tb_size.Size = new System.Drawing.Size(80, 21);
            this.tb_size.TabIndex = 13;
            this.tb_size.Text = "100";
            // 
            // tb_page
            // 
            this.tb_page.Location = new System.Drawing.Point(415, 47);
            this.tb_page.Name = "tb_page";
            this.tb_page.Size = new System.Drawing.Size(78, 21);
            this.tb_page.TabIndex = 14;
            this.tb_page.Text = "10";
            // 
            // cb_searchAllData
            // 
            this.cb_searchAllData.AutoSize = true;
            this.cb_searchAllData.Location = new System.Drawing.Point(507, 16);
            this.cb_searchAllData.Name = "cb_searchAllData";
            this.cb_searchAllData.Size = new System.Drawing.Size(96, 16);
            this.cb_searchAllData.TabIndex = 15;
            this.cb_searchAllData.Text = "搜索全部数据";
            this.cb_searchAllData.UseVisualStyleBackColor = true;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(7, 564);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(1019, 16);
            this.pb.Step = 1;
            this.pb.TabIndex = 16;
            this.pb.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.复制ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hostToolStripMenuItem,
            this.iPPortToolStripMenuItem,
            this.domainToolStripMenuItem});
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            // 
            // hostToolStripMenuItem
            // 
            this.hostToolStripMenuItem.Name = "hostToolStripMenuItem";
            this.hostToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.hostToolStripMenuItem.Text = "Host";
            this.hostToolStripMenuItem.Click += new System.EventHandler(this.hostToolStripMenuItem_Click);
            // 
            // iPPortToolStripMenuItem
            // 
            this.iPPortToolStripMenuItem.Name = "iPPortToolStripMenuItem";
            this.iPPortToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.iPPortToolStripMenuItem.Text = "IP:Port";
            this.iPPortToolStripMenuItem.Click += new System.EventHandler(this.iPPortToolStripMenuItem_Click);
            // 
            // domainToolStripMenuItem
            // 
            this.domainToolStripMenuItem.Name = "domainToolStripMenuItem";
            this.domainToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.domainToolStripMenuItem.Text = "Domain";
            this.domainToolStripMenuItem.Click += new System.EventHandler(this.domainToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 584);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.cb_searchAllData);
            this.Controls.Add(this.tb_page);
            this.Controls.Add(this.tb_size);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cb_remember);
            this.Controls.Add(this.tb_proxy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_key);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Fofa搜索工具 v1.4 by烛照.Master";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_key;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_proxy;
        private System.Windows.Forms.CheckBox cb_remember;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_keyword;
        private System.Windows.Forms.ListBox lb_keyword;
        private System.Windows.Forms.Button btn_cancelall;
        private System.Windows.Forms.Button btn_adds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_size;
        private System.Windows.Forms.TextBox tb_page;
        private System.Windows.Forms.ListView lv_result;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader host;
        private System.Windows.Forms.ColumnHeader ip;
        private System.Windows.Forms.ColumnHeader port;
        private System.Windows.Forms.ColumnHeader domain;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader server;
        private System.Windows.Forms.CheckBox cb_searchAllData;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iPPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem domainToolStripMenuItem;
    }
}

