// Decompiled with JetBrains decompiler
// Type: IDKShopSpoofer.Helpers
// Assembly: XSERVICE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BFC8236-C752-4F03-B26C-B599E427CA2C
// Assembly location: C:\Users\Zach\Desktop\IronServicesDecompiled.exe

using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Windows.Forms;

namespace IDKShopSpoofer
{
  internal class Helpers
  {
    public static Random U7T7HSvDQ6EeXvnYGPzN難読化KONANPROTECT難読化 = new Random();
    public const string S8vFis0RmWJn9lLLbwd8難読化KONANPROTECT難読化 = "ABCDEF0123456789";
    public static Random z36Xp4gWpeOCuMpmbOoO難読化KONANPROTECT難読化 = new Random();
    public const string sdRtWREcjcnJb1OpC7QO難読化KONANPROTECT難読化 = "abcdef0123456789";

    public static bool ME1IIGsXvZaXIYgVLcB8() => new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);

    public static string ZEcNrE13yAkDy9CoMIlQ(int size)
    {
      char[] chArray = new char[size];
      for (int index = 0; index < size; ++index)
        chArray[index] = "ABCDEF0123456789"[Helpers.U7T7HSvDQ6EeXvnYGPzN難読化KONANPROTECT難読化.Next("ABCDEF0123456789".Length)];
      return new string(chArray);
    }

