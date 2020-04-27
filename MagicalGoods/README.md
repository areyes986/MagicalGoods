# E-Commerce

## Andrew and Ally's Alchemical Auguries
---
### We are deployed on Azure!

Deployed: https://magicalgoodsstore.azurewebsites.net/

---
## Web Application
Our E-Commerce C# web application allows users to look through and purchase magical items. On our register page, we are grabbing our claims for our first name and last name to used to display it across our pages as well as having better security. 


---

## Tools Used
Microsoft Visual Studio Community 2019 

- C#
- ASP.Net Core
- Entity Framework
- MVC
- xUnit
- Bootstrap
- Azure

---

## Recent Updates

#### V 1.4
*Added OAuth for MySpace* - 23 Jan 2003

---

## Getting Started

Clone this repository to your local machine.

```
$ git clone https://github.com/YourRepo/YourProject.git
```
Once downloaded, you can either use the dotnet CLI utilities or Visual Studio 2017 (or greater) to build the web application. The solution file is located in the AmandaFE subdirectory at the root of the repository.
```
cd YourRepo/YourProject
dotnet build
```
The dotnet tools will automatically restore any NuGet dependencies. Before running the application, the provided code-first migration will need to be applied to the SQL server of your choice configured in the /AmandaFE/AmandaFE/appsettings.json file. This requires the Microsoft.EntityFrameworkCore.Tools NuGet package and can be run from the NuGet Package Manager Console:
```
Update-Database
```
Once the database has been created, the application can be run. Options for running and debugging the application using IIS Express or Kestrel are provided within Visual Studio. From the command line, the following will start an instance of the Kestrel server to host the application:
```
cd YourRepo/YourProject
dotnet run
```
Unit testing is included in the AmandaFE/FrontendTesting project using the xUnit test framework. Tests have been provided for models, view models, controllers, and utility classes for the application.

---

## Usage
***[Provide some images of your app with brief description as title]***

### Overview of Recent Posts
![Overview of Recent Posts](https://via.placeholder.com/500x250)

### Creating a Post
![Post Creation](https://via.placeholder.com/500x250)

### Enriching a Post
![Enriching Post](https://via.placeholder.com/500x250)

### Viewing Post Details
![Details of Post](https://via.placeholder.com/500x250)

---
## Data Flow (Frontend, Backend, REST API)
***[Add a clean and clear explanation of what the data flow is. Walk me through it.]***
![Data Flow Diagram](/assets/img/Flowchart.png)

---
## Data Model

### Overall Project Schema
***[Add a description of your DB schema. Explain the relationships to me.]***
![Database Schema](/assets/img/ERD.png)

---
## Model Properties and Requirements

### Blog

| Parameter | Type | Required |
| --- | --- | --- |
| ID  | int | YES |
| Summary | string | YES |
| Content | string | YES |
| Tags | string(s) | NO |
| Picture | img jpeg/png | NO |
| Sentiment | float | NO |
| Keywords | string(s) | NO |
| Related Posts | links | NO |
| Date | date/time object | YES |


### User

| Parameter | Type | Required |
| --- | --- | --- |
| ID  | int | YES |
| Name/Author | string | YES |
| Posts | list | YES |

---

## Change Log
***[The change log will list any changes made to the code base. This includes any changes from TA/Instructor feedback]***  
1.4: *Added OAuth for MySpace* - 23 Jan 2003  
1.3: *Changed email handler to Alta Vista, fixed issue with styling on Netscape Navigator browser.* - 21 Dec 1999  
1.2: *Fixed bug where pages would not load due to temp data* - 16 Jun 1998  
1.1: *Added ability for user to change photos on a post* - 12 May 1998  

---

## Authors
Albus Dumbbledore
Igor Karkaroff
Minerva McGonagall
Leta Lestrange
Gellert Grindelwald

---

For more information on Markdown: https://www.markdownguide.org/cheat-sheet