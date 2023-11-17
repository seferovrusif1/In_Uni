--CREATE DATABASE Library
--USE Library  
--CREATE TABLE Author
--(
--	İd int identity primary key,
--	Name nvarchar(60),
--	Age int CHECK(Age>0)
--)
--CREATE TABLE Book
--(
--	İd int identity primary key,
--	Name nvarchar(100)
--)
--CREATE TABLE Genre
--(
--	İd int identity primary key,
--	Title nvarchar(50)
--)
--CREATE TABLE AuthorBook
--(
--	İd int identity primary key,
--	AuthorId int REFERENCES   Author(İd)
--)
--CREATE TABLE BookGenre
--(
--	İd int identity primary key,
--	GenreId int REFERENCES Genre(İd),
--	BookId int REFERENCES Book(İd)
--)



--Alter Table AuthorBook
--Add BookId int REFERENCES Book(İd)
--------------------------------------------------------CREATE CARS_DB-------------------------------------------------------------------
--CREATE DATABASE CarsDB
--USE CarsDB
--CREATE TABLE Brands
--(
--	İd int identity primary key,
--	Name nvarchar(100)
--)
--CREATE TABLE Models
--(
--	İd int identity primary key,
--	Name nvarchar(100),
--	BrandId int REFERENCES Brands(İd) 
--)
--CREATE TABLE Colours
--(
--	İd int identity primary key,
--	Name nvarchar(100)
--)
--CREATE TABLE Owners
--(
--	İd int identity primary key,
--	Name nvarchar(60),
--	SurName nvarchar(60)
--)
--CREATE TABLE ModelColor
--(
--	İd int identity primary key,
--	ColorId int REFERENCES Colours(İd) ,
--	ModelId int REFERENCES Models(İd)
--)


--CREATE TABLE Cars
--(
--	İd int identity primary key,
--	SerialNumber nvarchar(100),
--	ModelId int REFERENCES Models(İd),
--	OwnerId int Owners(İd)
--)

----------------------------------------------------------INSERT INTO-------------------------------------------------------------------\

--MANUAL--

-------------------------------------------------------- Query -------------------------------------------------------------------\
Select b.Name From Author as a
Join AuthorBook as ab
on a.İd=ab.AuthorId
Join Book as b
on ab.BookId=b.İd
Where a.Name='Cavid'


Select a.Name as 'Author Name', b.Name as 'Book Name' From Author as a
Left Join AuthorBook as ab
on a.İd=ab.AuthorId
Left Join Book as b
on ab.BookId=b.İd
Where Age Between 20 and 30


Select  b.Name as 'Book Name', g.Title 'Genre' From Book as b
 Join BookGenre as bg
on b.İd=bg.BookId
 Join Genre as g
on bg.GenreId=g.İd
Where g.Title='Thriller'

Select  b.Name as 'Book Name', g.Title 'Genre' From Book as b
 Join BookGenre as bg
on b.İd=bg.BookId
 Join Genre as g
on bg.GenreId=g.İd
Where g.Title in ('Thriller','Dram','Fantasy')


Select a.Name as 'Author Name', b.Name as 'Book Name' From Author as a
Left Join AuthorBook as ab
on a.İd=ab.AuthorId
Left Join Book as b
on ab.BookId=b.İd
Where b.Name Like '%ab%'


-------------------------------------------------------- Cars -------------------------------------------------------------------\


--Select ca.SerialNumber From Colours as c
-- Join ModelColor as mc
--on c.İd=mc.ColorId
-- Join Cars as ca
--on ca.ModelId=mc.İd
--Where c.Name='qara'



--Select ca.SerialNumber From Colours as c
-- Join ModelColor as mc
--on c.İd=mc.ColorId
-- Join Cars as ca
--on ca.ModelId=mc.İd
--Where c.Name='qara'












