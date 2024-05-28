# Railway-Management-System
Railway management system is my ```CS219-Database Systems``` course project. In this project I have tried to automate the complete management process in railways. It is a desktop application developed in c# programming language.
## Tools:
- For IDE, I have used visual studio 2019 community version. The .sln file attached with the project
- For database and database managemnt system, I have used Micreosoft SQL Server Management Studio.
## Setup Guide:
1. Clone or download the project from github and place the folder in your desired file location.
2. Open visual studio and select **Open a project or solution**.
3. Select folder you have cloned/downloaded in step # 1 and click open. This will load the project in visual studio.
4. Now open SQL server management and create a new database.
5. You can check **SQL Configrations** folder to run all sql scripts. Most of these scripts are stored procedures for DDL commands to create necessary schema tables. You can execute these stored procedure by running ```spExecutionScript.sql```.
6. Now connect database from SQL server management studio to frontend in visual studio
   - Go to ```sql_connection.cs``` and add your local data source name and catalog name. data source name is same as server name you can find it in the properties manual of you SQL server management studio. Catalog name is the name of you database.

Splashscreens
![image](https://github.com/ItzAmeerHamza/Railway-Management-System/assets/73628472/9d6bfd99-5ba0-4ed7-a080-c5be946d0725)
![image](https://github.com/ItzAmeerHamza/Railway-Management-System/assets/73628472/c57606ca-4cc8-429c-bccc-16f98e60a429)

Login
![image](https://github.com/ItzAmeerHamza/Railway-Management-System/assets/73628472/391d6290-cf53-495f-bfd1-f19709864596)
SignUp
![image](https://github.com/ItzAmeerHamza/Railway-Management-System/assets/73628472/86841b03-79f1-4748-baef-dda9e531ab8e)
EmployeeRegistration
![image](https://github.com/ItzAmeerHamza/Railway-Management-System/assets/73628472/2dc09211-ecf6-4166-8745-063133e585f5)
![image](https://github.com/ItzAmeerHamza/Railway-Management-System/assets/73628472/46aa562d-8b17-4261-8f90-18fdc58218a6)
![image](https://github.com/ItzAmeerHamza/Railway-Management-System/assets/73628472/2d55c026-7855-4788-8007-c6257a17e2f2)
![image](https://github.com/ItzAmeerHamza/Railway-Management-System/assets/73628472/7b3e4ccd-b2e8-4773-bff4-542bdc925c38)
![image](https://github.com/ItzAmeerHamza/Railway-Management-System/assets/73628472/ee6d1dda-c2f2-4d44-9fde-f2be2b96ffac)

