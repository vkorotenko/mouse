rem @echo off
rem set PATH=C:\Windows\Microsoft.NET\Framework\v4.0.30319\;%PATH%
set MSB="C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe"

%MSB% mouseod.csproj
rem %MSB% mouse.wixproj /p:Cultures=ru-RU
%MSB% mouse.wixproj /p:Cultures=en-us
rem %MSB% mousebundle.wixproj /p:Cultures=en-US
