using System;
using System.Collections.Generic;
using System.Text;

namespace XmlTreeViewer.Domain.Models
{
    public class XmlElementInfo
    {
        public int Depth { get; }
        public int SiblingIndex { get; }
        public IReadOnlyList<XmlAttributeInfo> Attributes { get; }
        public string? Text { get; }

        public XmlElementInfo(int depth, int siblingIndex, IReadOnlyList<XmlAttributeInfo> attributes, string? text)
        {
            Depth = depth;
            SiblingIndex = siblingIndex;
            Attributes = attributes;
            Text = text;
        }
    }
}
