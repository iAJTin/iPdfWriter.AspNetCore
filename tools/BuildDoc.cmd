@ECHO OFF
CLS

rmdir ..\documentation /s /q

xmldocmd ..\src\lib\iPdfWriter\iPdfWriter.AspNetCore\bin\Debug\netstandard2.0\iPdfWriter.AspNetCore.dll ..\documentation
         
PAUSE
