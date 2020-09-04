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
    public partial class viaform : Form
    {
        public viaform()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (vianame.Text == "" || ck.Text == "" || cs.Text =="")
            {
                log.Text = "正しく入力されていません";
                return;
            }
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
