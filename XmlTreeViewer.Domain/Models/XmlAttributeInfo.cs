using System;
using System.Collections.Generic;
using System.Text;

namespace XmlTreeViewer.Domain.Models
{
    public class XmlAttributeInfo
    {
        public string Name { get; }
        public string Value { get; }

        public XmlAttributeInfo(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}
