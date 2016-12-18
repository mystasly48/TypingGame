using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace TypingGame {
  public class PracticeText {
    private static readonly string AbsolutePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\" + TextDirectory;

    public static string TextDirectory { get; set; } = "Text";

    public static string[] GetAllText() {
      return Directory.GetFiles(AbsolutePath);
    }

    public static string GetText(string name) {
      
    }
    
    public static string GetRandText() {
      string[] files = GetAllText();
      return files[GetRand(files.Length)];
    }

    public static bool IsExistText() {
      if (Directory.Exists(AbsolutePath)) {
        string[] files = GetAllText();
        if (files.Length == 0) {
          return false;
        } else {
          return true;
        }
      } else {
        return false;
      }
    }

    private static int GetRand(int max) {
      return new Random().Next(max);
    }

    private static string ReadFile(string name) {
      using (var sr = new StreamReader(name, Encoding.UTF8)) {
        return sr.ReadToEnd();
      }
    }
  }
}
