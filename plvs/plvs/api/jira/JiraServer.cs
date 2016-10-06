using System;
using System.Text;
using Atlassian.plvs.api.jira.facade;

namespace Atlassian.plvs.api.jira {
    public class JiraServer : Server {

        public int BuildNumber { get; set; }
        public string Version { get; set; }
        public string ServerTitle { get; set; }
        public int ProjectAffinityID { get; set; }
        public JiraProject ProjectAffinity { get; set; }

        public bool OldSkoolAuth { get; set; }

        public JiraServer(string name, string url, string userName, string password, bool noProxy, bool oldSkoolAuth) 
            : base(name, url, userName, password, noProxy) {
            OldSkoolAuth = oldSkoolAuth;
        }

        public JiraServer(Guid guid, string name, string url, string userName, string password, bool noProxy, bool oldSkoolAuth, bool enabled) 
            : base(guid, name, url, userName, password, noProxy, enabled) {
            OldSkoolAuth = oldSkoolAuth;
        }

        public JiraServer(Guid guid, string name, string url, string userName, string password, bool noProxy, bool oldSkoolAuth, bool enabled, string projectAffinityID)
    : base(guid, name, url, userName, password, noProxy, enabled)
        {
            OldSkoolAuth = oldSkoolAuth;
        }

        public JiraServer(JiraServer other) : base(other) {
            OldSkoolAuth = other != null && other.OldSkoolAuth;
        }

        public override string serverDetailsHtmlTable() {
            var sb = new StringBuilder();

            sb.Append(serverdetailsHtmlTableStart());
            sb.Append(serverBaseDetailsHtml());

            sb.Append("<tr valign=top><td width=\"200\">Authenticate with URL Parameters</td><td>")
                .Append(OldSkoolAuth ? "Yes" : "No").Append("</td></tr>\r\n");

            sb.Append(serverDetailsHtmlTableEnd());
            return sb.ToString();

        }

        public void InsertProjectAffinity()
        {
            //AbstractJiraServerFacade facade=new 
            //if (this.ProjectAffinityID != 0)
            //{
            //    var projectList = facade.getProjects(this);

            //}
        }

        public override Guid Type { get { return JiraServerTypeGuid; } }
    }
}