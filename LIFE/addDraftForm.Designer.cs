namespace LIFE
{
    partial class AddDraftForm
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
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Draft";
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.ContentTextBox.Location = new System.Drawing.Point(10, 34);
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ContentTextBox.Size = new System.Drawing.Size(200, 166);
            this.ContentTextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(135, 227);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.ForeColor = System.Drawing.Color.White;
            this.ContentLabel.Location = new System.Drawing.Point(12, 203);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(0, 12);
            this.ContentLabel.TabIndex = 3;
            // 
            // AddDraftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(222, 262);
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ContentTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDraftForm";
            this.Text = "addDraftForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label ContentLabel;
    }
}