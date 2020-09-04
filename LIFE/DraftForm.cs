using System;
using System.IO;
using System.Windows.Forms;

namespace LIFE
{
    public partial class DraftForm : Form
    {
        public tweeting t1 { get; set; }
        public AddDraftForm AddDraftDbj = null;

        public string FileName { get; set; } = string.Empty;

        public DraftForm(tweeting t)
        {
            t1 = t;
            InitializeComponent();
        }

        // Settingフォルダを作ってその中のSavedTweets.tweetに保存
        private void DraftForm_Load(object sender, EventArgs e)
        {
            string folder = AppDomain.CurrentDomain.BaseDirectory + "data";
            Directory.CreateDirectory(folder);
            FileName = folder + "\\SavedTweets" + ".tweet";
            FileName = Path.GetFullPath(FileName);

            if (File.Exists(FileName))
            {
                using (StreamReader sr = new StreamReader(FileName))
                {
                    int ch;
                    string draftedTweet = string.Empty;
                    while ((ch = sr.Read()) != -1)
                    {
                        if ((char)ch == '℧')
                        {
                            draftview.Rows.Add(draftedTweet);
                            draftedTweet = string.Empty;
                            continue;
                        }

                        draftedTweet += (char)ch;
                    }
                }
            }

            draftview.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            draftview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            draftview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            draftview.ReadOnly = true;
            draftview.AllowUserToAddRows = false;
            draftview.MultiSelect = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AddDraftDbj == null || AddDraftDbj.IsDisposed)
            {
                AddDraftDbj = new AddDraftForm(this);
                AddDraftDbj.ShowDialog();
            }
        }

        private void UseButton_Click(object sender, EventArgs e)
        {
            try
            {
                t1.TweetTextBox.Text += (string)draftview.CurrentRow.Cells[0].Value;
            }
            catch
            {
                MessageBox.Show(
                    "つかえませんでした(X3)",
                    "えらー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // 区切り文字は "℧"
        // 出力ファイルをメモ帳で開けばわかるけどただのテキストファイル
        // それを区切り文字で区切ってるだけ
        // xmlとかにしたほうがいいので変えられるなら変えてどうぞ
        // (xmlだと表示が崩れるからこっちのほうがテキストの可読性は高い)
        private void DraftForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            draftview.MultiSelect = true;
            draftview.SelectAll();

            using (StreamWriter sw = new StreamWriter(FileName, false))
            {
                for (int i = 0; i < draftview.SelectedCells.Count; i++)
                {
                    if (draftview.SelectedCells[i].Value == null)
                        break;

                    string toAdd = draftview.SelectedCells[i].Value.ToString();
                    sw.Write(toAdd + "℧");
                }
            }
        }
    }
}
