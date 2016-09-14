﻿using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace Atlassian.plvs {
    [Guid("06c81945-10ef-4d72-8daf-32d29f7e9573")]
    public class AtlassianToolWindow : ToolWindowPane {
        private readonly windows.AtlassianPanel control;

        public AtlassianToolWindow() :
            base(null) {
            Caption = Resources.ToolWindowTitle;
            BitmapResourceID = 301;
            BitmapIndex = 0;

            control = new windows.AtlassianPanel(); 
        }

        public override IWin32Window Window {
            get { return control; }
        }
    }
}