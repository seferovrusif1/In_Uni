--CREATE DATABASE AliNinoDB
--use AliNinoDB
--Create Table Categories
--(
--	Id int identity Primary key,
--	Title nvarchar(60),
--	ParentCategoryId int REFERENCES Categories(Id),
--	IsDeleted bit Default 0
--)


--Create Table Authors
--(
--	Id int identity Primary key,
--	Name nvarchar(60),
--	Surname nvarchar(60),
--	IsDeleted bit Default 0
--)

--Create Table PublishingHouse
--(
--	Id int identity Primary key,
--	Title nvarchar(60),
--	IsDeleted bit Default 0
--)
--Create Table Genres
--(
--	Id int identity Primary key,
--	Title nvarchar(60),
--	IsDeleted bit Default 0
--)
--Create Table Bindings
--(
--	Id int identity Primary key,
--	Title nvarchar(60),
--	IsDeleted bit Default 0
--)

--Create Table Languages
--(
--	Id int identity Primary key,
--	Title nvarchar(60),
--	IsDeleted bit Default 0
--)
--Create Table Books
--(
--	Id int identity Primary key,
--	Title nvarchar(60),
--	Description nvarchar(250),
--	ActualPrice int not null,
--	DiscountPrice int default null,
--	PublishingHouseId int REFERENCES PublishingHouse(id),
--	StockCount int,
--	ArticleCode nvarchar(20),
--	BindingId int REFERENCES Bindings(Id),
--	Pages int,
--	CategoryId int REFERENCES Categories(Id),
--	IsDeleted bit Default 0
--)

--Create Table BooksGenres
--(
--	Id int identity Primary key,
--	BookId  int REFERENCES Books(Id),
--	GenreId  int REFERENCES Genres(Id),
--)


--Create Table BooksAuthors
--(
--	Id int identity Primary key,
--	BookId  int REFERENCES Books(Id),
--	AuthorId  int REFERENCES Authors(Id),
--)


--Create Table BooksLanguages
--(
--	Id int identity Primary key,
--	BookId  int REFERENCES Books(Id),
--	LanguageId  int REFERENCES Languages(Id),
--)

--Create Table Comments
--(
--	Id int identity Primary key,
--	Description nvarchar(250),
--	BookId  int REFERENCES Books(Id),
--	Rating int Check(Rating between 0 and 5),
--	Name nvarchar(60) not null,
--	Email nvarchar(254) not null,
--	ImgUrl nvarchar(max),
--	IsDeleted bit Default 0
--)
Create Trigger DeleteBook
On Books
Instead Of Delete
as
BEGIN
	UPDATE Books
	SET IsDeleted = 1
	WHERE  Id in(SELECT Id FROM deleted)
END

Create PROCEDURE InsertAuthorsss(@AuthorName nvarchar(60),@AuthorSurname nvarchar(60),@BindingTitle nvarchar(60)
,@BookTitle nvarchar(60),@BookDescription nvarchar(250),@BookActualPrice int,@BookDiscountPrice int,@PublishingHouseId int
,@PublishingHouseId int,@StockCount int,@ArticleCode nvarchar(20),@BindingId int,@Pages int,@CategoryId int,)
AS
INSERT INTO Authors ([Name], Surname)
VALUES (@AuthorName,@surname)


EXEC dbo.InsertAuthorsss @name = 'a', @surname = 'a';







