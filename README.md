# 🍞 Pierre's Online Bakery 🍰

#### By _**Brenna Lavin**_

#### _This app uses authentication and authorization to allow a user to add flavors and food item types to an online bakery marketplace_

## Technologies Used

* C#
* .NET
* Microsoft EntityFrameworkCore
* Microsoft Identity
* Razor
* ASP.NET MVC
* MySQL Workbench

## Description

_Using MySQL Workbench, Microsoft EntityFrameWorkCore, C# and ASP.NET MVCs this project is a continuation in working with many to many relationships and incorporates Microsoft Identity Frameworks_

## Setup/Installation Requirements

* In order to use this application you must have MySQL Workbench installed. Depending on your machine please follow setup instructions listed [here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)
* Clone this repository to your local machine
* In the project's root directory, you will next need to create an appsettings.json file with the following information where YOURPASSWORDHERE is the password used to connect to MySQL:
```
  {
  "ConnectionStrings":{
    "DefaultConnection":"Server=localhost;Port=3306;database=brenna_lavin;uid=root; pwd=[YOURPASSWORDHERE];"
    }
  }
```

* Once saved, type ```cd Pierre``` in your command line to navigate to the main project folder.
* To install the project's dependencies, in the command line type ```dotnet restore```
* To ensure the database is properly connected to the project, type ```dotnet ef database update```, this will ideally apply the most recent migration of the database.
* Once in the Project folder, type ```dotnet run``` in the command line to run the program.

## Known Bugs
* None

## License


MIT License

Copyright (c) [2022] [Brenna Lavin](https://github.com/lavinbrenna)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
