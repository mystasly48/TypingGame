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

    string CurrentText = "";

    private void FontStripMenuItem_Click(object sender, EventArgs e) {
      fontDialog1.Font = Settings.Default.TextBoxFont;
      fontDialog1.ShowDialog();
      SaveFont(fontDialog1.Font);
      ApplyFont();
    }

    private void Form1_Load(object sender, EventArgs e) {
      FixControlsSize();
      ApplyFont();
      ApplyPracticeText();
    }

    private void ApplyPracticeText() {
      if (PracticeText.IsExistText()) {
        CurrentText = PracticeText.ReadFile(PracticeText.GetRandText());
        viewTb.Text = CurrentText;
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

    private void Form1_Resize(object sender, EventArgs e) {
      FixControlsSize();
    }

    private void FixControlsSize() {
      var size = new Size(Size.Width - 22, Size.Height / 2 - 46);
      viewTb.Size = size;
      writeTb.Size = size;
      writeTb.Location = new Point(0, Size.Height / 2 + 2);
      // Width, Height
      // Form Size  : 1397, 1012
      // view Size  : 1375, 460
      // view Loca  : 0   , 35
      // write Size : 1375, 460
      // write Loca : 0   , 508
      // 22  , 1012/2=506
      //
    }
  }
}
