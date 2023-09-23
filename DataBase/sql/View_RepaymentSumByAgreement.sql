CREATE VIEW View_RepaymentSumByAgreement AS 
SELECT c.ID, a.ID AS IDAgreement, c.FirstName, c.LastName, c.PESEL, c.Active, a.StartDate, a.EndDate, a.DayOfPement, a.Installment, a.IinstallmentCount, a.Percent, p.Repaid FROM Agreement a
LEFT JOIN 
(
SELECT IDAgreement ,SUM(Value) As Repaid FROM Repayment r
GROUP BY IDAgreement
) p ON p.IDAgreement = a.Id
LEFT JOIN Client c ON c.ID = a.IDClient