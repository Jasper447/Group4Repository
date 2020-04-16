USE WorldEvents

SELECT TOP 2
	[EventName] AS [What],
	[EventDate] AS [When]
FROM 
	[tblEvent]
ORDER BY EventDate ASC

SELECT TOP 2
	[EventName] AS [What],
	[EventDate] AS [When]
FROM 
	[tblEvent]
ORDER BY EventDate DESC
