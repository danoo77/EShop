# Pet shop
## How to run application (Windows machine .Net core 2.1 needs to be installed with latest angular)
1. Donwload sources
2. Specify MS SQL Server Connection string in appsettings.json inside the Web project (DmiConsulting.Eshop)
3. No need to create Database, application will handle it automatically
4. Go to Web project folder DmiConsultin.Eshop open cmd as admin or powershell and run
`dotnet run`
## Alternatively, you can use the publish.zip
1. Unzip the publish.zip
2. Do the same as mentioned in 2nd section above
3. Run powershel in the unziped folder and run `dotnet DmiConsulting.Eshop.dll`
## Prepare for the deployment
1. Open the solutin in Visual Studio
2. In Source control explorer find the Wew project - DmiConsulting.Eshop
3. Right click on the project and click publish
4. This will guide you through next steps

