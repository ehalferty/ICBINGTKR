﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ICBINGTKR.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class q3map2 : global::System.Configuration.ApplicationSettingsBase {
        
        private static q3map2 defaultInstance = ((q3map2)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new q3map2())));
        
        public static q3map2 Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:/Program Files/GtkRadiant-1.4/")]
        public string q3map2_path {
            get {
                return ((string)(this["q3map2_path"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:/Program Files (x86)/Steam/steamapps/common/Jedi Academy/GameData/")]
        public string fs_basepath {
            get {
                return ((string)(this["fs_basepath"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>-v -game ja -fs_basepath &lt;BASE&gt; -meta &lt;MAP&gt;</string>
  <string>-game ja -fs_basepath &lt;BASE&gt; -vis -saveprt &lt;MAP&gt;</string>
  <string>-v -game ja -fs_basepath &lt;BASE&gt; -light -fast -filter &lt;MAP&gt;</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection bsp_compile_commands {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["bsp_compile_commands"]));
            }
        }
    }
}
