@echo off
dotnet --info
dotnet build -c Release
echo.
DigestMethodTest\bin\Release\net452\DigestMethodTest.exe
DigestMethodTest\bin\Release\net471\DigestMethodTest.exe
echo.
echo ==== NUnit TESTS ====
echo.
dotnet test -c Release --no-build NUnitTests\NUnitTests.csproj
echo.
echo ==== xUnit TESTS ====
echo.
dotnet test -c Release --no-build xUnitTests\xUnitTests.csproj