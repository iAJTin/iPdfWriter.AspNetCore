@ECHO OFF
CLS

rmdir ..\documentation /s /q

xmldocmd ..\src\lib\iTin.Utilities\iTin.Utilities.Pdf\iTin.Utilities.Pdf.Writer\iTin.Utilities.Pdf.Writer.AspNetCore\bin\Debug\netstandard2.0\iTin.Utilities.Pdf.Writer.AspNetCore.dll ..\documentation
         
PAUSE
