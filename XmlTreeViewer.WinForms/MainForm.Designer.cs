namespace XmlTreeViewer.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new ToolStrip();
            btnOpen = new ToolStripButton();
            btnSave = new ToolStripButton();
            btnClose = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            treeView = new TreeView();
            imageList = new ImageList(components);
            groupBoxElement = new GroupBox();
            tableLayoutPanel2Element = new TableLayoutPanel();
            labelElementDepth = new Label();
            labelSiblingIndex = new Label();
            labelAttributes = new Label();
            labelText = new Label();
            listViewAttributes = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderValue = new ColumnHeader();
            textBoxText = new TextBox();
            labelElementDepthValue = new Label();
            labelSiblingIndexValue = new Label();
            groupBoxFile = new GroupBox();
            tableLayoutPanelFile = new TableLayoutPanel();
            labelFileName = new Label();
            labelMaxDepth = new Label();
            labelMaxDirectChildren = new Label();
            labelMinAttributes = new Label();
            labelMaxAttributes = new Label();
            labelFileNameValue = new Label();
            labelMaxDepthValue = new Label();
            labelMaxDirectChildrenValue = new Label();
            labelMinAttributesValue = new Label();
            labelMaxAttributesValue = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxElement.SuspendLayout();
            tableLayoutPanel2Element.SuspendLayout();
            groupBoxFile.SuspendLayout();
            tableLayoutPanelFile.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            resources.ApplyResources(toolStrip1, "toolStrip1");
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnOpen, btnSave, btnClose });
            toolStrip1.Name = "toolStrip1";
            // 
            // btnOpen
            // 
            resources.ApplyResources(btnOpen, "btnOpen");
            btnOpen.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnOpen.Name = "btnOpen";
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            resources.ApplyResources(btnSave, "btnSave");
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Name = "btnSave";
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnClose.Name = "btnClose";
            btnClose.Click += btnClose_Click;
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(splitContainer1.Panel1, "splitContainer1.Panel1");
            splitContainer1.Panel1.Controls.Add(treeView);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(splitContainer1.Panel2, "splitContainer1.Panel2");
            splitContainer1.Panel2.Controls.Add(groupBoxElement);
            splitContainer1.Panel2.Controls.Add(groupBoxFile);
            // 
            // treeView
            // 
            resources.ApplyResources(treeView, "treeView");
            treeView.HideSelection = false;
            treeView.ImageList = imageList;
            treeView.LabelEdit = true;
            treeView.Name = "treeView";
            treeView.StateImageList = imageList;
            treeView.AfterLabelEdit += treeViewNodes_AfterLabelEdit;
            treeView.AfterSelect += treeViewNodes_AfterSelect;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "folder");
            imageList.Images.SetKeyName(1, "file");
            // 
            // groupBoxElement
            // 
            resources.ApplyResources(groupBoxElement, "groupBoxElement");
            groupBoxElement.Controls.Add(tableLayoutPanel2Element);
            groupBoxElement.Name = "groupBoxElement";
            groupBoxElement.TabStop = false;
            // 
            // tableLayoutPanel2Element
            // 
            resources.ApplyResources(tableLayoutPanel2Element, "tableLayoutPanel2Element");
            tableLayoutPanel2Element.Controls.Add(labelElementDepth, 0, 0);
            tableLayoutPanel2Element.Controls.Add(labelSiblingIndex, 0, 1);
            tableLayoutPanel2Element.Controls.Add(labelAttributes, 0, 2);
            tableLayoutPanel2Element.Controls.Add(labelText, 0, 3);
            tableLayoutPanel2Element.Controls.Add(listViewAttributes, 1, 2);
            tableLayoutPanel2Element.Controls.Add(textBoxText, 1, 3);
            tableLayoutPanel2Element.Controls.Add(labelElementDepthValue, 1, 0);
            tableLayoutPanel2Element.Controls.Add(labelSiblingIndexValue, 1, 1);
            tableLayoutPanel2Element.Name = "tableLayoutPanel2Element";
            // 
            // labelElementDepth
            // 
            resources.ApplyResources(labelElementDepth, "labelElementDepth");
            labelElementDepth.Name = "labelElementDepth";
            // 
            // labelSiblingIndex
            // 
            resources.ApplyResources(labelSiblingIndex, "labelSiblingIndex");
            labelSiblingIndex.Name = "labelSiblingIndex";
            // 
            // labelAttributes
            // 
            resources.ApplyResources(labelAttributes, "labelAttributes");
            labelAttributes.Name = "labelAttributes";
            // 
            // labelText
            // 
            resources.ApplyResources(labelText, "labelText");
            labelText.Name = "labelText";
            // 
            // listViewAttributes
            // 
            resources.ApplyResources(listViewAttributes, "listViewAttributes");
            listViewAttributes.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderValue });
            listViewAttributes.FullRowSelect = true;
            listViewAttributes.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewAttributes.Name = "listViewAttributes";
            listViewAttributes.UseCompatibleStateImageBehavior = false;
            listViewAttributes.View = View.Details;
            // 
            // columnHeaderName
            // 
            resources.ApplyResources(columnHeaderName, "columnHeaderName");
            // 
            // columnHeaderValue
            // 
            resources.ApplyResources(columnHeaderValue, "columnHeaderValue");
            // 
            // textBoxText
            // 
            resources.ApplyResources(textBoxText, "textBoxText");
            textBoxText.Name = "textBoxText";
            textBoxText.ReadOnly = true;
            // 
            // labelElementDepthValue
            // 
            resources.ApplyResources(labelElementDepthValue, "labelElementDepthValue");
            labelElementDepthValue.Name = "labelElementDepthValue";
            // 
            // labelSiblingIndexValue
            // 
            resources.ApplyResources(labelSiblingIndexValue, "labelSiblingIndexValue");
            labelSiblingIndexValue.Name = "labelSiblingIndexValue";
            // 
            // groupBoxFile
            // 
            resources.ApplyResources(groupBoxFile, "groupBoxFile");
            groupBoxFile.Controls.Add(tableLayoutPanelFile);
            groupBoxFile.Name = "groupBoxFile";
            groupBoxFile.TabStop = false;
            // 
            // tableLayoutPanelFile
            // 
            resources.ApplyResources(tableLayoutPanelFile, "tableLayoutPanelFile");
            tableLayoutPanelFile.Controls.Add(labelFileName, 0, 0);
            tableLayoutPanelFile.Controls.Add(labelMaxDepth, 0, 1);
            tableLayoutPanelFile.Controls.Add(labelMaxDirectChildren, 0, 2);
            tableLayoutPanelFile.Controls.Add(labelMinAttributes, 0, 3);
            tableLayoutPanelFile.Controls.Add(labelMaxAttributes, 0, 4);
            tableLayoutPanelFile.Controls.Add(labelFileNameValue, 1, 0);
            tableLayoutPanelFile.Controls.Add(labelMaxDepthValue, 1, 1);
            tableLayoutPanelFile.Controls.Add(labelMaxDirectChildrenValue, 1, 2);
            tableLayoutPanelFile.Controls.Add(labelMinAttributesValue, 1, 3);
            tableLayoutPanelFile.Controls.Add(labelMaxAttributesValue, 1, 4);
            tableLayoutPanelFile.Name = "tableLayoutPanelFile";
            // 
            // labelFileName
            // 
            resources.ApplyResources(labelFileName, "labelFileName");
            labelFileName.Name = "labelFileName";
            // 
            // labelMaxDepth
            // 
            resources.ApplyResources(labelMaxDepth, "labelMaxDepth");
            labelMaxDepth.Name = "labelMaxDepth";
            // 
            // labelMaxDirectChildren
            // 
            resources.ApplyResources(labelMaxDirectChildren, "labelMaxDirectChildren");
            labelMaxDirectChildren.Name = "labelMaxDirectChildren";
            // 
            // labelMinAttributes
            // 
            resources.ApplyResources(labelMinAttributes, "labelMinAttributes");
            labelMinAttributes.Name = "labelMinAttributes";
            // 
            // labelMaxAttributes
            // 
            resources.ApplyResources(labelMaxAttributes, "labelMaxAttributes");
            labelMaxAttributes.Name = "labelMaxAttributes";
            // 
            // labelFileNameValue
            // 
            resources.ApplyResources(labelFileNameValue, "labelFileNameValue");
            labelFileNameValue.Name = "labelFileNameValue";
            // 
            // labelMaxDepthValue
            // 
            resources.ApplyResources(labelMaxDepthValue, "labelMaxDepthValue");
            labelMaxDepthValue.Name = "labelMaxDepthValue";
            // 
            // labelMaxDirectChildrenValue
            // 
            resources.ApplyResources(labelMaxDirectChildrenValue, "labelMaxDirectChildrenValue");
            labelMaxDirectChildrenValue.Name = "labelMaxDirectChildrenValue";
            // 
            // labelMinAttributesValue
            // 
            resources.ApplyResources(labelMinAttributesValue, "labelMinAttributesValue");
            labelMinAttributesValue.Name = "labelMinAttributesValue";
            // 
            // labelMaxAttributesValue
            // 
            resources.ApplyResources(labelMaxAttributesValue, "labelMaxAttributesValue");
            labelMaxAttributesValue.Name = "labelMaxAttributesValue";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "MainForm";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxElement.ResumeLayout(false);
            tableLayoutPanel2Element.ResumeLayout(false);
            tableLayoutPanel2Element.PerformLayout();
            groupBoxFile.ResumeLayout(false);
            tableLayoutPanelFile.ResumeLayout(false);
            tableLayoutPanelFile.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnOpen;
        private ToolStripButton btnSave;
        private ToolStripButton btnClose;
        private SplitContainer splitContainer1;
        private TreeView treeView;
        private ImageList imageList;
        private GroupBox groupBoxElement;
        private GroupBox groupBoxFile;
        private TableLayoutPanel tableLayoutPanel2Element;
        private TableLayoutPanel tableLayoutPanelFile;
        private Label labelFileName;
        private Label labelMaxDepth;
        private Label labelMaxDirectChildren;
        private Label labelMinAttributes;
        private Label labelMaxAttributes;
        private Label labelElementDepth;
        private Label labelSiblingIndex;
        private Label labelAttributes;
        private Label labelText;
        private ListView listViewAttributes;
        private TextBox textBoxText;
        private Label labelElementDepthValue;
        private Label labelSiblingIndexValue;
        private Label labelFileNameValue;
        private Label labelMaxDepthValue;
        private Label labelMaxDirectChildrenValue;
        private Label labelMinAttributesValue;
        private Label labelMaxAttributesValue;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderValue;
    }
}
