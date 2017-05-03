namespace PyenvForWindows
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.InstalledPython_ListBox = new System.Windows.Forms.ListBox();
            this.SwithTo_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InstalledPython_ListBox
            // 
            this.InstalledPython_ListBox.FormattingEnabled = true;
            this.InstalledPython_ListBox.ItemHeight = 12;
            this.InstalledPython_ListBox.Location = new System.Drawing.Point(12, 12);
            this.InstalledPython_ListBox.Name = "InstalledPython_ListBox";
            this.InstalledPython_ListBox.Size = new System.Drawing.Size(259, 208);
            this.InstalledPython_ListBox.TabIndex = 0;
            // 
            // SwithTo_Button
            // 
            this.SwithTo_Button.Location = new System.Drawing.Point(13, 227);
            this.SwithTo_Button.Name = "SwithTo_Button";
            this.SwithTo_Button.Size = new System.Drawing.Size(75, 23);
            this.SwithTo_Button.TabIndex = 1;
            this.SwithTo_Button.Text = "Switch";
            this.SwithTo_Button.UseVisualStyleBackColor = true;
            this.SwithTo_Button.Click += new System.EventHandler(this.SwithTo_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SwithTo_Button);
            this.Controls.Add(this.InstalledPython_ListBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox InstalledPython_ListBox;
        private System.Windows.Forms.Button SwithTo_Button;
    }
}

