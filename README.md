# C#.Net Import/Export CSV Library
**CSVLibraryAK** provides CSV import and export feature in C#.NET using **Datatable** as primary data structure. You can install this library via Nuget packages or you can download pre-compile DLL library or you can download this code and compile the DLL library file yourself. You can use this library into your any C#.NET project that supports Datatable data structure. This library imports CSV file with or without header and with any number of columns into C#.NET Datatable structure. The import function will automatically detects the number of columns of the CSV file. Export method will export your data from C#.NET Datatable data structure to .csv format file.

### Nuget Installation Version 1.1.0: https://www.nuget.org/packages/CSVLibraryAK/

### For detail article visit [C#.Net Import/Export CSV Library](#) at [Asma's Blog](https://www.asmak9.com/)

# Basic Usage

```C#

// Initialization.
bool hasHeader = true;
string importFilePath = "C:\\import.csv";
string exportFilePath = "C:\\export.csv";

// Impot CSV file.
DataTable data = CSVLibraryAK.Import(importFilePath, hasHeader);

// Export CSV file.
CSVLibraryAK.Export(exportFilePath, data);

```

# Examples

1. [ASP.NET MVC Application](#)
2. [WPF Application](#)

<br/>
<br/>
<br/>


Like, Share, Support, Subscribe!!!

#### YouTube: https://bit.ly/2sY1aBb 

#### Website: https://www.asmak9.com/

#### E-Store Bytezaar: https://www.bytezaar.com/

#### Facebook: https://www.facebook.com/AK.asmak9/

#### LinkedIn: https://www.linkedin.com/company/asmak9

#### Twitter: https://twitter.com/asmak/
