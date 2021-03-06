﻿using System.Collections.ObjectModel;
using System.Windows.Media;
using Atlassian.plvs.util;
using Atlassian.plvs.util.jira;
using Microsoft.VisualStudio.Language.Intellisense;
using Microsoft.VisualStudio.Text;

namespace Atlassian.plvs.markers.vs2010.menu {
    internal class OpenIssueInBrowserSmartTagAction : ISmartTagAction {
        private readonly string issueKey;
        private readonly string menuText;
        private readonly ITextSnapshot snapshot;

        public OpenIssueInBrowserSmartTagAction(ITrackingSpan span) {
            snapshot = span.TextBuffer.CurrentSnapshot;
            issueKey = span.GetText(snapshot);
            menuText = "View " + issueKey + " in the Browser";
        }

        public string DisplayText {
            get { return menuText; }
        }
        public ImageSource Icon {
            get { return PlvsUtils.bitmapSourceFromPngImage(Resources.view_in_browser); }
        }
        public bool IsEnabled {
            get { return true; }
        }

        public ReadOnlyCollection<SmartTagActionSet> ActionSets {
            get { return null; }
        }

        public void Invoke() {
            JiraIssueUtils.launchBrowser(issueKey);
        }
    }

}
