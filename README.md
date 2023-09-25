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
![Full Screen](https://github.com/danielmurphy1/ExpenseTrackerAngularCSharp/blob/master/Screenshots/FullScreenExpenseTracker.JPG)

![Mobile/Responsive Screen](https://github.com/danielmurphy1/ExpenseTrackerAngularCSharp/blob/master/Screenshots/MobileScreenExpenseTrackerJPG.JPG)
## Technologies/Design

### Technology Stack

- TypeScript/JavaScript with Angular Framework, CSS with Boostrap Library - Front End Stack
- C# with ASP.NET Web Application (ASP.NET Core 6) - Backend Stack and Internal/REST API
- PostgreSQL - Database with Npgsql Nuget Package
- Microsoft Azure - Hosting platform





### Summary

This is my second full-stack application since I began learning C#/.NET. While I have used Angular extensively at work, this is my first personal project using it, as I have favored React for personal projects in the past.

I found the setup to be pretty simple for this project, utilizing the WebAPI project type provided in Visual Studio. While I could have easily kept the logic for all database functions in the Program.cs file and the ExpensesController.cs file, I wanted to make sure that my code was readable and clean, so I opted to create a simple DatabaseConnection.cs file to keep on its own, as well as several service files for each of the different queries needed for the databse. I found that made the code much more readable, which is something that I strive for when I write applications.

Additionally to meet the same end of clean and readable code, I used Angular's built in services module to handle the client-side api request so that the main front-end logic could be handled by each component - calling the service where needed. Again, I was very pleased with the readability of the end product. 

In creating this project, I learned more about Angular form validation, as well as some of Angular's powerful built-in directives. Certainly, I have used them before, but seeing as this was a personal project, I had the time to read more about them as I used them to gain the needed functionality in this project with the result being a deeper knowledge and understanding of how they work and interact with components.

I also learned more about the deployment process to Microsoft Azure and how to use its built-in tools for troubleshooting during deployment.

I look forward to continue my learning of C# and the .NET framework in future projects. 

### Author

- Dan Murphy, Full-Stack Developer, https://www.linkedin.com/in/daniel-murphy-055/, https://danielmurphy.dev