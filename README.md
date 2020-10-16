Dr. Sillystringz's Factory

- An application to keep track of their machine repairs.
  MVC web application to manage their engineers, and the machines they are licensed to fix.
  he factory manager should be able to add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines.

User

- list of all engineers, and a list of all machines.
- select a engineer, see their details, and see a list of all machines that engineer is licensed to repair.
- select a machine, see its details, and see a list of all engineers licensed to repair it.
- add new engineers to our system when they are hired. add new machines to our system when they are installed.
- add new machines even if no engineers are employed.
- add new engineers even if no machines are installed
- add or remove machines that a specific engineer is licensed to repair.
- modify this relationship from the other side, and add or remove engineers from a specific machine.

Homepage

- lists all engineers and machines.
- click on an individual engineer or machine to see all the engineers/machines that belong to it.

  Naming
  Note: You must follow the naming conventions for your project. Projects that do not follow these conventions will not be reviewed and will be returned not passing.

Use your first name and last name to name your database in the following way:

Production Database: first_last
Use the following name for your directory:

Main Project Folder: Factory

<Tables>
Engineers

- Name
- Details
- Id

Machines

- Name
- Details
- id

EngineersMachines (join table)

- Machine id
- engineer id
