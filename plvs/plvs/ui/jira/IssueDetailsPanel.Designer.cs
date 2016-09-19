using System.Text.RegularExpressions;
using Atlassian.plvs;

namespace Atlassian.plvs.ui.jira {
    partial class IssueDetailsPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueDetailsPanel));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.jiraStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.issueTabs = new System.Windows.Forms.TabControl();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.updatedText = new System.Windows.Forms.TextBox();
            this.createdText = new System.Windows.Forms.TextBox();
            this.resolutionText = new System.Windows.Forms.TextBox();
            this.reporterText = new System.Windows.Forms.TextBox();
            this.assigneeText = new System.Windows.Forms.TextBox();
            this.componentText = new System.Windows.Forms.TextBox();
            this.priorityText = new System.Windows.Forms.TextBox();
            this.statusText = new System.Windows.Forms.TextBox();
            this.typeText = new System.Windows.Forms.TextBox();
            this.summaryText = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.assigneeEditBtn = new System.Windows.Forms.Button();
            this.priorityEditBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.summaryEditBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabDescriptionAndComments = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.issueComments = new System.Windows.Forms.WebBrowser();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.buttonAddComment = new System.Windows.Forms.ToolStripButton();
            this.buttonExpandAll = new System.Windows.Forms.ToolStripButton();
            this.buttonCollapseAll = new System.Windows.Forms.ToolStripButton();
            this.tabLinks = new System.Windows.Forms.TabPage();
            this.webLinkedIssues = new System.Windows.Forms.WebBrowser();
            this.tabSubtasks = new System.Windows.Forms.TabPage();
            this.webSubtasks = new System.Windows.Forms.WebBrowser();
            this.tabAttachments = new System.Windows.Forms.TabPage();
            this.splitContainerAttachments = new System.Windows.Forms.SplitContainer();
            this.toolStripContainer3 = new System.Windows.Forms.ToolStripContainer();
            this.listViewAttachments = new plvs.ui.AutosizeListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripAttachmentsMenu = new System.Windows.Forms.ToolStrip();
            this.buttonSaveAttachmentAs = new System.Windows.Forms.ToolStripButton();
            this.buttonUploadNew = new System.Windows.Forms.ToolStripButton();
            this.buttonPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonViewInBrowser = new System.Windows.Forms.ToolStripButton();
            this.buttonRefresh = new System.Windows.Forms.ToolStripButton();
            this.buttonStartStopProgress = new System.Windows.Forms.ToolStripButton();
            this.buttonLogWork = new System.Windows.Forms.ToolStripButton();
            this.dropDownIssueActions = new System.Windows.Forms.ToolStripDropDownButton();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipAttachments = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.issueTabs.SuspendLayout();
            this.tabSummary.SuspendLayout();
            this.tabDescriptionAndComments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabLinks.SuspendLayout();
            this.tabSubtasks.SuspendLayout();
            this.tabAttachments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAttachments)).BeginInit();
            this.splitContainerAttachments.Panel1.SuspendLayout();
            this.splitContainerAttachments.SuspendLayout();
            this.toolStripContainer3.ContentPanel.SuspendLayout();
            this.toolStripContainer3.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer3.SuspendLayout();
            this.toolStripAttachmentsMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.issueTabs);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(785, 428);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(785, 475);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jiraStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(785, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 0;
            // 
            // jiraStatus
            // 
            this.jiraStatus.Name = "jiraStatus";
            this.jiraStatus.Size = new System.Drawing.Size(37, 17);
            this.jiraStatus.Text = "status";
            // 
            // issueTabs
            // 
            this.issueTabs.Controls.Add(this.tabSummary);
            this.issueTabs.Controls.Add(this.tabDescriptionAndComments);
            this.issueTabs.Controls.Add(this.tabLinks);
            this.issueTabs.Controls.Add(this.tabSubtasks);
            this.issueTabs.Controls.Add(this.tabAttachments);
            this.issueTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issueTabs.Location = new System.Drawing.Point(0, 0);
            this.issueTabs.Name = "issueTabs";
            this.issueTabs.SelectedIndex = 0;
            this.issueTabs.Size = new System.Drawing.Size(785, 428);
            this.issueTabs.TabIndex = 0;
            // 
            // tabSummary
            // 
            this.tabSummary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabSummary.Controls.Add(this.updatedText);
            this.tabSummary.Controls.Add(this.createdText);
            this.tabSummary.Controls.Add(this.resolutionText);
            this.tabSummary.Controls.Add(this.reporterText);
            this.tabSummary.Controls.Add(this.assigneeText);
            this.tabSummary.Controls.Add(this.componentText);
            this.tabSummary.Controls.Add(this.priorityText);
            this.tabSummary.Controls.Add(this.statusText);
            this.tabSummary.Controls.Add(this.typeText);
            this.tabSummary.Controls.Add(this.summaryText);
            this.tabSummary.Controls.Add(this.button4);
            this.tabSummary.Controls.Add(this.assigneeEditBtn);
            this.tabSummary.Controls.Add(this.priorityEditBtn);
            this.tabSummary.Controls.Add(this.label11);
            this.tabSummary.Controls.Add(this.summaryEditBtn);
            this.tabSummary.Controls.Add(this.label10);
            this.tabSummary.Controls.Add(this.label9);
            this.tabSummary.Controls.Add(this.label8);
            this.tabSummary.Controls.Add(this.label7);
            this.tabSummary.Controls.Add(this.label6);
            this.tabSummary.Controls.Add(this.label5);
            this.tabSummary.Controls.Add(this.label4);
            this.tabSummary.Controls.Add(this.label3);
            this.tabSummary.Controls.Add(this.label2);
            this.tabSummary.Location = new System.Drawing.Point(4, 22);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSummary.Size = new System.Drawing.Size(777, 402);
            this.tabSummary.TabIndex = 0;
            this.tabSummary.Text = "Summary";
            // 
            // updatedText
            // 
            this.updatedText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updatedText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updatedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedText.Location = new System.Drawing.Point(169, 296);
            this.updatedText.Name = "updatedText";
            this.updatedText.Size = new System.Drawing.Size(163, 16);
            this.updatedText.TabIndex = 23;
            // 
            // createdText
            // 
            this.createdText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createdText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdText.Location = new System.Drawing.Point(169, 268);
            this.createdText.Name = "createdText";
            this.createdText.Size = new System.Drawing.Size(163, 16);
            this.createdText.TabIndex = 22;
            // 
            // resolutionText
            // 
            this.resolutionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resolutionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resolutionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolutionText.Location = new System.Drawing.Point(169, 240);
            this.resolutionText.Name = "resolutionText";
            this.resolutionText.Size = new System.Drawing.Size(507, 16);
            this.resolutionText.TabIndex = 21;
            // 
            // reporterText
            // 
            this.reporterText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reporterText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reporterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporterText.Location = new System.Drawing.Point(169, 212);
            this.reporterText.Name = "reporterText";
            this.reporterText.Size = new System.Drawing.Size(507, 16);
            this.reporterText.TabIndex = 20;
            // 
            // assigneeText
            // 
            this.assigneeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assigneeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.assigneeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assigneeText.Location = new System.Drawing.Point(169, 184);
            this.assigneeText.Name = "assigneeText";
            this.assigneeText.Size = new System.Drawing.Size(507, 16);
            this.assigneeText.TabIndex = 19;
            // 
            // componentText
            // 
            this.componentText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.componentText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.componentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentText.Location = new System.Drawing.Point(169, 156);
            this.componentText.Name = "componentText";
            this.componentText.Size = new System.Drawing.Size(507, 16);
            this.componentText.TabIndex = 18;
            // 
            // priorityText
            // 
            this.priorityText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priorityText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priorityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityText.Location = new System.Drawing.Point(169, 128);
            this.priorityText.Name = "priorityText";
            this.priorityText.Size = new System.Drawing.Size(507, 16);
            this.priorityText.TabIndex = 17;
            // 
            // statusText
            // 
            this.statusText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusText.Location = new System.Drawing.Point(169, 100);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(507, 16);
            this.statusText.TabIndex = 16;
            // 
            // typeText
            // 
            this.typeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeText.Location = new System.Drawing.Point(169, 75);
            this.typeText.Name = "typeText";
            this.typeText.Size = new System.Drawing.Size(507, 16);
            this.typeText.TabIndex = 15;
            // 
            // summaryText
            // 
            this.summaryText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.summaryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryText.Location = new System.Drawing.Point(169, 21);
            this.summaryText.Multiline = true;
            this.summaryText.Name = "summaryText";
            this.summaryText.Size = new System.Drawing.Size(507, 42);
            this.summaryText.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Image = global::Atlassian.plvs.Resources.edit;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.Location = new System.Drawing.Point(137, 149);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 29);
            this.button4.TabIndex = 13;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // assigneeEditBtn
            // 
            this.assigneeEditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.assigneeEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assigneeEditBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.assigneeEditBtn.Image = global::Atlassian.plvs.Resources.edit;
            this.assigneeEditBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.assigneeEditBtn.Location = new System.Drawing.Point(137, 177);
            this.assigneeEditBtn.Margin = new System.Windows.Forms.Padding(0);
            this.assigneeEditBtn.Name = "assigneeEditBtn";
            this.assigneeEditBtn.Size = new System.Drawing.Size(28, 29);
            this.assigneeEditBtn.TabIndex = 12;
            this.assigneeEditBtn.UseVisualStyleBackColor = true;
            this.assigneeEditBtn.Click += new System.EventHandler(this.assigneeEditBtn_Click);
            // 
            // priorityEditBtn
            // 
            this.priorityEditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.priorityEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priorityEditBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.priorityEditBtn.Image = global::Atlassian.plvs.Resources.edit;
            this.priorityEditBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.priorityEditBtn.Location = new System.Drawing.Point(137, 121);
            this.priorityEditBtn.Margin = new System.Windows.Forms.Padding(0);
            this.priorityEditBtn.Name = "priorityEditBtn";
            this.priorityEditBtn.Size = new System.Drawing.Size(28, 29);
            this.priorityEditBtn.TabIndex = 11;
            this.priorityEditBtn.UseVisualStyleBackColor = true;
            this.priorityEditBtn.Click += new System.EventHandler(this.priorityEditBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Component";
            // 
            // summaryEditBtn
            // 
            this.summaryEditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.summaryEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.summaryEditBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.summaryEditBtn.Image = global::Atlassian.plvs.Resources.edit;
            this.summaryEditBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.summaryEditBtn.Location = new System.Drawing.Point(137, 15);
            this.summaryEditBtn.Margin = new System.Windows.Forms.Padding(0);
            this.summaryEditBtn.Name = "summaryEditBtn";
            this.summaryEditBtn.Size = new System.Drawing.Size(28, 29);
            this.summaryEditBtn.TabIndex = 9;
            this.summaryEditBtn.UseVisualStyleBackColor = true;
            this.summaryEditBtn.Click += new System.EventHandler(this.summaryEditBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Resolution";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Updated";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Created";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Reporter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Assignee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Priority";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Summary";
            // 
            // tabDescriptionAndComments
            // 
            this.tabDescriptionAndComments.Controls.Add(this.splitContainer);
            this.tabDescriptionAndComments.Location = new System.Drawing.Point(4, 22);
            this.tabDescriptionAndComments.Name = "tabDescriptionAndComments";
            this.tabDescriptionAndComments.Padding = new System.Windows.Forms.Padding(3);
            this.tabDescriptionAndComments.Size = new System.Drawing.Size(777, 402);
            this.tabDescriptionAndComments.TabIndex = 1;
            this.tabDescriptionAndComments.Text = "Description and Comments";
            this.tabDescriptionAndComments.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.toolStripContainer2);
            this.splitContainer.Size = new System.Drawing.Size(771, 396);
            this.splitContainer.SplitterDistance = 273;
            this.splitContainer.TabIndex = 0;
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Controls.Add(this.issueComments);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(494, 371);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(494, 396);
            this.toolStripContainer2.TabIndex = 1;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.toolStrip2);
            // 
            // issueComments
            // 
            this.issueComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issueComments.IsWebBrowserContextMenuEnabled = false;
            this.issueComments.Location = new System.Drawing.Point(0, 0);
            this.issueComments.MinimumSize = new System.Drawing.Size(20, 20);
            this.issueComments.Name = "issueComments";
            this.issueComments.Size = new System.Drawing.Size(494, 371);
            this.issueComments.TabIndex = 0;
            this.issueComments.WebBrowserShortcutsEnabled = false;
            this.issueComments.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.issueComments_DocumentCompleted);
            this.issueComments.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.issueComments_Navigating);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.buttonAddComment,
            this.buttonExpandAll,
            this.buttonCollapseAll});
            this.toolStrip2.Location = new System.Drawing.Point(3, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(129, 25);
            this.toolStrip2.TabIndex = 0;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel1.Text = "Comments";
            // 
            // buttonAddComment
            // 
            this.buttonAddComment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAddComment.Image = global::Atlassian.plvs.Resources.new_comment;
            this.buttonAddComment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(23, 22);
            this.buttonAddComment.Text = "Add Comment";
            this.buttonAddComment.Click += new System.EventHandler(this.buttonAddComment_Click);
            // 
            // buttonExpandAll
            // 
            this.buttonExpandAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonExpandAll.Image = global::Atlassian.plvs.Resources.expand_all;
            this.buttonExpandAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonExpandAll.Name = "buttonExpandAll";
            this.buttonExpandAll.Size = new System.Drawing.Size(23, 22);
            this.buttonExpandAll.Text = "Expand All";
            this.buttonExpandAll.Click += new System.EventHandler(this.buttonExpandAll_Click);
            // 
            // buttonCollapseAll
            // 
            this.buttonCollapseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonCollapseAll.Image = global::Atlassian.plvs.Resources.collapse_all;
            this.buttonCollapseAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCollapseAll.Name = "buttonCollapseAll";
            this.buttonCollapseAll.Size = new System.Drawing.Size(23, 22);
            this.buttonCollapseAll.Text = "Collapse All";
            this.buttonCollapseAll.Click += new System.EventHandler(this.buttonCollapseAll_Click);
            // 
            // tabLinks
            // 
            this.tabLinks.Controls.Add(this.webLinkedIssues);
            this.tabLinks.Location = new System.Drawing.Point(4, 22);
            this.tabLinks.Name = "tabLinks";
            this.tabLinks.Size = new System.Drawing.Size(777, 402);
            this.tabLinks.TabIndex = 4;
            this.tabLinks.Text = "Linked Issues";
            this.tabLinks.UseVisualStyleBackColor = true;
            // 
            // webLinkedIssues
            // 
            this.webLinkedIssues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webLinkedIssues.IsWebBrowserContextMenuEnabled = false;
            this.webLinkedIssues.Location = new System.Drawing.Point(0, 0);
            this.webLinkedIssues.MinimumSize = new System.Drawing.Size(20, 20);
            this.webLinkedIssues.Name = "webLinkedIssues";
            this.webLinkedIssues.ScriptErrorsSuppressed = true;
            this.webLinkedIssues.Size = new System.Drawing.Size(777, 402);
            this.webLinkedIssues.TabIndex = 0;
            this.webLinkedIssues.WebBrowserShortcutsEnabled = false;
            this.webLinkedIssues.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webLinkedIssues_DocumentCompleted);
            this.webLinkedIssues.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webLinkedIssues_Navigating);
            // 
            // tabSubtasks
            // 
            this.tabSubtasks.Controls.Add(this.webSubtasks);
            this.tabSubtasks.Location = new System.Drawing.Point(4, 22);
            this.tabSubtasks.Name = "tabSubtasks";
            this.tabSubtasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubtasks.Size = new System.Drawing.Size(777, 402);
            this.tabSubtasks.TabIndex = 2;
            this.tabSubtasks.Text = "Subtasks";
            this.tabSubtasks.UseVisualStyleBackColor = true;
            // 
            // webSubtasks
            // 
            this.webSubtasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webSubtasks.IsWebBrowserContextMenuEnabled = false;
            this.webSubtasks.Location = new System.Drawing.Point(3, 3);
            this.webSubtasks.MinimumSize = new System.Drawing.Size(20, 20);
            this.webSubtasks.Name = "webSubtasks";
            this.webSubtasks.Size = new System.Drawing.Size(771, 396);
            this.webSubtasks.TabIndex = 0;
            this.webSubtasks.WebBrowserShortcutsEnabled = false;
            this.webSubtasks.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webSubtasks_DocumentCompleted);
            this.webSubtasks.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webSubtasks_Navigating);
            // 
            // tabAttachments
            // 
            this.tabAttachments.Controls.Add(this.splitContainerAttachments);
            this.tabAttachments.Location = new System.Drawing.Point(4, 22);
            this.tabAttachments.Name = "tabAttachments";
            this.tabAttachments.Size = new System.Drawing.Size(777, 402);
            this.tabAttachments.TabIndex = 3;
            this.tabAttachments.Text = "Attachments";
            this.tabAttachments.UseVisualStyleBackColor = true;
            // 
            // splitContainerAttachments
            // 
            this.splitContainerAttachments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAttachments.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAttachments.Name = "splitContainerAttachments";
            // 
            // splitContainerAttachments.Panel1
            // 
            this.splitContainerAttachments.Panel1.Controls.Add(this.toolStripContainer3);
            this.splitContainerAttachments.Size = new System.Drawing.Size(777, 402);
            this.splitContainerAttachments.SplitterDistance = 340;
            this.splitContainerAttachments.TabIndex = 0;
            // 
            // toolStripContainer3
            // 
            // 
            // toolStripContainer3.ContentPanel
            // 
            this.toolStripContainer3.ContentPanel.Controls.Add(this.listViewAttachments);
            this.toolStripContainer3.ContentPanel.Size = new System.Drawing.Size(340, 377);
            this.toolStripContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer3.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer3.Name = "toolStripContainer3";
            this.toolStripContainer3.Size = new System.Drawing.Size(340, 402);
            this.toolStripContainer3.TabIndex = 3;
            this.toolStripContainer3.Text = "toolStripContainer3";
            // 
            // toolStripContainer3.TopToolStripPanel
            // 
            this.toolStripContainer3.TopToolStripPanel.Controls.Add(this.toolStripAttachmentsMenu);
            // 
            // listViewAttachments
            // 
            this.listViewAttachments.AllowDrop = true;
            this.listViewAttachments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnAuthor,
            this.columnSize,
            this.columnDate});
            this.listViewAttachments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAttachments.FullRowSelect = true;
            this.listViewAttachments.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAttachments.HideSelection = false;
            this.listViewAttachments.Location = new System.Drawing.Point(0, 0);
            this.listViewAttachments.MultiSelect = false;
            this.listViewAttachments.Name = "listViewAttachments";
            this.listViewAttachments.Size = new System.Drawing.Size(340, 377);
            this.listViewAttachments.TabIndex = 0;
            this.listViewAttachments.UseCompatibleStateImageBehavior = false;
            this.listViewAttachments.View = System.Windows.Forms.View.Details;
            this.listViewAttachments.SelectedIndexChanged += new System.EventHandler(this.listViewAttachmentsSelectedIndexChanged);
            this.listViewAttachments.SizeChanged += new System.EventHandler(this.listViewAttachmentsSizeChanged);
            this.listViewAttachments.Click += new System.EventHandler(this.listViewAttachmentsClick);
            this.listViewAttachments.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewAttachments_DragDrop);
            this.listViewAttachments.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewAttachments_DragEnter);
            this.listViewAttachments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listViewAttachmentsKeyPress);
            this.listViewAttachments.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewAttachmentsMouseDoubleClick);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 94;
            // 
            // columnAuthor
            // 
            this.columnAuthor.Text = "Author";
            this.columnAuthor.Width = 76;
            // 
            // columnSize
            // 
            this.columnSize.Text = "Size [bytes]";
            this.columnSize.Width = 100;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            this.columnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnDate.Width = 66;
            // 
            // toolStripAttachmentsMenu
            // 
            this.toolStripAttachmentsMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripAttachmentsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripAttachmentsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonSaveAttachmentAs,
            this.buttonUploadNew,
            this.buttonPaste});
            this.toolStripAttachmentsMenu.Location = new System.Drawing.Point(3, 0);
            this.toolStripAttachmentsMenu.Name = "toolStripAttachmentsMenu";
            this.toolStripAttachmentsMenu.Size = new System.Drawing.Size(183, 25);
            this.toolStripAttachmentsMenu.TabIndex = 0;
            // 
            // buttonSaveAttachmentAs
            // 
            this.buttonSaveAttachmentAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonSaveAttachmentAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSaveAttachmentAs.Name = "buttonSaveAttachmentAs";
            this.buttonSaveAttachmentAs.Size = new System.Drawing.Size(62, 22);
            this.buttonSaveAttachmentAs.Text = "Save As...";
            this.buttonSaveAttachmentAs.Click += new System.EventHandler(this.saveAttachment);
            // 
            // buttonUploadNew
            // 
            this.buttonUploadNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonUploadNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonUploadNew.Name = "buttonUploadNew";
            this.buttonUploadNew.Size = new System.Drawing.Size(80, 22);
            this.buttonUploadNew.Text = "Upload New...";
            this.buttonUploadNew.Click += new System.EventHandler(this.uploadAttachment);
            // 
            // buttonPaste
            // 
            this.buttonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonPaste.Image = ((System.Drawing.Image)(resources.GetObject("buttonPaste.Image")));
            this.buttonPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(38, 22);
            this.buttonPaste.Text = "Paste";
            this.buttonPaste.Click += new System.EventHandler(this.buttonPasteClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonViewInBrowser,
            this.buttonRefresh,
            this.buttonStartStopProgress,
            this.buttonLogWork,
            this.dropDownIssueActions});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(124, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // buttonViewInBrowser
            // 
            this.buttonViewInBrowser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonViewInBrowser.Image = global::Atlassian.plvs.Resources.view_in_browser;
            this.buttonViewInBrowser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonViewInBrowser.Name = "buttonViewInBrowser";
            this.buttonViewInBrowser.Size = new System.Drawing.Size(23, 22);
            this.buttonViewInBrowser.Text = "View In Browser";
            this.buttonViewInBrowser.Click += new System.EventHandler(this.buttonViewInBrowser_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonRefresh.Image = global::Atlassian.plvs.Resources.refresh;
            this.buttonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(23, 22);
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonStartStopProgress
            // 
            this.buttonStartStopProgress.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonStartStopProgress.Image = ((System.Drawing.Image)(resources.GetObject("buttonStartStopProgress.Image")));
            this.buttonStartStopProgress.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonStartStopProgress.Name = "buttonStartStopProgress";
            this.buttonStartStopProgress.Size = new System.Drawing.Size(23, 22);
            this.buttonStartStopProgress.Text = "Start Progress";
            this.buttonStartStopProgress.Click += new System.EventHandler(this.buttonStartStopProgressClick);
            // 
            // buttonLogWork
            // 
            this.buttonLogWork.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonLogWork.Image = global::Atlassian.plvs.Resources.ico_logworkonissue;
            this.buttonLogWork.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonLogWork.Name = "buttonLogWork";
            this.buttonLogWork.Size = new System.Drawing.Size(23, 22);
            this.buttonLogWork.Text = "Log Work";
            this.buttonLogWork.Click += new System.EventHandler(this.buttonLogWorkClick);
            // 
            // dropDownIssueActions
            // 
            this.dropDownIssueActions.AutoToolTip = false;
            this.dropDownIssueActions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dropDownIssueActions.Image = global::Atlassian.plvs.Resources.pin_other;
            this.dropDownIssueActions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropDownIssueActions.Name = "dropDownIssueActions";
            this.dropDownIssueActions.Size = new System.Drawing.Size(29, 22);
            this.dropDownIssueActions.Text = "Issue Actions";
            this.dropDownIssueActions.ToolTipText = "Issue Actions";
            this.dropDownIssueActions.DropDownOpened += new System.EventHandler(this.dropDownIssueActions_DropDownOpened);
            this.dropDownIssueActions.MouseEnter += new System.EventHandler(this.dropDownIssueActionsMouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // IssueDetailsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "IssueDetailsPanel";
            this.Size = new System.Drawing.Size(785, 475);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.issueTabs.ResumeLayout(false);
            this.tabSummary.ResumeLayout(false);
            this.tabSummary.PerformLayout();
            this.tabDescriptionAndComments.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabLinks.ResumeLayout(false);
            this.tabSubtasks.ResumeLayout(false);
            this.tabAttachments.ResumeLayout(false);
            this.splitContainerAttachments.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAttachments)).EndInit();
            this.splitContainerAttachments.ResumeLayout(false);
            this.toolStripContainer3.ContentPanel.ResumeLayout(false);
            this.toolStripContainer3.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer3.TopToolStripPanel.PerformLayout();
            this.toolStripContainer3.ResumeLayout(false);
            this.toolStripContainer3.PerformLayout();
            this.toolStripAttachmentsMenu.ResumeLayout(false);
            this.toolStripAttachmentsMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl issueTabs;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.TabPage tabDescriptionAndComments;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.WebBrowser issueComments;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton buttonAddComment;
        private System.Windows.Forms.ToolStripButton buttonExpandAll;
        private System.Windows.Forms.ToolStripButton buttonCollapseAll;
        private System.Windows.Forms.ToolStripButton buttonRefresh;
        private System.Windows.Forms.ToolStripStatusLabel jiraStatus;
        private System.Windows.Forms.ToolStripButton buttonViewInBrowser;
        private System.Windows.Forms.ToolStripDropDownButton dropDownIssueActions;
        private System.Windows.Forms.ToolStripButton buttonLogWork;
        private System.Windows.Forms.TabPage tabSubtasks;
        private System.Windows.Forms.WebBrowser webSubtasks;
        private System.Windows.Forms.TabPage tabAttachments;
        private System.Windows.Forms.SplitContainer splitContainerAttachments;
        private ui.AutosizeListView listViewAttachments;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnAuthor;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnSize;
        private System.Windows.Forms.ToolTip toolTipAttachments;
        private System.Windows.Forms.ToolStripContainer toolStripContainer3;
        private System.Windows.Forms.ToolStrip toolStripAttachmentsMenu;
        private System.Windows.Forms.ToolStripButton buttonSaveAttachmentAs;
        private System.Windows.Forms.ToolStripButton buttonUploadNew;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TabPage tabLinks;
        private System.Windows.Forms.WebBrowser webLinkedIssues;
        private System.Windows.Forms.ToolStripButton buttonStartStopProgress;
        private System.Windows.Forms.ToolStripButton buttonPaste;
        private System.Windows.Forms.Button summaryEditBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox summaryText;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button assigneeEditBtn;
        private System.Windows.Forms.Button priorityEditBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox priorityText;
        private System.Windows.Forms.TextBox statusText;
        private System.Windows.Forms.TextBox typeText;
        private System.Windows.Forms.TextBox assigneeText;
        private System.Windows.Forms.TextBox componentText;
        private System.Windows.Forms.TextBox updatedText;
        private System.Windows.Forms.TextBox createdText;
        private System.Windows.Forms.TextBox resolutionText;
        private System.Windows.Forms.TextBox reporterText;
    }
}