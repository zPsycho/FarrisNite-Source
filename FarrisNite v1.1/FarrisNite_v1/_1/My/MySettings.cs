namespace FarrisNite_v1._1.My
{
    using Microsoft.VisualBasic.ApplicationServices;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Configuration;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    [CompilerGenerated, EditorBrowsable(EditorBrowsableState.Advanced), GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed class MySettings : ApplicationSettingsBase
    {
        private static MySettings defaultInstance = ((MySettings) SettingsBase.Synchronized(new MySettings()));
        private static bool addedHandler;
        private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

        [DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Advanced)]
        private static void AutoSaveSettings(object sender, EventArgs e)
        {
            if (MyProject.Application.SaveMySettingsOnExit)
            {
                MySettingsProperty.Settings.Save();
            }
        }

        public static MySettings Default
        {
            get
            {
                if (!addedHandler)
                {
                    object addedHandlerLockObject = MySettings.addedHandlerLockObject;
                    ObjectFlowControl.CheckForSyncLockOnValueType(addedHandlerLockObject);
                    lock (addedHandlerLockObject)
                    {
                        if (!addedHandler)
                        {
                            MyProject.Application.Shutdown += new ShutdownEventHandler(MySettings.AutoSaveSettings);
                            addedHandler = true;
                        }
                    }
                }
                return defaultInstance;
            }
        }
    }
}

