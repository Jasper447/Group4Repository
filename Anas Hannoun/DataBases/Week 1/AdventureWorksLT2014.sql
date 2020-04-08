CREATE INDEX idx_First_Last_Name ON Actor (last_name, first_Name)
GO

CREATE INDEX idx_Last_Name ON Actor(last_name)
GO

CREATE INDEX idx_title ON Film (title)
GO

CREATE INDEX idx_Language_ID ON Film (language_id)
GO

CREATE INDEX idx_Original_Language_ID ON Film (original_language_id)
GO
