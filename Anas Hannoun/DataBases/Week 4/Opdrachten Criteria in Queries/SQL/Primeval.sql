SELECT *
FROM tblEvent
WHERE
	CategoryID <> 14 AND EventDetails LIKE '%train%'


SELECT *
FROM tblEvent
WHERE
	CountryID = 13 AND (EventName NOT LIKE '%space%' AND EventDetails NOT LIKE '%space%')

SELECT *
FROM tblEvent
WHERE
	CategoryID IN (6, 5) AND (EventDetails NOT LIKE '%death%' AND EventDetails NOT LIKE '%war%')