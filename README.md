# _Factory_

#### _C# ASP.NET MVC Project for Epicodus, October 16th, 2020_

#### By _**Natalie Murphy**_

## Description

Dr. Sillystringz's Factory

- An application to keep track of their machine repairs.
  MVC web application to manage their engineers, and the machines they are licensed to fix.
- User able to add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines.

## User

- list of all engineers, and a list of all machines.
- select a engineer, see their details, and see a list of all machines that engineer is licensed to repair.
- select a machine, see its details, and see a list of all engineers licensed to repair it.
- add new engineers to our system when they are hired. add new machines to our system when they are installed.
- add new machines even if no engineers are employed.
- add new engineers even if no machines are installed
- add or remove machines that a specific engineer is licensed to repair.
- modify this relationship from the other side, and add or remove engineers from a specific machine.

### Specs

Engineers

- Name
- Details
- Id

Machines

- Name
- Details
- id

License (join table)

- Machine id
- engineer id

## Setup/Installation Requirements

- Download option

  - Download files from GitHub repository by click Code and Download Zip
  - Extract files into a single directory
  - Run GitBASH in directory
  - Type "dotnet restore" to get bin and obj files
  - Type "dotnet run" in GitBash to run the program
  - Have fun with Factory! <!-- TITLE HERE -->

- Cloning options
  - For cloning please use the following GitHub [tutorial](https://docs.github.com/en/enterprise/2.16/user/github/creating-cloning-and-archiving-repositories/cloning-a-repository)
  - Place files into a single directory
  - Run GitBASH in directory
  - Type "dotnet restore" to get bin and obj files
  - Type "dotnet run" in GitBash to run the program
  - Have fun with Factory! <!-- TITLE HERE -->

## Database Setup

- Go to appsettings.json and change the password if needed.

- Setup with SQL migrations

  - In the terminal, navigate to the project folder
  - Type "dotnet ef migrations add Initial" and wait for migration file to be built
  - Type "dotnet ef database update" and wait for build confirmation

- Setup with SQL statements

  - Enter the following code into your SQL database and run.

  ```

  ```

  Setup with SQL Import

- MySQL
- In the Navigator > Administration window, select Data Import/Restore.
- In Import Options select Import from Self-Contained File.
- Navigate to Natalie_Murphy.sql.
- Under Default Schema to be Imported To, select the New button.
  - Enter 'Natalie_Murphy' as the name of your database.
  - Click Ok.
- Click Start Import.

## Technologies Used

Main Programs

- C# / ASP.NET Core
- MVC
- MySQL
  -Bootstrap

### Other Links

[GitHub](https://github.com/murphynd)

### License

Copyright (c) 2020 **_{NatalieMurphy}_**
Licensed under MIT
