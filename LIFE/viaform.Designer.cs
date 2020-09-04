namespace LIFE
{
    partial class viaform
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vianame = new System.Windows.Forms.TextBox();
            this.ck = new System.Windows.Forms.TextBox();
            this.cs = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "ConsumerKey";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "ConsumerSecret";
            // 
            // vianame
            // 
            this.vianame.Location = new System.Drawing.Point(25, 45);
            this.vianame.Name = "vianame";
            this.vianame.Size = new System.Drawing.Size(153, 19);
            this.vianame.TabIndex = 3;
            // 
            // ck
            // 
            this.ck.Location = new System.Drawing.Point(25, 96);
            this.ck.Name = "ck";
            this.ck.Size = new System.Drawing.Size(153, 19);
            this.ck.TabIndex = 4;
            // 
            // cs
            // 
            this.cs.Location = new System.Drawing.Point(25, 151);
            this.cs.Name = "cs";
            this.cs.Size = new System.Drawing.Size(153, 19);
            this.cs.TabIndex = 5;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(25, 188);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(63, 23);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(115, 188);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(63, 23);
            this.ok.TabIndex = 7;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.ForeColor = System.Drawing.Color.Red;
            this.log.Location = new System.Drawing.Point(12, 9);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(0, 12);
            this.log.TabIndex = 8;
            // 
            // viaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(207, 234);
            this.Controls.Add(this.log);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.cs);
            this.Controls.Add(this.ck);
            this.Controls.Add(this.vianame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viaform";
            this.Text = "via Input";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vianame;
        private System.Windows.Forms.TextBox ck;
        private System.Windows.Forms.TextBox cs;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label log;
    }
}