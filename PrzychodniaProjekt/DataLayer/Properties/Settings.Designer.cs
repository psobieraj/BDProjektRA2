﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=SRYSIEK\\SQLEXPRESSSOBI;Initial Catalog=Przychodnia;Integrated Securit" +
            "y=True")]
        public string PrzychodniaConnectionString {
            get {
                return ((string)(this["PrzychodniaConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LUKASZ-KOMPUTER\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Sec" +
            "urity=True;TrustServerCertificate=True")]
        public string PrzychodniaConnectionString1 {
            get {
                return ((string)(this["PrzychodniaConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-T34RC4B\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Sec" +
            "urity=True")]
        public string PrzychodniaConnectionString2 {
            get {
                return ((string)(this["PrzychodniaConnectionString2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=COMP81\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=Tru" +
            "e")]
        public string PrzychodniaConnectionString3 {
            get {
                return ((string)(this["PrzychodniaConnectionString3"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=SRYSIEK\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=Tr" +
            "ue")]
        public string PrzychodniaConnectionString4 {
            get {
                return ((string)(this["PrzychodniaConnectionString4"]));
            }
        }
    }
}
