SELECT TOP(5)
         e.EmployeeID
		 ,e.JobTitle
		 ,a.AddressID
		 ,a.AddressText
FROM Employees AS e
LEFT JOIN Addresses AS a ON e.AddressID=a.AddressID
ORDER BY a.AddressID


SELECT TOP(50)
		e.FirstName
		,e.LastName
		,t.[Name] AS Town
		,a.AddressText
FROM Employees AS e
LEFT JOIN Addresses AS a ON e.AddressID=a.AddressID
LEFT JOIN Towns AS t ON a.TownID = t.TownID
ORDER BY e.FirstName, e.LastName

SELECT e.EmployeeID
      ,e.FirstName
	  ,e.LastName
	  ,d.[Name] AS DepartmentName
FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID AND
						d.[Name] = 'Sales'
ORDER BY e.EmployeeID


SELECT top(5) e.EmployeeID
	  ,e.FirstName
	  ,e.Salary
	  ,d.[Name] AS DepartmenName
FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
AND e.Salary > 15000
ORDER BY d.DepartmentID

SELECT TOP(3) e.EmployeeID
	, e.FirstName
FROM Employees AS e
LEFT JOIN EmployeesProjects p ON e.EmployeeID = p.EmployeeID
LEFT JOIN Projects pr ON p.ProjectID = pr.ProjectID
WHERE p.ProjectID IS NULL
ORDER BY e.EmployeeID


SELECT e.FirstName
      ,e.LastName
	  ,e.HireDate
	  ,d.[Name] AS [DeptName]
FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
AND e.HireDate > '1.1.1999' AND d.[Name] IN ('Sales', 'Finance')
ORDER BY e.HireDate

SELECT TOP(5) e.EmployeeID
             ,e.FirstName
			 ,pr.[Name] AS [ProjectName]
FROM Employees AS e
JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects AS pr ON ep.ProjectID = pr.ProjectID
AND pr.StartDate > '2002.06.01' AND pr.EndDate IS NULL
ORDER BY e.EmployeeID


SELECT e.EmployeeID
      ,e.FirstName
	  ,CASE
           WHEN DATEPART(YEAR, p.StartDate) = 2005 THEN NULL
		   ELSE p.[Name]
       END AS [ProjectName]
	   ,p.[Name] AS ProjectName
FROM Employees AS e
JOIN EmployeesProjects AS ep ON ep.EmployeeID = e.EmployeeID
JOIN Projects AS p ON p.ProjectID = ep.ProjectID
WHERE e.EmployeeID = 24


SELECT e.EmployeeID
      ,e.FirstName
	  ,e.ManagerID
	  ,m.FirstName AS [ManagerName]
FROM Employees AS e
JOIN Employees AS m ON e.ManagerID = m.EmployeeID
AND e.ManagerID IN(3,7)
ORDER BY e.EmployeeID

SELECT TOP(50) e.EmployeeID
              ,CONCAT(e.FirstName, ' ', e.LastName) AS [EmployeeName]
			  ,CONCAT(m.FirstName, ' ', m.LastName) AS [ManagerName]
			  ,d.[Name] AS [DepartmentName]
FROM Employees AS e
JOIN Employees AS m ON m.EmployeeID = e.ManagerID
JOIN Departments AS d ON d.DepartmentID = e.DepartmentID
ORDER BY e.EmployeeID ASC

SELECT MIN(a.AverageSalary) AS [MinAverageSalary]
FROM
(
    SELECT DepartmentID
          ,AVG(Salary) AS AverageSalary
    FROM Employees
    GROUP BY DepartmentID
) AS a

USE [Geography]
GO

SELECT c.CountryCode
      ,m.MountainRange
	  ,p.PeakName
	  ,p.Elevation
FROM Countries AS c
JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
JOIN Mountains AS m ON m.Id = mc.MountainId
JOIN Peaks AS p ON p.MountainId = m.Id
WHERE c.CountryName = 'Bulgaria' AND p.Elevation > 2835
ORDER BY p.Elevation DESC


SELECT c.CountryCode
      ,COUNT(m.MountainRange) AS [MountainRanges]
FROM Countries AS c
JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
JOIN Mountains AS m ON m.Id = mc.MountainId
WHERE c.CountryName IN('United States', 'Russia', 'Bulgaria')
GROUP BY c.CountryCode