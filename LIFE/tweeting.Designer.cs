namespace LIFE
{
    partial class tweeting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.モードToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.寿司モードToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ポーカーのリプライ化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.モールス信号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Label1 = new System.Windows.Forms.Label();
            this.TweetTextBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.TweetButton = new System.Windows.Forms.Button();
            this.NowButton = new System.Windows.Forms.Button();
            this.DraftButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.picturecount = new System.Windows.Forms.Label();
            this.openFilePicture = new System.Windows.Forms.OpenFileDialog();
            this.replyidstr = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.モードToolStripMenuItem,
            this.addPictureToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(166, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // モードToolStripMenuItem
            // 
            this.モードToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.寿司モードToolStripMenuItem,
            this.ポーカーのリプライ化ToolStripMenuItem,
            this.モールス信号ToolStripMenuItem});
            this.モードToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.モードToolStripMenuItem.Name = "モードToolStripMenuItem";
            this.モードToolStripMenuItem.Size = new System.Drawing.Size(51, 22);
            this.モードToolStripMenuItem.Text = "Mode";
            // 
            // 寿司モードToolStripMenuItem
            // 
            this.寿司モードToolStripMenuItem.Checked = true;
            this.寿司モードToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.寿司モードToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.寿司モードToolStripMenuItem.Name = "寿司モードToolStripMenuItem";
            this.寿司モードToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.寿司モードToolStripMenuItem.Text = "寿司モード";
            this.寿司モードToolStripMenuItem.Click += new System.EventHandler(this.寿司モードToolStripMenuItem_Click);
            // 
            // ポーカーのリプライ化ToolStripMenuItem
            // 
            this.ポーカーのリプライ化ToolStripMenuItem.Checked = true;
            this.ポーカーのリプライ化ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ポーカーのリプライ化ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ポーカーのリプライ化ToolStripMenuItem.Name = "ポーカーのリプライ化ToolStripMenuItem";
            this.ポーカーのリプライ化ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ポーカーのリプライ化ToolStripMenuItem.Text = "ポーカーのリプライ化";
            this.ポーカーのリプライ化ToolStripMenuItem.Click += new System.EventHandler(this.ポーカーのリプライ化ToolStripMenuItem_Click);
            // 
            // モールス信号ToolStripMenuItem
            // 
            this.モールス信号ToolStripMenuItem.Checked = true;
            this.モールス信号ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.モールス信号ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.モールス信号ToolStripMenuItem.Name = "モールス信号ToolStripMenuItem";
            this.モールス信号ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.モールス信号ToolStripMenuItem.Text = "モールス信号";
            this.モールス信号ToolStripMenuItem.Click += new System.EventHandler(this.モールス信号ToolStripMenuItem_Click);
            // 
            // addPictureToolStripMenuItem
            // 
            this.addPictureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.addPictureToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addPictureToolStripMenuItem.Name = "addPictureToolStripMenuItem";
            this.addPictureToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.addPictureToolStripMenuItem.Text = "image";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(51, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(7, 4);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(42, 17);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Tweet";
            // 
            // TweetTextBox
            // 
            this.TweetTextBox.AllowDrop = true;
            this.TweetTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.TweetTextBox.ForeColor = System.Drawing.Color.White;
            this.TweetTextBox.Location = new System.Drawing.Point(10, 70);
            this.TweetTextBox.Multiline = true;
            this.TweetTextBox.Name = "TweetTextBox";
            this.TweetTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TweetTextBox.Size = new System.Drawing.Size(250, 173);
            this.TweetTextBox.TabIndex = 2;
            this.TweetTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.TweetTextBox_DragDrop);
            this.TweetTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.TweetTextBox_DragEnter);
            this.TweetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TweetButton_KeyPress);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.Location = new System.Drawing.Point(14, 246);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 12);
            this.StatusLabel.TabIndex = 4;
            // 
            // TweetButton
            // 
            this.TweetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TweetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TweetButton.ForeColor = System.Drawing.Color.White;
            this.TweetButton.Location = new System.Drawing.Point(185, 273);
            this.TweetButton.Margin = new System.Windows.Forms.Padding(0);
            this.TweetButton.Name = "TweetButton";
            this.TweetButton.Size = new System.Drawing.Size(75, 23);
            this.TweetButton.TabIndex = 5;
            this.TweetButton.Text = "Tweet";
            this.TweetButton.UseVisualStyleBackColor = true;
            this.TweetButton.Click += new System.EventHandler(this.TweetButton_Click);
            // 
            // NowButton
            // 
            this.NowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NowButton.ForeColor = System.Drawing.Color.White;
            this.NowButton.Location = new System.Drawing.Point(96, 273);
            this.NowButton.Name = "NowButton";
            this.NowButton.Size = new System.Drawing.Size(75, 23);
            this.NowButton.TabIndex = 6;
            this.NowButton.Text = "Now";
            this.NowButton.UseVisualStyleBackColor = true;
            this.NowButton.Click += new System.EventHandler(this.NowButton_Click);
            // 
            // DraftButton
            // 
            this.DraftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DraftButton.ForeColor = System.Drawing.Color.White;
            this.DraftButton.Location = new System.Drawing.Point(10, 273);
            this.DraftButton.Name = "DraftButton";
            this.DraftButton.Size = new System.Drawing.Size(75, 23);
            this.DraftButton.TabIndex = 7;
            this.DraftButton.Text = "Draft";
            this.DraftButton.UseVisualStyleBackColor = true;
            this.DraftButton.Click += new System.EventHandler(this.DraftButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 11);
            this.label2.TabIndex = 8;
            this.label2.Text = "画像選択数:";
            // 
            // picturecount
            // 
            this.picturecount.AutoSize = true;
            this.picturecount.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.picturecount.ForeColor = System.Drawing.Color.White;
            this.picturecount.Location = new System.Drawing.Point(69, 308);
            this.picturecount.Name = "picturecount";
            this.picturecount.Size = new System.Drawing.Size(11, 11);
            this.picturecount.TabIndex = 9;
            this.picturecount.Text = "0";
            // 
            // openFilePicture
            // 
            this.openFilePicture.Multiselect = true;
            // 
            // replyidstr
            // 
            this.replyidstr.AutoSize = true;
            this.replyidstr.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.replyidstr.ForeColor = System.Drawing.Color.White;
            this.replyidstr.Location = new System.Drawing.Point(205, 308);
            this.replyidstr.Name = "replyidstr";
            this.replyidstr.Size = new System.Drawing.Size(0, 11);
            this.replyidstr.TabIndex = 10;
            // 
            // tweeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(279, 326);
            this.Controls.Add(this.replyidstr);
            this.Controls.Add(this.picturecount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DraftButton);
            this.Controls.Add(this.NowButton);
            this.Controls.Add(this.TweetButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.TweetTextBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "tweeting";
            this.Text = "tweeting";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.tweeting_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tweeting_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tweeting_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem モードToolStripMenuItem;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ToolStripMenuItem 寿司モードToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ポーカーのリプライ化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem モールス信号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPictureToolStripMenuItem;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button TweetButton;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button NowButton;
        private System.Windows.Forms.Button DraftButton;
        public System.Windows.Forms.TextBox TweetTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label picturecount;
        private System.Windows.Forms.OpenFileDialog openFilePicture;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        public System.Windows.Forms.Label replyidstr;
    }
}