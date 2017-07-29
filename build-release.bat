@echo off
title Building SSAC
"%windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe" "%~dp0\SS Anticheat\SS Anticheat.sln" /t:Build /p:Configuration=Release
echo Build script successfull
pause