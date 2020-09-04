using System;
using CoreTweet;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace LIFE
{
    public partial class tweeting : Form
    {
        public tweeting()
        {
            InitializeComponent();
        }

        public Tokens Tokens;
        private Point mousePoint;
        public DraftForm DraftObj { get; set; } = null;
        public int picturecounts = 1;

        //フォーム移動
        private void tweeting_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //位置を記憶する
                mousePoint = new Point(e.X, e.Y);
            }
        }

        private void tweeting_MouseMove(object sender, MouseEventArgs e)
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
        //ここまで

        private void tweeting_Load(object sender, EventArgs e)
        {
            寿司モードToolStripMenuItem.Checked = false;
            ポーカーのリプライ化ToolStripMenuItem.Checked = false;
            モールス信号ToolStripMenuItem.Checked = false;
        }

        //モードチェック
        private void 寿司モードToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            //チェック状態を反転させる
            item.Checked = !item.Checked;
            ポーカーのリプライ化ToolStripMenuItem.Checked = false;
            モールス信号ToolStripMenuItem.Checked = false;
        }

        private void ポーカーのリプライ化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            //チェック状態を反転させる
            item.Checked = !item.Checked;
            寿司モードToolStripMenuItem.Checked = false;
            モールス信号ToolStripMenuItem.Checked = false;
        }

        private void モールス信号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            //チェック状態を反転させる
            item.Checked = !item.Checked;
            寿司モードToolStripMenuItem.Checked = false;
            ポーカーのリプライ化ToolStripMenuItem.Checked = false;
        }
        //ここまで

        private void TweetButton_Click(object sender, EventArgs e)
        {
            if (Tokens == null)
            {
                StatusLabel.Text = "まだにんしょうしていません(X3)";
                return;
            }

            var text = TweetTextBox.Text.TrimEnd('\r', '\n');

            if (string.IsNullOrEmpty(text))
            {
                TweetTextBox.Clear();
                StatusLabel.Text = "しっぱいしました(X3)";
                TweetTextBox.Focus();
                return;
            }

            if (寿司モードToolStripMenuItem.Checked)
            {
                var sushiText = string.Empty;

                for (int i = 0; i < text.Length; i++)
                    sushiText += "🍣";

                text = sushiText;
            }
            else if (モールス信号ToolStripMenuItem.Checked)
            {
                MorseCode mc = new MorseCode();
                text = mc.ConvertToMorse(text);
                if (text == "error")
                {
                    StatusLabel.Text = "もーるすしんごうにできませんでした(X3)";
                    return;
                }
            }

            if (text == "!poker")
            {
                text = string.Empty;

                if (ポーカーのリプライ化ToolStripMenuItem.Checked)
                    text = $"@KIBOUDIED \r\n";

                text += CommandPoker();
            }
            else if (text == "!bill")
            {
                // IPアドレスを使ってるから心配ならいじるといいかも
                string ipAddress = string.Empty;

                IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in ipEntry.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        ipAddress = ip.ToString();
                        break;
                    }
                }

                int IntegerIP = (int)(long.Parse(ipAddress.Replace(".", "")) / 1000);
                int bill = (IntegerIP + int.Parse(DateTime.Now.ToString("yyyyMMdd"))) % 10000;

                text = $"本日のTwitter利用料 {bill:#,0}円";
            }

            // !nowをテキスト中に入れるとそこを時間に置き換える
            // 例：「なう(!now)」→「なう(2016/09/07 01:00:00)」
            int startIndex;
            if (0 <= (startIndex = text.IndexOf("!now")))
                text = text.Remove(startIndex, 4).Insert(startIndex, DateTime.Now.ToString());

            Tweet(text, 1);
        }

        public void Tweet(string text, int count)
        {
            const string completeText = "ついーとしました(:3)";
            const string failureText = "しっぱいしました(X3)";

            string textWithCount = text;
            try
            {
                if (count != 1)
                {
                    textWithCount += $"({count}回目)";

                    if (textWithCount.Length > 140)
                    {
                        StatusLabel.Text = failureText;
                        TweetTextBox.Focus();
                        return;
                    }
                }

                ToolStripMenuItem a1 = (ToolStripMenuItem)menuStrip1.Items[1];
                try
                {
                    if (picturecounts-1 == 0)
                    {
                        Tokens.Statuses.Update(status => textWithCount, in_reply_to_status_id => replyidstr.Text);
                        replyidstr.Text = "";
                    }
                    else if (picturecounts-1 == 1)
                    {
                        MediaUploadResult first = Tokens.Media.Upload(media: new FileInfo(@a1.DropDownItems[1].Text));
                        Status s = Tokens.Statuses.Update(status: textWithCount, media_ids: new long[] { first.MediaId }, in_reply_to_status_id: long.Parse(replyidstr.Text));
                        addPictureToolStripMenuItem.DropDownItems.RemoveAt(1);
                        picturecounts--;
                        picturecount.Text = (picturecounts - 1).ToString();
                        replyidstr.Text = "";
                    }
                    else if (picturecounts-1 == 2)
                    {
                        MediaUploadResult first = Tokens.Media.Upload(media: new FileInfo(@a1.DropDownItems[1].Text));
                        MediaUploadResult second = Tokens.Media.Upload(media: new FileInfo(@a1.DropDownItems[2].Text));
                        Status s = Tokens.Statuses.Update(status: textWithCount, media_ids: new long[] { first.MediaId, second.MediaId });
                        addPictureToolStripMenuItem.DropDownItems.RemoveAt(1);
                        addPictureToolStripMenuItem.DropDownItems.RemoveAt(1);
                        picturecounts = picturecounts-2;
                        picturecount.Text = (picturecounts - 1).ToString();
                        replyidstr.Text = "";
                    }
                    else if (picturecounts-1 == 3)
                    {
                        MediaUploadResult first = Tokens.Media.Upload(media: new FileInfo(@a1.DropDownItems[1].Text));
                        MediaUploadResult second = Tokens.Media.Upload(media: new FileInfo(@a1.DropDownItems[2].Text));
                        MediaUploadResult third = Tokens.Media.Upload(media: new FileInfo(@a1.DropDownItems[3].Text));
                        Status s = Tokens.Statuses.Update(status: textWithCount, media_ids: new long[] { first.MediaId, second.MediaId, third.MediaId });
                        addPictureToolStripMenuItem.DropDownItems.RemoveAt(1);
                        addPictureToolStripMenuItem.DropDownItems.RemoveAt(1);
                        addPictureToolStripMenuItem.DropDownItems.RemoveAt(1);
                        picturecounts = picturecounts - 3;
                        picturecount.Text = (picturecounts - 1).ToString();
                        replyidstr.Text = "";
                    }
                    else if (picturecounts-1 == 4)
                    {
                        MediaUploadResult first = Tokens.Media.Upload(media: new FileInfo(@a1.DropDownItems[1].Text));
                        MediaUploadResult second = Tokens.Media.Upload(media: new FileInfo(@a1.DropDownItems[2].Text));
                        MediaUploadResult third = Tokens.Media.Upload(media: new FileInfo(@a1.DropDownItems[3].Text));
                        MediaUploadResult fourth = Tokens.Media.Upload(media: new FileInfo(@a1.DropDownItems[4].Text));
                        Status s = Tokens.Statuses.Update(status: textWithCount, media_ids: new long[] { first.MediaId, second.MediaId, third.MediaId, fourth.MediaId });
                        addPictureToolStripMenuItem.DropDownItems.RemoveAt(1);
                        addPictureToolStripMenuItem.DropDownItems.RemoveAt(1);
                        addPictureToolStripMenuItem.DropDownItems.RemoveAt(1);
                        addPictureToolStripMenuItem.DropDownItems.RemoveAt(1);
                        picturecounts = picturecounts - 4;
                        picturecount.Text = (picturecounts - 1).ToString();
                        replyidstr.Text = "";
                    }

                }
                catch (Exception ex)
                {
                    StatusLabel.Text = failureText;
                }

                TweetTextBox.Clear();
                var resultText = completeText;

                if (count != 1)
                    resultText += $"({count}回目)";

                StatusLabel.Text = resultText;
                TweetTextBox.Focus();
            }
            catch
            {
                count++;
                Tweet(text, count);
            }
        }

        // NOWボタンを押すとyyyy/MM/dd hh:mm:ss形式で投稿
        private void NowButton_Click(object sender, EventArgs e)
        {
            Tweet(DateTime.Now.ToString(), 1);
        }

        // これのコードは本当に汚くてごめん
        // 出力はKIBOTTERを参考にしてほしい
        public string CommandPoker()
        {
            Poker poker = new Poker();
            string[] text = new string[10];
            int[] cards = poker.HandOutCards();
            string result = poker.Judge(cards);
            string tweetContent = "Enjoy Poker!!\r\n";

            for (int i = 0; i < 5; i++)
            {
                text[2 * i] = Convert.ToString(cards[i] % 4);

                if (text[2 * i] == "0") text[2 * i] = "♠";
                else if (text[2 * i] == "1") text[2 * i] = "♥";
                else if (text[2 * i] == "2") text[2 * i] = "♦";
                else if (text[2 * i] == "3") text[2 * i] = "♣";

                text[2 * i + 1] = Convert.ToString((cards[i] - cards[i] % 4) / 4 + 1);

                if (text[2 * i + 1] == "1") text[2 * i + 1] = "A";
                else if (text[2 * i + 1] == "11") text[2 * i + 1] = "J";
                else if (text[2 * i + 1] == "12") text[2 * i + 1] = "Q";
                else if (text[2 * i + 1] == "13") text[2 * i + 1] = "K";

                tweetContent += text[2 * i] + text[2 * i + 1];
            }

            return tweetContent += $"\r\n{result}";
        }

        // その他コントロールのイベント
        // Deckと同じようにTweetTextBoxにフォーカスが当たっているときに
        // Ctrl+Enterでボタンを動作させてるもの
        // KIBOTTER Ver.1.3.2.0とは違ってこれなら改行が入らない
        private void TweetButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n' && Control.ModifierKeys == Keys.Control)
            {
                TweetButton.PerformClick();
                e.Handled = true;
            }
        }

        // 最初のif文の条件式は多重起動防止
        private void DraftButton_Click(object sender, EventArgs e)
        {
            if (DraftObj == null || DraftObj.IsDisposed)
            {
                DraftObj = new DraftForm(this);
                DraftObj.Show();
            }
        }

        //画像追加
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();
            //複数のファイルを選択できるようにする
            ofd.Multiselect = true;
            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (picturecounts > 5)
                {
                    StatusLabel.Text = "画像は4枚までです";
                    return;
                }
                //OKボタンがクリックされたとき、選択されたファイル名をすべて表示する
                foreach (string fn in ofd.FileNames)
                {
                    if (picturecounts >= 5)
                    {
                        StatusLabel.Text = "画像は4枚までです";
                        return;
                    }
                    addPictureToolStripMenuItem.DropDownItems.Add(fn);
                    ToolStripMenuItem a1 = (ToolStripMenuItem)menuStrip1.Items[1];
                    a1.DropDownItems[picturecounts].ForeColor = Color.White;
                    a1.DropDownItems[picturecounts].Click += new EventHandler(picturedelete_Click);
                    picturecounts++;
                    picturecount.Text = (picturecounts - 1).ToString();
                }
            }
        }

        //選択された画像を削除
        private void picturedelete_Click(object sender, EventArgs e)
        {
            addPictureToolStripMenuItem.DropDownItems.Remove(((ToolStripMenuItem)sender));
            picturecounts--;
            picturecount.Text = (picturecounts - 1).ToString();

        }

        //Drag&Dropで画像追加
        private void TweetTextBox_DragEnter(object sender, DragEventArgs e)
        {
            //コントロール内にドラッグされたとき実行される
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                //ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                e.Effect = DragDropEffects.Copy;
            else
                //ファイル以外は受け付けない
                e.Effect = DragDropEffects.None;
        }

        private void TweetTextBox_DragDrop(object sender, DragEventArgs e)
        {
            //コントロール内にドロップされたとき実行される
            //ドロップされたすべてのファイル名を取得する
            string[] fileName =
                (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string fn in fileName)
            {
                if (picturecounts >= 5)
                {
                    StatusLabel.Text = "画像は4枚までです";
                    return;
                }
                addPictureToolStripMenuItem.DropDownItems.Add(fn);
                ToolStripMenuItem a1 = (ToolStripMenuItem)menuStrip1.Items[1];
                a1.DropDownItems[picturecounts].ForeColor = Color.White;
                a1.DropDownItems[picturecounts].Click += new EventHandler(picturedelete_Click);
                picturecounts++;
                picturecount.Text = (picturecounts - 1).ToString();
            }
        }
        //ここまで

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
