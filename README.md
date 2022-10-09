# README
To get the application up and running you need to install the following tools :
- 
## For Windows or Mac
- Install Community version of Visual studio 2022 [from here](https://visualstudio.microsoft.com/downloads/)
- Make sure to check .net 6 when installing Visual studio 2022 follow [this guide](https://learn.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60).
- Import the solution by clicking **File > Open > Project/Solution...**
-  Before running the solution you need to create a database using the following command in PostgreSQL :
```SQL
CREATE DATABASE audits_net_react_development;
```
- Create a user that will be used by the web app to connect to this database and that will have all the needed priveleges to create tables and manipulate data :
```SQL
CREATE ROLE audits_net_react WITH LOGIN ENCRYPTED PASSWORD 'audits';

GRANT ALL PRIVILEGES ON DATABASE audits_net_react_development TO audits_net_react;
```
- Build the solution and run it by clicking the green triangle, this should run both the .Net backend application and the reactJS frontend application.
## For Linux, Windows or Mac
- Since Visual studio is not available on Linux there's an alternative called Visual Studio Code, by following [this guide](https://www.c-sharpcorner.com/article/how-to-setup-visual-studio-code-for-c-sharp-10-and-net-6-0/) you can install all the necessary tools needed for this project.
- Open the solution in VS Code by opening it's folder.
-  Before running the solution you need to create a database using the following command in PostgreSQL :
```SQL
CREATE DATABASE audits_net_react_development;
```
- Create a user that will be used by the web app to connect to this database and that will have all the needed priveleges to create tables and manipulate data :
```SQL
CREATE ROLE audits_net_react WITH LOGIN ENCRYPTED PASSWORD 'audits';

GRANT ALL PRIVILEGES ON DATABASE audits_net_react_development TO audits_net_react;
```
- Run the solution by executing the command 
```
dotnet run
```
