# Pdf Concatenate Benchmarks

|               Method | pageCount |           Mean |        Gen0 |     Allocated |
|--------------------- |---------- |---------------:|------------:|--------------:|
|   'Aspose Pages.Add' |         2 |     2,503.2 us |   1332.0313 |    4876.79 KB |
| 'Aspose Concatenate' |         2 |     4,798.3 us |   1328.1250 |    5444.77 KB |
|               iText7 |         2 |       475.2 us |     59.5703 |     368.22 KB |
|             PdfSharp |         2 |       299.6 us |     96.1914 |     592.74 KB |
|      'IronPDF Merge' |         2 |     6,394.9 us |    296.8750 |    1854.42 KB |
|     'IronPDF Append' |         2 |     1,263.9 us |    109.3750 |     651.42 KB |
|   'Aspose Pages.Add' |        10 |    11,708.1 us |   6656.2500 |   26142.04 KB |
| 'Aspose Concatenate' |        10 |    14,935.8 us |   6656.2500 |   25028.82 KB |
|               iText7 |        10 |     2,455.5 us |    289.0625 |     1881.7 KB |
|             PdfSharp |        10 |     1,718.1 us |    453.1250 |    2773.94 KB |
|      'IronPDF Merge' |        10 |    94,180.5 us |   6000.0000 |   31913.88 KB |
|     'IronPDF Append' |        10 |     9,141.3 us |    781.2500 |    4491.93 KB |
|   'Aspose Pages.Add' |       100 |   127,451.2 us |  63250.0000 |  265330.29 KB |
| 'Aspose Concatenate' |       100 |   198,737.2 us |  45000.0000 |  246498.14 KB |
|               iText7 |       100 |    33,485.4 us |   3562.5000 |   20349.26 KB |
|             PdfSharp |       100 |    20,657.7 us |   4031.2500 |   27148.44 KB |
|      'IronPDF Merge' |       100 | 6,503,413.6 us | 365000.0000 |  2519448.8 KB |
|     'IronPDF Append' |       100 |    96,420.3 us |   8000.0000 |   47711.84 KB |
|   'Aspose Pages.Add' |      1000 | 1,873,453.9 us | 281000.0000 | 2656752.68 KB |
| 'Aspose Concatenate' |      1000 | 2,180,616.7 us | 181000.0000 | 2609810.86 KB |
|               iText7 |      1000 |   355,736.8 us |  28000.0000 |  195776.85 KB |
|             PdfSharp |      1000 |   224,457.3 us |  43000.0000 |   274143.6 KB |
|     'IronPDF Append' |      1000 | 1,031,910.6 us |  81000.0000 |  479870.33 KB |


## Diagnostics merging 1000 pdf files

### Aspose `Pages().Add()`
![Aspose Pages().Add()](Screens/aspose_add.png)

### Aspose `Concatenate()`
![Aspose Concatenate()](Screens/aspose_concat.png)

### iText 7
![iText 7](Screens/itext.png)

### PdfSharp
![pdfSharp](Screens/pdf_sharp.png)

### IronPdf `Merge()`
![IronPdf Merge()](Screens/iron_pdf_merge.png)

### IronPdf `AppendPdf()`
![IronPdf AppendPdf()](Screens/iron_pdf_append.png)