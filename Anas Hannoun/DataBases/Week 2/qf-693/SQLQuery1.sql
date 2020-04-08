CREATE TABLE tblProductionCompany(

ProductionCompanyId int IDENTITY(1,1) PRIMARY KEY,

ProductionCompanyName NVARCHAR(25),
Abbreviation NVARCHAR(3),
)
GO

INSERT INTO tblProductionCompany(

ProductionCompanyName,

Abbreviation

) VALUES ( 'British Broadcasting Corporation', 'BBC') , ('Canadian Broadcasting Corporation', 'CBC')
GO

Select * FROM tblProductionCompany
GO

