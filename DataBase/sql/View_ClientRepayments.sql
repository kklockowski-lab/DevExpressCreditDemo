CREATE VIEW View_ClientRepayments AS 
SELECT r.ID, c.FirstName, c.LastName, r.Date, r.Value, a.DayOfPement
FROM Repayments r
LEFT JOIN  Agreement a  ON r.IDAgreement = a.Id
LEFT JOIN Client c ON c.ID = a.IDClient