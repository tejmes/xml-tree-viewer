using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace XmlTreeViewer.WinForms.Helpers
{
    public class TreeViewBuilder
    {
        public void Build(TreeView treeView, XDocument document)
        {
            if (treeView == null) throw new ArgumentNullException(nameof(treeView));
            if (document?.Root == null) return;

            treeView.BeginUpdate();
            treeView.Nodes.Clear();

            var rootNode = CreateNode(document.Root);
            treeView.Nodes.Add(rootNode);

            treeView.EndUpdate();
        }

        private TreeNode CreateNode(XElement element)
        {
            var node = new TreeNode(element.Name.LocalName)
            {
                Tag = element
            };

            bool hasChildElements = element.Elements().Any();
            string key = hasChildElements ? "folder" : "file";

            node.ImageKey = key;
            node.SelectedImageKey = key;

            foreach (var child in element.Elements())
            {
                node.Nodes.Add(CreateNode(child));
            }

            return node;
        }
    }
}
