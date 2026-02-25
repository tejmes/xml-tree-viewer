using System.Xml.Linq;
using XmlTreeViewer.Application.Services;
using XmlTreeViewer.WinForms.Helpers;

namespace XmlTreeViewer.WinForms
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private readonly XmlFileService _fileService = new XmlFileService();
        private readonly TreeViewBuilder _treeViewBuilder = new TreeViewBuilder();

        private XDocument _document;
        private string _currentPath;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ResetUI()
        {
            treeView.Nodes.Clear();

            labelFileNameValue.Text = "";
            labelMaxDepthValue.Text = "";
            labelMaxDirectChildrenValue.Text = "";
            labelMinAttributesValue.Text = "";
            labelMaxAttributesValue.Text = "";

            labelElementDepthValue.Text = "";
            labelSiblingIndexValue.Text = "";
            listViewAttributes.Items.Clear();
            textBoxText.Clear();

            _document = null;
            _currentPath = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ResetUI();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                Filter = "XML files (*.xml)|*.xml",
                Title = "Vyberte XML soubor"
            };

            if (openFileDialog.ShowDialog(this) != DialogResult.OK) return;

            try
            {
                ResetUI();

                _currentPath = openFileDialog.FileName;
                _document = _fileService.Load(_currentPath);

                _treeViewBuilder.Build(treeView, _document);
                treeView.ExpandAll();

                var info = _fileService.GetFileInfo(_document, _currentPath);

                labelFileNameValue.Text = info.FileName;
                labelMaxDepthValue.Text = info.MaxDepth.ToString();
                labelMaxDirectChildrenValue.Text = info.MaxDirectChildren.ToString();
                labelMinAttributesValue.Text = info.MinAttributes.ToString();
                labelMaxAttributesValue.Text = info.MaxAttributes.ToString();

                btnSave.Enabled = true;
            }
            catch (Exception ex)
            {
                ResetUI();
                MessageBox.Show(this, ex.Message, "Chyba při otevírání XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeViewNodes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node?.Tag is not XElement element) return;

            var info = _fileService.GetElementInfo(element);

            labelElementDepthValue.Text = info.Depth.ToString();
            labelSiblingIndexValue.Text = info.SiblingIndex.ToString();

            listViewAttributes.BeginUpdate();
            listViewAttributes.Items.Clear();

            foreach (var a in info.Attributes)
            {
                var item = new ListViewItem(a.Name);
                item.SubItems.Add(a.Value);
                listViewAttributes.Items.Add(item);
            }

            listViewAttributes.EndUpdate();

            textBoxText.Text = info.Text ?? "";
        }

        private void treeViewNodes_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Node?.Tag is not XElement element) return;
            if (e.Label == null) return;

            var newName = e.Label.Trim();

            if (string.IsNullOrWhiteSpace(newName))
            {
                e.CancelEdit = true;
                return;
            }

            try
            {
                _fileService.RenameElement(element, newName);
            }
            catch (Exception ex)
            {
                e.CancelEdit = true;
                MessageBox.Show(this, ex.Message, "Neplatný název elementu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_document == null) return;

            using var SaveFileDialog = new SaveFileDialog
            {
                Filter = "XML files (*.xml)|*.xml",
                Title = "Uložit XML soubor",
                FileName = _currentPath != null ? Path.GetFileNameWithoutExtension(_currentPath) + "_edited.xml" : "output.xml"
            };

            if (SaveFileDialog.ShowDialog(this) != DialogResult.OK) return;

            try
            {
                _fileService.Save(_document, SaveFileDialog.FileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Chyba při ukládání", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
