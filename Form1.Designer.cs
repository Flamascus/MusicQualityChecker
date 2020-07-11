namespace MusicQualityChecker {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.lblLink = new System.Windows.Forms.Label();
      this.txbLink = new System.Windows.Forms.TextBox();
      this.btnCheck = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(340, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // settingsToolStripMenuItem
      // 
      this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
      this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
      this.settingsToolStripMenuItem.Text = "Settings";
      this.settingsToolStripMenuItem.Click += new System.EventHandler(this._SettingsToolStripMenuItem_Click);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.lblLink, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.txbLink, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.btnCheck, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(340, 77);
      this.tableLayoutPanel1.TabIndex = 1;
      this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this._TableLayoutPanel1_MouseEnter);
      // 
      // lblLink
      // 
      this.lblLink.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblLink.AutoSize = true;
      this.lblLink.Location = new System.Drawing.Point(3, 17);
      this.lblLink.Name = "lblLink";
      this.lblLink.Size = new System.Drawing.Size(30, 13);
      this.lblLink.TabIndex = 0;
      this.lblLink.Text = "Link:";
      // 
      // txbLink
      // 
      this.txbLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.txbLink.Location = new System.Drawing.Point(39, 14);
      this.txbLink.Name = "txbLink";
      this.txbLink.Size = new System.Drawing.Size(298, 20);
      this.txbLink.TabIndex = 1;
      // 
      // btnCheck
      // 
      this.btnCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this.btnCheck.AutoSize = true;
      this.tableLayoutPanel1.SetColumnSpan(this.btnCheck, 2);
      this.btnCheck.Location = new System.Drawing.Point(130, 51);
      this.btnCheck.Name = "btnCheck";
      this.btnCheck.Size = new System.Drawing.Size(80, 23);
      this.btnCheck.TabIndex = 2;
      this.btnCheck.Text = "CheckQuality";
      this.btnCheck.UseVisualStyleBackColor = true;
      this.btnCheck.Click += new System.EventHandler(this._BtnCheck_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(340, 101);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "MusicQualityChecker";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._Form1_FormClosing);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.TextBox txbLink;
        private System.Windows.Forms.Button btnCheck;
    }
}

