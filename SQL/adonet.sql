--Create database adonettask
--use adonettask
CREATE TABLE Users
(
	id int identity primary key,
	Name nvarchar(60),
	Surname nvarchar(60),
	Password nvarchar(256) not null
);
drop table Users
CREATE TABLE Blogs
(
	id int identity primary key,
	Title nvarchar(30),
	Description nvarchar(250),
	UserId int REFERENCES Users(id)
);
drop table Blogs