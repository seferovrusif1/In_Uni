alter table Ischi 
add IschiOfficeId int REFERENCES Filiallar(Id)
USE [AzMB101_Rusif1]
GO

/****** Object:  Table [dbo].[Ischi]    Script Date: 29.11.2023 11:36:38 ******/

CREATE TABLE [dbo].[Ischiler](
	[Id] [int] IDENTITY primary key NOT NULL,
	[Name] [nvarchar](30) NULL,
	[Surname] [nvarchar](30) NULL,
	[Age] [tinyint] not null,
	[Salary] [money] NULL,
	[PositionId] [int]  references Vezifeler(Id),
	[Start Date] [date] default getdate(),
	[OfficeId] [int] References Filallar(Id))


	create view IschiTable
	as
	Select i.Name+' '+i.Surname as Name,p.Name as Position,f.Name as Office,i.Age,i.[Start Date],i.Salary  From Ischiler as i
	join Filallar as f
	on f.Id=i.OfficeId
	join Vezifeler as p
	on p.Id=i.PositionId





