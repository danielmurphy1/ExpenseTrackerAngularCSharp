# Full Stack Expense Tracker (Angular and C#)

_Web Based Expense Tracker Application_

Create an Expense Tracker to Track Expenses and Delete Them As Needed

View To Do Application Live [Link to Application](https://expensetrackerangularcsharp.azurewebsites.net/) 


## Instructions

To Download and Run With a Local PostgreSQL Database

I. Clone SQL Databse Schema

1. Download PosgreSQL/PGAdmin 
2. Run the databse creation script in the `backup.sql` file in the `root` directory

II. Install Files to Run Locally

1. Clone code locally from GitHub and Open in Visual Studio.
2. CD into `ClientApp` directory.
3. Run `npm i` in `ClientApp` directory in the terminal.
4. In the root directory, rename `.env_sample` to `.env` file and replace `DEVELOPMENT_CONNECTION_STRING` with the connection string for your local PostgreSQL database.
5. Open `DatabaseConnection.cs` file in the root directory and uncomment line 11 and comment out line 12.
6. Open `expense.service.ts` in `ClinetApp/src/app/services` - comment out line 15 and uncomment line 13. 
7. Press the start button at the top of the Visual Studio window. If your browser does not open automatically, open a browser and enter `https://localhost:44465/` to run the application.

To Download and Run With JSON-Server

1. Clone code locally from GitHub and Open in Visual Studio.
2. CD into `ClientApp` directory.
3. Run `npm i` in `ClientApp` directory.
4. Run `npm run server` in the terminal.
5. Open another terminal (make sure you cd into the `ClientApp` directory), and run `ng serve` in that terminal.
6. If your browser does not open automatically, open a browser and enter `https://localhost:4200` to run the application.

### Application Screenshots
![Application Screenshot](https://github.com/danielmurphy1/csharptodo/blob/main/images/csharptodo.JPG)

## Technologies/Design

### Technology Stack

- JavaScript with React Framework, CSS with Boostrap Library - Front End Stack
- C# with ASP.NET Web Application (.NET Framework) - Backend Stack and Internal/REST API
- PostgreSQL - Database with Npgsql Nuget Package
- Microsoft Azure - Hosting platform





### Summary

This application is my second since I have begun learning C# and my first using .NET and also my first fullstack application using C#/ASP.NET Web Application. 

To create this application I continued to expand on my C# knowledge as well as learning .NET Web API from the beginning. I have created a couple of seperate To Do applications in the past; however, this is the first one that I have created using a SQL database and to have full CRUD capabilities (previously relying on local storage for data persistence).  

In creating this application I learned more about how data and requests flow between the client, server, and databse. I also learned more about how to split the backend logic between the REST API endpoint controllers and the services that each endpoint calls to perform database operations. 

As this was my first application deployed to Microsoft Azure, I also learned how that deployment process works. More importantly, I learned how to use Azure's logging to identify and fix problems during the deployment process. 

I look forward to continue my learning of C# and the .NET framework in future projects. 

### Author

- Dan Murphy, Full-Stack Developer, https://www.linkedin.com/in/daniel-murphy-055/, https://danielmurphy.dev