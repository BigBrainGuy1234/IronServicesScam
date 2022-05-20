// Decompiled with JetBrains decompiler
// Type: XSERVICE.Properties.Settings
// Assembly: XSERVICE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BFC8236-C752-4F03-B26C-B599E427CA2C
// Assembly location: C:\Users\Zach\Desktop\IronServicesDecompiled.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace XSERVICE.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.1.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings defaultInstance = Settings.defaultInstance;
        return defaultInstance;
      }
    }
  }
}
