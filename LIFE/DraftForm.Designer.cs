namespace LIFE
{
    partial class DraftForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.draftview = new System.Windows.Forms.DataGridView();
            this.tweetinfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.draftview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Draft";
            // 
            // draftview
            // 
            this.draftview.AllowUserToAddRows = false;
            this.draftview.AllowUserToDeleteRows = false;
            this.draftview.AllowUserToResizeColumns = false;
            this.draftview.AllowUserToResizeRows = false;
            this.draftview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.draftview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.draftview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.draftview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tweetinfo});
            this.draftview.Location = new System.Drawing.Point(10, 34);
            this.draftview.Name = "draftview";
            this.draftview.ReadOnly = true;
            this.draftview.RowHeadersVisible = false;
            this.draftview.RowTemplate.Height = 21;
            this.draftview.Size = new System.Drawing.Size(257, 212);
            this.draftview.TabIndex = 1;
            // 
            // tweetinfo
            // 
            this.tweetinfo.HeaderText = "ツイート内容";
            this.tweetinfo.Name = "tweetinfo";
            this.tweetinfo.ReadOnly = true;
            this.tweetinfo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tweetinfo.Width = 230;
            // 
            // DraftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(279, 317);
            this.Controls.Add(this.draftview);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DraftForm";
            this.Text = "DraftForm";
            ((System.ComponentModel.ISupportInitialize)(this.draftview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tweetinfo;
        public System.Windows.Forms.DataGridView draftview;
    }
}