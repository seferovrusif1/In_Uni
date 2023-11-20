--CREATE DATABASE Cinema
--use Cinema
--CREATE TABLE Movies
--(
--	Id int identity primary key,
--	Name nvarchar(60),
--	Rate float  CHECK(Rate>=0 AND Rate<=10)
--)
--CREATE TABLE Directors
--(
--	Id int identity primary key,
--	Name nvarchar(60),
--	Surname nvarchar(60),
--	Age tinyint CHECK(Age>=18)
--)

--CREATE TABLE Genres
--(
--	Id int identity primary key,
--	Name nvarchar(60)
--)
--CREATE TABLE Actors
--(
--	Id int identity primary key,
--	Name nvarchar(60),
--	Surname nvarchar(60),
--	Age tinyint CHECK(Age>=18)
--)


--CREATE TABLE MoviesDirectors
--(
--	Id int identity primary key,
--	MovieId int REFERENCES Movies(Id),
--	DirectorId int REFERENCES Directors(Id)
--)
--CREATE TABLE MoviesGenres
--(
--	Id int identity primary key,
--	MovieId int REFERENCES Movies(Id),
--	GenreId int REFERENCES Genres(Id)
--)
--CREATE TABLE MoviesActors
--(
--	Id int identity primary key,
--	MovieId int REFERENCES Movies(Id),
--	ActorId int REFERENCES Actors(Id)
--)
------------------------------------ Insert -------------------------------------
--Insert Actors Values (N'Akif',N'Kerimli',53)
--Insert Directors Values (N'Nolan',N'Cristopher',43),(N'Ali',N'John',23),(N'Javid',N'Akberov',29)
--Insert Genres Values (N'Sci-Fi'),(N'Drama'),(N'Fantastic'),(N'Comedy')
--Insert Movies Values(N'Intersettelar','9.3'),(N'Inception','9'),(N'Lords of Rings','8')
--Insert Movies Values(N'Ölümlü Dünya','7.5')
--Insert MoviesActors Values(1,2),(1,3),(1,6),(2,3),(2,1),(3,3),(3,4),(4,6),(4,1)
--Insert MoviesDirectors Values(1,1),(2,1),(4,3),(4,2),(3,1),(3,3)
--Insert MoviesGenres Values(1,1),(1,3),(2,1),(2,3),(3,3),(4,4)

------------------------------------ Queryes ------------------------------------
----1
--Select * from Movies
--where Movies.Rate>8

----2
--SELECT m.Name,m.Rate FROM Movies as m

----3
--SELECT a.Name+' '+a.Surname as Fulname,a.Age as Age From Actors as a 
--Where a.Age>40
--Union 
--SELECT d.Name+' '+d.Surname as Fulname,d.Age as Age From Directors as d 
--Where d.Age>40

------4

Select a.Director,Count(a.MID) as MovieCount FROM (SELECT d.Name+' '+d.Surname as Director,md.MovieId as MID    From Directors as d Join MoviesDirectors as md on d.Id=md.MovieId) as a
Group by a.Director

----5
SELECT a.Name+' '+a.Surname as Actor,m.Name as Movie,m.Rate as Rate ,d.Name+' '+d.Surname as Director FROM Movies as m
JOIN MoviesActors as ma
ON m.Id=ma.MovieId
JOIN Actors as a
ON a.Id=ma.ActorId
JOIN MoviesDirectors as md
ON md.MovieId=m.Id
JOIN Directors as d
ON md.DirectorId=d.Id


--6
SELECT a.Name+' '+a.Surname as Actor,m.Name as Movie,m.Rate as Rate ,g.Name as Genre ,d.Name+' '+d.Surname as Director FROM Movies as m
JOIN MoviesActors as ma
ON m.Id=ma.MovieId
JOIN Actors as a
ON a.Id=ma.ActorId
JOIN MoviesDirectors as md
ON md.MovieId=m.Id
JOIN Directors as d
ON md.DirectorId=d.Id
JOIN MoviesGenres as mg
ON mg.MovieId=m.Id
JOIN Genres as g
ON g.Id=mg.GenreId

