@echo off
echo -------Ready to Build Project!!!-------
echo -------This build command will run in 3 seconds-------

timeout /t 3
echo -------Building...-------
dotnet build 
timeout /t 1

copy C:\Projects\bin\Debug\netcoreapp3.1\Projects.exe C:\Users\28970\Desktop\Program
copy C:\Projects\bin\Debug\netcoreapp3.1\Projects.dll C:\Users\28970\Desktop\Program
copy C:\Projects\bin\Debug\netcoreapp3.1\Projects.runtimeconfig.json C:\Users\28970\Desktop\Program
echo -------Program is copy to Desktop\Program-------

echo -------Build is over,Program will run in 5 seconds-------
timeout /t 3
dotnet run

echo -------The Program Is Over.Quit in 3 seconds-------
timeout /t 1