namespace PlevkaXmlTreeViewer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            btnOpen = new ToolStripButton();
            btnSave = new ToolStripButton();
            btnClose = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            treeViewNodes = new TreeView();
            imageListNodes = new ImageList(components);
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
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnOpen, btnSave, btnClose });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(784, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnOpen
            // 
            btnOpen.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnOpen.Image = (Image)resources.GetObject("btnOpen.Image");
            btnOpen.ImageTransparentColor = Color.Magenta;
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(47, 22);
            btnOpen.Text = "Otevřit";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Enabled = false;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(41, 22);
            btnSave.Text = "Uložit";
            // 
            // btnClose
            // 
            btnClose.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageTransparentColor = Color.Magenta;
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(41, 22);
            btnClose.Text = "Zavřit";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 25);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(treeViewNodes);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBoxElement);
            splitContainer1.Panel2.Controls.Add(groupBoxFile);
            splitContainer1.Size = new Size(784, 536);
            splitContainer1.SplitterDistance = 250;
            splitContainer1.TabIndex = 1;
            // 
            // treeViewNodes
            // 
            treeViewNodes.Dock = DockStyle.Fill;
            treeViewNodes.HideSelection = false;
            treeViewNodes.ImageIndex = 0;
            treeViewNodes.ImageList = imageListNodes;
            treeViewNodes.LabelEdit = true;
            treeViewNodes.Location = new Point(0, 0);
            treeViewNodes.Name = "treeViewNodes";
            treeViewNodes.SelectedImageIndex = 0;
            treeViewNodes.Size = new Size(250, 536);
            treeViewNodes.StateImageList = imageListNodes;
            treeViewNodes.TabIndex = 0;
            // 
            // imageListNodes
            // 
            imageListNodes.ColorDepth = ColorDepth.Depth32Bit;
            imageListNodes.ImageStream = (ImageListStreamer)resources.GetObject("imageListNodes.ImageStream");
            imageListNodes.TransparentColor = Color.Transparent;
            imageListNodes.Images.SetKeyName(0, "Document.png");
            imageListNodes.Images.SetKeyName(1, "FolderOpened.png");
            // 
            // groupBoxElement
            // 
            groupBoxElement.Controls.Add(tableLayoutPanel2Element);
            groupBoxElement.Dock = DockStyle.Bottom;
            groupBoxElement.Location = new Point(0, 174);
            groupBoxElement.Name = "groupBoxElement";
            groupBoxElement.Size = new Size(530, 362);
            groupBoxElement.TabIndex = 1;
            groupBoxElement.TabStop = false;
            groupBoxElement.Text = "Element";
            // 
            // tableLayoutPanel2Element
            // 
            tableLayoutPanel2Element.ColumnCount = 2;
            tableLayoutPanel2Element.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2Element.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2Element.Controls.Add(labelElementDepth, 0, 0);
            tableLayoutPanel2Element.Controls.Add(labelSiblingIndex, 0, 1);
            tableLayoutPanel2Element.Controls.Add(labelAttributes, 0, 2);
            tableLayoutPanel2Element.Controls.Add(labelText, 0, 3);
            tableLayoutPanel2Element.Controls.Add(listViewAttributes, 1, 2);
            tableLayoutPanel2Element.Controls.Add(textBoxText, 1, 3);
            tableLayoutPanel2Element.Controls.Add(labelElementDepthValue, 1, 0);
            tableLayoutPanel2Element.Controls.Add(labelSiblingIndexValue, 1, 1);
            tableLayoutPanel2Element.Dock = DockStyle.Fill;
            tableLayoutPanel2Element.Location = new Point(3, 19);
            tableLayoutPanel2Element.Name = "tableLayoutPanel2Element";
            tableLayoutPanel2Element.RowCount = 4;
            tableLayoutPanel2Element.RowStyles.Add(new RowStyle());
            tableLayoutPanel2Element.RowStyles.Add(new RowStyle());
            tableLayoutPanel2Element.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2Element.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2Element.Size = new Size(524, 340);
            tableLayoutPanel2Element.TabIndex = 0;
            // 
            // labelElementDepth
            // 
            labelElementDepth.AutoSize = true;
            labelElementDepth.Dock = DockStyle.Fill;
            labelElementDepth.Location = new Point(3, 0);
            labelElementDepth.Name = "labelElementDepth";
            labelElementDepth.Size = new Size(256, 15);
            labelElementDepth.TabIndex = 0;
            labelElementDepth.Text = "Hloubka zanoření:";
            labelElementDepth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSiblingIndex
            // 
            labelSiblingIndex.AutoSize = true;
            labelSiblingIndex.Dock = DockStyle.Fill;
            labelSiblingIndex.Location = new Point(3, 15);
            labelSiblingIndex.Name = "labelSiblingIndex";
            labelSiblingIndex.Size = new Size(256, 15);
            labelSiblingIndex.TabIndex = 1;
            labelSiblingIndex.Text = "Pořadí mezi sourozenci:";
            labelSiblingIndex.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAttributes
            // 
            labelAttributes.AutoSize = true;
            labelAttributes.Dock = DockStyle.Fill;
            labelAttributes.Location = new Point(3, 30);
            labelAttributes.Name = "labelAttributes";
            labelAttributes.Size = new Size(256, 155);
            labelAttributes.TabIndex = 2;
            labelAttributes.Text = "Atributy:";
            labelAttributes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Dock = DockStyle.Fill;
            labelText.Location = new Point(3, 185);
            labelText.Name = "labelText";
            labelText.Size = new Size(256, 155);
            labelText.TabIndex = 3;
            labelText.Text = "Text:";
            labelText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listViewAttributes
            // 
            listViewAttributes.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderValue });
            listViewAttributes.Dock = DockStyle.Fill;
            listViewAttributes.FullRowSelect = true;
            listViewAttributes.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewAttributes.Location = new Point(265, 33);
            listViewAttributes.Name = "listViewAttributes";
            listViewAttributes.Size = new Size(256, 149);
            listViewAttributes.TabIndex = 4;
            listViewAttributes.UseCompatibleStateImageBehavior = false;
            listViewAttributes.View = View.Details;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Název";
            columnHeaderName.Width = 125;
            // 
            // columnHeaderValue
            // 
            columnHeaderValue.Text = "Hodnota";
            columnHeaderValue.Width = 125;
            // 
            // textBoxText
            // 
            textBoxText.Dock = DockStyle.Fill;
            textBoxText.Location = new Point(265, 188);
            textBoxText.Multiline = true;
            textBoxText.Name = "textBoxText";
            textBoxText.ReadOnly = true;
            textBoxText.ScrollBars = ScrollBars.Vertical;
            textBoxText.Size = new Size(256, 149);
            textBoxText.TabIndex = 5;
            // 
            // labelElementDepthValue
            // 
            labelElementDepthValue.AutoSize = true;
            labelElementDepthValue.Dock = DockStyle.Fill;
            labelElementDepthValue.Location = new Point(265, 0);
            labelElementDepthValue.Name = "labelElementDepthValue";
            labelElementDepthValue.Size = new Size(256, 15);
            labelElementDepthValue.TabIndex = 6;
            labelElementDepthValue.Text = "label6";
            labelElementDepthValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelSiblingIndexValue
            // 
            labelSiblingIndexValue.AutoSize = true;
            labelSiblingIndexValue.Dock = DockStyle.Fill;
            labelSiblingIndexValue.Location = new Point(265, 15);
            labelSiblingIndexValue.Name = "labelSiblingIndexValue";
            labelSiblingIndexValue.Size = new Size(256, 15);
            labelSiblingIndexValue.TabIndex = 7;
            labelSiblingIndexValue.Text = "label7";
            labelSiblingIndexValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBoxFile
            // 
            groupBoxFile.Controls.Add(tableLayoutPanelFile);
            groupBoxFile.Dock = DockStyle.Top;
            groupBoxFile.Location = new Point(0, 0);
            groupBoxFile.Name = "groupBoxFile";
            groupBoxFile.Size = new Size(530, 168);
            groupBoxFile.TabIndex = 0;
            groupBoxFile.TabStop = false;
            groupBoxFile.Text = "Soubor";
            // 
            // tableLayoutPanelFile
            // 
            tableLayoutPanelFile.ColumnCount = 2;
            tableLayoutPanelFile.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelFile.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
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
            tableLayoutPanelFile.Dock = DockStyle.Fill;
            tableLayoutPanelFile.Location = new Point(3, 19);
            tableLayoutPanelFile.Name = "tableLayoutPanelFile";
            tableLayoutPanelFile.RowCount = 5;
            tableLayoutPanelFile.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelFile.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelFile.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelFile.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelFile.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelFile.Size = new Size(524, 146);
            tableLayoutPanelFile.TabIndex = 0;
            // 
            // labelFileName
            // 
            labelFileName.AutoSize = true;
            labelFileName.Dock = DockStyle.Fill;
            labelFileName.Location = new Point(3, 0);
            labelFileName.Name = "labelFileName";
            labelFileName.Size = new Size(256, 29);
            labelFileName.TabIndex = 0;
            labelFileName.Text = "Název souboru:";
            labelFileName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMaxDepth
            // 
            labelMaxDepth.AutoSize = true;
            labelMaxDepth.Dock = DockStyle.Fill;
            labelMaxDepth.Location = new Point(3, 29);
            labelMaxDepth.Name = "labelMaxDepth";
            labelMaxDepth.Size = new Size(256, 29);
            labelMaxDepth.TabIndex = 1;
            labelMaxDepth.Text = "Max. hloubka:";
            labelMaxDepth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMaxDirectChildren
            // 
            labelMaxDirectChildren.AutoSize = true;
            labelMaxDirectChildren.Dock = DockStyle.Fill;
            labelMaxDirectChildren.Location = new Point(3, 58);
            labelMaxDirectChildren.Name = "labelMaxDirectChildren";
            labelMaxDirectChildren.Size = new Size(256, 29);
            labelMaxDirectChildren.TabIndex = 2;
            labelMaxDirectChildren.Text = "Max. přímých potomků:";
            labelMaxDirectChildren.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMinAttributes
            // 
            labelMinAttributes.AutoSize = true;
            labelMinAttributes.Dock = DockStyle.Fill;
            labelMinAttributes.Location = new Point(3, 87);
            labelMinAttributes.Name = "labelMinAttributes";
            labelMinAttributes.Size = new Size(256, 29);
            labelMinAttributes.TabIndex = 3;
            labelMinAttributes.Text = "Min. počet atributů:";
            labelMinAttributes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMaxAttributes
            // 
            labelMaxAttributes.AutoSize = true;
            labelMaxAttributes.Dock = DockStyle.Fill;
            labelMaxAttributes.Location = new Point(3, 116);
            labelMaxAttributes.Name = "labelMaxAttributes";
            labelMaxAttributes.Size = new Size(256, 30);
            labelMaxAttributes.TabIndex = 4;
            labelMaxAttributes.Text = "Max. počet atributů:";
            labelMaxAttributes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelFileNameValue
            // 
            labelFileNameValue.AutoSize = true;
            labelFileNameValue.Dock = DockStyle.Fill;
            labelFileNameValue.Location = new Point(265, 0);
            labelFileNameValue.Name = "labelFileNameValue";
            labelFileNameValue.Size = new Size(256, 29);
            labelFileNameValue.TabIndex = 5;
            labelFileNameValue.Text = "label1";
            labelFileNameValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelMaxDepthValue
            // 
            labelMaxDepthValue.AutoSize = true;
            labelMaxDepthValue.Dock = DockStyle.Fill;
            labelMaxDepthValue.Location = new Point(265, 29);
            labelMaxDepthValue.Name = "labelMaxDepthValue";
            labelMaxDepthValue.Size = new Size(256, 29);
            labelMaxDepthValue.TabIndex = 6;
            labelMaxDepthValue.Text = "label2";
            labelMaxDepthValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelMaxDirectChildrenValue
            // 
            labelMaxDirectChildrenValue.AutoSize = true;
            labelMaxDirectChildrenValue.Dock = DockStyle.Fill;
            labelMaxDirectChildrenValue.Location = new Point(265, 58);
            labelMaxDirectChildrenValue.Name = "labelMaxDirectChildrenValue";
            labelMaxDirectChildrenValue.Size = new Size(256, 29);
            labelMaxDirectChildrenValue.TabIndex = 7;
            labelMaxDirectChildrenValue.Text = "label3";
            labelMaxDirectChildrenValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelMinAttributesValue
            // 
            labelMinAttributesValue.AutoSize = true;
            labelMinAttributesValue.Dock = DockStyle.Fill;
            labelMinAttributesValue.Location = new Point(265, 87);
            labelMinAttributesValue.Name = "labelMinAttributesValue";
            labelMinAttributesValue.Size = new Size(256, 29);
            labelMinAttributesValue.TabIndex = 8;
            labelMinAttributesValue.Text = "label4";
            labelMinAttributesValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelMaxAttributesValue
            // 
            labelMaxAttributesValue.AutoSize = true;
            labelMaxAttributesValue.Dock = DockStyle.Fill;
            labelMaxAttributesValue.Location = new Point(265, 116);
            labelMaxAttributesValue.Name = "labelMaxAttributesValue";
            labelMaxAttributesValue.Size = new Size(256, 30);
            labelMaxAttributesValue.TabIndex = 9;
            labelMaxAttributesValue.Text = "label5";
            labelMaxAttributesValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            MinimumSize = new Size(800, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XML Tree Viewer";
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
        private TreeView treeViewNodes;
        private ImageList imageListNodes;
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
