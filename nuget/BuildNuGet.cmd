@ECHO OFF
CLS

..\src\.nuget\nuget Pack iPdfWriter.AspNetCore.1.0.1.nuspec -NoDefaultExcludes -NoPackageAnalysis -OutputDirectory ..\deployment\nuget 

pause

