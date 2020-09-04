using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreTweet;
using CoreTweet.Streaming;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using Microsoft.VisualBasic;

namespace LIFE
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        //現在時刻
        string now;
        Tokens maintoken;
        private Point mousePoint;
        public tweeting t { get; set; } = null;
        public int TLRowIndex;
        public string opentweeturl;
        public string usernameurl;
        public string viaurls;
        public Bitmap tweeticon;
        public string tweetidstr;
        public string tweetuserscreenname;
        public string tweettexts;

        private void Home_Load(object sender, EventArgs e)
        {
            //初期化
            now = DateTime.Now.ToString("yyyy/MM/dd ") + DateTime.Now.ToString("HH:mm:ss");

            ToolStripManager.Renderer = new ToolStripProfessionalRenderer(new VS2012ColorTable());

            // リンクをクリックした際に呼ばれるイベントを追加
            tweetview.LinkClicked += new LinkClickedEventHandler(tweetview_LinkClicked);

            //setting.iniから初期ログインアカウント読み込み
            StringBuilder LA = new StringBuilder(1024);
            IniFileHandler.GetPrivateProfileString("起動時", "LoginAccount",
                    "default", LA, (uint)LA.Capacity, "./data/setting.ini");
            string LoginAccount = LA.ToString();

            //token.iniのセクション一覧取得後toolstripmenuに追加
            byte[] ac = new byte[1024];
            uint resultSize2
                  = IniFileHandler.GetPrivateProfileStringByByteArray(
                        null, null, "default", ac,
                        (uint)ac.Length, "./data/token.ini");
            string result2 = Encoding.Default.GetString(
                                    ac, 0, (int)resultSize2 - 1);
            string[] sections = result2.Split('\0');
            int n = 0;
            foreach (string section in sections)
            {
                selectToolStripMenuItem.DropDownItems.Add(section);
                ToolStripMenuItem a1 = (ToolStripMenuItem)menuStrip1.Items[0];
                ToolStripMenuItem a2 = (ToolStripMenuItem)a1.DropDownItems[1];
                a2.DropDownItems[n].ForeColor = Color.White;
                a2.DropDownItems[n].Click += new EventHandler(accountselect_Click);
                deleteToolStripMenuItem.DropDownItems.Add(section);
                ToolStripMenuItem a3 = (ToolStripMenuItem)a1.DropDownItems[2];
                a3.DropDownItems[n].ForeColor = Color.White;
                a3.DropDownItems[n].Click += new EventHandler(accountdelete_Click); ;

                //起動時のログインアカウントだった場合
                if (LoginAccount == section)
                {
                    //トークンを読み込む
                    StringBuilder ck = new StringBuilder(1024);
                    IniFileHandler.GetPrivateProfileString(section, "ConsumerKey",
                            "default", ck, (uint)ck.Capacity, "./data/token.ini");
                    StringBuilder cs = new StringBuilder(1024);
                    IniFileHandler.GetPrivateProfileString(section, "ConsumerSecret",
                            "default", cs, (uint)cs.Capacity, "./data/token.ini");
                    StringBuilder ak = new StringBuilder(1024);
                    IniFileHandler.GetPrivateProfileString(section, "AccessToken",
                            "default", ak, (uint)ak.Capacity, "./data/token.ini");
                    StringBuilder ats = new StringBuilder(1024);
                    IniFileHandler.GetPrivateProfileString(section, "AccessTokenSecret",
                            "default", ats, (uint)ats.Capacity, "./data/token.ini");
                    try
                    {
                        maintoken = Tokens.Create(ck.ToString(), cs.ToString(), ak.ToString(), ats.ToString());
                        var userResponse = maintoken.Account.VerifyCredentials();
                        //スクリーンネーム表示
                        loginscreenname.Text = userResponse.ScreenName;
                        //名前表示
                        loginname.Text = userResponse.Name;
                        // アイコン取得
                        WebClient i = new WebClient();
                        byte[] icon = i.DownloadData(userResponse.ProfileImageUrl);
                        MemoryStream iconstream = new MemoryStream(icon);
                        //ここまで
                        //アイコン表示
                        loginicon.Image = Image.FromStream(iconstream);
                        TLstream();
                    }
                    catch (Exception ex)
                    {
                    }
                }
                n++;
            }

            //via.iniのセクション一覧取得後toolstripmenuに追加
            byte[] ar2 = new byte[1024];
            uint resultSize3
                  = IniFileHandler.GetPrivateProfileStringByByteArray(
                        null, null, "default", ar2,
                        (uint)ar2.Length, "./data/via.ini");
            string result3 = Encoding.Default.GetString(
                                    ar2, 0, (int)resultSize3 - 1);
            string[] sections2 = result3.Split('\0');
            int m = 0;
            foreach (string section3 in sections2)
            {
                addToolStripMenuItem.DropDownItems.Add(section3);
                ToolStripMenuItem b1 = (ToolStripMenuItem)menuStrip1.Items[0];
                ToolStripMenuItem b2 = (ToolStripMenuItem)b1.DropDownItems[0];
                b2.DropDownItems[m].ForeColor = Color.White;
                b2.DropDownItems[m].Click += new EventHandler(accountadd_Click);
                m++;

            }

        }

        //タイマー
        private void time_Tick(object sender, EventArgs e)
        {
            now = DateTime.Now.ToString("yyyy/MM/dd ") + DateTime.Now.ToString("HH:mm:ss");
        }

        //Form1のMouseDownイベントハンドラ
        //マウスのボタンが押されたとき
        private void Home_MouseDown(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //位置を記憶する
                mousePoint = new Point(e.X, e.Y);
            }
        }

        //Form1のMouseMoveイベントハンドラ
        //マウスが動いたとき
        private void Home_MouseMove(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
                //または、つぎのようにする
                //this.Location = new Point(
                //    this.Location.X + e.X - mousePoint.X,
                //    this.Location.Y + e.Y - mousePoint.Y);
            }
        }

        

        //TLストリーミング処理
        public void TLstream ()
        {
            //非同期処理
            Task TLstream = Task.Run(() =>
            {
                //TL読み込み
                StringBuilder co = new StringBuilder(1024);
                IniFileHandler.GetPrivateProfileString("起動時", "LoadTweet",
                        "default", co, (uint)co.Capacity, "./data/setting.ini");
                var home = maintoken.Statuses.HomeTimeline(count => int.Parse(co.ToString()));
                foreach (var status in home)
                {
                    // RTを取得した場合
                    if (status.Text.StartsWith("RT"))
                    {
                        Status statusshow = maintoken.Statuses.Show(id => status.RetweetedStatus.Id);

                        // アイコン取得
                        WebClient i = new WebClient();
                        byte[] icon = i.DownloadData(statusshow.User.ProfileImageUrl);
                        MemoryStream st = new MemoryStream(icon);
                        //ここまで

                        //RTFav確認
                        Bitmap rtfav = new Bitmap("./data/img/Transparency.png");
                        int rtfavcheck = 0;
                        if (statusshow.IsFavorited == true && statusshow.IsRetweeted == true)
                        {
                            rtfav = new Bitmap("./data/img/rtfav.png");
                            rtfavcheck = 3;
                        }
                        else if (statusshow.IsFavorited == true)
                        {
                            rtfav = new Bitmap("./data/img/favicon.png");
                            rtfavcheck = 1;
                        }
                        else if (statusshow.IsRetweeted == true)
                        {
                            rtfav = new Bitmap("./data/img/rticon.gif");
                            rtfavcheck = 2;
                        }
                        //ここまで

                        //via取得
                        string viaurl = GetBetweenStrings.GetBetweenString("\"", "\"", statusshow.Source);
                        string vianame = statusshow.Source.Replace("</a>", "");
                        vianame = vianame.Replace("<a href=", "");
                        vianame = vianame.Replace(viaurl, "");
                        vianame = vianame.Replace("\">", "");
                        vianame = vianame.Replace("\"\" rel=\"nofollow", "");
                        //ここまで

                        string text = statusshow.User.Name + " @" + statusshow.User.ScreenName + "\r\n" + statusshow.Text + "\r\n" + statusshow.CreatedAt.LocalDateTime + "  @" + status.User.ScreenName + "がRT";
                        this.Invoke((Action)(() => {
                            TL.Rows.Add(new Bitmap(st), text, rtfav, statusshow.Id, rtfavcheck, statusshow.Text, statusshow.User.ScreenName, statusshow.User.ProfileImageUrl, statusshow.User.Name + " @" + statusshow.User.ScreenName, "https://twitter.com/" + statusshow.User.ScreenName, vianame, viaurl);
                        }));
                    }
                    else
                    {
                        // アイコン取得
                        WebClient i = new WebClient();
                        byte[] icon = i.DownloadData(status.User.ProfileImageUrl);
                        MemoryStream st = new MemoryStream(icon);
                        //ここまで
                        //RTFav確認
                        Bitmap rtfav = new Bitmap("./data/img/Transparency.png");
                        int rtfavcheck = 0;
                        if (status.IsFavorited == true && status.IsRetweeted == true)
                        {
                            rtfav = new Bitmap("./data/img/rtfav.png");
                            rtfavcheck = 3;
                        }
                        else if (status.IsFavorited == true)
                        {
                            rtfav = new Bitmap("./data/img/favicon.png");
                            rtfavcheck = 1;
                        }
                        else if (status.IsRetweeted == true)
                        {
                            rtfav = new Bitmap("./data/img/rticon.gif");
                            rtfavcheck = 2;
                        }
                        //ここまで

                        //via取得
                        string viaurl = GetBetweenStrings.GetBetweenString("\"", "\"", status.Source);
                        string vianame = status.Source.Replace("</a>", "");
                        vianame = vianame.Replace("<a href=", "");
                        vianame = vianame.Replace(viaurl, "");
                        vianame = vianame.Replace("\">", "");
                        vianame = vianame.Replace("\"\" rel=\"nofollow", "");
                        //ここまで

                        string text = status.User.Name + " @" + status.User.ScreenName + "\r\n" + status.Text + "\r\n" + status.CreatedAt.LocalDateTime + " ";
                        this.Invoke((Action)(() => {
                            TL.Rows.Add(new Bitmap(st), text, rtfav, status.Id, rtfavcheck, status.Text, status.User.ScreenName, status.User.ProfileImageUrl, status.User.Name + " @" + status.User.ScreenName, "https://twitter.com/" + status.User.ScreenName, vianame, viaurl);
                        }));
                    }
                        
                }
                
                //ストリーミング接続
                var stream = maintoken.Streaming.UserAsObservable().Publish();

                Action<StatusMessage> printStatus = (message) =>
                {
                    var status = (message as StatusMessage).Status;


                    // RTを取得した場合
                    if (status.Text.StartsWith("RT"))
                    {
                        Status statusshow = maintoken.Statuses.Show(id => status.RetweetedStatus.Id);

                        // アイコン取得
                        WebClient i = new WebClient();
                        byte[] icon = i.DownloadData(statusshow.User.ProfileImageUrl);
                        MemoryStream st = new MemoryStream(icon);
                        //ここまで

                        //RTFav確認
                        Bitmap rtfav = new Bitmap("./data/img/Transparency.png");
                        int rtfavcheck = 0;
                        if (statusshow.IsFavorited == true && statusshow.IsRetweeted == true)
                        {
                            rtfav = new Bitmap("./data/img/rtfav.png");
                            rtfavcheck = 3;
                        }
                        else if (statusshow.IsFavorited == true)
                        {
                            rtfav = new Bitmap("./data/img/favicon.png");
                            rtfavcheck = 1;
                        }
                        else if (statusshow.IsRetweeted == true)
                        {
                            rtfav = new Bitmap("./data/img/rticon.gif");
                            rtfavcheck = 2;
                        }
                        //ここまで

                        //via取得
                        string viaurl = GetBetweenStrings.GetBetweenString("\"", "\"", statusshow.Source);
                        string vianame = statusshow.Source.Replace("</a>", "");
                        vianame = vianame.Replace("<a href=", "");
                        vianame = vianame.Replace(viaurl, "");
                        vianame = vianame.Replace("\">", "");
                        vianame = vianame.Replace("\"\" rel=\"nofollow", "");
                        //ここまで

                        string text = statusshow.User.Name + " @" + statusshow.User.ScreenName + "\r\n" + statusshow.Text + "\r\n" + statusshow.CreatedAt.LocalDateTime + "  @" + status.User.ScreenName + "がRT";
                        this.Invoke((Action)(() => {
                            TL.Rows.Insert(0, new Bitmap(st), text, rtfav, statusshow.Id, rtfavcheck, statusshow.Text, statusshow.User.ScreenName, statusshow.User.ProfileImageUrl, statusshow.User.Name + " @" + statusshow.User.ScreenName, "https://twitter.com/" + statusshow.User.ScreenName, vianame, viaurl);
                        }));


                    }
                    else
                    {
                        // アイコン取得
                        WebClient i = new WebClient();
                        byte[] icon = i.DownloadData(status.User.ProfileImageUrl);
                        MemoryStream st = new MemoryStream(icon);
                        //ここまで

                        //RTFav確認
                        Bitmap rtfav = new Bitmap("./data/img/Transparency.png");
                        int rtfavcheck = 0;
                        if (status.IsFavorited == true && status.IsRetweeted == true)
                        {
                            rtfav = new Bitmap("./data/img/rtfav.png");
                            rtfavcheck = 3;
                        }
                        else if (status.IsFavorited == true)
                        {
                            rtfav = new Bitmap("./data/img/favicon.png");
                            rtfavcheck = 1;
                        }
                        else if (status.IsRetweeted == true)
                        {
                            rtfav = new Bitmap("./data/img/rticon.gif");
                            rtfavcheck = 2;
                        }
                        //ここまで

                        //via取得
                        string viaurl = GetBetweenStrings.GetBetweenString("\"", "\"", status.Source);
                        string vianame = status.Source.Replace("</a>", "");
                        vianame = vianame.Replace("<a href=", "");
                        vianame = vianame.Replace(viaurl, "");
                        vianame = vianame.Replace("\">", "");
                        vianame = vianame.Replace("\"\" rel=\"nofollow", "");
                        //ここまで

                        string text = status.User.Name + " @" + status.User.ScreenName + "\r\n" + status.Text + "\r\n" + status.CreatedAt.LocalDateTime + " ";
                        this.Invoke((Action)(() => {
                            TL.Rows.Insert(0, new Bitmap(st), text, rtfav, status.Id, rtfavcheck, status.Text, status.User.ScreenName, status.User.ProfileImageUrl, status.User.Name + " @" + status.User.ScreenName, "https://twitter.com/" + status.User.ScreenName, vianame, viaurl);
                        }));


                        st.Close();
                    }

                    
                };

                stream.OfType<StatusMessage>().Subscribe(printStatus, onError: exception => MessageBox.Show(exception.ToString(), "エラー", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2));
                var disposable = stream.Connect();
            });
        }

        //アカウント追加
        public void accountadd_Click(object sender, EventArgs e)
        {
            //via読み込み
            string appname = ((ToolStripMenuItem)sender).Text.ToString();
            StringBuilder ck = new StringBuilder(1024);
            IniFileHandler.GetPrivateProfileString(appname, "ConsumerKey",
                    "default", ck, (uint)ck.Capacity, "./data/via.ini");
            StringBuilder cs = new StringBuilder(1024);
            IniFileHandler.GetPrivateProfileString(appname, "ConsumerSecret",
                    "default", cs, (uint)cs.Capacity, "./data/via.ini");

            var session = OAuth.Authorize(ck.ToString(), cs.ToString());
            System.Diagnostics.Process.Start(session.AuthorizeUri.AbsoluteUri);
            string pin = Interaction.InputBox("ここにPINコードを入力してください", "PINコード入力", "");
            if (pin == "")
            {
                return;
            }
            Tokens newtokens;
            try
            {
                newtokens = OAuth.GetTokens(session, pin);
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(em(ex.Message), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return;
            }

            //token.iniのセクション数調べる
            byte[] ac = new byte[1024];
            uint resultSize2
                  = IniFileHandler.GetPrivateProfileStringByByteArray(
                        null, null, "default", ac,
                        (uint)ac.Length, "./token.ini");
            string result2 = Encoding.Default.GetString(
                                    ac, 0, (int)resultSize2 - 1);
            string[] sections = result2.Split('\0');
            int n = 0;
            foreach (string section in sections)
            {
                n++;           
            }

            //スクリーンネーム取得
            var userResponse = newtokens.Account.VerifyCredentials();
            string tokenname = userResponse.ScreenName + "(" + appname + ")";

            //iniファイルに保存
            IniFileHandler.WritePrivateProfileString(tokenname, "ConsumerKey", ck.ToString(), "./data/token.ini");
            IniFileHandler.WritePrivateProfileString(tokenname, "ConsumerSecret", cs.ToString(), "./data/token.ini");
            IniFileHandler.WritePrivateProfileString(tokenname, "AccessToken", newtokens.AccessToken, "./data/token.ini");
            IniFileHandler.WritePrivateProfileString(tokenname, "AccessTokenSecret", newtokens.AccessTokenSecret, "./data/token.ini");

            //メニューに追加
            selectToolStripMenuItem.DropDownItems.Add(tokenname);
            ToolStripMenuItem a1 = (ToolStripMenuItem)menuStrip1.Items[0];
            ToolStripMenuItem a2 = (ToolStripMenuItem)a1.DropDownItems[1];
            a2.DropDownItems[n].ForeColor = Color.White;
            a2.DropDownItems[n].Click += new EventHandler(accountselect_Click);
            deleteToolStripMenuItem.DropDownItems.Add(string.Format(tokenname));
            ToolStripMenuItem a3 = (ToolStripMenuItem)a1.DropDownItems[2];
            a3.DropDownItems[n].ForeColor = Color.White;
            a3.DropDownItems[n].Click += new EventHandler(accountdelete_Click);
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setting s = new setting();
            s.StartPosition = FormStartPosition.CenterScreen;
            s.ShowDialog(this);
        }

        //via追加
        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viaform v = new viaform();
            v.StartPosition = FormStartPosition.CenterScreen;
            v.ShowDialog(this);

        }

        //アカウント選択
        private void accountselect_Click(object sender, EventArgs e)
        {
            

        }

        //アカウント削除
        private void accountdelete_Click(object sender, EventArgs e)
        {
            DialogResult c = MessageBox.Show("本当に削除してもよろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (c == DialogResult.Yes)
            {
                IniFileHandler.WritePrivateProfileString(((ToolStripMenuItem)sender).Text, null, null, "./data/token.ini");
                DialogResult result = MessageBox.Show("削除されました(X3)", "成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2);
                Application.Restart();
            }
        }

        //via削除
        public void viadelete_Click(object sender, EventArgs e)
        {


        }

        //エラー処理
        public string em(string ex)
        {
            if (ex == "Error processing your OAuth request: Invalid oauth_verifier parameter")
            {
                ex = "認証に失敗しました。\r\nPINコードが間違ってるかトークンが無効になってる可能性があります(X3)";
            }
            else if (ex == "You are unable to follow more people at this time. Learn more <a href='http://support.twitter.com/articles/66885-i-can-t-follow-people-follow-limits'>here</a>.")
            {
                ex = "フォロー制限がかかっています(X3)";
            }
            else if (ex == "You have been blocked from following this account at the request of the user.")
            {
                ex = "ブロックされています(X3)";
            }
            else if (ex == "To protect our users from spam and other malicious activity, this account is temporarily locked.Please log in to https://twitter.com to unlock your account.")
            {
                ex = "アカウントがロックされました(X3)";
            }
            else if (ex == "You can't follow yourself.")
            {
                ex = "自分をフォローできません(X3)";
            }

            return ex;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //簡易ツイート
        private void easytweeting_Click(object sender, EventArgs e)
        {
            tweet twi = new LIFE.tweet();
            twi.easytweet(maintoken, easytweet.Text);
            easytweet.Text = "";
        }

        //ツイート画面開く
        private void tweetopen_Click(object sender, EventArgs e)
        {
            if (t == null || t.IsDisposed)
            {
                t = new tweeting();
                t.Tokens = maintoken;
                t.Show();
            }
            else if (!t.IsDisposed)
            {
                t.Close();
            }
            
        }

        private void easytweet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n' && Control.ModifierKeys == Keys.Control)
            {
                easytweeting.PerformClick();
                e.Handled = true;
            }
        }

        //オンマウス時の処理
        //ツイートボタン
        private void tweetopen_MouseMove(object sender, EventArgs e)
        {
            tweetopen.BackColor = Color.FromArgb(62, 62, 64);
        }
        private void tweetopen_MouseLeave(object sender, EventArgs e)
        {
            tweetopen.BackColor = Color.FromArgb(45, 45, 48);
        }
        //オンマウスでTLセル選択
        private void TL_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                TL.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                foreach (DataGridViewRow r in TL.Rows)
                {
                    r.Selected = false;
                }

                TLRowIndex = e.RowIndex;
                TL.Rows[e.RowIndex].Selected = true;

            }

            DataGridViewImageCell tweeticon =(DataGridViewImageCell)TL.Rows[TLRowIndex].Cells[0];
            tweetusericon.Image = (Image)tweeticon.Value;
            tweetusername.Text = TL.Rows[TLRowIndex].Cells[8].Value.ToString();
            tweetvia.Text = TL.Rows[TLRowIndex].Cells[10].Value.ToString();
            usernameurl = TL.Rows[TLRowIndex].Cells[9].Value.ToString();
            viaurls = TL.Rows[TLRowIndex].Cells[11].Value.ToString();
            opentweeturl = "https://twitter.com/null/status/" + TL.Rows[TLRowIndex].Cells[3].Value.ToString();
            tweetidstr = TL.Rows[TLRowIndex].Cells[3].Value.ToString();
            tweetuserscreenname = "@" + TL.Rows[TLRowIndex].Cells[6].Value.ToString() + " ";
            tweettexts = TL.Rows[TLRowIndex].Cells[5].Value.ToString();
            tweetview.Text = TL.Rows[TLRowIndex].Cells[5].Value.ToString();



        }
        //ここまで

        //ショートカットキーの処理
        private void Home_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N)
            {
                if (t == null || t.IsDisposed)
                {
                    t = new tweeting();
                    t.Tokens = maintoken;
                    t.Show();
                }
            }
            //ふぁぼの処理
            if (e.KeyCode == Keys.F)
            {
                string id_str = TL.Rows[TLRowIndex].Cells[3].Value.ToString();
                string rtfavcheck = TL.Rows[TLRowIndex].Cells[4].Value.ToString();
                Bitmap rtfav = new Bitmap("./data/img/Transparency.png");
                int rfc = 0;
                if (rtfavcheck == "0")
                {
                    rtfav = new Bitmap("./data/img/favicon.png");
                    rfc = 1;
                    TL.Rows[TLRowIndex].Cells[2].Value = rtfav;
                    TL.Rows[TLRowIndex].Cells[4].Value = rfc;
                }
                else if (rtfavcheck == "1")
                {
                    TL.Rows[TLRowIndex].Cells[2].Value = rtfav;
                    TL.Rows[TLRowIndex].Cells[4].Value = rfc;
                    maintoken.Favorites.Destroy(id => id_str);
                    return;
                }
                else if (rtfavcheck == "2")
                {
                    rtfav = new Bitmap("./data/img/rtfav.png");
                    rfc = 3;
                    TL.Rows[TLRowIndex].Cells[2].Value = rtfav;
                    TL.Rows[TLRowIndex].Cells[4].Value = rfc;
                }
                else if (rtfavcheck == "3")
                {
                    rtfav = new Bitmap("./data/img/rticon.gif");
                    rfc = 2;
                    TL.Rows[TLRowIndex].Cells[2].Value = rtfav;
                    TL.Rows[TLRowIndex].Cells[4].Value = rfc;
                    maintoken.Favorites.Destroy(id => id_str);
                    return;
                }
                maintoken.Favorites.Create(id => id_str);

            }

            //RTの処理
            if (e.KeyCode == Keys.R)
            {
                string id_str = TL.Rows[TLRowIndex].Cells[3].Value.ToString();
                string rtfavcheck = TL.Rows[TLRowIndex].Cells[4].Value.ToString();
                Bitmap rtfav = new Bitmap("./data/img/Transparency.png");
                int rfc = 0;
                if (rtfavcheck == "0")
                {
                    rtfav = new Bitmap("./data/img/rticon.gif");
                    rfc = 2;
                    TL.Rows[TLRowIndex].Cells[2].Value = rtfav;
                    TL.Rows[TLRowIndex].Cells[4].Value = rfc;
                }
                else if (rtfavcheck == "1")
                {
                    rtfav = new Bitmap("./data/img/rtfav.png");
                    rfc = 3;
                    TL.Rows[TLRowIndex].Cells[2].Value = rtfav;
                    TL.Rows[TLRowIndex].Cells[4].Value = rfc;
                }
                else if (rtfavcheck == "2")
                {
                    TL.Rows[TLRowIndex].Cells[2].Value = rtfav;
                    TL.Rows[TLRowIndex].Cells[4].Value = rfc;
                    maintoken.Statuses.Destroy(id => id_str);
                    return;
                }
                else if (rtfavcheck == "3")
                {
                    rtfav = new Bitmap("./data/img/favicon.png");
                    rfc = 1;
                    TL.Rows[TLRowIndex].Cells[2].Value = rtfav;
                    TL.Rows[TLRowIndex].Cells[4].Value = rfc;
                    maintoken.Statuses.Destroy(id => id_str);
                    return;
                }
                maintoken.Statuses.Retweet(id => id_str);

            }

            //パクツイの処理
            if (e.KeyCode == Keys.P)
            {
                string text = TL.Rows[TLRowIndex].Cells[5].Value.ToString();
                maintoken.Statuses.Update(status => text);
            }

            //改変パクツイの処理
            if (e.KeyCode == Keys.C)

            {
                string text = TL.Rows[TLRowIndex].Cells[5].Value.ToString();
                string chengescreenname = TL.Rows[TLRowIndex].Cells[6].Value.ToString();
                text = text.Replace(loginscreenname.Text, chengescreenname);
                maintoken.Statuses.Update(status => text);
            }



        }

        //大富豪ルーム作成
        private void 作成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Random r = new System.Random(1000);
            int roomnumber = r.Next(10000000,100000000);
            int n = r.Next(2, 37);
            string joincount = nConvert.IntToN(12345, 2);
            string ruletype = nConvert.IntToN(12345, 31);
            string playingconvertn = nConvert.IntToN(n, 26);
            string text = joincount + "," + ruletype + "," + playingconvertn + "#LIFEPlaying01" + roomnumber;
            maintoken.Statuses.Update(status => text);
        }

        //リンクの処理
        private void opentweet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(opentweeturl);
        }

        private void tweetusername_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(usernameurl);
        }

        private void tweetvia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(viaurls);
        }

        private void tweetview_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(opentweeturl);
        }
        //ここまで

        //リプライボタン
        private void replybutton_Click(object sender, EventArgs e)
        {
            if(t == null || t.IsDisposed)
            {
                t = new tweeting();
                t.Tokens = maintoken;
                t.Show();
            }

            t.TweetTextBox.Focus();
            t.replyidstr.Text = "";
            t.replyidstr.Text = tweetidstr;
            t.TweetTextBox.Text = "";
            t.TweetTextBox.Text = tweetuserscreenname;
        }

        //RTボタン
        private void rtbutton_Click(object sender, EventArgs e)
        {
            string id_str = TL.Rows[TLRowIndex].Cells[3].Value.ToString();
            string rtfavcheck = TL.Rows[TLRowIndex].Cells[4].Value.ToString();
            Bitmap rtfav = new Bitmap("./data/img/Transparency.png");
            int rfc = 0;
            if (rtfavcheck == "0")
            {
                rtfav = new Bitmap("./data/img/rticon.gif");
                rfc = 2;
                TL.Rows[TLRowIndex].Cells[2].Value = rtfav;
                TL.Rows[TLRowIndex].Cells[4].Value = rfc;
            }
            else if (rtfavcheck == "1")
            {
                rtfav = new Bitmap("./data/img/rtfav.png");
                rfc = 3;
                TL.Rows[TLRowIndex].Cells[2].Value = rtfav;
                TL.Rows[TLRowIndex].Cells[4].Value = rfc;
            }
            else if (rtfavcheck == "2")
            {
                TL.Rows[TLRowIndex].Cells[2].Value = rtfav;
                TL.Rows[TLRowIndex].Cells[4].Value = rfc;
                maintoken.Statuses.Destroy(id => id_str);
                return;
            }
            else if (rtfavcheck == "3")
            {
                rtfav = new Bitmap("./data/img/favicon.png");
                rfc = 1;
                TL.Rows[TLRowIndex].Cells[2].Value = rtfav;
                TL.Rows[TLRowIndex].Cells[4].Value = rfc;
                maintoken.Statuses.Destroy(id => id_str);
                return;
            }
            maintoken.Statuses.Retweet(id => id_str);
        }
    }
}
