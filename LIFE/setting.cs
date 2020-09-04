using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIFE
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        private void setting_Load(object sender, EventArgs e)
        {
            //token.iniのセクション一覧取得後StartAppLoginAcountに追加
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
                StartAppLoginAcount.Items.Add(section);
            }
        }

        //設定の保存
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string startaccount;
            int indexStartAppLoginAcount = StartAppLoginAcount.SelectedIndex;
            startaccount = StartAppLoginAcount.Items[indexStartAppLoginAcount].ToString();

            if (!Validation.IsNumeric(StartAppTLLoadTweetCount.Text) || int.Parse(StartAppTLLoadTweetCount.Text) > 200)
            {
                //整数じゃないとき
                DialogResult result = MessageBox.Show("200までの整数値を入力してください(X3)", "エラー:起動時に読み込むツイート数", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return;
            }

            //iniファイルに保存
            IniFileHandler.WritePrivateProfileString("起動時", "LoginAccount", startaccount, "./data/setting.ini");
            IniFileHandler.WritePrivateProfileString("起動時", "LoadTweet", StartAppTLLoadTweetCount.Text, "./data/setting.ini");

        }
    }
}
