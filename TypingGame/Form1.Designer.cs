namespace TypingGame {
  partial class Form1 {
    /// <summary>
    /// 必要なデザイナー変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows フォーム デザイナーで生成されたコード

    /// <summary>
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent() {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.FormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fontDialog1 = new System.Windows.Forms.FontDialog();
      this.writeTb = new System.Windows.Forms.TextBox();
      this.viewTb = new System.Windows.Forms.TextBox();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(825, 24);
      this.menuStrip1.TabIndex = 2;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // FormatToolStripMenuItem
      // 
      this.FormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontToolStripMenuItem});
      this.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem";
      this.FormatToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
      this.FormatToolStripMenuItem.Text = "Format";
      // 
      // FontToolStripMenuItem
      // 
      this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
      this.FontToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
      this.FontToolStripMenuItem.Text = "Font";
      this.FontToolStripMenuItem.Click += new System.EventHandler(this.FontStripMenuItem_Click);
      // 
      // fontDialog1
      // 
      this.fontDialog1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      // 
      // writeTb
      // 
      this.writeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.writeTb.Location = new System.Drawing.Point(0, 333);
      this.writeTb.Multiline = true;
      this.writeTb.Name = "writeTb";
      this.writeTb.ShortcutsEnabled = false;
      this.writeTb.Size = new System.Drawing.Size(825, 300);
      this.writeTb.TabIndex = 3;
      // 
      // viewTb
      // 
      this.viewTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.viewTb.Enabled = false;
      this.viewTb.Location = new System.Drawing.Point(0, 27);
      this.viewTb.Multiline = true;
      this.viewTb.Name = "viewTb";
      this.viewTb.ShortcutsEnabled = false;
      this.viewTb.Size = new System.Drawing.Size(825, 300);
      this.viewTb.TabIndex = 4;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(825, 637);
      this.Controls.Add(this.viewTb);
      this.Controls.Add(this.writeTb);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem FormatToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
    private System.Windows.Forms.FontDialog fontDialog1;
    private System.Windows.Forms.TextBox writeTb;
    private System.Windows.Forms.TextBox viewTb;
  }
}

