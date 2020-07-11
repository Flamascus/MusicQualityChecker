namespace MusicQualityChecker {
  partial class SettingsForm {
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.lblYtdlPath = new System.Windows.Forms.Label();
      this.lblSpekPath = new System.Windows.Forms.Label();
      this.txbYtdl = new System.Windows.Forms.TextBox();
      this.txbSpek = new System.Windows.Forms.TextBox();
      this.btnLocateYtdl = new System.Windows.Forms.Button();
      this.btnLocateSpek = new System.Windows.Forms.Button();
      this.btnOk = new System.Windows.Forms.Button();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.Controls.Add(this.lblYtdlPath, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.lblSpekPath, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.txbYtdl, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.txbSpek, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.btnLocateYtdl, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.btnLocateSpek, 2, 1);
      this.tableLayoutPanel1.Controls.Add(this.btnOk, 1, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 138);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // lblYtdlPath
      // 
      this.lblYtdlPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblYtdlPath.AutoSize = true;
      this.lblYtdlPath.Location = new System.Drawing.Point(3, 20);
      this.lblYtdlPath.Name = "lblYtdlPath";
      this.lblYtdlPath.Size = new System.Drawing.Size(80, 13);
      this.lblYtdlPath.TabIndex = 0;
      this.lblYtdlPath.Text = "youtube-dl path";
      // 
      // lblSpekPath
      // 
      this.lblSpekPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblSpekPath.AutoSize = true;
      this.lblSpekPath.Location = new System.Drawing.Point(3, 74);
      this.lblSpekPath.Name = "lblSpekPath";
      this.lblSpekPath.Size = new System.Drawing.Size(54, 13);
      this.lblSpekPath.TabIndex = 1;
      this.lblSpekPath.Text = "spek path";
      // 
      // txbYtdl
      // 
      this.txbYtdl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.txbYtdl.Location = new System.Drawing.Point(89, 17);
      this.txbYtdl.Name = "txbYtdl";
      this.txbYtdl.Size = new System.Drawing.Size(288, 20);
      this.txbYtdl.TabIndex = 2;
      // 
      // txbSpek
      // 
      this.txbSpek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.txbSpek.Location = new System.Drawing.Point(89, 71);
      this.txbSpek.Name = "txbSpek";
      this.txbSpek.Size = new System.Drawing.Size(288, 20);
      this.txbSpek.TabIndex = 3;
      // 
      // btnLocateYtdl
      // 
      this.btnLocateYtdl.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.btnLocateYtdl.AutoSize = true;
      this.btnLocateYtdl.Location = new System.Drawing.Point(383, 15);
      this.btnLocateYtdl.Name = "btnLocateYtdl";
      this.btnLocateYtdl.Size = new System.Drawing.Size(26, 23);
      this.btnLocateYtdl.TabIndex = 4;
      this.btnLocateYtdl.Text = "...";
      this.btnLocateYtdl.UseVisualStyleBackColor = true;
      this.btnLocateYtdl.Click += new System.EventHandler(this._BtnLocateYtdl_Click);
      // 
      // btnLocateSpek
      // 
      this.btnLocateSpek.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.btnLocateSpek.AutoSize = true;
      this.btnLocateSpek.Location = new System.Drawing.Point(383, 69);
      this.btnLocateSpek.Name = "btnLocateSpek";
      this.btnLocateSpek.Size = new System.Drawing.Size(26, 23);
      this.btnLocateSpek.TabIndex = 5;
      this.btnLocateSpek.Text = "...";
      this.btnLocateSpek.UseVisualStyleBackColor = true;
      this.btnLocateSpek.Click += new System.EventHandler(this._BtnLocateSpek_Click);
      // 
      // btnOk
      // 
      this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.SetColumnSpan(this.btnOk, 2);
      this.btnOk.Location = new System.Drawing.Point(334, 112);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(75, 23);
      this.btnOk.TabIndex = 6;
      this.btnOk.Text = "OK";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.Click += new System.EventHandler(this._BtnOk_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.Filter = "Executables |*.exe";
      // 
      // SettingsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(412, 138);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "SettingsForm";
      this.Text = "SettingsForm";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblYtdlPath;
        private System.Windows.Forms.Label lblSpekPath;
        private System.Windows.Forms.Button btnLocateYtdl;
        private System.Windows.Forms.Button btnLocateSpek;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txbYtdl;
        private System.Windows.Forms.TextBox txbSpek;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}