# XML Tree Viewer

XML Tree Viewer is a Windows Forms desktop application for viewing and editing the structure of XML documents in a visual and user-friendly way. It represents the hierarchical structure of an XML file as a tree and allows inspection of detailed information about individual elements.

## Features

* Open and load XML files from disk
* Display XML structure in a hierarchical TreeView
* Visual distinction between parent elements and leaf elements using icons
* Display file-level statistics:

  * file name
  * maximum depth of the XML tree
  * maximum number of direct child elements
  * minimum and maximum number of attributes per element
* Display element-level information:

  * element depth in the tree
  * index among sibling elements
  * list of attributes (name and value)
  * element text content (for leaf elements)
* Rename XML elements directly in the TreeView
* Save the modified XML document to a new file
* Handling of invalid or malformed XML files
