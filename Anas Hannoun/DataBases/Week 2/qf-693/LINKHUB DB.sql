CREATE UNIQUE INDEX idx_UserName ON Users (UserName)
GO

CREATE UNIQUE INDEX idx_EmailAdress ON Users (Email)
GO

CREATE UNIQUE INDEX idx_CategoryName ON Catigories (CatigoryName)
GO

CREATE INDEX idx_UserID ON Urls (UserID)
GO

CREATE INDEX idx_CatigoryCode ON Urls (CatigoryCode)
GO