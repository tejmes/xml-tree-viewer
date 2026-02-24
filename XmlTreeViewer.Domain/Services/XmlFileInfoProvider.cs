using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using XmlTreeViewer.Domain.Models;

namespace XmlTreeViewer.Domain.Services
{
    public class XmlFileInfoProvider
    {
        public XmlFileInfo GetInfo(XDocument document)
        {
            if (document == null) throw new ArgumentNullException(nameof(document));
            if (document.Root == null) throw new InvalidOperationException("XML dokument neobsahuje root element!");

            var elements = document.Root.DescendantsAndSelf().ToList();

            int maxDepth = elements.Max(GetDepth);

            int maxDirectChildren = elements.Max(e => e.Elements().Count());

            int minAttributes = elements.Min(e => e.Attributes().Count());

            int maxAttributes = elements.Max(e => e.Attributes().Count());

            return new XmlFileInfo(
                fileName: string.Empty,
                maxDepth: maxDepth,
                maxDirectChildren: maxDirectChildren,
                minAttributes: minAttributes,
                maxAttributes: maxAttributes
            );
        }

        private static int GetDepth(XElement element)
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
    }
}
