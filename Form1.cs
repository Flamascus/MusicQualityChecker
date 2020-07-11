using MusicQualityChecker.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Timer = System.Timers.Timer;
using System.Linq;

namespace MusicQualityChecker {
  public partial class Form1 : Form {
   
    private static readonly DirectoryInfo _TEMP_DIR = new DirectoryInfo("temp");
    private readonly FileSystemWatcher _downloadWatcher;
    private static readonly string _DOWNLOAD_ARGUMENT = Settings.Default.dlArgument;
    private static readonly string[] _EXTENSIONS = new[] { "mp3", "opus", "flac", "wav", "m4a", "aac" };
    private readonly Timer _timer;


    public Form1() {
      InitializeComponent();
      _TEMP_DIR.Create();

      this._timer = new Timer {
        Interval = 100,
        AutoReset = false
      };
      
      this._timer.Elapsed += (_, __) => this._StartSpek();

      this._downloadWatcher = new FileSystemWatcher(_TEMP_DIR.FullName, "*.*");
      this._downloadWatcher.Created += this._OnMusicFileChanged;
      this._downloadWatcher.Changed += this._OnMusicFileChanged;
      this._downloadWatcher.EnableRaisingEvents = true;
    }

    private void _TableLayoutPanel1_MouseEnter(object _, EventArgs __)
      => this.txbLink.Text = Clipboard.GetText();

    private void _BtnCheck_Click(object _, EventArgs __) {
      var link = this.txbLink.Text;
      if (link == string.Empty)
        return;

      //cut yt playlist links
      if (link.StartsWith("https://www.youtube.com"))
        link = link.Split(new[] { "&list=" }, StringSplitOptions.None)[0];

      //need to surround with " for console
      var path = Settings.Default.youtubeDLPath;

      if (path != "youtube-dl") {
        path = $"\"{Settings.Default.youtubeDLPath}\"";
        Process.Start(path, string.Format(_DOWNLOAD_ARGUMENT, "", link, _TEMP_DIR.FullName));
        return;
      }

      var argument = "/c " + string.Format(_DOWNLOAD_ARGUMENT,
        path, link, _TEMP_DIR.FullName);

      Process.Start(@"C:\windows\system32\cmd.exe", argument);
    }
    
    private void _OnMusicFileChanged(object _, FileSystemEventArgs e) { 
      foreach (var extension in _EXTENSIONS) {
        if (e.FullPath.EndsWith(extension)) {
          this._timer.Start();
          return;
        }
      }
    }

    private void _StartSpek() {
      var file = _TEMP_DIR.GetFiles().OrderByDescending(f => f.CreationTime).First();
      Process.Start(Settings.Default.spekPath, $"\"{file.FullName}\"");
    }

    private void _Form1_FormClosing(object _, FormClosingEventArgs __) {
      var files = _TEMP_DIR.GetFiles();

      foreach (var file in files)
        file.Delete();
    }

    private void _SettingsToolStripMenuItem_Click(object sender, EventArgs e)
      => new SettingsForm().Show();
  }
}
