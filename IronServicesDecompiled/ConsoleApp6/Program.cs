// Decompiled with JetBrains decompiler
// Type: ConsoleApp6.Program
// Assembly: XSERVICE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BFC8236-C752-4F03-B26C-B599E427CA2C
// Assembly location: C:\Users\Zach\Desktop\IronServicesDecompiled.exe

using IDKShopSpoofer;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ConsoleApp6
{
  internal class Program : ProgramBase
  {
    private static void Main(string[] args)
    {
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.Title = "SPOOFER X SERVICE";
      Console.WriteLine("   _____ ____  ____  ____  ________________     _  __    _____ __________ _    __________________");
      Console.WriteLine("  / ___// __ \\/ __ \\/ __ \\/ ____/ ____/ __ \\   | |/ /   / ___// ____/ __ \\ |  / /  _/ ____/ ____/");
      Console.WriteLine("  \\__ \\/ /_/ / / / / / / / /_  / __/ / /_/ /   |   /    \\__ \\/ __/ / /_/ / | / // // /   / __/   ");
      Console.WriteLine(" ___/ / ____/ /_/ / /_/ / __/ / /___/ _, _/   /   |    ___/ / /___/ _, _/| |/ // // /___/ /___   ");
      Console.WriteLine("/____/_/    \\____/\\____/_/   /_____/_/ |_|   /_/|_|   /____/_____/_/ |_| |___/___/\\____/_____/   ");
      Console.WriteLine("\n\n Connecting..");
      ProgramBase.KeyAuthApp.init();
      if (!ProgramBase.KeyAuthApp.response.success)
      {
        Console.WriteLine("\n Status: " + ProgramBase.KeyAuthApp.response.message);
        Thread.Sleep(1500);
        Environment.Exit(0);
      }
      Console.WriteLine(" Application Version: " + ProgramBase.KeyAuthApp.app_data.version);
      ProgramBase.KeyAuthApp.check();
      Console.WriteLine(" Current Session Validation Status: " + ProgramBase.KeyAuthApp.response.message);
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.Title = "SPOOFER X SERVICE";
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.Title = "SPOOFER X SERVICE";
      Console.WriteLine("   _____ ____  ____  ____  ________________     _  __    _____ __________ _    __________________");
      Console.WriteLine("  / ___// __ \\/ __ \\/ __ \\/ ____/ ____/ __ \\   | |/ /   / ___// ____/ __ \\ |  / /  _/ ____/ ____/");
      Console.WriteLine("  \\__ \\/ /_/ / / / / / / / /_  / __/ / /_/ /   |   /    \\__ \\/ __/ / /_/ / | / // // /   / __/   ");
      Console.WriteLine(" ___/ / ____/ /_/ / /_/ / __/ / /___/ _, _/   /   |    ___/ / /___/ _, _/| |/ // // /___/ /___   ");
      Console.WriteLine("/____/_/    \\____/\\____/_/   /_____/_/ |_|   /_/|_|   /____/_____/_/ |_| |___/___/\\____/_____/   ");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("\n [1] Login\n\n Choose option: ");
      if (int.Parse(Console.ReadLine()) == 1)
      {
        Console.Title = "SPOOFER X SERVICE";
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Title = "SPOOFER X SERVICE";
        Console.WriteLine("   _____ ____  ____  ____  ________________     _  __    _____ __________ _    __________________");
        Console.WriteLine("  / ___// __ \\/ __ \\/ __ \\/ ____/ ____/ __ \\   | |/ /   / ___// ____/ __ \\ |  / /  _/ ____/ ____/");
        Console.WriteLine("  \\__ \\/ /_/ / / / / / / / /_  / __/ / /_/ /   |   /    \\__ \\/ __/ / /_/ / | / // // /   / __/   ");
        Console.WriteLine(" ___/ / ____/ /_/ / /_/ / __/ / /___/ _, _/   /   |    ___/ / /___/ _, _/| |/ // // /___/ /___   ");
        Console.WriteLine("/____/_/    \\____/\\____/_/   /_____/_/ |_|   /_/|_|   /____/_____/_/ |_| |___/___/\\____/_____/   ");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("\n\n Enter Key: ");
        string key = Console.ReadLine();
        ProgramBase.KeyAuthApp.license(key);
      }
      else
      {
        Console.WriteLine("\n\n Invalid Selection");
        Thread.Sleep(1500);
        Environment.Exit(0);
      }
      if (!ProgramBase.KeyAuthApp.response.success)
      {
        Console.WriteLine("\n Status: " + ProgramBase.KeyAuthApp.response.message);
        Thread.Sleep(1500);
        Environment.Exit(0);
      }
      Console.WriteLine("\n Logged In!\n Cheat FiveM");
      Console.Title = "SPOOFER X SERVICE";
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.Title = "SPOOFER X SERVICE";
      Console.WriteLine("   _____ ____  ____  ____  ________________     _  __    _____ __________ _    __________________");
      Console.WriteLine("  / ___// __ \\/ __ \\/ __ \\/ ____/ ____/ __ \\   | |/ /   / ___// ____/ __ \\ |  / /  _/ ____/ ____/");
      Console.WriteLine("  \\__ \\/ /_/ / / / / / / / /_  / __/ / /_/ /   |   /    \\__ \\/ __/ / /_/ / | / // // /   / __/   ");
      Console.WriteLine(" ___/ / ____/ /_/ / /_/ / __/ / /___/ _, _/   /   |    ___/ / /___/ _, _/| |/ // // /___/ /___   ");
      Console.WriteLine("/____/_/    \\____/\\____/_/   /_____/_/ |_|   /_/|_|   /____/_____/_/ |_| |___/___/\\____/_____/   ");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("                                   ┌ SPOOFER X SERVICE ──────────────────────┐");
      Console.WriteLine("                                   │                                         │");
      Console.WriteLine("                                   │ [1] FiveM                               │");
      Console.WriteLine("                                   │                                         │");
      Console.WriteLine("                                   │ [2] Valorant                            │");
      Console.WriteLine("                                   │                                         │");
      Console.WriteLine("                                   │ [3] Warzone                             │");
      Console.WriteLine("                                   │                                         │");
      Console.WriteLine("                                   │ [4] Fortnite                            │");
      Console.WriteLine("                                   │                                         │");
      Console.WriteLine("                                   │ [5] Rust                                │");
      Console.WriteLine("                                   │                                         │");
      Console.WriteLine("                                   │ [6] APEX                                │");
      Console.WriteLine("                                   │                                         │");
      Console.WriteLine("                                   │ Status ON                               │");
      Console.WriteLine("                                   └─────────────────────────────────────────┘");
      string str = Console.ReadLine();
      if (str == "1")
      {
        Console.Title = "SPOOFER X SERVICE";
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Title = "SPOOFER X SERVICE";
        Console.WriteLine("   _____ ____  ____  ____  ________________     _  __    _____ __________ _    __________________");
        Console.WriteLine("  / ___// __ \\/ __ \\/ __ \\/ ____/ ____/ __ \\   | |/ /   / ___// ____/ __ \\ |  / /  _/ ____/ ____/");
        Console.WriteLine("  \\__ \\/ /_/ / / / / / / / /_  / __/ / /_/ /   |   /    \\__ \\/ __/ / /_/ / | / // // /   / __/   ");
        Console.WriteLine(" ___/ / ____/ /_/ / /_/ / __/ / /___/ _, _/   /   |    ___/ / /___/ _, _/| |/ // // /___/ /___   ");
        Console.WriteLine("/____/_/    \\____/\\____/_/   /_____/_/ |_|   /_/|_|   /____/_____/_/ |_| |___/___/\\____/_____/   ");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("                                   ┌ SPOOFER X SERVICE ──────────────────────┐");
        Console.WriteLine("                                   │                                         │");
        Console.WriteLine("                                   │ [1] Unbanned Hwid / Cfx                 │");
        Console.WriteLine("                                   │                                         │");
        Console.WriteLine("                                   │ [2] Unbanned Servers                    │");
        Console.WriteLine("                                   │                                         │");
        Console.WriteLine("                                   │ Status ON                               │");
        Console.WriteLine("                                   └─────────────────────────────────────────┘");
        Console.ReadLine();
      }
      if (str == "1")
      {
        Console.Title = "SPOOFER X SERVICE";
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Title = "SPOOFER X SERVICE";
        Console.WriteLine("   _____ ____  ____  ____  ________________     _  __    _____ __________ _    __________________");
        Console.WriteLine("  / ___// __ \\/ __ \\/ __ \\/ ____/ ____/ __ \\   | |/ /   / ___// ____/ __ \\ |  / /  _/ ____/ ____/");
        Console.WriteLine("  \\__ \\/ /_/ / / / / / / / /_  / __/ / /_/ /   |   /    \\__ \\/ __/ / /_/ / | / // // /   / __/   ");
        Console.WriteLine(" ___/ / ____/ /_/ / /_/ / __/ / /___/ _, _/   /   |    ___/ / /___/ _, _/| |/ // // /___/ /___   ");
        Console.WriteLine("/____/_/    \\____/\\____/_/   /_____/_/ |_|   /_/|_|   /____/_____/_/ |_| |___/___/\\____/_____/   ");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string path = Path.Combine(folderPath, "DigitalEntitlements");
        try
        {
          Process process = new Process();
          process.StartInfo.FileName = "cmd.exe";
          process.StartInfo.RedirectStandardInput = true;
          process.StartInfo.RedirectStandardOutput = true;
          process.StartInfo.CreateNoWindow = true;
          process.StartInfo.UseShellExecute = false;
          process.Start();
          process.StandardInput.WriteLine("TASKKILL /IM Fivem.exe /F");
          process.StandardInput.Flush();
          process.StandardInput.Close();
          process.WaitForExit();
          Directory.Delete(path, true);
          Directory.CreateDirectory(path);
          Process.Start(folderPath + "/FiveM/Fivem.exe");
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show(ex.Message);
        }
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("[*] - ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Spoofing Started...");
        Console.WriteLine("");
        Thread.Sleep(2500);
        Helpers.AJn25LLJKL0aeh1aXoXn();
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("[*] - ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Successfully Spoofed Product ID!");
        Console.WriteLine("");
        Helpers.Fivem();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("[*] - ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Please restart your computer!");
        Console.Read();
      }
      else
      {
        if (str == "2")
        {
          Console.Title = "SPOOFER X SERVICE";
          Console.Clear();
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.Title = "SPOOFER X SERVICE";
          Console.WriteLine("   _____ ____  ____  ____  ________________     _  __    _____ __________ _    __________________");
          Console.WriteLine("  / ___// __ \\/ __ \\/ __ \\/ ____/ ____/ __ \\   | |/ /   / ___// ____/ __ \\ |  / /  _/ ____/ ____/");
          Console.WriteLine("  \\__ \\/ /_/ / / / / / / / /_  / __/ / /_/ /   |   /    \\__ \\/ __/ / /_/ / | / // // /   / __/   ");
          Console.WriteLine(" ___/ / ____/ /_/ / /_/ / __/ / /___/ _, _/   /   |    ___/ / /___/ _, _/| |/ // // /___/ /___   ");
          Console.WriteLine("/____/_/    \\____/\\____/_/   /_____/_/ |_|   /_/|_|   /____/_____/_/ |_| |___/___/\\____/_____/   ");
          Console.WriteLine("");
          Console.WriteLine("");
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.WriteLine("                                   ┌ SPOOFER X SERVICE ──────────────────────┐");
          Console.WriteLine("                                   │                                         │");
          Console.WriteLine("                                   │ [1] Play Valorant                       │");
          Console.WriteLine("                                   │                                         │");
          Console.WriteLine("                                   │ [2] Error Val 5                         │");
          Console.WriteLine("                                   │                                         │");
          Console.WriteLine("                                   │ [3] Error Val 105                       │");
          Console.WriteLine("                                   │                                         │");
          Console.WriteLine("                                   │ [4] Fix Errors                          │");
          Console.WriteLine("                                   │                                         │");
          Console.WriteLine("                                   │ Status ON                               │");
          Console.WriteLine("                                   └─────────────────────────────────────────┘");
          Console.ReadLine();
        }
        if (!(str == "3"))
          return;
        Console.Title = "SPOOFER X SERVICE";
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Title = "SPOOFER X SERVICE";
        Console.WriteLine("   _____ ____  ____  ____  ________________     _  __    _____ __________ _    __________________");
        Console.WriteLine("  / ___// __ \\/ __ \\/ __ \\/ ____/ ____/ __ \\   | |/ /   / ___// ____/ __ \\ |  / /  _/ ____/ ____/");
        Console.WriteLine("  \\__ \\/ /_/ / / / / / / / /_  / __/ / /_/ /   |   /    \\__ \\/ __/ / /_/ / | / // // /   / __/   ");
        Console.WriteLine(" ___/ / ____/ /_/ / /_/ / __/ / /___/ _, _/   /   |    ___/ / /___/ _, _/| |/ // // /___/ /___   ");
        Console.WriteLine("/____/_/    \\____/\\____/_/   /_____/_/ |_|   /_/|_|   /____/_____/_/ |_| |___/___/\\____/_____/   ");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("                                   ┌ SPOOFER X SERVICE ──────────────────────┐");
        Console.WriteLine("                                   │                                         │");
        Console.WriteLine("                                   │ [1] Play Warzibe                        │");
        Console.WriteLine("                                   │                                         │");
        Console.WriteLine("                                   │ [2] Check Update                        │");
        Console.WriteLine("                                   │                                         │");
        Console.WriteLine("                                   │ [3] FiX Erros                           │");
        Console.WriteLine("                                   │                                         │");
        Console.WriteLine("                                   │ [4] SPOOF Warzone                       │");
        Console.WriteLine("                                   │                                         │");
        Console.WriteLine("                                   │ Status ON                               │");
        Console.WriteLine("                                   └─────────────────────────────────────────┘");
        Console.ReadLine();
      }
    }
  }
}
