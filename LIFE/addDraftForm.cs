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
    public partial class AddDraftForm : Form
    {
        DraftForm df { get; set; }
        int Count = 0;

        public AddDraftForm(DraftForm d)
        {
            df = d;
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            df.draftview.Rows.Add(ContentTextBox.Text);
            ContentLabel.Text = $"ついかしました({++Count}こめ)";
            ContentTextBox.Text = string.Empty;
        }
    }
}
