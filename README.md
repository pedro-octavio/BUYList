# BUYLIST
A multi-user api can control your shopping list.
## PREREQUESITES
* [.Net Core](https://dotnet.microsoft.com/download);
* Some Database, in this case as using [MySql](https://www.mysql.com);
## CONFIGURING THE PROJECT
1) Install necessary packges:
> Executing the "Restore NuGet Packges" in Visual Studio, or dotnet restore in root directory
2) Insert your connectionstring in BUYList.API/appsettings.Development.json
3) Update database using this command:
> Visual Studio: Update-Database
> Some text editor: dotnet  ef database update
4) Insert a hash string in BUYList.Domain/Settings.cs
5) Run the BUYList.API;
## MAKE WITH
* .Net Core
* Automapper
* EntityFramework
* FluentValidator
* Autofac
* MySql
* IdentityModel
## VERSIONS
* 1.0.0 - First Commit;
* 1.1.0 - User services Added;
* 1.2.0 - JWT Authentication Added;
* 1.3.0 - Items and users are now related to validation;
* 1.3.1 - Entering Data during Migration;
## CONTRIBUITORS
* [**Pedro Octávio**](https://github.com/pedro-octavio) - *desenvolviment of project*
