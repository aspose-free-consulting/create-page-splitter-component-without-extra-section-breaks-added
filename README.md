# Create Page Splitter Component without Extra Section Breaks Added

This free consulting project helps you process Word document with page splitter utility and helps remove extra section breaks. This project helps you to split Word document's pages into separate documents. It splits a document into multiple sections so that each page begins and ends at a section boundary.

#How to Run the Project

* You can either clone the repository using your favorite GitHub client or download the ZIP file
* Extract the contents of the ZIP file to any folder on your computer
* The project is created in Visual Studio 2017
*	Open the solution file in Visual Studio and build the project
*	On the first run, the dependencies will automatically be downloaded via NuGet
*	Get the temporary license and put it in Debug folder
*	Run the project, and give full path input document, start and end page numbers


# Limitation of PageSplitter

This project inserts the section break at the end of each page. So, in some cases section break pushes the last line of page to next page. 

# Fixes in this project

* This utility threw an exception when customer’s document is processed through it. This issue has been fixed.
* Added code to remove extra empty pages/sections from the document. See the following screenshots.


#Screenshots

This is the problematic input word document containing extra section breaks 

![problematic output](https://user-images.githubusercontent.com/1214951/68274359-b88da980-008a-11ea-9c25-a196e8f8084b.png)

This is the fixed output word document without extra section breaks

![fixed output](https://user-images.githubusercontent.com/1214951/68274357-b7f51300-008a-11ea-958e-ce3b591ffe4e.png)



## Interested in Aspose free consulting project?
[If you are also interested in a free consulting project by Aspose team then please view details on this page](https://aspose-free-consulting.github.io/)

If you have any questions about Aspose APIs, please feel free to [post your query in Aspose file format APIs Forums](https://forum.aspose.com/). 

Also, you can keep in touch with the latest developments in [file format APIs offered by Aspose at our Blog](https://blog.aspose.com/). 

## This free consluting project is based on the following issue:
[I want to create a page splitter component without extra section breaks added](https://github.com/aspose-free-consulting/projects/issues/15)
