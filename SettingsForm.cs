using MusicQualityChecker.Properties;
using System;
using System.Windows.Forms;

namespace MusicQualityChecker {
  public partial class SettingsForm : Form {

    public SettingsForm() {
      InitializeComponent();
      this.txbYtdl.Text = Settings.Default.youtubeDLPath;
      this.txbSpek.Text = Settings.Default.spekPath;
    }

    private void _BtnOk_Click(object _, EventArgs __) {
      Settings.Default.youtubeDLPath = this.txbYtdl.Text;
      Settings.Default.spekPath = this.txbSpek.Text;
      this.Close();
    }

    private void _BtnLocateYtdl_Click(object _, EventArgs __) {
      if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
        this.txbYtdl.Text = this.openFileDialog1.FileName;
    }

    private void _BtnLocateSpek_Click(object _, EventArgs __) {
      if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
        this.txbSpek.Text = this.openFileDialog1.FileName;
    }
  }
}
