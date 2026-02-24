using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using XmlTreeViewer.Domain.Models;
using XmlTreeViewer.Domain.Services;

namespace XmlTreeViewer.Application.Services
{
    public class XmlFileService
    {
        private readonly XmlFileInfoProvider _fileInfoProvider;
        private readonly XmlElementInfoProvider _elementInfoProvider;

        public XmlFileService()
        {
            _fileInfoProvider = new XmlFileInfoProvider();
            _elementInfoProvider = new XmlElementInfoProvider();
        }

        public XDocument Load(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentException("Cesta k souboru je prázdná!", nameof(path));

            return XDocument.Load(path, LoadOptions.PreserveWhitespace);
        }

        public void Save(XDocument document, string path)
        {
            if (document == null) throw new ArgumentNullException(nameof(document));
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentException("Cesta pro uložení je prázdná!", nameof(path));

            document.Save(path);
        }

        public XmlFileInfo GetFileInfo(XDocument document, string path)
        {
            if (document == null) throw new ArgumentNullException(nameof(document));
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentException("Zdrojová cesta je prázdná!", nameof(path));

            var fileInfo = _fileInfoProvider.GetInfo(document);

            return new XmlFileInfo(Path.GetFileName(path), fileInfo.MaxDepth, fileInfo.MaxDirectChildren, fileInfo.MinAttributes, fileInfo.MaxAttributes);
        }

        public XmlElementInfo GetElementInfo(XElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            return _elementInfoProvider.GetInfo(element);
        }

        public void RenameElement(XElement element, string newName)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (string.IsNullOrWhiteSpace(newName)) throw new ArgumentException("Název elementu je prázdný!", nameof(newName));

            XmlConvert.VerifyName(newName);

            element.Name = XName.Get(newName);
        }
    }
}
