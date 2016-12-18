using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TypingGame.Properties;

namespace TypingGame {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    string Text = "";

    private void FontStripMenuItem_Click(object sender, EventArgs e) {
      fontDialog1.Font = Settings.Default.TextBoxFont;
      fontDialog1.ShowDialog();
      SaveFont(fontDialog1.Font);
      ApplyFont();
    }

    private void Form1_Load(object sender, EventArgs e) {
      ApplyFont();
      ApplyPracticeText();
    }

    private void ApplyPracticeText() {
      if (PracticeText.IsExistText()) {
        using (var sr = new StreamReader(PracticeText.GetRandText(), Encoding.UTF8)) {
          Text = sr.ReadToEnd();
        }
        viewTb.Text = Text;
      } else {
        MessageBox.Show("Practice Text was not Found.");
      }
    }

    private void ApplyFont() {
      viewTb.Font = Settings.Default.TextBoxFont;
      writeTb.Font = Settings.Default.TextBoxFont;
    }

    private void SaveFont(Font font) {
      Settings.Default.TextBoxFont = font;
      Settings.Default.Save();
    }
  }
}
