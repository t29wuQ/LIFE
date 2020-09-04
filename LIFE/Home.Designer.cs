namespace LIFE
{
    partial class Home
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大富豪ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.作成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入室ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.readmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.imageListicon = new System.Windows.Forms.ImageList(this.components);
            this.TL = new System.Windows.Forms.DataGridView();
            this.icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.tweet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtfav = new System.Windows.Forms.DataGridViewImageColumn();
            this.idstr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtfavcheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tweettext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tweetuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconurl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userurl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vianame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viaurl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.easytweet = new System.Windows.Forms.TextBox();
            this.easytweeting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LIFElabel = new System.Windows.Forms.Label();
            this.tweetopen = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.loginscreenname = new System.Windows.Forms.Label();
            this.loginicon = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginname = new System.Windows.Forms.Label();
            this.tweetusername = new System.Windows.Forms.LinkLabel();
            this.tweetusericon = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tweetvia = new System.Windows.Forms.LinkLabel();
            this.opentweet = new System.Windows.Forms.LinkLabel();
            this.replybutton = new System.Windows.Forms.Button();
            this.rtbutton = new System.Windows.Forms.Button();
            this.favbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tweetview = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tweetopen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tweetusericon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.playingToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(285, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.selectToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.accountToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // playingToolStripMenuItem
            // 
            this.playingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大富豪ToolStripMenuItem});
            this.playingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.playingToolStripMenuItem.Name = "playingToolStripMenuItem";
            this.playingToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.playingToolStripMenuItem.Text = "Playing";
            // 
            // 大富豪ToolStripMenuItem
            // 
            this.大富豪ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.作成ToolStripMenuItem,
            this.入室ToolStripMenuItem});
            this.大富豪ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.大富豪ToolStripMenuItem.Name = "大富豪ToolStripMenuItem";
            this.大富豪ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.大富豪ToolStripMenuItem.Text = "大富豪";
            // 
            // 作成ToolStripMenuItem
            // 
            this.作成ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.作成ToolStripMenuItem.Name = "作成ToolStripMenuItem";
            this.作成ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.作成ToolStripMenuItem.Text = "作成";
            this.作成ToolStripMenuItem.Click += new System.EventHandler(this.作成ToolStripMenuItem_Click);
            // 
            // 入室ToolStripMenuItem
            // 
            this.入室ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.入室ToolStripMenuItem.Name = "入室ToolStripMenuItem";
            this.入室ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.入室ToolStripMenuItem.Text = "入室";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.readmeToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // readmeToolStripMenuItem
            // 
            this.readmeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.readmeToolStripMenuItem.Name = "readmeToolStripMenuItem";
            this.readmeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.readmeToolStripMenuItem.Text = "Readme";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(42, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // imageListicon
            // 
            this.imageListicon.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListicon.ImageSize = new System.Drawing.Size(100, 100);
            this.imageListicon.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TL
            // 
            this.TL.AllowUserToAddRows = false;
            this.TL.AllowUserToDeleteRows = false;
            this.TL.AllowUserToResizeColumns = false;
            this.TL.AllowUserToResizeRows = false;
            this.TL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TL.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TL.ColumnHeadersVisible = false;
            this.TL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.icon,
            this.tweet,
            this.rtfav,
            this.idstr,
            this.rtfavcheck,
            this.tweettext,
            this.tweetuser,
            this.iconurl,
            this.username,
            this.userurl,
            this.vianame,
            this.viaurl});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TL.DefaultCellStyle = dataGridViewCellStyle5;
            this.TL.Location = new System.Drawing.Point(72, 68);
            this.TL.Margin = new System.Windows.Forms.Padding(0);
            this.TL.MultiSelect = false;
            this.TL.Name = "TL";
            this.TL.ReadOnly = true;
            this.TL.RowHeadersVisible = false;
            this.TL.RowTemplate.Height = 21;
            this.TL.Size = new System.Drawing.Size(402, 475);
            this.TL.TabIndex = 3;
            this.TL.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TL_CellMouseMove);
            // 
            // icon
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.icon.DefaultCellStyle = dataGridViewCellStyle2;
            this.icon.HeaderText = "icon";
            this.icon.Name = "icon";
            this.icon.ReadOnly = true;
            this.icon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.icon.Width = 70;
            // 
            // tweet
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tweet.DefaultCellStyle = dataGridViewCellStyle3;
            this.tweet.HeaderText = "tweet";
            this.tweet.Name = "tweet";
            this.tweet.ReadOnly = true;
            this.tweet.Width = 300;
            // 
            // rtfav
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.rtfav.DefaultCellStyle = dataGridViewCellStyle4;
            this.rtfav.HeaderText = "rtfav";
            this.rtfav.Name = "rtfav";
            this.rtfav.ReadOnly = true;
            this.rtfav.Width = 10;
            // 
            // idstr
            // 
            this.idstr.HeaderText = "idstr";
            this.idstr.Name = "idstr";
            this.idstr.ReadOnly = true;
            this.idstr.Visible = false;
            // 
            // rtfavcheck
            // 
            this.rtfavcheck.HeaderText = "rtfavcheck";
            this.rtfavcheck.Name = "rtfavcheck";
            this.rtfavcheck.ReadOnly = true;
            this.rtfavcheck.Visible = false;
            // 
            // tweettext
            // 
            this.tweettext.HeaderText = "tweettext";
            this.tweettext.Name = "tweettext";
            this.tweettext.ReadOnly = true;
            this.tweettext.Visible = false;
            // 
            // tweetuser
            // 
            this.tweetuser.HeaderText = "tweetuser";
            this.tweetuser.Name = "tweetuser";
            this.tweetuser.ReadOnly = true;
            this.tweetuser.Visible = false;
            // 
            // iconurl
            // 
            this.iconurl.HeaderText = "iconurl";
            this.iconurl.Name = "iconurl";
            this.iconurl.ReadOnly = true;
            this.iconurl.Visible = false;
            // 
            // username
            // 
            this.username.HeaderText = "username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Visible = false;
            // 
            // userurl
            // 
            this.userurl.HeaderText = "userurl";
            this.userurl.Name = "userurl";
            this.userurl.ReadOnly = true;
            this.userurl.Visible = false;
            // 
            // vianame
            // 
            this.vianame.HeaderText = "vianame";
            this.vianame.Name = "vianame";
            this.vianame.ReadOnly = true;
            this.vianame.Visible = false;
            // 
            // viaurl
            // 
            this.viaurl.HeaderText = "viaurl";
            this.viaurl.Name = "viaurl";
            this.viaurl.ReadOnly = true;
            this.viaurl.Visible = false;
            // 
            // easytweet
            // 
            this.easytweet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.easytweet.ForeColor = System.Drawing.Color.White;
            this.easytweet.Location = new System.Drawing.Point(72, 546);
            this.easytweet.Name = "easytweet";
            this.easytweet.Size = new System.Drawing.Size(699, 19);
            this.easytweet.TabIndex = 4;
            this.easytweet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.easytweet_KeyPress);
            // 
            // easytweeting
            // 
            this.easytweeting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easytweeting.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.easytweeting.ForeColor = System.Drawing.Color.White;
            this.easytweeting.Location = new System.Drawing.Point(777, 546);
            this.easytweeting.Name = "easytweeting";
            this.easytweeting.Size = new System.Drawing.Size(75, 19);
            this.easytweeting.TabIndex = 5;
            this.easytweeting.Text = "Tweet";
            this.easytweeting.UseVisualStyleBackColor = true;
            this.easytweeting.Click += new System.EventHandler(this.easytweeting_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(59, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3, 570);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(859, 3);
            this.label2.TabIndex = 8;
            // 
            // LIFElabel
            // 
            this.LIFElabel.AutoSize = true;
            this.LIFElabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIFElabel.ForeColor = System.Drawing.Color.White;
            this.LIFElabel.Location = new System.Drawing.Point(7, 4);
            this.LIFElabel.Name = "LIFElabel";
            this.LIFElabel.Size = new System.Drawing.Size(83, 17);
            this.LIFElabel.TabIndex = 9;
            this.LIFElabel.Text = "Twitter Client";
            // 
            // tweetopen
            // 
            this.tweetopen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tweetopen.BackgroundImage")));
            this.tweetopen.InitialImage = ((System.Drawing.Image)(resources.GetObject("tweetopen.InitialImage")));
            this.tweetopen.Location = new System.Drawing.Point(5, 59);
            this.tweetopen.Margin = new System.Windows.Forms.Padding(0);
            this.tweetopen.Name = "tweetopen";
            this.tweetopen.Size = new System.Drawing.Size(50, 50);
            this.tweetopen.TabIndex = 10;
            this.tweetopen.TabStop = false;
            this.toolTip1.SetToolTip(this.tweetopen, "ツイート画面を開きます");
            this.tweetopen.Click += new System.EventHandler(this.tweetopen_Click);
            this.tweetopen.MouseLeave += new System.EventHandler(this.tweetopen_MouseLeave);
            this.tweetopen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tweetopen_MouseMove);
            // 
            // loginscreenname
            // 
            this.loginscreenname.AutoSize = true;
            this.loginscreenname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginscreenname.ForeColor = System.Drawing.Color.White;
            this.loginscreenname.Location = new System.Drawing.Point(140, 595);
            this.loginscreenname.Name = "loginscreenname";
            this.loginscreenname.Size = new System.Drawing.Size(23, 17);
            this.loginscreenname.TabIndex = 12;
            this.loginscreenname.Text = "ㅤ";
            // 
            // loginicon
            // 
            this.loginicon.Location = new System.Drawing.Point(72, 571);
            this.loginicon.Name = "loginicon";
            this.loginicon.Size = new System.Drawing.Size(45, 45);
            this.loginicon.TabIndex = 13;
            this.loginicon.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(123, 595);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "@";
            // 
            // loginname
            // 
            this.loginname.AutoSize = true;
            this.loginname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginname.ForeColor = System.Drawing.Color.White;
            this.loginname.Location = new System.Drawing.Point(123, 578);
            this.loginname.Name = "loginname";
            this.loginname.Size = new System.Drawing.Size(23, 17);
            this.loginname.TabIndex = 15;
            this.loginname.Text = "ㅤ";
            // 
            // tweetusername
            // 
            this.tweetusername.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.tweetusername.AutoSize = true;
            this.tweetusername.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tweetusername.LinkColor = System.Drawing.Color.White;
            this.tweetusername.Location = new System.Drawing.Point(532, 78);
            this.tweetusername.Name = "tweetusername";
            this.tweetusername.Size = new System.Drawing.Size(0, 24);
            this.tweetusername.TabIndex = 16;
            this.tweetusername.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.tweetusername.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tweetusername_LinkClicked);
            // 
            // tweetusericon
            // 
            this.tweetusericon.Location = new System.Drawing.Point(480, 68);
            this.tweetusericon.Name = "tweetusericon";
            this.tweetusericon.Size = new System.Drawing.Size(45, 45);
            this.tweetusericon.TabIndex = 17;
            this.tweetusericon.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(481, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "via";
            // 
            // tweetvia
            // 
            this.tweetvia.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.tweetvia.AutoSize = true;
            this.tweetvia.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tweetvia.LinkColor = System.Drawing.Color.White;
            this.tweetvia.Location = new System.Drawing.Point(508, 381);
            this.tweetvia.Name = "tweetvia";
            this.tweetvia.Size = new System.Drawing.Size(0, 16);
            this.tweetvia.TabIndex = 19;
            this.tweetvia.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.tweetvia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tweetvia_LinkClicked);
            // 
            // opentweet
            // 
            this.opentweet.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.opentweet.AutoSize = true;
            this.opentweet.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.opentweet.LinkColor = System.Drawing.Color.White;
            this.opentweet.Location = new System.Drawing.Point(477, 485);
            this.opentweet.Name = "opentweet";
            this.opentweet.Size = new System.Drawing.Size(89, 16);
            this.opentweet.TabIndex = 20;
            this.opentweet.TabStop = true;
            this.opentweet.Text = "Open Tweet";
            this.opentweet.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.opentweet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.opentweet_LinkClicked);
            // 
            // replybutton
            // 
            this.replybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replybutton.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.replybutton.ForeColor = System.Drawing.Color.White;
            this.replybutton.Location = new System.Drawing.Point(477, 408);
            this.replybutton.Name = "replybutton";
            this.replybutton.Size = new System.Drawing.Size(75, 19);
            this.replybutton.TabIndex = 21;
            this.replybutton.Text = "Reply";
            this.replybutton.UseVisualStyleBackColor = true;
            this.replybutton.Click += new System.EventHandler(this.replybutton_Click);
            // 
            // rtbutton
            // 
            this.rtbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rtbutton.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rtbutton.ForeColor = System.Drawing.Color.White;
            this.rtbutton.Location = new System.Drawing.Point(572, 408);
            this.rtbutton.Name = "rtbutton";
            this.rtbutton.Size = new System.Drawing.Size(75, 19);
            this.rtbutton.TabIndex = 22;
            this.rtbutton.Text = "Retweet";
            this.rtbutton.UseVisualStyleBackColor = true;
            this.rtbutton.Click += new System.EventHandler(this.rtbutton_Click);
            // 
            // favbutton
            // 
            this.favbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favbutton.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.favbutton.ForeColor = System.Drawing.Color.White;
            this.favbutton.Location = new System.Drawing.Point(676, 408);
            this.favbutton.Name = "favbutton";
            this.favbutton.Size = new System.Drawing.Size(75, 19);
            this.favbutton.TabIndex = 23;
            this.favbutton.Text = "Favorite";
            this.favbutton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(477, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 19);
            this.button1.TabIndex = 24;
            this.button1.Text = "CopyTweet";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(572, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 19);
            this.button2.TabIndex = 25;
            this.button2.Text = "CopyTweetR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(676, 449);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 19);
            this.button3.TabIndex = 26;
            this.button3.Text = "Reply";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tweetview
            // 
            this.tweetview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tweetview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tweetview.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tweetview.ForeColor = System.Drawing.Color.White;
            this.tweetview.Location = new System.Drawing.Point(480, 130);
            this.tweetview.Name = "tweetview";
            this.tweetview.ReadOnly = true;
            this.tweetview.Size = new System.Drawing.Size(356, 238);
            this.tweetview.TabIndex = 27;
            this.tweetview.Text = "";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(858, 619);
            this.Controls.Add(this.tweetview);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.favbutton);
            this.Controls.Add(this.rtbutton);
            this.Controls.Add(this.replybutton);
            this.Controls.Add(this.opentweet);
            this.Controls.Add(this.tweetvia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tweetusericon);
            this.Controls.Add(this.tweetusername);
            this.Controls.Add(this.loginname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginicon);
            this.Controls.Add(this.loginscreenname);
            this.Controls.Add(this.tweetopen);
            this.Controls.Add(this.LIFElabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.easytweeting);
            this.Controls.Add(this.easytweet);
            this.Controls.Add(this.TL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "LIFE";
            this.Load += new System.EventHandler(this.Home_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Home_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Home_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Home_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tweetopen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tweetusericon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem readmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.Timer time;
        public System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ImageList imageListicon;
        private System.Windows.Forms.DataGridView TL;
        private System.Windows.Forms.TextBox easytweet;
        private System.Windows.Forms.Button easytweeting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LIFElabel;
        private System.Windows.Forms.PictureBox tweetopen;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label loginscreenname;
        private System.Windows.Forms.PictureBox loginicon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label loginname;
        private System.Windows.Forms.ToolStripMenuItem playingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大富豪ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 作成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入室ToolStripMenuItem;
        private System.Windows.Forms.LinkLabel tweetusername;
        private System.Windows.Forms.PictureBox tweetusericon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel tweetvia;
        private System.Windows.Forms.LinkLabel opentweet;
        private System.Windows.Forms.DataGridViewImageColumn icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tweet;
        private System.Windows.Forms.DataGridViewImageColumn rtfav;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstr;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtfavcheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn tweettext;
        private System.Windows.Forms.DataGridViewTextBoxColumn tweetuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn iconurl;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn userurl;
        private System.Windows.Forms.DataGridViewTextBoxColumn vianame;
        private System.Windows.Forms.DataGridViewTextBoxColumn viaurl;
        private System.Windows.Forms.Button replybutton;
        private System.Windows.Forms.Button rtbutton;
        private System.Windows.Forms.Button favbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox tweetview;
    }
}

