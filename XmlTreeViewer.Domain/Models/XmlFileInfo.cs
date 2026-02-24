using System;
using System.Collections.Generic;
using System.Text;

namespace XmlTreeViewer.Domain.Models
{
    public class XmlFileInfo
    {
        public string FileName { get; }
        public int MaxDepth { get; }
        public int MaxDirectChildren { get; }
        public int MinAttributes { get; }
        public int MaxAttributes { get; }

        public XmlFileInfo(string fileName, int maxDepth, int maxDirectChildren, int minAttributes, int maxAttributes)
        {
            FileName = fileName;
            MaxDepth = maxDepth;
            MaxDirectChildren = maxDirectChildren;
            MinAttributes = minAttributes;
            MaxAttributes = maxAttributes;
        }
    }
}
