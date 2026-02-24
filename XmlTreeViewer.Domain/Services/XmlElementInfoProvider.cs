using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using XmlTreeViewer.Domain.Models;

namespace XmlTreeViewer.Domain.Services
{
    public class XmlElementInfoProvider
    {
        public XmlElementInfo GetInfo(XElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            int depth = GetDepth(element);

            int siblingIndex = GetSiblingIndex(element);

            var attributes = element.Attributes().Select(a => new XmlAttributeInfo(a.Name.LocalName, a.Value)).ToList();

            string text = GetTextIfLeaf(element);

            return new XmlElementInfo(depth, siblingIndex, attributes, text);
        }

        public static int GetDepth(XElement element)
        {
            int depth = 0;

            var parent = element.Parent;

            while (parent != null)
            {
                depth++;
                parent = parent.Parent;
            }

            return depth;
        }

        public static int GetSiblingIndex(XElement element)
        {
            var parent = element.Parent;

            if (parent == null) return 1;

            int index = 1;

            foreach(var sibling in parent.Elements())
            {
                if (ReferenceEquals(sibling, element)) return index;

                index++;
            }

            return index;
        }

        private static string GetTextIfLeaf(XElement element)
        {
            bool hasChildren = element.Elements().Any();

            if (hasChildren) return null;

            var text = element.Value?.Trim();

            if (string.IsNullOrEmpty(text)) return null;

            return text;
        }
    }
}
