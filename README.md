# C#.Net Import/Export CSV Library
**CSVLibraryAK** provides CSV import and export feature in C#.NET using **Datatable** as primary data structure. You can install this library via Nuget packages. You can use this library into your any C#.NET project that supports Datatable data structure. This library imports CSV file with or without header and with any number of columns into C#.NET Datatable structure. The import function will automatically detects the number of columns of the CSV file. Export method will export your data from C#.NET Datatable data structure to .csv format file.

### Nuget Installation Version 1.1.4: https://www.nuget.org/packages/CSVLibraryAK/

### Copyright (c) [Asma's Blog](https://www.asmak9.com/)

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

1. [Console Application](https://bit.ly/2XYnh8g)
2. [ASP.NET MVC Application](https://bit.ly/2XVaXcb)
3. [WPF Application](https://bit.ly/30tyG0M)

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