    public static void YggTBZBMlsdZ6ioI1NRD()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("[*] - ");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write("Current MAC Address: " + Helpers.fZYuf6Z8WsJCrlKiXSM1());
      string str = "00" + Helpers.ZEcNrE13yAkDy9CoMIlQ(10);
      RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E972-E325-11CE-BFC1-08002BE10318}\\0012", true);
      registryKey.SetValue("NetworkAddress", (object) str);
      registryKey.Close();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("[*] - ");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write("MAC address changed to: " + Helpers.fZYuf6Z8WsJCrlKiXSM1());
    }

    public static void FiveM()
    {
      string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
      string path1 = Path.Combine(folderPath, "DigitalEntitlements");
      string path2 = Path.Combine(folderPath, "CitizenFX");
      string path3 = Path.Combine(folderPath, "FiveM\\FiveM.app\\citizen");
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
        Directory.Delete(path1, true);
        Directory.CreateDirectory(path1);
        Directory.Delete(path3, true);
        Directory.CreateDirectory(path3);
        Directory.Delete(path2, true);
        Directory.CreateDirectory(path2);
        Process.Start(folderPath + "/FiveM/Fivem.exe");
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    public static string fZYuf6Z8WsJCrlKiXSM1()
    {
      RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E972-E325-11CE-BFC1-08002BE10318}\\0012", true);
      string str = (string) registryKey.GetValue("NetworkAddress");
      registryKey.Close();
      return str;
    }

    public static void DOhGXU6QluWyrhaySme4()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("[*] - ");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write("Current GUID: " + Helpers.A2qtia8l7FkJBpA1iS6V());
      string str = Guid.NewGuid().ToString();
      RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Cryptography", true).SetValue("TWFjaGluZUd1aWQ=", (object) str);
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("[*] - ");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write("GUID changed to: " + Helpers.A2qtia8l7FkJBpA1iS6V());
    }

    public static string A2qtia8l7FkJBpA1iS6V()
    {
      string name1 = "SOFTWARE\\Microsoft\\Cryptography";
      string name2 = "MachineGuid";
      string str;
      using (RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
      {
        using (RegistryKey registryKey2 = registryKey1.OpenSubKey(name1))
          str = ((registryKey2 != null ? registryKey2.GetValue(name2) : throw new KeyNotFoundException(string.Format("Key Not Found: {0}", (object) name1))) ?? throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", (object) name2))).ToString();
      }
      return str;
    }

    public static void AJn25LLJKL0aeh1aXoXn()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("[*] - ");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write("Current ProductID: " + Helpers.llifJMwCgJQzPS4rfYX7());
      string str = Helpers.ZEcNrE13yAkDy9CoMIlQ(5) + "-" + Helpers.ZEcNrE13yAkDy9CoMIlQ(5) + "-" + Helpers.ZEcNrE13yAkDy9CoMIlQ(5) + "-" + Helpers.ZEcNrE13yAkDy9CoMIlQ(5);
      RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
      registryKey.SetValue("ProductID", (object) str);
      registryKey.Close();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("[*] - ");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write("ProductID changed to: " + Helpers.llifJMwCgJQzPS4rfYX7());
    }

    public static string llifJMwCgJQzPS4rfYX7()
    {
      string name1 = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
      string name2 = "ProductID";
      string str;
      using (RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
      {
        using (RegistryKey registryKey2 = registryKey1.OpenSubKey(name1))
          str = ((registryKey2 != null ? registryKey2.GetValue(name2) : throw new KeyNotFoundException(string.Format("Key Not Found: {0}", (object) name1))) ?? throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", (object) name2))).ToString();
      }
      return str;
    }

    public static string ZYaVfK5UYZDtvj9O0IST(int size)
    {
      char[] chArray = new char[size];
      for (int index = 0; index < size; ++index)
        chArray[index] = "abcdef0123456789"[Helpers.z36Xp4gWpeOCuMpmbOoO難読化KONANPROTECT難読化.Next("abcdef0123456789".Length)];
      return new string(chArray);
    }

    internal static void Fivem() => throw new NotImplementedException();

    public static void OI2Bv1VVM9vz1pYWKWAz()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("[*] - ");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write("Current install time: " + Helpers.hcdQGWE6jQ06FDTQw90N());
      string str = Helpers.ZYaVfK5UYZDtvj9O0IST(15);
      RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
      registryKey.SetValue("InstallTime", (object) str);
      registryKey.Close();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("[*] - ");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write("Install time changed to: " + Helpers.hcdQGWE6jQ06FDTQw90N());
    }

    public static string hcdQGWE6jQ06FDTQw90N()
    {
      string name1 = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
      string name2 = "InstallTime";
      string str;
      using (RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
      {
        using (RegistryKey registryKey2 = registryKey1.OpenSubKey(name1))
          str = ((registryKey2 != null ? registryKey2.GetValue(name2) : throw new KeyNotFoundException(string.Format("Key Not Found: {0}", (object) name1))) ?? throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", (object) name2))).ToString();
      }
      return str;
    }

    public static void oKIo4D1FVMDEITcb5Lv9()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("[*] - ");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write("Current install date: " + Helpers.WpbvJYuX6H0bwmK64omC());
      string str = Helpers.ZYaVfK5UYZDtvj9O0IST(8);
      RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
      registryKey.SetValue("InstallDate", (object) str);
      registryKey.Close();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("[*] - ");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write("New Install Date: " + Helpers.WpbvJYuX6H0bwmK64omC());
    }

    public static string WpbvJYuX6H0bwmK64omC()
    {
      string name1 = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
      string name2 = "InstallDate";
      string str;
      using (RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
      {
        using (RegistryKey registryKey2 = registryKey1.OpenSubKey(name1))
          str = ((registryKey2 != null ? registryKey2.GetValue(name2) : throw new KeyNotFoundException(string.Format("Key Not Found: {0}", (object) name1))) ?? throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", (object) name2))).ToString();
      }
      return str;
    }

    public static void uzK6MVYl1hlkdqrz8MfF()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("[*] - ");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write("Current HwProfileGUID: " + Helpers.JE9Nm1IWJFHgZseXeFjn());
      string str = "{" + Guid.NewGuid().ToString() + "}";
      RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001", true);
      registryKey.SetValue("HwProfileGUID", (object) str);
      registryKey.Close();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("[*] - ");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write("New HwProfileGUID: " + Helpers.JE9Nm1IWJFHgZseXeFjn());
    }

    public static string JE9Nm1IWJFHgZseXeFjn()
    {
      string name1 = "SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001";
      string name2 = "HwProfileGUID";
      string str;
      using (RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
      {
        using (RegistryKey registryKey2 = registryKey1.OpenSubKey(name1))
          str = ((registryKey2 != null ? registryKey2.GetValue(name2) : throw new KeyNotFoundException(string.Format("Key Not Found: {0}", (object) name1))) ?? throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", (object) name2))).ToString();
      }
      return str;
    }

    public static bool AIvoWgxFuKySIgtqZwjk(string str, byte[] data, int offset)
    {
      for (int index = 0; index < str.Length; ++index)
      {
        if ((int) data[index + offset] != (int) (byte) str[index])
          return false;
      }
      return true;
    }

    public static void NCcWaEUlM3V22sFAIlrF()
    {
      string s = Helpers.ZEcNrE13yAkDy9CoMIlQ(8);
      uint num = uint.Parse(s, NumberStyles.HexNumber);
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("[*] - ");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write("SEREIHNlcmlhbCBjaGFuZ2luZyB0bzog" + s + "IC0g" + num.ToString());
    }

    public static void yGp7jzoyhVy9x68NR()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("[*] - ");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write("Current PC name: " + Helpers.VMs1p5pQatheFeQKaeQl());
      RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName", true);
      registryKey.SetValue("Q29tcHV0ZXJOYW1l", (object) ("REVTS1RPUC0=" + Helpers.ZEcNrE13yAkDy9CoMIlQ(15)));
      registryKey.Close();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("[*] - ");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write("PC name spoofed to: " + Helpers.VMs1p5pQatheFeQKaeQl());
    }

    public static string VMs1p5pQatheFeQKaeQl()
    {
      string name1 = "SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName";
      string name2 = "ComputerName";
      string str;
      using (RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
      {
        using (RegistryKey registryKey2 = registryKey1.OpenSubKey(name1))
          str = ((registryKey2 != null ? registryKey2.GetValue(name2) : throw new KeyNotFoundException(string.Format("Key Not Found: {0}", (object) name1))) ?? throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", (object) name2))).ToString();
      }
      return str;
    }

    private class Disk : IDisposable
    {
      private SafeFileHandle handle;
      private const uint INVALID_SET_FILE_POINTER = 4294967295;

      public Disk(char volume)
      {
        this.handle = new SafeFileHandle(Helpers.Disk.CreateFile(string.Format("\\\\.\\{0}:", (object) volume), FileAccess.ReadWrite, FileShare.ReadWrite, IntPtr.Zero, FileMode.Open, 0, IntPtr.Zero), true);
        if (!this.handle.IsInvalid)
          return;
        Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
      }

      public void ReadSector(uint sector, byte[] buffer)
      {
        if (buffer == null)
          throw new ArgumentNullException(nameof (buffer));
        if (Helpers.Disk.SetFilePointer(this.handle, sector, IntPtr.Zero, Helpers.Disk.EMoveMethod.Begin) == uint.MaxValue)
          Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
        uint lpNumberOfBytesRead;
        if (!Helpers.Disk.ReadFile(this.handle, buffer, buffer.Length, out lpNumberOfBytesRead, IntPtr.Zero))
          Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
        if ((long) lpNumberOfBytesRead != (long) buffer.Length)
          throw new IOException();
      }

      public void WriteSector(uint sector, byte[] buffer)
      {
        if (buffer == null)
          throw new ArgumentNullException(nameof (buffer));
        if (Helpers.Disk.SetFilePointer(this.handle, sector, IntPtr.Zero, Helpers.Disk.EMoveMethod.Begin) == uint.MaxValue)
          Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
        uint lpNumberOfBytesWritten;
        if (!Helpers.Disk.WriteFile(this.handle, buffer, buffer.Length, out lpNumberOfBytesWritten, IntPtr.Zero))
          Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
        if ((long) lpNumberOfBytesWritten != (long) buffer.Length)
          throw new IOException();
      }

      public void Dispose()
      {
        this.Dispose(true);
        GC.SuppressFinalize((object) this);
      }

      protected virtual void Dispose(bool disposing)
      {
        if (!disposing || this.handle == null)
          return;
        this.handle.Dispose();
      }

      [DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
      public static extern IntPtr CreateFile(
        string fileName,
        [MarshalAs(UnmanagedType.U4)] FileAccess fileAccess,
        [MarshalAs(UnmanagedType.U4)] FileShare fileShare,
        IntPtr securityAttributes,
        [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition,
        int flags,
        IntPtr template);

      [DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
      private static extern uint SetFilePointer(
        [In] SafeFileHandle hFile,
        [In] uint lDistanceToMove,
        [In] IntPtr lpDistanceToMoveHigh,
        [In] Helpers.Disk.EMoveMethod dwMoveMethod);

      [DllImport("kernel32.dll", SetLastError = true)]
      private static extern bool ReadFile(
        SafeFileHandle hFile,
        [Out] byte[] lpBuffer,
        int nNumberOfBytesToRead,
        out uint lpNumberOfBytesRead,
        IntPtr lpOverlapped);

      [DllImport("kernel32.dll")]
      private static extern bool WriteFile(
        SafeFileHandle hFile,
        [In] byte[] lpBuffer,
        int nNumberOfBytesToWrite,
        out uint lpNumberOfBytesWritten,
        [In] IntPtr lpOverlapped);

      private enum EMoveMethod : uint
      {
        Begin,
        Current,
        End,
      }
    }
  }
}
