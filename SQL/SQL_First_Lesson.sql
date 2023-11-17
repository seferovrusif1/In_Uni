--CREATE DATABASE asdkn
--DROP DATABASE asdkn
--use master
--DROP TABLE [dbo].[employees],[dbo].[job_grades],[dbo].[job_history],[dbo].[jobs],[dbo].[locations],[dbo].[regions]


--------------------------------------------------------CREATE TABLE-------------------------------------------------------------------

--CREATE TABLE regions
--(
--	Region_ID int identity primary key,
--	Region_Name nvarchar(25)
--)
--select * from regions

--CREATE TABLE countries
--(
--	Country_ID int identity primary key ,
--	Country_Name nvarchar(40),
--	Region_ID int
--)
--select * from countries

--CREATE TABLE locations
--(
--	Location_ID  int identity primary key,
--	Street_Address nvarchar(25),
--	Postal_Code nvarchar(12),
--	City nvarchar(30),
--	State_Province nvarchar(12),
--	Country_ID varchar(2)
--)
--select * from locations
--CREATE TABLE departments
--(
--	Department_ID  int identity primary key ,
--	Department_Name nvarchar(30),
--	Manager_ID int,
--	Location_ID int,
--)
--select * from departments

--CREATE TABLE job_history
--(
--	Employee_ID  int  ,
--	[Start_Date] Date ,
--	End_Date Date,
--	Job_ID int,
--	Department_ID int
--)
--select * from job_history

--CREATE TABLE employees
--(
--	Employee_ID  int identity primary key ,
--	First_Name nvarchar(20),
--	Last_Name nvarchar(25),
--	Email nvarchar(25),
--	Phone_Number varchar(20),
--	Hire_Date Date,
--	Job_ID nvarchar(10),
--	Salary int,
--	Commission_PCT int,
--	Manager_ID int,
--	Department_ID int,
--)
--select * from employees

--CREATE TABLE jobs
--(
--	Job_ID  int identity primary key,
--	Job_Title nvarchar(35),
--	Min_Salary int,
--	Max_Salary int,
--)
--select * from jobs

--CREATE TABLE job_grades
--(
--	Grade_Level  int identity primary key,
--	Lowest_SAL int,
--	Highest_SAL int
--)
--select * from job_grades


--------------------------------------------------------INSERT INTO-------------------------------------------------------------------\

--INSERT INTO [dbo].[countries] VALUES (N'Azerbaijan',1)
--INSERT INTO [dbo].[departments] VALUES (N'IKT',1,1)
--INSERT INTO job_grades VALUES (500,1500)
--INSERT INTO jobs VALUES (N'Backend',800,2000)
--INSERT INTO regions VALUES (N'Asia')
--INSERT INTO locations VALUES (N'C. Cabbarli 19',N'AZ101',N'Baku',N'asas',1)
--INSERT INTO job_history VALUES (1,'2023-10-10','2023-12-12',1,1)
--ALTER TABLE employees ALTER COLUMN Job_ID int  
--INSERT INTO employees VALUES (N'Rusif',N'Safarov','rs@gmail.com','050 505 0505','2023-01-10',1,700,65,1,1)

-------------------------------------------------------- ALTER -------------------------------------------------------------------\

--ALTER TABLE countries ALTER COLUMN Country_Name nvarchar(60)  
--ALTER TABLE employees ALTER COLUMN Hire_Date Date  
--ALTER TABLE job_history DROP COLUMN Department_ID


select * from employees
