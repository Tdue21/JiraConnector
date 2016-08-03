﻿using System;
using System.Collections.Generic;
using Atlassian.plvs.api.jira;
using Atlassian.plvs.util.jira;

namespace Atlassian.plvs.models.jira.fields {
    public class DescriptionFiller : FieldFiller {
        public List<string> getFieldValues(string field, JiraIssue issue, object rawIssueObject) {
            string value = JiraIssueUtils.getRawIssueObjectPropertyValue<string>(rawIssueObject, "description");
            return value != null ? new List<string> { value } : null; 
        }

        public string getSettablePropertyName(string id, JiraIssue issue, object rawIssueObject) {
            return null;
        }
    }
}